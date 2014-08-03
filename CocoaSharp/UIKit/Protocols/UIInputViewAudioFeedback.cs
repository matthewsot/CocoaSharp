using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIInputViewAudioFeedback protocol defines a single property for enabling a custom input or keyboard accessory view to play standard keyboard input clicks.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIInputViewAudioFeedback_ProtocolReference/index.html#//apple_ref/occ/intf/UIInputViewAudioFeedback"/>    [iOSVersion(4.2)]    public interface UIInputViewAudioFeedback//: NSObjectProtocol    {        /// <summary>        /// Specifies whether or not an input view enables input clicks.        /// </summary>        [iOSVersion(4.2)]        [Export("enableInputClicksWhenVisible")]        bool EnableInputClicksWhenVisible { get; private set; }    }}