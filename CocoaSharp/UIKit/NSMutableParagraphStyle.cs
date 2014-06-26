using CoreGraphics;
using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/ApplicationKit/Classes/NSMutableParagraphStyle_Class/index.html#//apple_ref/occ/cl/NSMutableParagraphStyle
    /// <summary>
    /// The NSMutableParagraphStyle class adds methods to its superclass, NSParagraphStyle, for changing the values of the subattributes in a paragraph style attribute. See the NSParagraphStyle and NSAttributedString specifications for more information.
    /// </summary>
    [iOSVersion(6)]
    public class NSMutableParagraphStyle : NSParagraphStyle
    {
        /// <summary>
        /// The text alignment of the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("alignment")]
        public NSTextAlignment Alignment { get; set; }
        
        /// <summary>
        /// The indentation of the first line of the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("firstLineHeadIndent")]
        public CGFloat FirstLineHeadIndent { get; set; }
        
        /// <summary>
        /// The indentation of the receiver’s lines other than the first.
        /// </summary>
        [iOSVersion(6)]
        [Export("headIndent")]
        public CGFloat HeadIndent { get; set; }
        
        /// <summary>
        /// The trailing indentation of the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("tailIndent")]
        public CGFloat TailIndent { get; set; }
        
        /// <summary>
        /// The mode that should be used to break lines in the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("lineBreakMode")]
        public NSLineBreakMode LineBreakMode { get; set; }
        
        /// <summary>
        /// The receiver’s maximum line height.
        /// </summary>
        [iOSVersion(6)]
        [Export("maximumLineHeight")]
        public CGFloat MaximumLineHeight { get; set; }
        
        /// <summary>
        /// The receiver’s minimum height.
        /// </summary>
        [iOSVersion(6)]
        [Export("minimumLineHeight")]
        public CGFloat MinimumLineHeight { get; set; }
        
        /// <summary>
        /// The distance in points between the bottom of one line fragment and the top of the next.
        /// </summary>
        [iOSVersion(6)]
        [Export("lineSpacing")]
        public CGFloat LineSpacing { get; set; }
        
        /// <summary>
        /// The space after the end of the paragraph.
        /// </summary>
        [iOSVersion(6)]
        [Export("paragraphSpacing")]
        public CGFloat ParagraphSpacing { get; set; }
        
        /// <summary>
        /// The distance between the paragraph’s top and the beginning of its text content.
        /// </summary>
        [iOSVersion(6)]
        [Export("paragraphSpacingBefore")]
        public CGFloat ParagraphSpacingBefore { get; set; }
        
        /// <summary>
        /// The base writing direction for the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("baseWritingDirection")]
        public NSWritingDirection BaseWritingDirection { get; set; }
        
        /// <summary>
        /// The line height multiple.
        /// </summary>
        [iOSVersion(6)]
        [Export("lineHeightMultiple")]
        public CGFloat LineHeightMultiple { get; set; }

        /// <summary>
        /// An array of NSTextTab objects representing the receiver’s tab stops.
        /// </summary>
        [iOSVersion(7)]
        [Export("tabStops")]
        public AnyObject[] TabStops { get; set; }

        /// <summary>
        /// The document-wide default tab interval.
        /// </summary>
        [iOSVersion(7)]
        [Export("defaultTabinterval")]
        public CGFloat DefaultTabinterval { get; set; }
        
        /// <summary>
        /// The paragraph’s threshold for hyphenation.
        /// </summary>
        [iOSVersion(6)]
        [Export("hyphenationFactor")]
        public CFloat HyphenationFactor { get; set; }
    }
}