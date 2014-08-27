using Foundation;
using SharpSwift.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// The amount of acceleration in a single linear direction.
    /// </summary>
    [iOSVersion(2)]
    public struct CGGlyph
    {
        static public implicit operator CGGlyph(CGFontIndex value)
        {
            return new CGGlyph();
        }
        static public implicit operator CGFontIndex(CGGlyph value)
        {
            return null;
        }
    }
}
