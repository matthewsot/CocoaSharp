using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSwift.Attributes
{
    //TODO: handle unwrapping better
    public class AmbiguousWrapping<T>
    {
        static public implicit operator T(AmbiguousWrapping<T> value)
        {
            return default(T);
        }

        static public implicit operator AmbiguousWrapping<T>(T value)
        {
            return default(AmbiguousWrapping<T>);
        }
    }
}
