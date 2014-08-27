using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIMutableUserNotificationCategory object encapsulates information about custom actions that your app can perform in response to a local or push notification. Use instances of this class to customize the actions included in an alert when space onscreen is constrained.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMutableUserNotificationCategory_class/index.html#//apple_ref/occ/cl/UIMutableUserNotificationCategory"/>    [iOSVersion(8)]    public class UIMutableUserNotificationCategory : UIUserNotificationCategory//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding    {        /// <summary>        /// Sets the actions to display for different alert styles.        /// </summary>        /// <param name="actions">An array of UIUserNotificationAction objects representing the actions to display for the given context. When displaying the notification to the user, the system displays the action buttons using the same order as the items in this array. If you specify nil or an empty array, this method removes the actions for the specified context.</param>        /// <param name="forContext">The context in which the alert is displayed. For a list of possible values, see UIUserNotificationActionContext.</param>        [iOSVersion(8)]        [Export("setActions")]        public void SetActions(AnyObject[] actions, UIUserNotificationActionContext forContext) {  }                /// <summary>        /// The name of the action group.        /// </summary>        [iOSVersion(8)]        [Export("identifier")]        public string Identifier { get; set; }    }}