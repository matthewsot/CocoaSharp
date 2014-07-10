using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StubGen
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="http://google.com"/>
    partial class Scraper
    {
        public static string ParseAsDescription(string text)
        {
            return Regex.Replace(Regex.Replace(text.Trim(), "(\r\n)|(\r)|(\n)", NewLine + "/// ").Replace("/// " + NewLine, ""), "\\/\\/\\/\\s*((\r\n)|(\r)|(\n))", "");
        }

        static List<string> Signatures = new List<string>();
        private static string Differentiate(ScrapedMethod method)
        {
            var methodSignature = method.Name + " " + method.ReturnType.CSharpType + " " +
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
        public static string Class(string url, string[] usings = null)
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

            output += "/// <summary>" + NewLine + "/// " +
                      ParseAsDescription(parsed.Description) + NewLine +
                      "/// </summary>" + NewLine;
            output += "/// <see cref=\"" + url + "\"/>" + NewLine;
            output += "public class " + parsed.Name;
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

            foreach (var member in parsed.Members)
            {
                if (member is ScrapedMethod)
                {
                    var method = (ScrapedMethod) member;
                    output += "/// <summary>" + NewLine + "/// " +
                              ParseAsDescription(method.Description) + NewLine +
                              "/// </summary>" + NewLine;
                    foreach (var param in method.Parameters)
                    {
                        if (param.Description == null)
                        {
                            param.Description = "";
                        }
                        output += "/// <param name=\"" + param.Name + "\">" + ParseAsDescription(param.Description) + "</param>" + NewLine;
                    }
                    var differentiator = Differentiate(method);
                    if (differentiator != "")
                    {
                        output += "/// <param name=\"NAME_YOUR_PARAMS\">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>" + NewLine;
                    }
                    if (method.ReturnDescription != null)
                    {
                        output += "/// <returns>" + ParseAsDescription(method.ReturnDescription) + "</returns>" +
                                  NewLine;
                    }
                    if (method.iOSVersion.HasValue)
                    {
                        output += "[iOSVersion(" + method.iOSVersion + ")]" + NewLine;
                    }
                    if (method.Deprecated)
                    {
                        output += "[Obsolete]" + NewLine;
                    }
                    if (!method.IsConstructor)
                    {
                        if (method.CSharpName != method.Name)
                        {
                            output += "[Export(\"" + method.Name + "\")]" + NewLine;
                        }
                        output += method.Public ? "public " : "private ";
                        output += method.Static ? "static " : "";

                        output += method.ReturnType.CSharpType + " ";
                        output += method.CSharpName + "(";
                        output += string.Join(", ",
                            method.Parameters.Select(param => param.Type.CSharpType + " " + param.Name));
                        output += differentiator + ") { ";
                        if (method.ReturnType.CSharpType != "void")
                        {
                            output += "return default(" + method.ReturnType.CSharpType + ");";
                        }
                        output += " }" + NewLine + NewLine;
                    }
                    else if(method.IsConstructor)
                    {
                        output += "public " + parsed.Name + "(";
                        output += string.Join(", ",
                            method.Parameters.Select(param => param.Type.CSharpType + " " + param.Name));
                        output += differentiator + ") { }" + NewLine + NewLine;
                    }
                }
            }

            return output.TrimEnd() + NewLine + "}" + NewLine + "}";
        }
    }
}
