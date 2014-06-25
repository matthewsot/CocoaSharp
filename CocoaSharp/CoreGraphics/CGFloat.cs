using Foundation;
using SwiftSharp.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// The basic type for all floating-point values. 
    /// </summary>
    [iOSVersion(2)]
    public struct CGFloat
    {
        static public implicit operator CGFloat(CFloat value)
        {
            return new CGFloat();
        }
        static public implicit operator CFloat(CGFloat value)
        {
            return null;
        }
    }
}
