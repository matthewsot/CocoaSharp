using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// A notification that an accessible application can send.
    /// </summary>
    [iOSVersion(3)]
    public struct UIAccessibilityNotifications
    {
        static public implicit operator UIAccessibilityNotifications(UInt32 value)
        {
            return new UIAccessibilityNotifications();
        }
        static public implicit operator UInt32(UIAccessibilityNotifications value)
        {
            return 0;
        }
    }
}
