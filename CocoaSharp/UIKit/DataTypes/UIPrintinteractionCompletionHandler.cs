using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using SharpSwift.Attributes;

namespace UIKit
{
    /// <summary>
    /// The type of block callback for responding to the completion of a print job or handing printing errors.
    /// </summary>
    [iOSVersion(4.2)]
    public struct UIPrintinteractionCompletionHandler
    {
        static public implicit operator UIPrintinteractionCompletionHandler(Action<UIPrintinteractionController, bool, NSError> value)
        {
            return new UIPrintinteractionCompletionHandler();
        }
        static public implicit operator Action<UIPrintinteractionController, bool, NSError>(UIPrintinteractionCompletionHandler value)
        {
            return null;
        }
    }
}
