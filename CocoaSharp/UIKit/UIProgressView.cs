using ObjectiveC;

    /// <summary>
    /// The styles permitted for the progress bar.
    /// </summary>
    public enum UIProgressViewStyle
    {
        /// <summary>
        /// The standard progress-view style. This is the default.
        /// </summary>
        [iOSVersion(2)]
        Default,

        /// <summary>
        /// The style of progress view that is used in a toolbar.
        /// </summary>
        [iOSVersion(2)]
        Bar,
    }