using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSwift.Attributes
{
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
}
