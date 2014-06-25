using ObjectiveC;

    /// <summary>
    /// The insertion point for custom menu items.
    /// </summary>
    public enum UIDocumentMenuOrder
    {
        /// <summary>
        /// The top item in the document menu.
        /// </summary>
        [iOSVersion(8)]
        First,

        /// <summary>
        /// The bottom item in the document menu.
        /// </summary>
        [iOSVersion(8)]
        Last,
    }