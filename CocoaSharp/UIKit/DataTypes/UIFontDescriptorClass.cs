using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// UIFontDescriptorClass classifies certain stylistic qualities of the font.
    /// </summary>
    [iOSVersion(7)]
    public struct UIFontDescriptorClass
    {
        static public implicit operator UIFontDescriptorClass(int value)
        {
            return new UIFontDescriptorClass();
        }
        static public implicit operator int(UIFontDescriptorClass value)
        {
            return 0;
        }
    }
}
