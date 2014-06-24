using System.Security.Cryptography.X509Certificates;
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
        public static string ParseEnum(HtmlNode section, HtmlNode declarationPara, string summary)
        {
            var declaration = RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim();
            var name = Regex.Split(declaration, "enum ")[1].Split(':')[0].Trim();
            var output = summary + /*"public*/ "enum " + name + "\r\n{";

            var items = Regex.Split(declaration, "\n");

            var descriptions = section.SelectNodes("./ul[@class='list-bullet']/li");

            var keysAndTrivia = new Dictionary<string, string>();
            foreach (var desc in descriptions)
            {
                var keyName = RemoveHTMLTags(desc.SelectSingleNode("./p[@class='para Swift']").InnerHtml).Trim();
                var summarry = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").First().InnerHtml).Trim();
                var availableIn = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").Last().InnerHtml).Trim();

                var trivia = "\r\n/// <summary>\r\n/// " + summarry + "\r\n/// </summary>\r\n";

                if (availableIn.Contains("in iOS "))
                {
                    trivia += "[iOSVersion(" + Regex.Split(availableIn, "in iOS ")[1].Split(' ')[0].Trim('.', '0') + ")]\r\n";
                }

                keysAndTrivia.Add(keyName, trivia);
            }

            foreach (var item in items)
            {
                if (item.Contains("case "))
                {
                    var itemName = Regex.Split(item, "case ").Last().Trim();
                    var trivia = "";
                    if (keysAndTrivia.ContainsKey(itemName))
                    {
                        trivia = keysAndTrivia[itemName];
                    }
                    output += trivia + itemName + ",\r\n";
                }
            }
            return output + "}\r\n";
        }

        public static string ParseStruct(HtmlNode section, HtmlNode declarationPara, string summary)
        {
            var declaration = RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim();
            var name = Regex.Split(declaration, "struct ")[1].Split(':')[0].Trim();
            var output = summary + "public enum " + name + "\r\n{";

            var items = Regex.Split(declaration, "\n");

            var descriptions = section.SelectNodes("./ul[@class='list-bullet']/li");

            var keysAndTrivia = new Dictionary<string, string>();
            foreach (var desc in descriptions)
            {
                var keyName = RemoveHTMLTags(desc.SelectSingleNode("./p[@class='para Swift']").InnerHtml).Trim();
                var summarry = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").First().InnerHtml).Trim();
                var availableIn = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").Last().InnerHtml).Trim();

                var trivia = "\r\n/// <summary>\r\n/// " + summarry + "\r\n/// </summary>\r\n";

                if (availableIn.Contains("in iOS "))
                {
                    trivia += "[iOSVersion(" + Regex.Split(availableIn, "in iOS ")[1].Split(' ')[0].Trim('.', '0') + ")]\r\n";
                }

                keysAndTrivia.Add(keyName, trivia);
            }

            foreach (var item in items)
            {
                if (item.Contains("var ") && !item.Contains("var value:"))
                {
                    var itemName = item.Split(':')[0].Split(' ').Last();
                    var trivia = "";
                    if (keysAndTrivia.ContainsKey(itemName))
                    {
                        trivia = keysAndTrivia[itemName];
                    }
                    output += trivia + itemName + ",\r\n";
                }
            }
            return output + "}\r\n";
        }

        public static string ParseKeys(HtmlNode section, HtmlNode declarationPara, string summary)
        {
            var declaration = RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim();
            var keys = Regex.Split(declaration, "\n");
            
            var descriptions = section.SelectNodes("./ul[@class='list-bullet']/li");
            var keysAndTrivia = new Dictionary<string, string>();
            foreach (var desc in descriptions)
            {
                var keyName = RemoveHTMLTags(desc.SelectSingleNode("./p[@class='para Swift']").InnerHtml).Trim();
                var summarry = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").First().InnerHtml).Trim();
                var availableIn = RemoveHTMLTags(desc.SelectNodes("./div[@class='definition']/p").Last().InnerHtml).Trim();

                var trivia = "\r\n/// <summary>\r\n/// " + summarry + "\r\n/// </summary>\r\n";

                if (availableIn.Contains("in iOS "))
                {
                    trivia += "[iOSVersion(" + Regex.Split(availableIn, "in iOS ")[1].Split(' ')[0].Trim('.', '0') + ")]\r\n";
                }

                keysAndTrivia.Add(keyName, trivia);
            }

            var output = summary;
            foreach (var key in keys)
            {
                var type = ParseType(key.Split(':')[1].Trim().Trim('!'));
                var keyName = key.Split(':')[0].Split(' ')[1];
                var trivia = "";
                if (keysAndTrivia.ContainsKey(keyName))
                {
                    trivia = keysAndTrivia[keyName];
                }
                output += trivia + key.Split(':')[0].Trim().Replace("var ", "public " + type + " ") + " { get;" + (trivia.Contains("read-write") ? "" : " private") + " set; }\r\n";
            }
            return output + "\r\n";
        }

        public static string RemoveHTMLTags(string html)
        {
            return Regex.Replace(html, "<.*?>", "");
        }

        public static Tuple<string, Dictionary<string, string>>  ParseDeclaration(string declaration)
        {
            var output = /*"public "*/"";
            if (declaration.StartsWith("@optional"))
            {
                output = "[Optional]\r\n" + output;
                declaration = declaration.Substring(10);
            }

            declaration = declaration.Replace("&gt;", ">").Replace("&lt;", "<").Trim();
            var argsToRename = new Dictionary<string, string>();
            if (declaration.StartsWith("class") || declaration.StartsWith("static"))
            {
                output += "static ";
            }
            if (declaration.StartsWith("class func") || declaration.StartsWith("func") || declaration.StartsWith("init") || declaration.StartsWith("convenience init"))
            {
                var typeOfMethod = "void";
                //method
                if (declaration.Contains("->"))
                {
                    typeOfMethod = ParseType(Regex.Split(declaration, Regex.Escape("->")).Last().Trim().TrimEnd('!', ')'));
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
                if (name != "init")
                {
                    output = "[Export(\"" + name + "\")]\r\n" + output;
                }
                output += name.ToUpper()[0] + name.Substring(1) + "(";

                var arguments = Regex.Match(declaration, "\\([\\s\\S]*\\)").Value;
                arguments = arguments.Substring(1, arguments.Length - 2);
                var funcArgs = Regex.Matches(arguments, "\\(\\([\\s\\S]*?\\)[\\s\\S]*?\\)");
                foreach (var funcArg in funcArgs)
                {
                    var sides = Regex.Split(funcArg.ToString(), Regex.Escape("->"));
                    var retVal = ParseType(sides.Last().Trim().TrimEnd('!', ')'));
                    var parameters = sides.First().Trim().Trim('(', ')').Replace(",", "COMMAHERE123").Replace("!", "");

                    if (retVal == "void")
                    {
                        declaration = declaration.Replace(funcArg.ToString(), "Action<" + parameters + ">");
                    }
                    else
                    {
                        declaration = declaration.Replace(funcArg.ToString(), "Func<" + parameters + "COMMAHERE123 " + retVal + ">");
                    }
                }

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
                        else
                        {
                            var internalArgName = arg.Split(':')[0].Trim().Split(' ').Last();
                            argsToRename.Add(internalArgName, argName);
                        }
                        if (argName == "object" || argName == "string" || argName == "delegate")
                        {
                            argName = "@" + argName;
                        }
                        var argType = ParseType(arg.Split(':')[1].Trim().Trim('!'));
                        output += argType + " " + argName + ", ";
                    }
                }
                output = output.TrimEnd(' ', ',');

                //output += ") { ";
                output += ");";/*
                if (name != "init")
                {
                    switch (typeOfMethod)
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
                }
                output += " }";*/
            }
            else if (declaration.StartsWith("var"))
            {
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
            else
            {
                output += "\r\n//" + declaration;
            }
            return new Tuple<string, Dictionary<string, string>>(output + "\r\n\r\n", argsToRename);
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
            if (sections == null)
            {
                return "";
            }
            foreach(var section in sections)
            {
                try
                {
                    var summary = "/// <summary>\r\n/// " + RemoveHTMLTags(section.ChildNodes.First(node => node.Attributes.Any(attr => attr.Name == "class" && attr.Value == "abstract")).InnerHtml.Trim()).Trim() + "\r\n/// </summary>\r\n";

                    var obsolete = "";
                    if (summary.ToLower().Contains("deprecat"))
                    {
                        obsolete = "[Obsolete]\r\n";
                    }

                    var declarationPara = section.SelectSingleNode("./div[@class='declaration']/div[@class='Swift']/p[@class='para']");
                    if (declarationPara == null)
                    {
                        continue;
                    }
                    if (RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Contains("struct "))
                    {
                        output += ParseStruct(section, declarationPara, summary);
                    }
                    else if (RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Contains("enum "))
                    {
                        output += ParseEnum(section, declarationPara, summary);
                    }
                    else if (Regex.Split(RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim(), "var ").Length > 2)
                    {
                        output += ParseKeys(section, declarationPara, summary);
                    }
                    else
                    {
                        var parsedDecl = ParseDeclaration(RemoveHTMLTags(declarationPara.InnerHtml.Trim()).Trim());

                        string declaration = parsedDecl.Item1;
                        var argsToRename = parsedDecl.Item2;

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
                        foreach (var argToRename in argsToRename)
                        {
                            parameters = parameters.Replace("<param name=\"" + argToRename.Key + "\"",
                                "<param name=\"" + argToRename.Value + "\"");
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

                        var thisFinal = summary + parameters + result + obsolete + availability + declaration;
                        output += thisFinal;
                    }
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
                case "Void":
                    return "void";
                case "NSString":
                case "String":
                    return "string";
                case "Bool":
                    return "bool";
                case "Int":
                case "Int32":
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
        public static string ScrapeToCSFile(string url, string self, string inherits)
        {
           // try {
                var output = "using ObjectiveC;\r\nusing System;\r\nusing SwiftSharp.Attributes;\r\n\r\n";
                output += "namespace Foundation\r\n{\r\n";
                output += "//" + url + "\r\n";
                using (var client = new HttpClient())
                {
                    var data = client.GetStringAsync(url).Result;
                    var doc = new HtmlDocument
                    {
                        OptionFixNestedTags = true
                    };
                    doc.LoadHtml(data);
                    //var desc = RemoveHTMLTags(doc.DocumentNode.SelectSingleNode("/html/body//section[@class='z-class-description section']/p[@class='para']").InnerHtml).Trim();
                    var desc = RemoveHTMLTags(doc.DocumentNode.SelectSingleNode("/html/body//section[@class='intro']/p[@class='para']").InnerHtml).Trim();
                    desc = desc.Replace("More...", "").Trim();
                    output += "/// <summary>\r\n/// " + desc + "\r\n/// </summary>\r\n";

                    var availability = "";//RemoveHTMLTags(doc.DocumentNode.SelectSingleNode("/html/body//div[@class='z-reference-info-availability half']/span").InnerHtml).Trim();

                    //output += "[iOSVersion(" + Regex.Split(availability, "in iOS ")[1].Split(' ')[0].Trim('.', '0') + ")]\r\n";
                    output += "public class " + self /*+ " : " + inherits*/ + "\r\n{\r\n";

                    output += ScrapeWithAgility(data);
                }

                return output.TrimEnd().Replace("`", "").Replace("  ", " ").Replace("YEStrue", "true").Replace("NOfalse", "false").Replace("public Self Init(", "public Self(").Replace("void Init(", "Self(").Replace("Self", self).Replace("COMMAHERE123", ",").Replace("Int", "int") + "\r\n}\r\n}";
            //}
            //catch { Console.WriteLine("Error parsing " + self); return ""; }
        }
    }
}
