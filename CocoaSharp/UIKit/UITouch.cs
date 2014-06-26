using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITouch_Class/index.html#//apple_ref/occ/cl/UITouch    /// <summary>    /// A UITouch object represents the presence or movement of a finger on the screen for a particular event. You access UITouch objects through UIEvent objects passed into responder objects for event handling.    /// </summary>    [iOSVersion(2)]    public class UITouch : NSObject    {        /// <summary>        /// Returns the current location of the receiver in the coordinate system of the given view.        /// </summary>        /// <param name="view">The view object in whose coordinate system you want the touch located. A custom view that is handling the touch may specify self to get the touch location in its own coordinate system. Pass nil to get the touch location in the window’s coordinates.</param>        /// <returns>A point specifying the location of the receiver in view.</returns>        [iOSVersion(2)]        [Export("locationInView")]        public CGPoint LocationInView(UIView view) { return new CGPoint(); }                /// <summary>        /// Returns the previous location of the receiver in the coordinate system of the given view.        /// </summary>        /// <param name="view">The view object in whose coordinate system you want the touch located. A custom view that is handling the touch may specify self to get the touch location in its own coordinate system. Pass nil to get the touch location in the window’s coordinates.</param>        /// <returns>This method returns the previous location of a UITouch object in the coordinate system of the specified view. Because the touch object might have been forwarded to a view from another view, this method performs any necessary conversion of the touch location to the coordinate system of the specified view.</returns>        [iOSVersion(2)]        [Export("previousLocationInView")]
        public CGPoint PreviousLocationInView(UIView view) { return new CGPoint(); }                /// <summary>        /// The view in which the touch initially occurred. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("view")]        public UIView View { get; private set; }                /// <summary>        /// The window in which the touch initially occurred. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("window")]        public UIWindow Window { get; private set; }                /// <summary>        /// The radius (in points) of the touch. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("majorRadius")]        public CGFloat MajorRadius { get; private set; }                /// <summary>        /// The tolerance (in points) of the touch’s radius. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("majorRadiusTolerance")]        public CGFloat MajorRadiusTolerance { get; private set; }                /// <summary>        /// The number of times the finger was tapped for this given touch. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("tapCount")]        public int TapCount { get; private set; }                /// <summary>        /// The time when the touch occurred or when it was last mutated. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("timestamp")]        public NSTimeinterval Timestamp { get; private set; }                /// <summary>        /// The type of touch. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("phase")]        public UITouchPhase Phase { get; private set; }                /// <summary>        /// The gesture recognizers that are receiving the touch object. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("gestureRecognizers")]        public AnyObject[] GestureRecognizers { get; private set; }    }

    /// <summary>
    /// The phase of a finger touch.
    /// </summary>
    public enum UITouchPhase
    {
        /// <summary>
        /// A finger for a given event touched the screen.
        /// </summary>
        [iOSVersion(2)]
        Began,

        /// <summary>
        /// A finger for a given event moved on the screen.
        /// </summary>
        [iOSVersion(2)]
        Moved,

        /// <summary>
        /// A finger is touching the surface but hasn't moved since the previous event.
        /// </summary>
        [iOSVersion(2)]
        Stationary,

        /// <summary>
        /// A finger for a given event was lifted from the screen.
        /// </summary>
        [iOSVersion(2)]
        Ended,

        /// <summary>
        /// The system cancelled tracking for the touch, as when (for example) the user puts the device to his or her face.
        /// </summary>
        [iOSVersion(2)]
        Cancelled,
    }}