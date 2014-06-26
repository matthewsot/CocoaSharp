using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISwipeGestureRecognizer_Class/index.html#//apple_ref/occ/cl/UISwipeGestureRecognizer    /// <summary>    /// UISwipeGestureRecognizer is a concrete subclass of UIGestureRecognizer that looks for swiping gestures in one or more directions. A swipe is a discrete gesture, and thus the associated action message is sent only once per gesture.    /// </summary>    [iOSVersion(3.2)]    public class UISwipeGestureRecognizer : UIGestureRecognizer    {        /// <summary>        /// The permitted direction of the swipe for this gesture recognizer.        /// </summary>        [iOSVersion(3.2)]        [Export("direction")]        public UISwipeGestureRecognizerDirection Direction { get; set; }                /// <summary>        /// The number of touches that must be present for the swipe gesture to be recognized.        /// </summary>        [iOSVersion(3.2)]        [Export("numberOfTouchesRequired")]        public int NumberOfTouchesRequired { get; set; }    }

    /// <summary>
    /// The direction of the swipe.
    /// </summary>
    public enum UISwipeGestureRecognizerDirection
    {
        /// <summary>
        /// The touch or touches swipe to the right. This direction is the default.
        /// </summary>
        [iOSVersion(3.2)]
        Right,

        /// <summary>
        /// The touch or touches swipe to the left.
        /// </summary>
        [iOSVersion(3.2)]
        Left,

        /// <summary>
        /// The touch or touches swipe upward.
        /// </summary>
        [iOSVersion(3.2)]
        Up,

        /// <summary>
        /// The touch or touches swipe downward.
        /// </summary>
        [iOSVersion(3.2)]
        Down,
    }}