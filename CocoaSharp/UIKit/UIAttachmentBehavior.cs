using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The type of an attachment behavior, indicating what a dynamic item is attached to.
    /// </summary>
    public enum UIAttachmentBehaviorType
    {
        /// <summary>
        /// Designates an attachment behavior that connects a dynamic item to another dynamic item.
        /// </summary>
        [iOSVersion(7)]
        Items,

        /// <summary>
        /// Designates an attachment behavior that connects a dynamic item to an anchor point.
        /// </summary>
        [iOSVersion(7)]
        Anchor,
    }