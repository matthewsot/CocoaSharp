using System;
using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// A direction of the text.
    /// </summary>
    [iOSVersion(3.2)]
    public struct UITextDirection
    {
        static public implicit operator UITextDirection(int value)
        {
            return new UITextDirection();
        }
        static public implicit operator int(UITextDirection value)
        {
            return 0;
        }
    }
}
