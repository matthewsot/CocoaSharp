using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Enum(ScrapedEnum scrapedEnum, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            output += scrapedEnum.GetTrivia();

            output += "public enum " + scrapedEnum.CSharpName + NewLine + "{" + NewLine;
            if (scrapedEnum.Members != null)
            {
                foreach (var member in scrapedEnum.Members)
                {
                    output += member.GetTrivia();

                    output += member.CSharpName + "," + NewLine;
                }
            }

            output += "}" + NewLine;
            return output;
        }
    }
}
