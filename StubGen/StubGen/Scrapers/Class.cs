using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StubGen
{
    partial class Scraper
    {
        public static string ParseAsDescription(string text)
        {
            return Regex.Replace(Regex.Replace(text.Trim(), "(\r\n)|(\r)|(\n)", NewLine + "/// ").Replace("/// " + NewLine, ""), "\\/\\/\\/\\s*((\r\n)|(\r)|(\n))", "");
        }

        static List<string> Signatures = new List<string>();
        private static string Differentiate(ScrapedMethod method)
        {
            var methodSignature = method.RawName + " " + method.ReturnType.CSharpType + " " +
                                  string.Join("", method.Parameters.Select(param => param.Type.CSharpType));

            if (Signatures.Any(sig => sig == methodSignature))
            {
                switch (Signatures.Count(sig => sig == methodSignature))
                {
                    case 1:
                        Signatures.Add(methodSignature);
                        return ", bool NAME_YOUR_PARAMS = false";
                    case 2:
                        Signatures.Add(methodSignature);
                        return ", int NAME_YOUR_PARAMS = 0";
                    case 3:
                        Signatures.Add(methodSignature);
                        return ", string NAME_YOUR_PARAMS = \"\"";
                    case 4:
                        Signatures.Add(methodSignature);
                        return ", double NAME_YOUR_PARAMS = 4.2";
                    default:
                        return "";
                        break;
                }
            }
            Signatures.Add(methodSignature);
            return "";
        }

        public static string NewLine = Environment.NewLine;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Class(string url, bool isInterface = false, string[] usings = null)
        {
            Signatures = new List<string>();
            var parsed = new ScrapedClass(url);
            if (usings == null)
            {
                usings = new[]
                {
                    "ObjectiveC",
                    "System",
                    "SwiftSharp.Attributes",
                    "Foundation",
                    "CoreGraphics",
                    "UIKit"
                };
            }
            var output = "using " + string.Join(";" + NewLine + "using ", usings) + ";";

            output += NewLine + NewLine + "namespace " + parsed.Namespace + NewLine + "{" + NewLine;

            output += parsed.GetTrivia().Replace("/// </summary>" + NewLine, "/// </summary>" + NewLine + "/// <see cref=\"" + url + "\"/>" + NewLine);

            output += "public " + (isInterface ? "interface" : "class") + " " + parsed.Name;

            if (parsed.Inherits != null && parsed.Inherits != "")
            {
                output += " : " + parsed.Inherits + ", ";
            }
            if (parsed.ConformsTo != null && parsed.ConformsTo.Any())
            {
                output += string.Join(", ", parsed.ConformsTo);
            }
            output = output.TrimEnd(' ', ',');
            output += NewLine + "{" + NewLine;

            var allProperties = parsed.Members.OfType<ScrapedProperty>().ToList();
            for (var i = 0; i < allProperties.Count(); i++) //todo test this
            {
                var currProperty = allProperties[i];
                var allWithSame = allProperties.Where(
                    prop =>
                        prop != currProperty && prop.RawName == currProperty.RawName &&
                        prop.Type.RawSwift == currProperty.Type.RawSwift);

                foreach (var withSame in allWithSame)
                {
                    allProperties.Remove(withSame);
                    parsed.Members.Remove(withSame);
                }
            }

            foreach (var method in parsed.Members.OfType<ScrapedMethod>())
            {
                var toOutput = method.GetTrivia();

                var toAddAfterSummary = NewLine;
                foreach (var param in method.Parameters)
                {
                    if (param.Description == null)
                    {
                        param.Description = "";
                    }
                    toAddAfterSummary += "/// <param name=\"" + param.Name + "\">" + ParseAsDescription(param.Description) +
                              "</param>" + NewLine;
                }

                var differentiator = Differentiate(method);
                if (differentiator != "")
                {
                    toAddAfterSummary +=
                        "/// <param name=\"NAME_YOUR_PARAMS\">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>" +
                        NewLine;
                }
                if (method.ReturnDescription != null)
                {
                    toAddAfterSummary += "/// <returns>" + ParseAsDescription(method.ReturnDescription) + "</returns>" +
                              NewLine;
                }

                if (differentiator != "")
                {
                    toOutput += "[IgnoreParameters(\"NAME_YOUR_PARAMS\")]" + NewLine;
                }

                if (isInterface && (method.Static || method.IsConstructor))
                {
                    //csharp doesn't allow static things in interfaces
                    toOutput = toOutput.Replace("[", "//[");
                }
                output += toOutput.Replace("/// </summary>" + NewLine, "/// </summary>" + toAddAfterSummary);

                if (isInterface && (method.Static || method.IsConstructor))
                {
                    output += "//";
                }

                if (!method.IsConstructor)
                {
                    output += method.Public ? "public " : "private ";
                    output += method.Static ? "static " : "";

                    output += method.ReturnType.CSharpType + " ";
                    output += method.CSharpName + "(";
                    output += string.Join(", ",
                        method.Parameters.Select(param => param.Type.CSharpType + " " + param.Name));
                    output += differentiator + ")";
                    if (!isInterface)
                    {
                        output += " { ";
                        if (method.ReturnType.CSharpType != "void")
                        {
                            output += "return default(" + method.ReturnType.CSharpType + ");";
                        }
                        output += " }";
                    }
                    else
                    {
                        output += ";";
                    }
                    output += NewLine + NewLine;
                }
                else if (method.IsConstructor)
                {
                    output += "public " + parsed.Name + "(";
                    output += string.Join(", ",
                        method.Parameters.Select(param => param.Type.CSharpType + " " + param.Name));
                    output += differentiator + ") { }" + NewLine + NewLine;
                }
            }

            foreach(var property in parsed.Members.OfType<ScrapedProperty>())
            {
                output += property.GetTrivia();

                output += property.Public ? "public " : "private ";
                output += property.Static ? "static " : "";
                output += property.Type.CSharpType + " ";
                output += property.CSharpName + " { ";
                output += property.PublicGetter ? "get; " : "private get; ";
                output += property.PublicSetter ? "set; " : "private set; ";
                output += "}" + NewLine + NewLine;
            }

            output = output.TrimEnd() + NewLine + "}" + NewLine;

            foreach (var scrapedEnum in parsed.Members.OfType<ScrapedEnum>())
            {
                output += scrapedEnum.GetTrivia();

                output += "public enum " + scrapedEnum.CSharpName + NewLine + "{" + NewLine;
                foreach (var member in scrapedEnum.Members)
                {
                    output += member.GetTrivia();

                    output += member.CSharpName + "," + NewLine;
                }

                output += "}" + NewLine;
            }

            foreach (var typeAlias in parsed.Members.OfType<ScrapedTypedef>())
            {
                output += typeAlias.GetTrivia();

                output += "public struct " + typeAlias.Alias + NewLine + "{" + NewLine;
                output +=
                    "static public implicit operator " + typeAlias.Alias + "(" + typeAlias.RealType.CSharpType +
                    " value)" +
                    NewLine + "{" + NewLine +
                    "return default(" + typeAlias.Alias + ");" + NewLine +
                    "}" + NewLine;

                output += "static public implicit operator " + typeAlias.RealType.CSharpType+ "(" + typeAlias.Alias + " value)" + NewLine+
                    "{" + NewLine + "return default(" + typeAlias.RealType.CSharpType + ");" + NewLine + "}" + NewLine;
            }

            return output.TrimEnd() + NewLine + "}" + NewLine;
        }
    }
}
