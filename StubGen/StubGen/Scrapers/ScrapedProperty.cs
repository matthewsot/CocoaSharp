using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;

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
            if (Description.Contains("Returns a dictionary that contains information about the receiver"))
            {
                
            }
            Deprecated = Description.ToLower().Contains("deprecat");
            var name = Declaration.Split("var ")[1].Split(':')[0].Trim();

            RawName = name;
            CSharpName = (name.ToUpper()[0] + name.Substring(1)).Trim('`');

            if (new[] { "object", "string", "delegate", "int", "uint", "float", "class", "this", "new" }.Contains(CSharpName))
            {
                CSharpName = "@" + CSharpName;
            }

            var type = Declaration.SplitAtFirstOccurrence(':')[1].Trim().Split('{')[0].Split(';')[0].Trim();
            Type = ScrapedType.ScrapeType(type);

            PublicGetter = true;
            PublicSetter = !(Declaration.Contains("{ get }"));
            Public = true;

            Static = Declaration.Contains("class var ");
        }
    }
}
