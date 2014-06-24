using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwiftSharp.Attributes
{
    class ExportAttribute : Attribute
    {
        public string ExportAs { get; set; }
        public ExportAttribute(string exportAs)
        {
            ExportAs = exportAs;
        }
    }

    class iOSVersionAttribute : Attribute
    {
        public double Version { get; set; }
        public iOSVersionAttribute(double version)
        {
            Version = version;
        }
    }

    class OptionalAttribute : Attribute
    {
    }

    class GlobalAttribute : Attribute
    {
    }
}
