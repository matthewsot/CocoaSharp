using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A text document proxy provides textual context to a custom keyboard (which is based on the UIInputViewController class) by way of the keyboard’s textDocumentProxy property.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextDocumentProxy_Protocol/index.html#//apple_ref/occ/intf/UITextDocumentProxy"/>    [iOSVersion(8)]    public interface UITextDocumentProxy//: NSObjectProtocol, UIKeyInput, UITextInputTraits    {        /// <summary>        /// Textual context after the insertion point in the current text input object. (required) (read-only)        /// </summary>        [iOSVersion(8)]        [Export("documentContextAfterInput")]        string DocumentContextAfterInput { get; private set; }                /// <summary>        /// Textual context before the insertion point in the current text input object. (required) (read-only)        /// </summary>        [iOSVersion(8)]        [Export("documentContextBeforeInput")]        string DocumentContextBeforeInput { get; private set; }    }}