using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// A structure used to describe a portion of a series—such as characters in a string or objects in an NSArray object.
    /// </summary>
    [iOSVersion(2)]
    public struct _NSRange
    {
        public NSUInteger location;
        public NSUInteger length;
    }

    /// <summary>
    /// A structure used to describe a portion of a series—such as characters in a string or objects in an NSArray object.
    /// </summary>
    [iOSVersion(2)]
    public struct NSRange
    {
        public NSUInteger location;
        public NSUInteger length;
        static public implicit operator NSRange(_NSRange value)
        {
            return new NSRange();
        }
        static public implicit operator _NSRange(NSRange value)
        {
            return new _NSRange();
        }
    }
}
