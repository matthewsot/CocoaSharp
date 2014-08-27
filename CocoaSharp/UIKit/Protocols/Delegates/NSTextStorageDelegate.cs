using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The NSTextStorageDelegate protocol defines the optional methods implemented by delegates of NSTextStorage objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSTextStorageDelegate_Protocol_TextKit/index.html#//apple_ref/occ/intf/NSTextStorageDelegate"/>    [iOSVersion(7)]    public interface NSTextStorageDelegate//: NSObjectProtocol    {        /// <summary>        /// Sent when a text storage object is about to process edits.        /// </summary>        /// <param name="textStorage">The text storage object processing edits.</param>        /// <param name="willProcessEditing">The types of edits to do: NSTextStorageEditedAttributes, NSTextStorageEditedCharacters, or both.</param>        /// <param name="range">The range in the original string (before the edit).</param>        /// <param name="changeInLength">The length delta for the editing changes.</param>        [iOSVersion(7)]        [Export("textStorage")]        void TextStorage(NSTextStorage textStorage, NSTextStorageEditActions willProcessEditing, NSRange range, int changeInLength);                /// <summary>        /// Sent when a text storage object has finished processing edits.        /// </summary>        /// <param name="textStorage">The text storage object processing edits.</param>        /// <param name="didProcessEditing">The types of edits done: NSTextStorageEditedAttributes, NSTextStorageEditedCharacters, or both.</param>        /// <param name="range">The range in the original string (before the edit).</param>        /// <param name="changeInLength">The length delta for the editing changes.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(7)]        [Export("textStorage")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void TextStorage(NSTextStorage textStorage, NSTextStorageEditActions didProcessEditing, NSRange range, int changeInLength, bool NAME_YOUR_PARAMS = false);    }}