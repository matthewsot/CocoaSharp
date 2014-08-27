using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpSwift.Attributes;

namespace Foundation
{
    //Opaque type containing an endian-independent float value. 
    [iOSVersion(2)]
    struct NSSwappedFloat
    {
        private CUnsignedInt v;
    }
}
