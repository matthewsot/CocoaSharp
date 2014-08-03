using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Typedef(ScrapedTypedef typeAlias, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            output += typeAlias.GetTrivia();

            output += "public struct " + typeAlias.Alias + NewLine + "{" + NewLine;
            output +=
                "static public implicit operator " + typeAlias.Alias + "(" + typeAlias.RealType.CSharpType +
                " value)" +
                NewLine + "{" + NewLine +
                "return default(" + typeAlias.Alias + ");" + NewLine +
                "}" + NewLine;

            output += "static public implicit operator " + typeAlias.RealType.CSharpType + "(" + typeAlias.Alias + " value)" + NewLine +
                "{" + NewLine + "return default(" + typeAlias.RealType.CSharpType + ");" + NewLine + "}" + NewLine + "}" + NewLine;
            return output;
        }
    }
}
