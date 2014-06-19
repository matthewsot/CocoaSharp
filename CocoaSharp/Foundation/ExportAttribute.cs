using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    class ExportAttribute : Attribute
    {
        public string ExportAs { get; set; }
        public ExportAttribute(string exportAs)
        {
            ExportAs = exportAs;
        }
    }
}
