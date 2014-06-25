using System;
using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// The completion handler to execute when dismissing a printer picker controller.
    /// </summary>
    [iOSVersion(8)]
    public struct UIPrinterPickerCompletionHandler
    {
        static public implicit operator UIPrinterPickerCompletionHandler(Action<UIPrinterPickerController, bool, NSError> value)
        {
            return new UIPrinterPickerCompletionHandler();
        }
        static public implicit operator Action<UIPrinterPickerController, bool, NSError>(UIPrinterPickerCompletionHandler value)
        {
            return null;
        }
    }
}
