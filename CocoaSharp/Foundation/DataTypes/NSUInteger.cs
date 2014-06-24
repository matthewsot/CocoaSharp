using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    //TODO: figure out what NSUInteger really is
    public struct NSUInteger
    {
        static public implicit operator NSUInteger(int value)
        {
            return new NSUInteger();
        }
        static public implicit operator int(NSUInteger value)
        {
            return 0;
        }
    }
}
