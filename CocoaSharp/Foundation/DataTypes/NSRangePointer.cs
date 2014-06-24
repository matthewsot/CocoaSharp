using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Type indicating a parameter is a pointer to an NSRange structure.
    /// </summary>
    [iOSVersion(2)]
    public struct NSRangePointer
    {
        static public implicit operator NSRangePointer(UnsafePointer<NSRange> value)
        {
            return new NSRangePointer();
        }
        static public implicit operator UnsafePointer<NSRange>(NSRangePointer value)
        {
            return new UnsafePointer<NSRange>();
        }
    }
}
