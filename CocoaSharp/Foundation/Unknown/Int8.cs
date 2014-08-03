using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct Int8
    {
        static public implicit operator Int8(int value)
        {
            return new Int8();
        }
        static public implicit operator int(Int8 value)
        {
            return 0;
        }
    }
}
