using System;
using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{

    /// <summary>
    /// A unique token that identifies a request to run in the background.
    /// </summary>
    [iOSVersion(4)]
    public struct UIBackgroundTaskIdentifier
    {
        static public implicit operator UIBackgroundTaskIdentifier(int value)
        {
            return new UIBackgroundTaskIdentifier();
        }
        static public implicit operator int(UIBackgroundTaskIdentifier value)
        {
            return 0;
        }
    }
}
