using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// A mask that contains the OR combination of the accessibility traits that best characterize an accessibility element.
    /// </summary>
    [iOSVersion(3)]
    public struct UIAccessibilityTraits
    {
        static public implicit operator UIAccessibilityTraits(UInt64 value)
        {
            return new UIAccessibilityTraits();
        }
        static public implicit operator UInt64(UIAccessibilityTraits value)
        {
            return 0;
        }
    }
}
