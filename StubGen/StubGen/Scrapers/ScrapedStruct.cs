using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;


namespace StubGen
{
    public class ScrapedStructMember : ScrapedMember
    {
        public ScrapedType Type { get; set; }
        public bool ReadOnly { get; set; }
        public ScrapedStructMember(string declaration)
        {
            Public = true;
            RawName = declaration.Split("var ")[1].Split(':')[0].Trim();
            CSharpName = RawName.ToUpper()[0] + RawName.Substring(1);
            Type = ScrapedType.ScrapeType(declaration.Split(':')[1].Trim().Split(' ')[0]);
            ReadOnly = declaration.Contains("{ get }");
        }
    }

    public class ScrapedStruct : ScrapedMember
    {
        public List<ScrapedStructMember> Members { get; set; }

        public ScrapedStruct(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='abstract']/p").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");

            if (Declaration.StartsWith("struct "))
            {
                var name = Declaration.Split("struct ")[1].Split(' ')[0].Trim();

                RawName = name;
                CSharpName = name.ToUpper()[0] + name.Substring(1);

                Members = new List<ScrapedStructMember>();
                var members = Declaration.Split('\n').Select(str => str.Trim());
                foreach (var member in members)
                {
                    if (member.Contains("var "))
                    {
                        Members.Add(new ScrapedStructMember(member));
                    }
                }
            }

            var descriptions = node.SelectNodes("./ul[@class='list-bullet']/li");
            if (descriptions != null)
            {
                foreach (var desc in descriptions)
                {
                    var optName = desc.SelectSingleNode("./p[@class='para Swift']").RealInnerText().Trim();

                    var definitionPs = desc.SelectNodes("./div[@class='definition']/p[@class='para']");
                    var availability = definitionPs.Last().RealInnerText().Trim();
                    double? availNum = null;
                    if (availability.Contains("in iOS "))
                    {
                        try
                        {
                            availNum = double.Parse(availability.Trim().Split("in iOS ")[1].Split(' ')[0]);
                            definitionPs.Remove(definitionPs.Last());
                        }
                        catch
                        {

                        }
                    }
                    var def = string.Join(Environment.NewLine, definitionPs.Select(defi => defi.RealInnerText().Trim()));

                    var memberWithName = Members.FirstOrDefault(mem => mem.RawName == optName);
                    if (memberWithName != null)
                    {
                        memberWithName.iOSVersion = availNum;
                        memberWithName.Description = def;
                        memberWithName.Deprecated = def.ToLower().Contains("deprec");
                    }
                }
            }

            Public = true;
            Static = true;
        }
    }
}
