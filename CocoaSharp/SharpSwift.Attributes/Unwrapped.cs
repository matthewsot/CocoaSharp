using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSwift.Attributes
{
    //TODO: handle unwrapping better
    public class Unwrapped<T>
    {
        static public implicit operator T(Unwrapped<T> value)
        {
            return default(T);
        }

        static public implicit operator Unwrapped<T>(T value)
        {
            return default(Unwrapped<T>);
        }
    }
}
