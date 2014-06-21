using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    class iOSVersionAttribute : Attribute
    {
        public double Version { get; set; }
        public iOSVersionAttribute(double version)
        {
            Version = version;
        }
    }
}
