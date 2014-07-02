using ObjectiveC;using System;using SwiftSharp.Attributes;

namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAlertController_class/index.html#//apple_ref/occ/cl/UIAlertController    /// <summary>    /// A UIAlertController object displays an alert message to the user. This class replaces the UIActionSheet and UIAlertView classes for displaying alerts. After configuring the alert controller with the actions and style you want, present it using the presentViewController:animated:completion: method.    /// </summary>    [iOSVersion(8)]    public class UIAlertController : UIViewController    {        /// <summary>        /// Creates and returns a view controller for displaying an alert to the user.        /// </summary>        /// <param name="title">The title of the alert. Use this string to get the user’s attention and communicate the reason for the alert.</param>        /// <param name="message">Descriptive text that provides additional details about the reason for the alert.</param>        /// <param name="preferredStyle">The style to use when presenting the alert controller. Use this parameter to configure the alert controller as an action sheet or as a modal alert.</param>        /// <returns>An initialized alert controller object.</returns>        [iOSVersion(8)]        public UIAlertController(string title, string message, UIAlertControllerStyle preferredStyle) : base("", null) { }                /// <summary>        /// The title of the alert.        /// </summary>        [iOSVersion(8)]        [Export("title")]        public string Title { get; set; }                /// <summary>        /// Descriptive text that provides more details about the reason for the alert.        /// </summary>        [iOSVersion(8)]        [Export("message")]        public string Message { get; set; }                /// <summary>        /// The style of the alert controller. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("preferredStyle")]        public UIAlertControllerStyle PreferredStyle { get; private set; }                /// <summary>        /// Attaches an action object to the alert or action sheet.        /// </summary>        /// <param name="action">The action object to display as part of the alert. Actions are displayed as buttons in the alert. The action object provides the button text and the action to be performed when that button is tapped.</param>        [iOSVersion(8)]        [Export("addAction")]        public void AddAction(UIAlertAction action) { }                /// <summary>        /// The actions that the user can take in response to the alert or action sheet. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("actions")]        public AnyObject[] Actions { get; private set; }                /// <summary>        /// Adds a text field to an alert.        /// </summary>        /// <param name="configurationHandler">A block for configuring the text field prior to displaying the alert. This block has no return value and takes a single parameter corresponding to the text field object. Use that parameter to change the text field properties.</param>        [iOSVersion(8)]        [Export("addTextFieldWithConfigurationHandler")]        public void AddTextFieldWithConfigurationHandler(Action<UITextField> configurationHandler) { }                /// <summary>        /// The array of text fields displayed by the alert. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("textFields")]        public AnyObject[] TextFields { get; private set; }    }

    /// <summary>
    /// Constants indicating the type of alert to display.
    /// </summary>
    public enum UIAlertControllerStyle
    {
        /// <summary>
        /// An action sheet displayed in the context of the view controller that presented it.
        /// </summary>
        [iOSVersion(8)]
        ActionSheet,

        /// <summary>
        /// An alert displayed modally for the app.
        /// </summary>
        [iOSVersion(8)]
        Alert,
    }}