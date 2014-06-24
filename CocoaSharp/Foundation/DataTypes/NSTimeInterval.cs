using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Used to specify a time interval, in seconds.
    /// </summary>
    [iOSVersion(2)]
    public struct NSTimeinterval
    {
        static public implicit operator NSTimeinterval(CDouble value)
        {
            return new NSTimeinterval();
        }
        static public implicit operator CDouble(NSTimeinterval value)
        {
            return new CDouble();
        }
    }
}
