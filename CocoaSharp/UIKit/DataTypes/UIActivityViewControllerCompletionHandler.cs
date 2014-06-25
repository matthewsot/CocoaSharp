using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// A completion handler to execute after the activity view controller is dismissed.
    /// </summary>
    [iOSVersion(6)]
    public struct UIActivityViewControllerCompletionHandler
    {
        static public implicit operator UIActivityViewControllerCompletionHandler(Action<string, bool> value)
        {
            return new UIActivityViewControllerCompletionHandler();
        }
        static public implicit operator Action<string, bool>(UIActivityViewControllerCompletionHandler value)
        {
            return null;
        }
    }
}