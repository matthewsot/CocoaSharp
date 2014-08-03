using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct NSPropertyListWriteOptions
    {
        static public implicit operator NSPropertyListWriteOptions(int value)
        {
            return new NSPropertyListWriteOptions();
        }
        static public implicit operator int (NSPropertyListWriteOptions value)
        {
            return 0;
        }
    }
}
