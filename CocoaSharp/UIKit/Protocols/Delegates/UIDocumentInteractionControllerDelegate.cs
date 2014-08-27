using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIDocumentInteractionControllerDelegate protocol includes methods you can implement to respond to messages from a document interaction controller. Use this protocol to participate when document previews are displayed and when a document is about to be opened by another application. You can also use this protocol to respond to commands (such as “copy” and “print”) from a document interaction controller’s options menu.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocumentInteractionControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UIDocumentInteractionControllerDelegate"/>    [iOSVersion(3.2)]    public interface UIDocumentInteractionControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Called when a document interaction controller needs a view controller for presenting a document preview.        /// </summary>        /// <param name="controller">The document interaction controller requesting the parent view controller.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerViewControllerForPreview")]        UIViewController DocumentInteractionControllerViewControllerForPreview(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller needs the starting point for animating the display of a document preview.        /// </summary>        /// <param name="controller">The document interaction controller requesting the starting view.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerViewForPreview")]        UIView DocumentInteractionControllerViewForPreview(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller needs the rectangle to use as the starting point for animating the display of a document preview.        /// </summary>        /// <param name="controller">The document interaction controller requesting the starting rectangle.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerRectForPreview")]        CGRect DocumentInteractionControllerRectForPreview(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller is about to display a preview for its document.        /// </summary>        /// <param name="controller">The document interaction controller that is about to preview its document.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerWillBeginPreview")]        void DocumentInteractionControllerWillBeginPreview(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller has dismissed its document preview.        /// </summary>        /// <param name="controller">The document interaction controller that dismissed its document preview.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerDidEndPreview")]        void DocumentInteractionControllerDidEndPreview(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller is about to display an options menu.        /// </summary>        /// <param name="controller">The document interaction controller that is about to display an options menu.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerWillPresentOptionsMenu")]        void DocumentInteractionControllerWillPresentOptionsMenu(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller has dismissed its options menu.        /// </summary>        /// <param name="controller">The document interaction controller that dismissed its options menu.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerDidDismissOptionsMenu")]        void DocumentInteractionControllerDidDismissOptionsMenu(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller is about to display an Open In menu.        /// </summary>        /// <param name="controller">The document interaction controller that is about to display a menu.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerWillPresentOpenInMenu")]        void DocumentInteractionControllerWillPresentOpenInMenu(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller has dismissed its Open In menu.        /// </summary>        /// <param name="controller">The document interaction controller that dismissed its menu.</param>        [iOSVersion(3.2)]        [Export("documentInteractionControllerDidDismissOpenInMenu")]        void DocumentInteractionControllerDidDismissOpenInMenu(UIDocumentInteractionController controller);                /// <summary>        /// Called when a document interaction controller’s document is about to be opened by the specified application.        /// </summary>        /// <param name="controller">The document interaction controller whose document is about to be opened.</param>        /// <param name="willBeginSendingToApplication">The bundle identifier of the application that is about to open the document. This value corresponds to the value in the CFBundleIdentifier key of the application’s Info.plist file.</param>        [iOSVersion(3.2)]        [Export("documentInteractionController")]        void DocumentInteractionController(UIDocumentInteractionController controller, string willBeginSendingToApplication);                /// <summary>        /// Called when a document interaction controller’s document has been handed off to the specified application.        /// </summary>        /// <param name="controller">The document interaction controller whose document is about to be opened.</param>        /// <param name="didEndSendingToApplication">The bundle identifier of the application that is about to open the document. This value corresponds to the value in the CFBundleIdentifier key of the application’s Info.plist file.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(3.2)]        [Export("documentInteractionController")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void DocumentInteractionController(UIDocumentInteractionController controller, string didEndSendingToApplication, bool NAME_YOUR_PARAMS = false);    }}