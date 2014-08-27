using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSwift.Attributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class IgnoreParameterAttribute : Attribute
    {
        public string Ignore { get; set; }
        public IgnoreParameterAttribute(string toIgnore)
        {
            Ignore = toIgnore;
        }
    }
}
