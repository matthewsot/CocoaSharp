using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Type for the platform-specific native socket handle.
    /// </summary>
    [iOSVersion(2)]
    public struct NSSocketNativeHandle
    {
        static public implicit operator NSSocketNativeHandle(Cint value)
        {
            return new NSSocketNativeHandle();
        }
        static public implicit operator Cint(NSSocketNativeHandle value)
        {
            return null;
        }
    }
}
