using HtmlAgilityPack;


namespace StubGen
{
    public class ScrapedNotification : ScrapedMember
    {
        public ScrapedNotification(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='api-description']/p[@class='para']").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            iOSVersion = double.Parse(node.SelectSingleNode("./div[@class='availability']/p").RealInnerText().Split("in iOS ")[1].Split(' ')[0]);



            RawName = name;
            CSharpName = name.ToUpper()[0] + name.Substring(1);

            var type = Declaration.Split('=')[1].Trim().Split(' ')[0].Trim();

            Public = true;
            Static = true;
        }
    }
}
