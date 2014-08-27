using SharpSwift.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct UInt8
    {
        static public implicit operator UInt8(uint value)
        {
            return new UInt8();
        }
        static public implicit operator uint(UInt8 value)
        {
            return 0;
        }
    }
}
