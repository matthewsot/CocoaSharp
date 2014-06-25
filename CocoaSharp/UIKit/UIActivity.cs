using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIActivity_Class/index.html#//apple_ref/occ/cl/UIActivity    /// <summary>    /// The UIActivity class is an abstract class that you subclass in order to implement application-specific services. A service takes data that is passed to it, does something to that data, and returns the results. For example, an social media service might take whatever text, images, or other content is provided to it and post them to the user’s account. Activity objects are used in conjunction with a UIActivityViewController object, which is responsible for presenting services to the user.    /// </summary>    [iOSVersion(6)]    public class UIActivity : NSObject    {        /// <summary>        /// Returns the category of the activity, which may be used to group activities in the UI.        /// </summary>        /// <returns>The assigned category of the activity. The default implementation returns UIActivityCategoryAction.</returns>        [iOSVersion(7)]        [Export("activityCategory")]
        public static UIActivityCategory ActivityCategory() { return UIActivityCategory.Action; }                /// <summary>        /// An identifier for the type of service being provided.        /// </summary>        /// <returns>A string that identifies the provided service to your app.</returns>        [iOSVersion(6)]        [Export("activityType")]        public string ActivityType() { return ""; }                /// <summary>        /// A user-readable string describing the service.        /// </summary>        /// <returns>A string that describes the service.</returns>        [iOSVersion(6)]        [Export("activityTitle")]        public string ActivityTitle() { return ""; }                /// <summary>        /// An image that identifies the service to the user.        /// </summary>        /// <returns>An image that can be presented to the user.</returns>        [iOSVersion(6)]        [Export("activityImage")]        public UIImage ActivityImage() { return null; }                /// <summary>        /// Returns a Boolean indicating whether the service can act on the specified data items.        /// </summary>        /// <param name="activityItems">An array of objects of varying types. These are the data objects on which the service would act.</param>        /// <returns>true if your service can act on the specified data items or false if it cannot.</returns>        [iOSVersion(6)]        [Export("canPerformWithActivityItems")]        public bool CanPerformWithActivityItems(AnyObject[] activityItems) { return false; }                /// <summary>        /// Prepares your service to act on the specified data.        /// </summary>        /// <param name="activityItems">An array of objects of varying types. These are the data objects on which to act.</param>        [iOSVersion(6)]        [Export("prepareWithActivityItems")]        public void PrepareWithActivityItems(AnyObject[] activityItems) { }                /// <summary>        /// Returns the view controller to present to the user.        /// </summary>        /// <returns>The view controller to present to the user. The default implementation returns nil.</returns>        [iOSVersion(6)]        [Export("activityViewController")]        public UIViewController ActivityViewController() { return null; }                /// <summary>        /// Performs the service when no custom view controller is provided.        /// </summary>        [iOSVersion(6)]        [Export("performActivity")]        public void PerformActivity() { }                /// <summary>        /// Notifies the system that your activity object has completed its work.        /// </summary>        /// <param name="completed">Specify true if the service executed to completion or false if the service was canceled or did not finish because of an error.</param>        [iOSVersion(6)]        [Export("activityDidFinish")]        public void ActivityDidFinish(bool completed) { }                /// <summary>        /// Activity types for which the system has built-in support.        /// </summary>                /// <summary>        /// The object posts the provided content to the user’s wall on Facebook.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypePostToFacebook { get; private set; }                /// <summary>        /// The object posts the provided content to the user’s Twitter feed.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypePostToTwitter { get; private set; }                /// <summary>        /// The object posts the provided content to the user’s Weibo feed.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypePostToWeibo { get; private set; }                /// <summary>        /// The object posts the provided content to the Messages app.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypeMessage { get; private set; }                /// <summary>        /// The object posts the provided content to a new email message.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypeMail { get; private set; }                /// <summary>        /// The object prints the provided content.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypePrint { get; private set; }                /// <summary>        /// The object posts the provided content to the pasteboard.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypeCopyToPasteboard { get; private set; }                /// <summary>        /// The object assigns the image to a contact.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypeAssignToContact { get; private set; }                /// <summary>        /// The object assigns the image or video to the user’s camera roll.        /// </summary>        [iOSVersion(6)]        public string UIActivityTypeSaveToCameraRoll { get; private set; }                /// <summary>        /// The object adds the URL to Safari’s reading list.        /// </summary>        [iOSVersion(7)]        public string UIActivityTypeAddToReadingList { get; private set; }                /// <summary>        /// The object posts the provided image to the user’s Flickr account.        /// </summary>        [iOSVersion(7)]        public string UIActivityTypePostToFlickr { get; private set; }                /// <summary>        /// The object posts the provided video to the user’s Vimeo account.        /// </summary>        [iOSVersion(7)]        public string UIActivityTypePostToVimeo { get; private set; }                /// <summary>        /// The object posts the provided content to the user’s Tencent Weibo feed.        /// </summary>        [iOSVersion(7)]        public string UIActivityTypePostToTencentWeibo { get; private set; }                /// <summary>        /// The object makes the provided content available via AirDrop.        /// </summary>        [iOSVersion(7)]        public string UIActivityTypeAirDrop { get; private set; }                /// <summary>        /// Activities have a defined category, and the activity UI may show activities grouped by category.        /// </summary>        public enum UIActivityCategory        {            /// <summary>            /// Activities whose primary purpose is to take an action on the selected item. For example, copying an image, or saving it to the camera roll.            /// </summary>            [iOSVersion(7)]            Action,                        /// <summary>            /// Activities whose primary purpose is to share the selected item. For example, sending an image by email.            /// </summary>            [iOSVersion(7)]            Share,        }    }}