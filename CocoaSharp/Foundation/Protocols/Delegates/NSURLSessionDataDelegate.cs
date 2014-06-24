using ObjectiveC;

    /// <summary>
    /// Constants indicating how a data or upload session should proceed after receiving the initial headers.
    /// </summary>
    public enum NSURLSessionResponseDisposition
    {
        /// <summary>
        /// Cancel the load. Equivalent to calling cancel on the task.
        /// </summary>
        [iOSVersion(7)]
        Cancel,

        /// <summary>
        /// Allow the load operation to continue.
        /// </summary>
        [iOSVersion(7)]
        Allow,

        /// <summary>
        /// Convert this request into a download task.
        /// </summary>
        [iOSVersion(7)]
        BecomeDownload,
    }