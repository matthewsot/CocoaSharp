using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocumentPickerViewController_Class/index.html#//apple_ref/occ/cl/UIDocumentPickerViewController    /// <summary>    /// A UIDocumentPickerViewController object lets the user select documents or destinations outside your app’s sandbox.    /// </summary>    [iOSVersion(8)]    public class UIDocumentPickerViewController : UIViewController    {        /// <summary>        /// Initializes and returns a document picker that can import or open the given file types.        /// </summary>        /// <param name="documentTypes">An array of uniform type identifiers. UTIs are strings that uniquely identify a file’s type. For more information, see Uniform Type Identifiers Overview.</param>        /// <param name="inMode">The type of file-transfer operation that the document picker performs. This argument accepts only the UIDocumentPickerModeImport or UIDocumentPickerModeOpen mode.</param>        /// <returns>Returns an initialized UIDocumentPickerViewController object, or nil if the object could not be successfully initialized.</returns>        [iOSVersion(8)]        public UIDocumentPickerViewController(AnyObject[] documentTypes, UIDocumentPickerMode inMode) { }                /// <summary>        /// Initializes and returns a document picker that can export or move the given document.        /// </summary>        /// <param name="URL">The document to be exported or moved.</param>        /// <param name="inMode">The type of file-transfer operation that the document picker performs. This argument accepts only the UIDocumentPickerModeExportToService or UIDocumentPickerModeMoveToService mode.</param>        /// <returns>Returns an initialized UIDocumentPickerViewController object, or nil if the object could not be successfully initialized.</returns>        [iOSVersion(8)]        public UIDocumentPickerViewController(NSURL URL, UIDocumentPickerMode inMode) { }                /// <summary>        /// The document picker’s delegate.        /// </summary>        [iOSVersion(8)]        [Export("delegate")]        public UIDocumentPickerDelegate Delegate { get; set; }                /// <summary>        /// The type of file-transfer operation that the document picker performs. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("documentPickerMode")]        public UIDocumentPickerMode DocumentPickerMode { get; private set; }    }

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
    }}