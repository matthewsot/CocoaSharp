using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIUserNotificationSettings_class/index.html#//apple_ref/occ/cl/UIUserNotificationSettings    /// <summary>    /// A UIUserNotificationSettings object encapsulates the types of notifications that can be displayed to the user by your app. Apps that use visible or audible alerts in conjunction with a local or push notification must register the types of alerts they employ. UIKit correlates the information you provide with the user’s preferences to determine what types of alerts your app is allowed to employ.    /// </summary>    [iOSVersion(8)]    public class UIUserNotificationSettings : NSObject    {        /// <summary>        /// Creates and returns a settings object that you can use to register your requested notification and action types.        /// </summary>        /// <param name="forTypes">The notification types that your app supports. For a list of possible values, see the constants for the UIUserNotificationType type.</param>        /// <param name="categories">A set of UIUserNotificationCategory objects that define the groups of actions a notification may include.</param>        /// <returns>A new user notification settings object that you can register with the UIApplication object.</returns>        [iOSVersion(8)]        public UIUserNotificationSettings(UIUserNotificationType forTypes, NSSet categories) { }                /// <summary>        /// A bitmask of the notification types that your app is allowed to use. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("types")]        public UIUserNotificationType Types { get; private set; }                /// <summary>        /// The app’s registered groups of actions. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("categories")]        public NSSet Categories { get; private set; }    }

    /// <summary>
    /// Constants indicating how the app alerts the user when a local or push notification arrives.
    /// </summary>
    public enum UIUserNotificationType
    {
        /// <summary>
        /// The app does not present any UI upon receiving a notification.
        /// </summary>
        [iOSVersion(8)]
        None,

        /// <summary>
        /// The app badges its icon.
        /// </summary>
        [iOSVersion(8)]
        Badge,

        /// <summary>
        /// The app plays a sound.
        /// </summary>
        [iOSVersion(8)]
        Sound,

        /// <summary>
        /// The app posts an alert.
        /// </summary>
        [iOSVersion(8)]
        Alert,
    }}