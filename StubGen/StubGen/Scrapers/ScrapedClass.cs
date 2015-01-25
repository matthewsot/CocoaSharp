using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace StubGen
{
    public class ScrapedClass : ScrapedMember
    {
        public static double? ParseAvailability(HtmlDocument doc)
        {
            var text = doc.DocumentNode.SelectSingleNode("//div[@class='z-reference-info-availability half']").RealInnerText();
            
            if (text == null) return null;

            try
            {
                var number = Regex.Split(text, "in iOS ")[1].Split(' ')[0];
                double version;
                if (!double.TryParse(number, out version))
                {
                    return null;
                }
                return version;
            }
            catch
            {
                return null;
            }
        }

        public string Inherits { get; set; }
        public IEnumerable<string> ConformsTo { get; set; }
        public List<ScrapedMember> Members { get; set; }
        public string Namespace { get; set; }
        public string Name { get; set; }

        public ScrapedClass() { }

        public ScrapedClass(string url)
        {
            using (var client = new HttpClient())
            {
                var data = client.GetStringAsync(url).Result;
                var doc = new HtmlDocument { OptionFixNestedTags = true };
                doc.LoadHtml(data);
                
                //Parses the inheritance tree
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

                //Parses the conformance
                var conformsTo =
                    doc.DocumentNode.SelectNodes("//div[@class='conforms-to']/ul/li[@class='Swift']/code");
                ConformsTo = conformsTo == null ? new string[0] : conformsTo.Select(node => node.RealInnerText().Trim());

                //Parses the name
                Name = doc.DocumentNode.SelectSingleNode("//h1[@class='chapter-name']").RealInnerText().Replace(" ", "").Trim().Replace("Reference", "");
                CSharpName = Name;

                //Parses the namespace from the "Import Statement" section
                var importStatement =
                    doc.DocumentNode.SelectSingleNode(
                        "//div[@class='z-module-import half']/code[@class='code-voice Swift']");
                if (importStatement != null)
                {
                    try
                    {
                        Namespace = importStatement.RealInnerText().Split("import ")[1].Split(' ')[0].Trim()
                            .Replace(" ", "");
                        if (Namespace.EndsWith("Reference"))
                        {
                            Namespace = Namespace.Replace("Reference", "");
                        }
                    }
                    catch
                    {
                        Namespace = "";
                    }
                }

                //Parses the description
                var description =
                    doc.DocumentNode.SelectSingleNode("//section[@class='z-class-description section']/p")
                        .RealInnerText().Replace("More...", "").Trim();

                Description = description ?? "";
                if (Description == "")
                {
                   var desc =
                   doc.DocumentNode.SelectSingleNode("//section[@class='z-protocol-description section']/p")
                       .RealInnerText().Replace("More...", "").Trim();

                    Description = desc ?? "";
                }

                //Parses the iOSVersion
                iOSVersion = ParseAvailability(doc);

                //Parses the members within the class
                var members = doc.DocumentNode.SelectNodes("//section[@class='section task-group-section']//ul[@class='task-group-list']/li[@class='item symbol']");
                Members = new List<ScrapedMember>();
                if (members != null)
                {
                    foreach (var member in members)
                    {
                        Members.Add(ScrapeMember(member));
                    }
                }
            }
        }
    }
}
