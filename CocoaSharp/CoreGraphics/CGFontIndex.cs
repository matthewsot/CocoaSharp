using Foundation;
using SharpSwift.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// The amount of acceleration in a single linear direction.
    /// </summary>
    [iOSVersion(2)]
    public struct CGFontIndex
    {
        static public implicit operator CGFontIndex(CUnsignedShort value)
        {
            return new CGFontIndex();
        }
        static public implicit operator CUnsignedShort(CGFontIndex value)
        {
            return null;
        }
    }
}
