using ObjectiveC;

    /// <summary>
    /// Modes that define the type of file transfer operation used by the document picker.
    /// </summary>
    public enum UIDocumentPickerMode
    {
        /// <summary>
        /// The document picker imports a file from outside the app’s sandbox.
        /// </summary>
        [iOSVersion(8)]
        Import,

        /// <summary>
        /// The document picker opens an external file located outside the app’s sandbox.
        /// </summary>
        [iOSVersion(8)]
        Open,

        /// <summary>
        /// The document picker exports a local file to a destination outside the app’s sandbox.
        /// </summary>
        [iOSVersion(8)]
        ExportToService,

        /// <summary>
        /// The document picker moves a local file outside the app’s sandbox and provides access to it as an external file.
        /// </summary>
        [iOSVersion(8)]
        MoveToService,
    }