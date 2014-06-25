using CoreGraphics;
using ObjectiveC;
        public NSGlyphProperty PropertyForGlyphAtIndex(int glyphIndex) { return NSGlyphProperty.Null; }
        public NSRange GlyphRangeForBoundingRectWithoutAdditionalLayout(CGRect bounds, NSTextContainer inTextContainer) { return new NSRange(); }
        public NSRange GlyphRangeForCharacterRange(NSRange charRange, CMutablePointer<NSRange> actualCharacterRange) { return new NSRange(); }
        public NSRange GlyphRangeForTextContainer(NSTextContainer container) { return new NSRange(); }
        public NSRange RangeOfNominallySpacedGlyphsContainingIndex(int glyphIndex) { return new NSRange(); }
    }

    /// <summary>
    /// Describes the text layout orientation.
    /// </summary>
    public enum NSTextLayoutOrientation
    {
        /// <summary>
        /// Lines rendered horizontally, extending from top to bottom
        /// </summary>
        [iOSVersion(7)]
        Horizontal,

        /// <summary>
        /// Lines rendered vertically, extending from right to left
        /// </summary>
        [iOSVersion(7)]
        Vertical,
    }

    /// <summary>
    /// Describes glyph properties.
    /// </summary>
    public enum NSGlyphProperty
    {
        /// <summary>
        /// Null glyph ignored for layout and display.
        /// </summary>
        [iOSVersion(7)]
        Null,

        /// <summary>
        /// Control character such as tab, attachment, and so on, that has associated special behavior.
        /// </summary>
        [iOSVersion(7)]
        ControlCharacter,

        /// <summary>
        /// Glyphs with elastic glyph width behavior such as whitespace.
        /// </summary>
        [iOSVersion(7)]
        Elastic,

        /// <summary>
        /// Glyphs with combining properties, typically characters in Unicode Mn class.
        /// </summary>
        [iOSVersion(7)]
        NonBaseCharacter,
    }

    /// <summary>
    /// Describes actions control characters can cause.
    /// </summary>
    public enum NSControlCharacterAction
    {
        /// <summary>
        /// Glyphs with this action are filtered out from layout (notShownAttributeForGlyphAtIndex: == YES for the glyph).
        /// </summary>
        [iOSVersion(7)]
        ZeroAdvancementAction,

        /// <summary>
        /// The width for a glyph with this action is determined by the delegate method layoutManager:boundingBoxForControlGlyphAtIndex:forTextContainer:proposedLineFragment:glyphPosition:characterIndex: if the method is implemented; otherwise, same as NSControlCharacterZeroAdvancementAction.
        /// </summary>
        [iOSVersion(7)]
        WhitespaceAction,

        /// <summary>
        /// Treated as a tab character.
        /// </summary>
        [iOSVersion(7)]
        HorizontalTabAction,

        /// <summary>
        /// Causes a line break.
        /// </summary>
        [iOSVersion(7)]
        LineBreakAction,

        /// <summary>
        /// Causes a paragraph break; firstLineHeadIndent is used for the following glyph.
        /// </summary>
        [iOSVersion(7)]
        ParagraphBreakAction,

        /// <summary>
        /// Causes container break.
        /// </summary>
        [iOSVersion(7)]
        ContainerBreakAction,
    }