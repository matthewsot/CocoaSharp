using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string ParseAsDescription(string text)
        {
            if (text == null)
            {
                return "";
            }
            return Regex.Replace(Regex.Replace(text.Trim(), "(\r\n)|(\r)|(\n)", NewLine + "/// ").Replace("/// " + NewLine, ""), "\\/\\/\\/\\s*((\r\n)|(\r)|(\n))", "");
        }

        static List<string> Signatures = new List<string>();
        private static string Differentiate(ScrapedMethod method)
        {
            var methodSignature = method.CSharpName + " " +
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
                        Signatures.Add(methodSignature);
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

            //add all the usings
            var output = "using " + string.Join(";" + NewLine + "using ", usings) + ";";


            //namespace xyz {
            output += NewLine + NewLine + "namespace " + parsed.Namespace + NewLine + "{" + NewLine;


            //trivia, add the <see cref> tag
            output += parsed.GetTrivia().Replace("/// </summary>" + NewLine,
                                                "/// </summary>" + NewLine +
                                                "/// <see cref=\"" + url + "\"/>" + NewLine);


            //public class Name
            output += "public " + (isInterface ? "interface" : "class") + " " + parsed.Name;
            if (isInterface)
            {
                var m = 1;
            }

            if (!string.IsNullOrEmpty(parsed.Inherits))
            {
                output += " : " + parsed.Inherits + "//, ";
            }
            else
            {
                output += "//: ";
            }
            if (parsed.ConformsTo != null && parsed.ConformsTo.Any())
            {
                //All the interfaces are commented out, since they don't all work right
                output += string.Join(", ", parsed.ConformsTo);
            }

            output = output.TrimEnd(' ', ',');
            output += NewLine + "{" + NewLine;


            //Remove repeated properties
            var allProperties = parsed.Members.OfType<ScrapedProperty>().ToList();
            for (var i = 0; i < allProperties.Count(); i++)
            {
                var currProperty = allProperties[i];
                var allWithSame = allProperties.Where(
                    prop =>
                        prop != currProperty && prop.RawName == currProperty.RawName &&
                        prop.Type.RawSwift == currProperty.Type.RawSwift).ToList();

                for (var w = 0; w < allWithSame.Count(); w++)
                {
                    var withSame = allWithSame[w];
                    allProperties.Remove(withSame);
                    parsed.Members.Remove(withSame);
                }
            }


            foreach (var method in parsed.Members.OfType<ScrapedMethod>())
            {
                output += Finals.Method(method, parsed, isInterface);
            }

            foreach (var property in parsed.Members.OfType<ScrapedProperty>())
            {
                output += Finals.Property(property, parsed, isInterface);
            }

            output = output.TrimEnd() + NewLine + "}" + NewLine;

            //Enums and Typedefs don't need to be in the actual class

            foreach (var scrapedEnum in parsed.Members.OfType<ScrapedEnum>())
            {
                output += Finals.Enum(scrapedEnum, parsed, isInterface);
            }

            foreach (var typeAlias in parsed.Members.OfType<ScrapedTypedef>())
            {
                output += Finals.Typedef(typeAlias, parsed, isInterface);
            }

            foreach (var notification in parsed.Members.OfType<ScrapedNotification>())
            {
                output += Finals.Notification(notification, parsed, isInterface);
            }


            return output.TrimEnd() + NewLine + "}" + NewLine;
        }
    }
}
