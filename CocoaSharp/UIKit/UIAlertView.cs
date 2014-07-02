using CoreGraphics;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAlertView_Class/index.html#//apple_ref/occ/cl/UIAlertView    /// <summary>    /// Use the UIAlertView class to display an alert message to the user. An alert view functions similar to but differs in appearance from an action sheet (an instance of UIActionSheet).    /// </summary>    [iOSVersion(2)]    public class UIAlertView : UIView    {        /// <summary>        /// Convenience method for initializing an alert view.        /// </summary>        /// <param name="title">The string that appears in the receiver’s title bar.</param>        /// <param name="message">Descriptive text that provides more details than the title.</param>        /// <param name="delegate">The receiver’s delegate or nil if it doesn’t have a delegate.</param>        /// <param name="cancelButtonTitle">The title of the cancel button or nil if there is no cancel button.   Using this argument is equivalent to setting the cancel button index to the value returned by invoking addButtonWithTitle: specifying this title.</param>        /// <param name="otherButtonTitles,">The title of another button.   Using this argument is equivalent to invoking addButtonWithTitle: with this title to add more buttons.   Too many buttons can cause the alert view to scroll. For guidelines on the best ways to use an alert in an app, see Temporary Views.</param>        /// <param name="...">Titles of additional buttons to add to the receiver, terminated with nil.</param>        /// <returns>Newly initialized alert view.</returns>        [iOSVersion(2)]        public UIAlertView(string title, string message, AnyObject @delegate, string cancelButtonTitle) : base(new CGRect()) { }                /// <summary>        /// The receiver’s delegate or nil if it doesn’t have a delegate.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public AnyObject Delegate { get; set; }                /// <summary>        /// The kind of alert displayed to the user.        /// </summary>        [iOSVersion(5)]        [Export("alertViewStyle")]        public UIAlertViewStyle AlertViewStyle { get; set; }                /// <summary>        /// The string that appears in the receiver’s title bar.        /// </summary>        [iOSVersion(2)]        [Export("title")]        public string Title { get; set; }                /// <summary>        /// Descriptive text that provides more details than the title.        /// </summary>        [iOSVersion(2)]        [Export("message")]        public string Message { get; set; }                /// <summary>        /// A Boolean value that indicates whether the receiver is displayed. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("visible")]        public bool Visible { get; private set; }                /// <summary>        /// Adds a button to the receiver with the given title.        /// </summary>        /// <param name="title">The title of the new button.</param>        /// <returns>The index of the new button. Button indices start at 0 and increase in the order they are added.</returns>        [iOSVersion(2)]        [Export("addButtonWithTitle")]        public int AddButtonWithTitle(string title) { return 0; }                /// <summary>        /// The number of buttons on the alert view. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("numberOfButtons")]        public int NumberOfButtons { get; private set; }                /// <summary>        /// Returns the title of the button at the given index.        /// </summary>        /// <param name="buttonIndex">The index of the button. The button indices start at 0.</param>        /// <returns>The title of the button specified by index buttonIndex.</returns>        [iOSVersion(2)]        [Export("buttonTitleAtIndex")]        public string ButtonTitleAtIndex(int buttonIndex) { return ""; }                /// <summary>        /// Returns the text field at the given index        /// </summary>        /// <param name="textFieldIndex">The index of the text field. The text field indices start at 0.</param>        /// <returns>The text field specified by index textFieldIndex.</returns>        [iOSVersion(5)]        [Export("textFieldAtIndex")]        public UITextField TextFieldAtIndex(int textFieldIndex) { return null; }                /// <summary>        /// The index number of the cancel button.        /// </summary>        [iOSVersion(2)]        [Export("cancelButtonIndex")]        public int CancelButtonIndex { get; set; }                /// <summary>        /// The index of the first other button. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("firstOtherButtonIndex")]        public int FirstOtherButtonIndex { get; private set; }                /// <summary>        /// Displays the receiver using animation.        /// </summary>        [iOSVersion(2)]        [Export("show")]        public void Show() { }                /// <summary>        /// Dismisses the receiver, optionally with animation.        /// </summary>        /// <param name="buttonIndex">The index of the button that was clicked just before invoking this method. The button indices start at 0.</param>        /// <param name="animated">true if the receiver should be removed by animating it first; otherwise, false if it should be removed immediately with no animation.</param>        [iOSVersion(2)]        [Export("dismissWithClickedButtonIndex")]        public void DismissWithClickedButtonIndex(int buttonIndex, bool animated) { }    }

    /// <summary>
    /// The presentation style of the alert.
    /// </summary>
    public enum UIAlertViewStyle
    {
        /// <summary>
        /// A standard alert.
        /// </summary>
        [iOSVersion(5)]
        Default,

        /// <summary>
        /// An alert that allows the user to enter text. The text field is obscured.
        /// </summary>
        [iOSVersion(5)]
        SecureTextInput,

        /// <summary>
        /// An alert that allows the user to enter text.
        /// </summary>
        [iOSVersion(5)]
        PlainTextInput,

        /// <summary>
        /// An alert that allows the user to enter a login identifier and password.
        /// </summary>
        [iOSVersion(5)]
        LoginAndPasswordInput,
    }}