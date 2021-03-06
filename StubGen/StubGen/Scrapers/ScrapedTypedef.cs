﻿using HtmlAgilityPack;


namespace StubGen
{
    public class ScrapedTypedef : ScrapedMember
    {
        public string Alias { get; set; }
        public ScrapedType RealType { get; set; }

        public ScrapedTypedef(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='abstract']/p").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            iOSVersion = double.Parse(node.SelectSingleNode("./div[@class='availability']/p").RealInnerText().Split("in iOS ")[1].Split(' ')[0]);

            var name = Declaration.Split("typealias ")[1].Split('=')[0].Trim();

            RawName = name;
            CSharpName = name.ToUpper()[0] + name.Substring(1);
            Alias = CSharpName;

            var type = Declaration.Split('=')[1].Trim().Split(' ')[0].Trim();
            RealType = ScrapedType.ScrapeType(type);

            Public = true;
            Static = true;
        }
    }
}
