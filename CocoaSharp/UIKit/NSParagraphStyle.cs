using CoreGraphics;
using ObjectiveC;

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
    }