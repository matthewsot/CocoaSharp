using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSAttributedString_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40011688
    /// <summary>
    /// The UIKit framework adds methods to NSAttributedString to support the drawing of styled strings and to compute the size and metrics of a string prior to drawing. None of these methods affects the contents of the object itself, only how it is drawn on screen.
    /// </summary>
    [iOSVersion(6)]
    [Export("NSAttributedString")]
    public class NSAttributedStringAdditions
    {
        /// <summary>
        /// Attributes that you can apply to text in an attributed string.
        /// </summary>
        
        /// <summary>
        /// The value of this attribute is a UIFont object. Use this attribute to change the font for a range of text. If you do not specify this attribute, the string uses a 12-point Helvetica(Neue) font by default.
        /// </summary>
        [iOSVersion(6)]
        public string NSFontAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSParagraphStyle object. Use this attribute to apply multiple attributes to a range of text. If you do not specify this attribute, the string uses the default paragraph attributes, as returned by the defaultParagraphStyle method of NSParagraphStyle.
        /// </summary>
        [iOSVersion(6)]
        public string NSParagraphStyleAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is a UIColor object. Use this attribute to specify the color of the text during rendering. If you do not specify this attribute, the text is rendered in black.
        /// </summary>
        [iOSVersion(6)]
        public string NSForegroundColorAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is a UIColor object. Use this attribute to specify the color of the background area behind the text. If you do not specify this attribute, no background color is drawn.
        /// </summary>
        [iOSVersion(6)]
        public string NSBackgroundColorAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing an integer. Ligatures cause specific character combinations to be rendered using a single custom glyph that corresponds to those characters. The value 0 indicates no ligatures. The value 1 indicates the use of the default ligatures. The value 2 indicates the use of all ligatures. The default value for this attribute is 1. (Value 2 is unsupported on iOS.)
        /// </summary>
        [iOSVersion(6)]
        public string NSLigatureAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing a floating-point value. This value specifies the number of points by which to adjust kern-pair characters. Kerning prevents unwanted space from occurring between specific characters and depends on the font. The value 0 means kerning is disabled. The default value for this attribute is 0.
        /// </summary>
        [iOSVersion(6)]
        public string NSKernAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing an integer. This value indicates whether the text has a line through it and corresponds to one of the constants described in “Underline and Strikethrough Style Attributes”. The default value for this attribute is NSUnderlineStyleNone.
        /// </summary>
        [iOSVersion(6)]
        public string NSStrikethroughStyleAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing an integer. This value indicates whether the text is underlined and corresponds to one of the constants described in “Underline and Strikethrough Style Attributes”. The default value for this attribute is NSUnderlineStyleNone.
        /// </summary>
        [iOSVersion(6)]
        public string NSUnderlineStyleAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this parameter is a UIColor object. If it is not defined (which is the case by default), it is assumed to be the same as the value of NSForegroundColorAttributeName; otherwise, it describes the outline color. For more details, see Drawing attributed strings that are both filled and stroked.
        /// </summary>
        [iOSVersion(6)]
        public string NSStrokeColorAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing a floating-point value. This value represents the amount to change the stroke width and is specified as a percentage of the font point size. Specify 0 (the default) for no additional changes. Specify positive values to change the stroke width alone. Specify negative values to stroke and fill the text. For example, a typical value for outlined text would be 3.0.
        /// </summary>
        [iOSVersion(6)]
        public string NSStrokeWidthAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSShadow object. The default value of this property is nil.
        /// </summary>
        [iOSVersion(6)]
        public string NSShadowAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSString object. Use this attribute to specify a text effect, such as NSTextEffectLetterpressStyle. The default value of this property is nil, indicating no text effect.
        /// </summary>
        [iOSVersion(7)]
        public string NSTextEffectAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSTextAttachment object. The default value of this property is nil, indicating no attachment.
        /// </summary>
        [iOSVersion(7)]
        public string NSAttachmentAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is and NSURL object (preferred) or an NSString object. The default value of this property is nil, indicating no link.
        /// </summary>
        [iOSVersion(7)]
        public string NSLinkAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing a floating point value indicating the character’s offset from the baseline, in points. The default value is 0.
        /// </summary>
        [iOSVersion(7)]
        public string NSBaselineOffsetAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is a UIColor object. The default value is nil, indicating same as foreground color.
        /// </summary>
        [iOSVersion(7)]
        public string NSUnderlineColorAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is a UIColor object. The default value is nil, indicating same as foreground color.
        /// </summary>
        [iOSVersion(7)]
        public string NSStrikethroughColorAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing a floating point value indicating skew to be applied to glyphs. The default value is 0, indicating no skew.
        /// </summary>
        [iOSVersion(7)]
        public string NSObliquenessAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing a floating point value indicating the log of the expansion factor to be applied to glyphs. The default value is 0, indicating no expansion.
        /// </summary>
        [iOSVersion(7)]
        public string NSExpansionAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSArray of NSNumber objects representing the nested levels of writing direction overrides, in order from outermost to innermost.
        /// </summary>
        [iOSVersion(7)]
        public string NSWritingDirectionAttributeName { get; private set; }
        
        /// <summary>
        /// The value of this attribute is an NSNumber object containing an integer. The value 0 indicates horizontal text. The value 1 indicates vertical text. In iOS, horizontal text is always used and specifying a different value is undefined.
        /// </summary>
        [iOSVersion(6)]
        public string NSVerticalGlyphFormAttributeName { get; private set; }

        /// <summary>
        /// The following values can be returned for the NSDocumentTypeDocumentAttribute key in the document attributes dictionary.
        /// </summary>
        
        /// <summary>
        /// Plain text document.
        /// </summary>
        [iOSVersion(7)]
        public string NSPlainTextDocumentType { get; private set; }
        
        /// <summary>
        /// Rich text format document.
        /// </summary>
        [iOSVersion(7)]
        public string NSRTFTextDocumentType { get; private set; }
        
        /// <summary>
        /// Rich text format with attachments document.
        /// </summary>
        [iOSVersion(7)]
        public string NSRTFDTextDocumentType { get; private set; }
        
        /// <summary>
        /// Hypertext Markup Language (HTML) document.
        /// </summary>
        [iOSVersion(7)]
        public string NSHTMLTextDocumentType { get; private set; }
        
        /// <summary>
        /// These keys represent in and out document properties used by both read and write methods.
        /// </summary>
        
        /// <summary>
        /// @&quot;DocumentType&quot;, one of the document types declared in Document Types. For reader methods, this key in options can specify the document type for interpreting the contents. Upon return, the document attributes can contain this key for indicating the actual format used to read the contents. For write methods, this key specifies the format for generating the data.
        /// </summary>
        [iOSVersion(7)]
        public string NSDocumentTypeDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;CharacterEncoding&quot;, NSNumber containing integer specifying NSStringEncoding for the file; default for plain text is the default encoding. This key in options can specify the string encoding for reading the data. Upon return, the document attributes can contain the actual encoding used. For writing methods, this value is used for generating the plain text data.
        /// </summary>
        [iOSVersion(7)]
        public string NSCharacterEncodingDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;DefaultAttributes&quot;, NSDictionary containing attributes to be applied to plain files. Used by reader methods. This key in options can specify the default attributes applied to the entire document contents. Upon return, the document attributes can contain this key indicating the actual attributes used.
        /// </summary>
        [iOSVersion(7)]
        public string NSDefaultAttributesDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;PaperSize&quot;, NSValue containing CGSize (in points).
        /// </summary>
        [iOSVersion(7)]
        public string NSPaperSizeDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;PaperMargin&quot;, NSValue containing UIEdgeInsets.
        /// </summary>
        [iOSVersion(7)]
        public string NSPaperMarginDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;ViewSize&quot;, NSValue containing CGSize (in points).
        /// </summary>
        [iOSVersion(7)]
        public string NSViewSizeDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;ViewZoom&quot;, NSNumber containing floating point value: 100 = 100% zoom.
        /// </summary>
        [iOSVersion(7)]
        public string NSViewZoomDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;ViewMode&quot;, NSNumber containing integer: 0 = normal; 1 = page layout.
        /// </summary>
        [iOSVersion(7)]
        public string NSViewModeDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;ReadOnly&quot;, NSNumber containing integer: if missing, 0 or negative = not readonly; 1 or more = readonly. This attribute has nothing to do with the file system protection on the file; instead, it indicates how the file should be displayed to the user.
        /// </summary>
        [iOSVersion(7)]
        public string NSReadOnlyDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;BackgroundColor&quot;, UIColor representing the document-wide page background color.
        /// </summary>
        [iOSVersion(7)]
        public string NSBackgroundColorDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;HyphenationFactor&quot;, NSNumber containing floating point value: 0 = off; 1 = full hyphenation.
        /// </summary>
        [iOSVersion(7)]
        public string NSHyphenationFactorDocumentAttribute { get; private set; }
        
        /// <summary>
        /// @&quot;DefaultTabinterval&quot;, NSNumber containing floating point value representing the document-wide default tab stop interval, in points.
        /// </summary>
        [iOSVersion(7)]
        public string NSDefaultTabintervalDocumentAttribute { get; private set; }
        
        /// <summary>
        /// An NSArray containing NSDictionary objects, each dictionary describing a layout orientation section. The dictionary can have two attributes: NSTextLayoutSectionOrientation and NSTextLayoutSectionRange. When there is a gap between sections, it's assumed to have NSTextLayoutOrientationHorizontal.
        /// </summary>
        [iOSVersion(7)]
        public string NSTextLayoutSectionsAttribute { get; private set; }
        
        /// <summary>
        /// These constants are used by NSTextLayoutSectionsAttribute.
        /// </summary>
        
        /// <summary>
        /// An NSNumber containing an NSTextLayoutOrientation value. The default value is NSTextLayoutOrientationHorizontal.
        /// </summary>
        [iOSVersion(7)]
        public string NSTextLayoutSectionOrientation { get; private set; }
        
        /// <summary>
        /// An NSValue containing an NSRange representing a character range. The default value is a range covering the entire string.
        /// </summary>
        [iOSVersion(7)]
        public string NSTextLayoutSectionRange { get; private set; }
        
        /// <summary>
        /// This constant is used by NSTextEffectAttributeName.
        /// </summary>
        [Export("NSTextEffectLetterpressStyle")]
        public string NSTextEffectLetterpressStyle { get; private set; }
    }
    /// <summary>
    /// Options for customizing the way strings are drawn.
    /// </summary>
    public enum NSStringDrawingOptions
    {
        /// <summary>
        /// Truncate and add an ellipsis character to the last visible line if the text does not fit into the specified bounds. This option is ignored if the NSStringDrawingUsesLineFragmentOrigin option is not also specified.
        /// </summary>
        [iOSVersion(6)]
        TruncatesLastVisibleLine,

        /// <summary>
        /// The origin specified when drawing the string is the line fragment origin and not the baseline origin.
        /// </summary>
        [iOSVersion(6)]
        UsesLineFragmentOrigin,

        /// <summary>
        /// Use the font leading information to calculate line heights.
        /// </summary>
        [iOSVersion(6)]
        UsesFontLeading,

        /// <summary>
        /// Use the image glyph bounds (instead of the typographic bounds) when computing layout.
        /// </summary>
        [iOSVersion(6)]
        UsesDeviceMetrics,
    }
    /// <summary>
    /// Constants for specifying both the NSUnderlineStyleAttributeName and NSStrikethroughStyleAttributeName attributes of an attributed string.
    /// </summary>
    public enum NSUnderlineStyle
    {
        /// <summary>
        /// Do not draw a line.
        /// </summary>
        [iOSVersion(6)]
        StyleNone,

        /// <summary>
        /// Draw a single line.
        /// </summary>
        [iOSVersion(6)]
        StyleSingle,

        /// <summary>
        /// Draw a thick line.
        /// </summary>
        [iOSVersion(7)]
        StyleThick,

        /// <summary>
        /// Draw a double line.
        /// </summary>
        [iOSVersion(7)]
        StyleDouble,

        /// <summary>
        /// Draw a line of dots.
        /// </summary>
        [iOSVersion(7)]
        PatternDot,

        /// <summary>
        /// Draw a line of dashes.
        /// </summary>
        [iOSVersion(7)]
        PatternDash,

        /// <summary>
        /// Draw a line of alternating dashes and dots.
        /// </summary>
        [iOSVersion(7)]
        PatternDashDot,

        /// <summary>
        /// Draw a line of alternating dashes and two dots.
        /// </summary>
        [iOSVersion(7)]
        PatternDashDotDot,

        /// <summary>
        /// Draw the line only underneath or through words, not whitespace.
        /// </summary>
        [iOSVersion(7)]
        ByWord,
    }

    /// <summary>
    /// Options for specifying text writing direction used with NSWritingDirectionAttributeName.
    /// </summary>
    public enum NSTextWritingDirection
    {
        /// <summary>
        /// Text is embedded in text with another writing direction. For example, an English quotation in the middle of an Arabic sentence could be marked as being embedded left-to-right text.
        /// </summary>
        [iOSVersion(7)]
        Embedding,

        /// <summary>
        /// Enables character types with inherent directionality to be overridden when required for special cases, such as for part numbers made of mixed English, digits, and Hebrew letters to be written from right to left.
        /// </summary>
        [iOSVersion(7)]
        Override,
    }
}