using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocumentMenuViewController_Class/index.html#//apple_ref/occ/cl/UIDocumentMenuViewController    /// <summary>    /// A UIDocumentMenuViewController object represents a list of all the available document pickers for a given file type and mode. You can also add your own custom menu items to this list.    /// </summary>    [iOSVersion(8)]    public class UIDocumentMenuViewController : UIViewController    {        /// <summary>        /// Initializes and returns a document menu to import or open the given file types.        /// </summary>        /// <param name="documentTypes">An array of uniform type identifiers. UTIs are strings that uniquely identify a file’s type. For more information, see Uniform Type Identifiers Overview.</param>        /// <param name="inMode">The type of file transfer operation the document picker performs. This argument accepts only the UIDocumentPickerModeImport or UIDocumentPickerModeOpen mode.</param>        /// <returns>Returns an initialized UIDocumentMenuViewController object, or nil if the object could not be successfully initialized.</returns>        [iOSVersion(8)]        public UIDocumentMenuViewController(AnyObject[] documentTypes, UIDocumentPickerMode inMode): base("", null) { }                /// <summary>        /// Initializes and returns a document menu to export or move the given document.        /// </summary>        /// <param name="URL">The document to be exported or moved.</param>        /// <param name="inMode">The type of file-transfer operation that the document picker performs. This argument accepts only the UIDocumentPickerModeExportToService or UIDocumentPickerModeMoveToService mode.</param>        /// <returns>Returns an initialized UIDocumentMenuViewController object, or nil if the object could not be successfully initialized.</returns>        [iOSVersion(8)]        public UIDocumentMenuViewController(NSURL URL, UIDocumentPickerMode inMode) : base("", null) { }                /// <summary>        /// Adds a custom menu item to the list of document pickers.        /// </summary>        /// <param name="title">The custom menu item’s title.</param>        /// <param name="image">The custom menu item’s image.</param>        /// <param name="order">The position of this menu item. See UIDocumentMenuOrder for possible values.</param>        /// <param name="handler">A block that is called when the user selects this custom menu item.</param>        [iOSVersion(8)]        [Export("addOptionWithTitle")]        public void AddOptionWithTitle(string title, UIImage image, UIDocumentMenuOrder order, Action handler) { }                /// <summary>        /// The document menu’s delegate.        /// </summary>        [iOSVersion(8)]        [Export("delegate")]        public UIDocumentMenuDelegate Delegate { get; set; }    }

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
    }}