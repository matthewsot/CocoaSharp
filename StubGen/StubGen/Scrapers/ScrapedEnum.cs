using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;


namespace StubGen
{
    public class ScrapedEnumMember : ScrapedMember
    {
        public ScrapedEnumMember(string declaration)
        {
            if (declaration.Contains("static var "))
            {
                RawName = declaration.Split("static var ")[1].Split(':')[0].Trim();
                CSharpName = RawName.ToUpper()[0] + RawName.Substring(1);
            }
            else if (declaration.Contains("case "))
            {
                RawName = declaration.Split("case ")[1].Trim();
                CSharpName = RawName.ToUpper()[0] + RawName.Substring(1);
            }
        }
    }

    public class ScrapedEnum : ScrapedMember
    {
        public List<ScrapedEnumMember> Members { get; set; }

        public ScrapedEnum(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='abstract']/p").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            iOSVersion = double.Parse(node.SelectSingleNode("./div[@class='availability']/p").RealInnerText().Split("in iOS ")[1].Split(' ')[0]);

            if (Declaration.StartsWith("struct "))
            {
                var name = Declaration.Split("struct ")[1].Split(':')[0].Trim();

                RawName = name;
                CSharpName = name.ToUpper()[0] + name.Substring(1);

                Members = new List<ScrapedEnumMember>();
                var members = Declaration.Split('\n').Select(str => str.Trim());
                foreach (var member in members)
                {
                    if (member.Contains("static var "))
                    {
                        Members.Add(new ScrapedEnumMember(member));
                    }
                }
            }
            else if (Declaration.StartsWith("enum "))
            {
                var name = Declaration.Split("enum ")[1].Split(':')[0].Trim();

                RawName = name;
                CSharpName = name.ToUpper()[0] + name.Substring(1);

                Members = new List<ScrapedEnumMember>();
                var members = Declaration.Split('\n').Select(str => str.Trim());
                foreach (var member in members)
                {
                    if (member.Contains("case "))
                    {
                        Members.Add(new ScrapedEnumMember(member));
                    }
                }
            }

            var descriptions = node.SelectNodes("./ul[@class='list-bullet']/li");
            foreach (var desc in descriptions)
            {
                var optName = desc.SelectSingleNode("./p[@class='para Swift']").RealInnerText().Trim();

                var definitionPs = desc.SelectNodes("./div[@class='definition']/p[@class='para']");
                var availability = definitionPs.Last().RealInnerText().Trim();
                double? availNum = null;
                if (availability.Contains("in iOS "))
                {
                    availNum = double.Parse(availability.Trim().Split("in iOS ")[1].Split(' ')[0]);
                    definitionPs.Remove(definitionPs.Last());
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

            Public = true;
            Static = true;
        }
    }
}
