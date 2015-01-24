using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Property(ScrapedProperty property, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            //TODO: static/private properties shouldn't be here for interfaces

            output += property.GetTrivia();

            if (property.Type.Optional)
            {
                output += "[ValueOptional]" + NewLine;
            }
            if (property.Type.Unwrapped)
            {
                output += "[ValueUnwrapped]" + NewLine;
            }

            if (!isInterface) //todo: comment out private/static properties in interfaces
            {
                output += property.Public ? "public " : "private ";
                output += property.Static ? "static " : "";
            }
            if (property.Type.CSharpType == "Self")
            {
                property.Type.CSharpType = parent.Name;
            }
            output += property.Type.CSharpType + " ";
            output += property.CSharpName + " { ";
            output += property.PublicGetter ? "get; " : "private get; ";
            output += property.PublicSetter ? "set; " : "private set; ";
            output += "}" + NewLine + NewLine;

            return output;
        }
    }
}
