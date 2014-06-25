using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// Constants for specifying the direction of the popover arrow.
    /// </summary>
    public enum UIPopoverArrowDirection
    {
        /// <summary>
        /// An arrow that points upward.
        /// </summary>
        [iOSVersion(3.2)]
        Up,

        /// <summary>
        /// An arrow that points downward.
        /// </summary>
        [iOSVersion(3.2)]
        Down,

        /// <summary>
        /// An arrow that points toward the left.
        /// </summary>
        [iOSVersion(3.2)]
        Left,

        /// <summary>
        /// An arrow that points toward the right.
        /// </summary>
        [iOSVersion(3.2)]
        Right,

        /// <summary>
        /// An arrow that points in any direction.
        /// </summary>
        [iOSVersion(3.2)]
        Any,

        /// <summary>
        /// The status of the arrow is currently unknown.
        /// </summary>
        [iOSVersion(3.2)]
        Unknown,
    }