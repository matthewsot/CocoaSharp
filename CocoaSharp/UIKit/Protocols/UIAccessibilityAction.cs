using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAccessibilityAction_Protocol/index.html#//apple_ref/doc/uid/TP40009678    /// <summary>    /// The UIAccessibilityAction informal protocol provides a way for accessibility elements to support specific actions, such as selecting values in a range or scrolling through information on the screen. For example, to respond to a scrolling gesture, you implement the accessibilityScroll: method and post UIAccessibilityPageScrolledNotification with the new page status (such as “Page 3 of 9”). Or, to make an element such as a slider or picker view accessible, you first need to characterize it by including the UIAccessibilityTraitAdjustable trait. Then, you must implement the accessibilityIncrement and accessibilityDecrement methods. When you do this, assistive technology users can adjust the element using gestures specific to the assistive technology.    /// </summary>    [iOSVersion(4)]    public interface UIAccessibilityAction    {    }

    /// <summary>
    /// The direction of a scrolling action.
    /// </summary>
    public enum UIAccessibilityScrollDirection
    {
        /// <summary>
        /// The user is scrolling to the right.
        /// </summary>
        [iOSVersion(4.2)]
        Right,

        /// <summary>
        /// The user is scrolling to the left.
        /// </summary>
        [iOSVersion(4.2)]
        Left,

        /// <summary>
        /// The user is scrolling up.
        /// </summary>
        [iOSVersion(4.2)]
        Up,

        /// <summary>
        /// The user is scrolling down.
        /// </summary>
        [iOSVersion(4.2)]
        Down,

        /// <summary>
        /// The user is scrolling to the next view in an ordered set of views.
        /// </summary>
        [iOSVersion(5)]
        Next,

        /// <summary>
        /// The user is scrolling to the previous view in an ordered set of views.
        /// </summary>
        [iOSVersion(5)]
        Previous,
    }}