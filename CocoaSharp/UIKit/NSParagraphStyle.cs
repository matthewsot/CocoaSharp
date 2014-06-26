using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/ApplicationKit/Classes/NSParagraphStyle_Class/index.html#//apple_ref/occ/cl/NSParagraphStyle    /// <summary>    /// The NSParagraphStyle class and its subclass NSMutableParagraphStyle encapsulate the paragraph or ruler attributes used by the NSAttributedString classes. Instances of these classes are often referred to as paragraph style objects or, when no confusion will result, paragraph styles.    /// </summary>    [iOSVersion(6)]    public class NSParagraphStyle : NSObject    {        /// <summary>        /// Returns the default paragraph style.        /// </summary>        [iOSVersion(6)]        [Export("defaultParagraphStyle")]        public static NSParagraphStyle DefaultParagraphStyle() { return null; }                /// <summary>        /// The text alignment of the receiver. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("alignment")]        public NSTextAlignment Alignment { get; private set; }                /// <summary>        /// The indentation of the first line of the receiver. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("firstLineHeadIndent")]        public CGFloat FirstLineHeadIndent { get; private set; }                /// <summary>        /// The indentation of the receiver’s lines other than the first. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("headIndent")]        public CGFloat HeadIndent { get; private set; }                /// <summary>        /// The trailing indentation of the receiver. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("tailIndent")]        public CGFloat TailIndent { get; private set; }                /// <summary>        /// The line height multiple. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("lineHeightMultiple")]        public CGFloat LineHeightMultiple { get; private set; }                /// <summary>        /// The receiver’s maximum line height. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("maximumLineHeight")]        public CGFloat MaximumLineHeight { get; private set; }                /// <summary>        /// The receiver’s minimum height. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("minimumLineHeight")]        public CGFloat MinimumLineHeight { get; private set; }                /// <summary>        /// The distance in points between the bottom of one line fragment and the top of the next. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("lineSpacing")]        public CGFloat LineSpacing { get; private set; }                /// <summary>        /// The space after the end of the paragraph. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("paragraphSpacing")]        public CGFloat ParagraphSpacing { get; private set; }                /// <summary>        /// The distance between the paragraph’s top and the beginning of its text content. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("paragraphSpacingBefore")]        public CGFloat ParagraphSpacingBefore { get; private set; }

        /// <summary>
        /// An array of NSTextTab objects representing the receiver’s tab stops.        /// </summary>        /// <returns>The NSTextTab objects, sorted by location, that define the tab stops for the paragraph style.</returns>        [iOSVersion(7)]        [Export("tabStops")]        public AnyObject[] TabStops { get; private set; }                /// <summary>        /// Returns the document-wide default tab interval.        /// </summary>        /// <returns>The default tab interval in points. Tabs after the last specified in tabStops are placed at integer multiples of this distance (if positive). Default return value is 0.0.</returns>        [iOSVersion(7)]        [Export("defaultTabinterval")]        public CGFloat DefaultTabinterval { get; private set; }                /// <summary>        /// The mode that should be used to break lines in the receiver. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("lineBreakMode")]        public NSLineBreakMode LineBreakMode { get; private set; }                /// <summary>        /// The paragraph’s threshold for hyphenation. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("hyphenationFactor")]        public CFloat HyphenationFactor { get; private set; }                /// <summary>        /// Returns the default writing direction for the specified language.        /// </summary>        /// <param name="languageName">The language specified in ISO language region format. Can be nil to return a default writing direction derived from the user’s defaults database.</param>        /// <returns>The default writing direction.</returns>        [iOSVersion(6)]        [Export("defaultWritingDirectionForLanguage")]
        public static NSWritingDirection DefaultWritingDirectionForLanguage(string languageName) { return NSWritingDirection.LeftToRight; }                /// <summary>        /// The base writing direction for the receiver. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("baseWritingDirection")]        public NSWritingDirection BaseWritingDirection { get; private set; }    }

    /// <summary>
    /// These constants specify what happens when a line is too long for its container.
    /// </summary>
    public enum NSLineBreakMode
    {
        /// <summary>
        /// Wrapping occurs at word boundaries, unless the word itself doesn’t fit on a single line. See Characters and Grapheme Clusters in String Programming Guide for a discussion of issues related to determining word boundaries.
        /// </summary>
        [iOSVersion(6)]
        ByWordWrapping,

        /// <summary>
        /// Wrapping occurs before the first character that doesn’t fit.
        /// </summary>
        [iOSVersion(6)]
        ByCharWrapping,

        /// <summary>
        /// Lines are simply not drawn past the edge of the text container.
        /// </summary>
        [iOSVersion(6)]
        ByClipping,

        /// <summary>
        /// The line is displayed so that the end fits in the container and the missing text at the beginning of the line is indicated by an ellipsis glyph. Although this mode works for multiline text, it is more often used for single line text.
        /// </summary>
        [iOSVersion(6)]
        ByTruncatingHead,

        /// <summary>
        /// The line is displayed so that the beginning fits in the container and the missing text at the end of the line is indicated by an ellipsis glyph. Although this mode works for multiline text, it is more often used for single line text.
        /// </summary>
        [iOSVersion(6)]
        ByTruncatingTail,

        /// <summary>
        /// The line is displayed so that the beginning and end fit in the container and the missing text in the middle is indicated by an ellipsis glyph. Although this mode works for multiline text, it is more often used for single line text.
        /// </summary>
        [iOSVersion(6)]
        ByTruncatingMiddle,
    }}