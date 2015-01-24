using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace StubGen
{
    public class Helpers
    {
        public static string ParseType(string type)
        {
            type = type.Trim().Trim('_', '!').Trim();
            var optional = type.EndsWith("?");
            type = type.Trim('?').Trim();

            var finalType = type;
            switch (type.ToLower())
            {
                case "void":
                    finalType = "void";
                    break;
                case "nsstring":
                case "string":
                    finalType = "string";
                    break;
                case "bool":
                    finalType = "bool";
                    break;
                case "int":
                case "int32":
                    finalType = "int";
                    break;
                case "uint":
                case "uint32":
                    finalType = "uint";
                    break;
                case "uint64":
                    finalType = "UInt64";
                    break;
                case "uint16":
                    finalType = "UInt16";
                    break;
                case "float":
                    finalType = "float";
                    break;
            }

            return optional ? "Optional<" + finalType + ">" : finalType;
        }
    }

    public static class Extensions
    {
        public static string RealInnerText(this HtmlNode node)
        {
            if (node == null)
            {
                return "";
            }
            return Regex.Replace(node.InnerText, "<.*?>", "").Replace("&gt;", ">").Replace("&lt;", "<").Replace("NOfalse", "false").Replace("YEStrue", "true").Trim();
        }

        public static string[] Split(this string str, string splitAt)
        {
            return Regex.Split(str, Regex.Escape(splitAt));
        }

        public static string[] SplitAtFirstOccurrence(this string str, string splitAt)
        {
            return new[] { str.Split(splitAt)[0], str.Substring(str.IndexOf(splitAt) + 1) };
        }

        public static string[] SplitAtFirstOccurrence(this string str, char splitAt)
        {
            return new[] { str.Split(splitAt)[0], str.Substring(str.IndexOf(splitAt) + 1) };
        }
    }
}
