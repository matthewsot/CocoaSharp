using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The NSTextContainer class defines a region in which text is laid out. An NSLayoutManager object uses one or more NSTextContainer objects to determine where to break lines, lay out portions of text, and so on. An NSTextContainer object defines rectangular regions, and you can define exclusion paths inside the text container's bounding rectangle so that text flows around the exclusion path as it is laid out. You can create subclasses that define regions of nonrectangular shapes, such as circular regions.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSTextContainer_Class_TextKit/index.html#//apple_ref/occ/cl/NSTextContainer"/>    [iOSVersion(7)]    public class NSTextContainer : NSObject//, AnyObject, NSCoding, NSObjectProtocol, NSTextLayoutOrientationProvider    {        /// <summary>        /// Initializes a text container with a specified bounding rectangle.        /// </summary>        /// <param name="size">The size of the text container's bounding rectangle.</param>        [iOSVersion(7)]        public NSTextContainer(CGSize size) { }                /// <summary>        /// Returns the bounds of a line fragment rectangle inside the receiver for the proposed rectangle.        /// </summary>        /// <param name="proposedRect">A rectangle in which to lay out text proposed by the layout manager.</param>        /// <param name="atIndex">The character location inside the text storage for the line fragment being processed.</param>        /// <param name="writingDirection">The direction of advancement for line fragments inside a visual horizontal line. The values passed into the method are either NSWritingDirectionLeftToRight or NSWritingDirectionRightToLeft.</param>        /// <param name="remainingRect">The remainder of the proposed rectangle that was excluded from returned rectangle. It can be passed in as the proposed rectangle for the next iteration.</param>        [iOSVersion(7)]        [Export("lineFragmentRectForProposedRect")]        public CGRect LineFragmentRectForProposedRect(CGRect proposedRect, int atIndex, NSWritingDirection writingDirection, UnsafePointer<CGRect> remainingRect) { return default(CGRect); }                /// <summary>        /// Accessor for the NSLayoutManager object owning the receiver.        /// </summary>        [iOSVersion(7)]        [Export("layoutManager")]        public NSLayoutManager LayoutManager { get; set; }                /// <summary>        /// An array of UIBezierPath objects representing the exclusion paths inside the receiver's bounding rectangle. Default value: nil.        /// </summary>        [iOSVersion(7)]        [Export("exclusionPaths")]        public AnyObject[] ExclusionPaths { get; set; }                /// <summary>        /// Controls the size of the receiver’s bounding rectangle. Default value: CGSizeZero.        /// </summary>        [iOSVersion(7)]        [Export("size")]        public CGSize Size { get; set; }                /// <summary>        /// Defines the behavior of the last line inside the text container. Default value: NSLineBreakByWordWrapping.        /// </summary>        [iOSVersion(7)]        [Export("lineBreakMode")]        public NSLineBreakMode LineBreakMode { get; set; }                /// <summary>        /// Controls whether the receiver adjusts the height of its bounding rectangle when its text view is resized. Default value: false.        /// </summary>        [iOSVersion(7)]        [Export("heightTracksTextView")]        public bool HeightTracksTextView { get; set; }                /// <summary>        /// Controls whether the receiver adjusts the width of its bounding rectangle when its text view is resized. Default value: false.        /// </summary>        [iOSVersion(7)]        [Export("widthTracksTextView")]        public bool WidthTracksTextView { get; set; }                /// <summary>        /// The maximum number of lines that can be stored in the receiver. Default value: 0 (no limit).        /// </summary>        [iOSVersion(7)]        [Export("maximumNumberOfLines")]        public int MaximumNumberOfLines { get; set; }                /// <summary>        /// The amount by which text is inset within line fragment rectangles, in points. Default value: 5.0.        /// </summary>        [iOSVersion(7)]        [Export("lineFragmentPadding")]        public CGFloat LineFragmentPadding { get; set; }    }}