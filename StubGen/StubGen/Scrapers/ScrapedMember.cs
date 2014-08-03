using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using StubGen.Scrapers.Finals;

namespace StubGen
{
    public class ScrapedMember
    {
        public string Declaration { get; set; }
        public string Description { get; set; }
        public double? iOSVersion { get; set; }
        public bool Deprecated { get; set; }
        public bool Public { get; set; }
        public bool Static { get; set; }

        public string RawName { get; set; }
        public string CSharpName { get; set; }

        public ScrapedMember() { }

        public ScrapedMember(ScrapedMember baseValues)
        {
            Declaration = baseValues.Declaration;
            Description = baseValues.Description;
            iOSVersion = baseValues.iOSVersion;
            Deprecated = baseValues.Deprecated;
        }

        public string GetTrivia()
        {
            var NewLine = Finals.NewLine;
            var output = "/// <summary>" + NewLine + "/// " +
                      Finals.ParseAsDescription(Description) + NewLine +
                      "/// </summary>" + NewLine;

            if (iOSVersion.HasValue) //todo iosversion in scrapedmember
            {
                output += "[iOSVersion(" + iOSVersion.ToString() + ")]" + NewLine;
            }
            if (Deprecated)
            {
                output += "[Obsolete]" + NewLine;
            }
            if (CSharpName != RawName)
            {
                output += "[Export(\"" + RawName + "\")]" + NewLine;
            }
            return output;
        }

        public static ScrapedMember ScrapeMember(HtmlNode node)
        {
            var baseMember = new ScrapedMember();
            var availabilityNode = node.GetAttributeValue("data-availability", "not a number");
            double availability;
            if (!double.TryParse(availabilityNode, out availability))
            {
                baseMember.iOSVersion = null;
            }
            else
            {
                baseMember.iOSVersion = availability;
            }

            var realNode = node.SelectSingleNode("./div[@class='height-container']/section");

            var declarationNode =
                realNode.SelectSingleNode("./div[@class='declaration']/div[@class='Swift']/p[@class='para']");

            baseMember.Declaration = declarationNode.RealInnerText().Trim();
            if (baseMember.Declaration.StartsWith("struct ") && baseMember.Declaration.Contains("Option"))
            {
                return new ScrapedEnum(baseMember, realNode);
            }
            if ((baseMember.Declaration.Contains("init(") || baseMember.Declaration.Contains("func ")))
            {
                return new ScrapedMethod(baseMember, realNode);
            }
            if (baseMember.Declaration.Contains("var "))
            {
                return new ScrapedProperty(baseMember, realNode);
            }
            if (baseMember.Declaration.Contains("typealias "))
            {
                return new ScrapedTypedef(baseMember, realNode);
            }
            if (baseMember.Declaration == "" && realNode.SelectSingleNode("./div[@class='api-description']") != null)
            {
                return new ScrapedNotification(baseMember, realNode);
            }

            return baseMember;
        }
    }
}
