using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StubGen
{
    class Scraper
    {
        public static string RemoveHTMLTags(string html)
        {
            return Regex.Replace(html, "<.*?>", "");
        }

        public static string ParseDeclaration(string declaration)
        {
            declaration = declaration.Replace("&gt;", ">").Replace("&lt;", "<").Trim();
            var output = "public ";
            if (declaration.StartsWith("class") || declaration.StartsWith("static") || declaration.StartsWith("func") || declaration.StartsWith("init"))
            {
                if (declaration.StartsWith("class") || declaration.StartsWith("static"))
                {
                    output += "static ";
                }
                var typeOfMethod = "void";
                //method
                if (declaration.Contains("->"))
                {
                    typeOfMethod = ParseType(Regex.Split(declaration, Regex.Escape("->"))[1].Trim().TrimEnd('!'));
                    output += typeOfMethod + " ";
                }
                else
                {
                    output += "void ";
                }

                string name;
                if (declaration.Contains("init("))
                {
                    name = "init";
                }
                else
                {
                    name = Regex.Split(declaration, "func ")[1].Split('(')[0].Trim();
                }
                output = "[Export(\"" + name + "\")]\r\n" + output;
                output += name.ToUpper()[0] + name.Substring(1) + "(";

                var args = declaration.Split('(')[1].Split(')')[0].Split(',');
                foreach(var arg in args)
                {
                    if (arg.Trim() != "")
                    {
                        var argName = arg.Split(':')[0].Trim().Split(' ').First();
                        if (argName == "_")
                        {
                            argName = arg.Split(':')[0].Trim().Split(' ').Last();
                        }
                        var argType = ParseType(arg.Split(':')[1].Trim().Trim('!'));
                        output += argType + " " + argName + ", ";
                    }
                }
                output = output.TrimEnd(' ', ',');

                output += ") { ";
                switch(typeOfMethod)
                {
                    case "void":
                        output += "";
                        break;
                    case "string":
                        output += "return \"\";";
                        break;
                    case "int":
                    case "float":
                    case "double":
                        output += "return 0;";
                        break;
                    case "bool":
                        output += "return false;";
                        break;
                    default:
                        output += "return null;";
                        break;
                }
                output += " }";
            }
            else if(declaration.StartsWith("var"))
            {
                output += "static ";
                //property
                var type = ParseType(declaration.Split(':')[1].Trim().Split(' ')[0].TrimEnd('!'));
                output += type + " ";
                var name = Regex.Split(declaration, "var ")[1].Split(':')[0].Trim();
                output = "[Export(\"" + name + "\")]\r\n" + output;
                output += name.ToUpper()[0] + name.Substring(1) + " ";
                if (!declaration.Contains("set"))
                {
                    output += "{ get; private set; }";
                }
                else
                {
                    output += "{ get; set; }";
                }
            }
            return output + "\r\n\r\n";
        }

        public static string ScrapeWithAgility(string data)
        {
            var output = "";
            var doc = new HtmlDocument
            {
                OptionFixNestedTags = true
            };
            doc.LoadHtml(data);
            //thanks http://stackoverflow.com/questions/846994/how-to-use-html-agility-pack
            var sections = doc.DocumentNode.SelectNodes("/html/body//li[@class='item symbol']/div[@class='height-container']/section");
            foreach(var section in sections)
            {
                try
                {
                    var summary = "/// <summary>\r\n/// " + RemoveHTMLTags(section.ChildNodes.First(node => node.Attributes.Any(attr => attr.Name == "class" && attr.Value == "abstract")).InnerHtml.Trim()).Trim() + "\r\n/// </summary>\r\n";

                    var declarationPara = section.SelectSingleNode("./div[@class='declaration']/div[@class='Swift']/p[@class='para']");
                    if (declarationPara == null)
                    {
                        continue;
                    }
                    string declaration = ParseDeclaration(RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim());

                    var objcPara = section.SelectSingleNode("./div[@class='declaration']/div[@class='Objective-C']/p[@class='para']");
                    if (objcPara != null)
                    {
                        var objcdecl = RemoveHTMLTags(objcPara.InnerHtml.Trim()).Trim();
                        if (objcdecl.Contains("@property") && !objcdecl.Contains("readonly"))
                        {
                            declaration = declaration.Replace("private set", "set");
                        }
                        else if (objcdecl.Contains("@property") && objcdecl.Contains("readonly"))
                        {
                            declaration = declaration.Replace("; set;", "; private set;");
                        }
                    }
                    else
                    {
                        declaration = "[SwiftOnly]\r\n" + declaration;
                    }

                    var parameters = "";
                    var paramTable = section.SelectSingleNode("./div[@class='parameters']/table/tbody");
                    if (paramTable != null)
                    {
                        var paramsInTable = paramTable.SelectNodes("./tr");
                        foreach (var param in paramsInTable)
                        {
                            var name = ParseType(RemoveHTMLTags(param.SelectNodes("./td").First().InnerHtml.Trim()).Trim());
                            var desc = RemoveHTMLTags(param.SelectNodes("./td").Last().InnerHtml.Trim()).Trim().Replace("\r\n", " ").Replace("\r", " ").Replace("\n", " ");
                            parameters += "/// <param name=\"" + name + "\">" + desc + "</param>\r\n";
                        }
                    }

                    var resultPara = section.SelectSingleNode("./div[@class='result-description']/p[@class='para']");
                    string result = "";
                    if (resultPara != null)
                    {
                        result = "/// <returns>" + RemoveHTMLTags(resultPara.InnerHtml).Trim() + "</returns>\r\n";
                    }

                    var availabilityDiv = section.SelectSingleNode("./div[@class='availability']/p[@class='para availability-item']");
                    string availability = "";
                    if (availabilityDiv != null)
                    {
                        availability = "[iOSVersion(" + Regex.Split(RemoveHTMLTags(availabilityDiv.InnerHtml).Trim(), "in iOS ")[1].Split(' ')[0].Trim('.', '0') + ")]\r\n";
                    }

                    var thisFinal = summary + parameters + result + availability + declaration;
                    output += thisFinal;
                }
                catch
                {
                    output += "\r\n\r\nWHAT\r\n\r\n";
                }
            }
            return output;
        }

        public static string ParseType(string type)
        {
            switch (type)
            {
                case "NSString":
                case "String":
                    return "string";
                case "Bool":
                    return "bool";
                case "Int":
                    return "int";
                default:
                    return type.Trim().Trim('_', '!').Trim();
            }
        }
        public static string GetDescOfParamWithName(string paramTable, string paramName)
        {
            try
            {
                var thing = Regex.Match(paramTable, "<em class=\"term\">.*?" + paramName.Replace("`", "") + ".*?</em>[\\s\\S]*?</div>[\\s\\S]*?</td>").Value;
                var definition = Regex.Split(Regex.Split(thing, "<div class=\"definition\">[\\s\\S]*?<p class=\"para\">")[1], "</p>")[0];
                return Regex.Replace(definition, "<.*?>", "").Trim();
            }
            catch
            {
                return "NEEDS DEFINITION";
            }
        }
        public static string ScrapeToCSFile(string url)
        {
            var output = "";
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(url).Result;
                output = ScrapeWithAgility(data);
            }
            Console.WriteLine("What is Self?");
            return output.Replace("`", "").Replace("  ", " ").Replace("YEStrue", "true").Replace("NOfalse", "false").Replace("Self", Console.ReadLine());
        }
    }
}
