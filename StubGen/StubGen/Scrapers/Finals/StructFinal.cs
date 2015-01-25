using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Struct(ScrapedStruct scrapedEnum, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            output += scrapedEnum.GetTrivia();

            output += "public struct " + scrapedEnum.CSharpName + NewLine + "{" + NewLine;
            if (scrapedEnum.Members != null)
            {
                foreach (var member in scrapedEnum.Members)
                {
                    output += member.GetTrivia();

                    if (member.Type.Optional)
                    {
                        output += "[Optional]" + NewLine;
                    }
                    if (member.Type.Unwrapped)
                    {
                        output += "[Unwrapped]" + NewLine;
                    }

                    if (!isInterface) //todo: comment out private/static properties in interfaces
                    {
                        output += member.Public ? "public " : "";
                        output += member.Static ? "static " : "";
                    }
                    if (member.Type.CSharpType == "Self")
                    {
                        member.Type.CSharpType = scrapedEnum.CSharpName;
                    }

                    output += member.Type.CSharpType + " ";
                    output += member.CSharpName + " { get; ";
                    output += member.ReadOnly ? "private set; " : "set; ";
                    output += "}" + NewLine + NewLine;
                }
            }

            output += "}" + NewLine;
            return output;
        }
    }
}
