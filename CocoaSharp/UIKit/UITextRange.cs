using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UITextRange object represents a range of characters in a text container; in other words, it identifies a starting index and an ending index in string backing a text-entry object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextRange_Class/index.html#//apple_ref/occ/cl/UITextRange"/>    [iOSVersion(3.2)]    public class UITextRange : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// The start of a range of text. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("start")]        public UITextPosition Start { get; private set; }                /// <summary>        /// The end of the range of text. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("end")]        public UITextPosition End { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the range of text represented by the receiver is zero-length. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("empty")]        public bool Empty { get; private set; }    }}