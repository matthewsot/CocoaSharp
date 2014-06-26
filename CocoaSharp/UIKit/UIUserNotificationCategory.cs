using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIUserNotificationCategory_class/index.html#//apple_ref/occ/cl/UIUserNotificationCategory    /// <summary>    /// A UIUserNotificationCategory object encapsulates information about custom actions that your app can perform in response to a local or push notification. Each instance of this class represents a group of actions to display in conjunction with a single notification. The title of each action is uses as the title of a button in the alert displayed to the user. When the user taps a button, the system reports the selected action to your app delegate.    /// </summary>    [iOSVersion(8)]    public class UIUserNotificationCategory : NSObject    {        /// <summary>        /// The name of the action group. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("identifier")]        public string Identifier { get; private set; }                /// <summary>        /// Returns the actions to be displayed for the given notification context.        /// </summary>        /// <param name="context">The context in which the notification is displayed. Notifications can have a default context or a minimal context depending on whether the notification was just delivered or the user is looking at it in more detail.</param>        /// <returns>An array of UIUserNotificationAction objects to be displayed in the specified context. The order of the objects in the array represents the order that they are displayed in the resulting notification.</returns>        [iOSVersion(8)]        [Export("actionsForContext")]        public AnyObject[] ActionsForContext(UIUserNotificationActionContext context) { return null; }    }

    /// <summary>
    /// Constants indicating the amount of space available for displaying actions in a notification.
    /// </summary>
    public enum UIUserNotificationActionContext
    {
        /// <summary>
        /// The default context for displaying the alert. In this context, the full UI is displayed for the notification’s alert. You may specify up to four custom actions in this context.
        /// </summary>
        [iOSVersion(8)]
        Default,

        /// <summary>
        /// A notification where space is minimal. In this context, a minimal UI is displayed for the notification’s alert. You may specify up to two custom actions in this context.
        /// </summary>
        [iOSVersion(8)]
        Minimal,
    }}