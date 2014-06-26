using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIActivityIndicatorView_Class/index.html#//apple_ref/occ/cl/UIActivityIndicatorView    /// <summary>    /// Use an activity indicator to show that a task is in progress. An activity indicator appears as a “gear” that is either spinning or stopped.    /// </summary>    [iOSVersion(2)]    public class UIActivityIndicatorView : UIView    {        /// <summary>        /// Initializes and returns an activity-indicator object.        /// </summary>        /// <param name="activityIndicatorStyle">A constant that specifies the style of the object to be created. See UIActivityIndicatorStyle for descriptions of the style constants.</param>        /// <returns>An initialized UIActivityIndicatorView object or nil if the object couldn’t be created.</returns>        [iOSVersion(2)]        public UIActivityIndicatorView(UIActivityIndicatorViewStyle activityIndicatorStyle) { }                /// <summary>        /// Starts the animation of the progress indicator.        /// </summary>        [iOSVersion(2)]        [Export("startAnimating")]        public void StartAnimating() { }                /// <summary>        /// Stops the animation of the progress indicator.        /// </summary>        [iOSVersion(2)]        [Export("stopAnimating")]        public void StopAnimating() { }                /// <summary>        /// Returns whether the receiver is animating.        /// </summary>        /// <returns>true if the receiver is animating, otherwise false.</returns>        [iOSVersion(2)]        [Export("isAnimating")]        public bool IsAnimating() { return false; }                /// <summary>        /// A Boolean value that controls whether the receiver is hidden when the animation is stopped.        /// </summary>        [iOSVersion(2)]        [Export("hidesWhenStopped")]        public bool HidesWhenStopped { get; set; }                /// <summary>        /// The basic appearance of the activity indicator.        /// </summary>        [iOSVersion(2)]        [Export("activityIndicatorViewStyle")]        public UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }                /// <summary>        /// The color of the activity indicator.        /// </summary>        [iOSVersion(5)]        [Export("color")]        public UIColor Color { get; set; }    }

    /// <summary>
    /// The visual style of the progress indicator.
    /// </summary>
    public enum UIActivityIndicatorViewStyle
    {
        /// <summary>
        /// The large white style of indicator.
        /// </summary>
        [iOSVersion(2)]
        WhiteLarge,

        /// <summary>
        /// The standard white style of indicator (the default).
        /// </summary>
        [iOSVersion(2)]
        White,

        /// <summary>
        /// The standard gray style of indicator.
        /// </summary>
        [iOSVersion(2)]
        Gray,
    }}