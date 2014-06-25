using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwiftSharp.Attributes
{
    public class ExportAttribute : Attribute
    {
        public string ExportAs { get; set; }
        public ExportAttribute(string exportAs)
        {
            ExportAs = exportAs;
        }
    }

    public class iOSVersionAttribute : Attribute
    {
        public double Version { get; set; }
        public iOSVersionAttribute(double version)
        {
            Version = version;
        }
    }

    public class OptionalAttribute : Attribute
    {
    }

    public class GlobalAttribute : Attribute
    {
    }
}
