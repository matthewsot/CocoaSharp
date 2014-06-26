using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAlertAction_Class/index.html#//apple_ref/occ/cl/UIAlertAction    /// <summary>    /// A UIAlertAction object represents an action that can be taken when tapping a button in an alert. You use this class to configure information about a single action, including the title to display in the button, any styling information, and a handler to execute when the user taps the button. After creating an alert action object, add it to a UIAlertController object before displaying the corresponding alert to the user.    /// </summary>    [iOSVersion(8)]    public class UIAlertAction : NSObject    {        /// <summary>        /// Create and return an action with the specified title and behavior.        /// </summary>        /// <param name="title">The text to use for the button title. The value you specify should be localized for the user’s current language. This parameter must not be nil.</param>        /// <param name="style">Additional styling information to apply to the button. Use the style information to convey the type of action that is performed by the button. For a list of possible values, see the constants in UIAlertActionStyle.</param>        /// <param name="handler">A block to execute when the user selects the action. This block has no return value and takes the selected action object as its only parameter.</param>        /// <returns>A new alert action object.</returns>        [iOSVersion(8)]        public UIAlertAction(string title, UIAlertActionStyle style, Action<UIAlertAction> handler) { }                /// <summary>        /// The title of the action’s button. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("title")]        public string Title { get; private set; }                /// <summary>        /// The style that is applied to the action’s button. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("style")]        public UIAlertActionStyle Style { get; private set; }                /// <summary>        /// A Boolean value indicating whether the action is currently enabled.        /// </summary>        [iOSVersion(8)]        [Export("enabled")]        public bool Enabled { get; set; }    }

    /// <summary>
    /// Styles to apply to action buttons in an alert.
    /// </summary>
    public enum UIAlertActionStyle
    {
        /// <summary>
        /// Apply the default style to the action’s button.
        /// </summary>
        [iOSVersion(8)]
        Default,

        /// <summary>
        /// Apply a style that indicates the action cancels the operation and leaves things unchanged.
        /// </summary>
        [iOSVersion(8)]
        Cancel,

        /// <summary>
        /// Apply a style that indicates the action might change or delete data.
        /// </summary>
        [iOSVersion(8)]
        Destructive,
    }}