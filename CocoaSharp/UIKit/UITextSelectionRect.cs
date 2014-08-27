using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UITextSelectionRect class encapsulates information about a selected range of text in a document. This class is an abstract class and must be subclassed to be used. The system text input views provide their own concrete implementations of this class.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextSelectionRect_class/index.html#//apple_ref/occ/cl/UITextSelectionRect"/>    [iOSVersion(6)]    public class UITextSelectionRect : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// The rectangle that encloses the receiver’s text range. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("rect")]        public CGRect Rect { get; private set; }                /// <summary>        /// The writing direction of text in the receiver’s text range. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("writingDirection")]        public UITextWritingDirection WritingDirection { get; private set; }                /// <summary>        /// A Boolean value indicating whether the text is oriented vertically. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("isVertical")]        public bool IsVertical { get; private set; }                /// <summary>        /// A Boolean value indicating whether the rectangle contains the start of the selection. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("containsStart")]        public bool ContainsStart { get; private set; }                /// <summary>        /// A Boolean value indicating whether the rectangle contains the end of the selection. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("containsEnd")]        public bool ContainsEnd { get; private set; }    }}