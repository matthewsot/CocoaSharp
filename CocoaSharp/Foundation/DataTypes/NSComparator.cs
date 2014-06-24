using System;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Defines the signature for a block object used for comparison operations.
    /// </summary>
    [iOSVersion(4)]
    public struct NSComparator
    {
        static public implicit operator NSComparator(Func<AnyObject, AnyObject, NSComparisonResult> value)
        {
            return new NSComparator();
        }
        static public implicit operator Func<AnyObject, AnyObject, NSComparisonResult>(NSComparator value)
        {
            return (delegate(AnyObject o, AnyObject anyObject) { return NSComparisonResult.OrderedSame;});
        }
    }
}
