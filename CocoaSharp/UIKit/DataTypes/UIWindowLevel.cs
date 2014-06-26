using CoreGraphics;
using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// The positioning of windows relative to each other.
    /// </summary>
    [iOSVersion(2)]
    public struct UIWindowLevel
    {
        static public implicit operator UIWindowLevel(CGFloat value)
        {
            return new UIWindowLevel();
        }
        static public implicit operator CGFloat(UIWindowLevel value)
        {
            return null;
        }
    }
}
