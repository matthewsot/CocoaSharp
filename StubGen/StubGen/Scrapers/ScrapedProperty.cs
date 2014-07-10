using HtmlAgilityPack;


namespace StubGen
{
    public class ScrapedProperty : ScrapedMember
    {
        public bool PublicGetter { get; set; }
        public bool PublicSetter { get; set; }
        public ScrapedType Type { get; set; }

        public ScrapedProperty(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='abstract']/p").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            var name = Declaration.Split("var ")[1].Split(':')[0].Trim();

            RawName = name;
            CSharpName = name.ToUpper()[0] + name.Substring(1);

            var type = Declaration.Split(':')[1].Trim().Split(' ')[0].Trim();
            Type = ScrapedType.ScrapeType(type);

            var objCDeclaration =
                node.SelectSingleNode("./div[@class='declaration']/div[@class='Objective-C']/p[@class='para']").RealInnerText().Trim();

            PublicGetter = true;
            PublicSetter = !(objCDeclaration.Contains("@property") && objCDeclaration.Contains("readonly"));
            Public = true;

            Static = Declaration.Contains("class var ");
        }
    }
}
