using HtmlAgilityPack;
using StubGen.Scrapers.Finals;


namespace StubGen
{
    public class ScrapedNotification : ScrapedMember
    {
        public ScrapedNotification(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='api-description']/p[@class='para']").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            iOSVersion = double.Parse(node.SelectSingleNode("./div[@class='availability']/p").RealInnerText().Split("in iOS ")[1].Split(' ')[0]);
            Declaration =
                node.ParentNode.ParentNode.SelectSingleNode(
                    "./div[@class='task-group-term']/code/a[@class='notification Swift']").RealInnerText();


            RawName = Declaration;
            CSharpName = Declaration;

            Public = true;
            Static = true;
        }
    }
}
