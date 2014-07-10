using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace StubGen
{
    public static class Extensions
    {
        public static string RealInnerText(this HtmlNode node)
        {
            return Regex.Replace(node.InnerText, "<.*?>", "").Replace("&gt;", ">").Replace("&lt;", "<").Replace("NOfalse", "false").Replace("YEStrue", "true").Trim();
        }

        public static string[] Split(this string str, string splitAt)
        {
            return Regex.Split(str, Regex.Escape(splitAt));
        }
    }

    public class ScrapedClass : ScrapedMember
    {
        public static double? ParseAvailability(string text)
        {
            if (text == null) return null;

            var number = Regex.Split(text, "in iOS ")[1].Split(' ')[0];
            double version;
            if (!double.TryParse(number, out version))
            {
                return null;
            }
            return version;
        }

        public string Inherits { get; set; }
        public IEnumerable<string> ConformsTo { get; set; }
        public IEnumerable<ScrapedMember> Members { get; set; }
        public string Namespace { get; set; }
        public string Name { get; set; }

        public ScrapedClass() { }

        public ScrapedClass(string url)
        {
            using (var client = new HttpClient())
            {
                var data = client.GetStringAsync(url).Result;
                var doc = new HtmlDocument
                {
                    OptionFixNestedTags = true
                };
                doc.LoadHtml(data);

                var inheritanceTree = doc.DocumentNode.SelectNodes("//div[@class='inheritance']/ul[@class='Swift']/li/code");
                if (inheritanceTree != null)
                {
                    for (var i = 1; i < inheritanceTree.Count; i++)
                    {
                        if (inheritanceTree[i].SelectSingleNode("./a") == null)
                        {
                            //The current node isn't a link
                            Inherits = inheritanceTree[i - 1].RealInnerText().Trim();
                        }
                    }
                }
                else
                {
                    Inherits = null;
                }

                var conformsTo =
                    doc.DocumentNode.SelectNodes("//div[@class='conforms-to']/ul/li[@class='Swift']/code");
                ConformsTo = conformsTo == null ? new string[0] : conformsTo.Select(node => node.RealInnerText().Trim());

                var description =
                    doc.DocumentNode.SelectSingleNode("//section[@class='z-class-description section']/p")
                        .RealInnerText().Replace("More...", "").Trim();

                Description = description ?? "";

                var availability =
                    doc.DocumentNode.SelectSingleNode("//div[@class='z-reference-info-availability half']").RealInnerText();

                iOSVersion = ParseAvailability(availability);

                var members = doc.DocumentNode.SelectNodes("//section[@class='section task-group-section']//ul[@class='task-group-list']/li[@class='item symbol']");
                //Members = members.Select(member => ScrapedMember.ScrapeMember(member));
                Members = new List<ScrapedMember>();
                foreach (var member in members)
                {
                    var res = ScrapeMember(member);
                    ((List<ScrapedMember>)Members).Add(res);
                }

                var import =
                    doc.DocumentNode.SelectSingleNode(
                        "//div[@class='z-module-import half']/code[@class='code-voice Swift']");
                if (import != null)
                {
                    Namespace = import.RealInnerText().Split("import ")[1].Split(' ')[0].Trim();
                }

                Name = doc.DocumentNode.SelectSingleNode("//h1[@class='chapter-name']").RealInnerText();
            }
        }
    }
}
