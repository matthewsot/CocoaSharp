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

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class IgnoreParameterAttribute : Attribute
    {
        public string Ignore { get; set; }
        public IgnoreParameterAttribute(string toIgnore)
        {
            Ignore = toIgnore;
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class RenameParameterAttribute : Attribute
    {
        public string From { get; set; }
        public string To { get; set; }
        public RenameParameterAttribute(string from, string to)
        {
            From = from;
            To = to;
        }
    }

    public class OptionalAttribute : Attribute
    {
    }

    public class GlobalAttribute : Attribute
    {
    }
}
