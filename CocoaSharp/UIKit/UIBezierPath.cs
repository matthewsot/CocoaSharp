using CoreGraphics;
using ObjectiveC;
        public UIBezierPath(CGRect rect) { }
        public UIBezierPath(CGRect ovalInRect) { }

    /// <summary>
    /// The corners of a rectangle.
    /// </summary>
    public enum UIRectCorner
    {
        /// <summary>
        /// The top-left corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        TopLeft,

        /// <summary>
        /// The top-right corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        TopRight,

        /// <summary>
        /// The bottom-left corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        BottomLeft,

        /// <summary>
        /// The bottom-right corner of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        BottomRight,

        /// <summary>
        /// All corners of the rectangle.
        /// </summary>
        [iOSVersion(3.2)]
        AllCorners,
    }