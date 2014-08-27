using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpSwift.Attributes;

namespace Foundation
{
    ///Opaque structure containing endian-independent double value. 
    [iOSVersion(2)]
    struct NSSwappedDouble
    {
        private CUnsignedLongLong v;
    }
}
