using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIEvent_Class/index.html#//apple_ref/occ/cl/UIEvent    /// <summary>    /// A UIEvent object (or, simply, an event object) represents an event in iOS. There are three general types of event: touch events, motion events, and remote-control events. Remote-control events allow a responder object to receive commands from an external accessory or headset so that it can manage manage audio and video—for example, playing a video or skipping to the next audio track. Motion events were introduced in iOS 3.0 and remote-control events in iOS 4.0.    /// </summary>    [iOSVersion(2)]    public class UIEvent : NSObject    {        /// <summary>        /// Returns all touch objects associated with the receiver.        /// </summary>        /// <returns>A set of UITouch objects representing all touches associated with an event (represented by the receiver).</returns>        [iOSVersion(2)]        [Export("allTouches")]        public NSSet AllTouches() { return null; }                /// <summary>        /// Returns the touch objects that belong to a given view for the event represented by the receiver.        /// </summary>        /// <param name="view">TheUIView object on which the touches related to the event were made.</param>        /// <returns>A set of UITouch objects representing the touches for the specified view related to the event represented by the receiver.</returns>        [iOSVersion(2)]        [Export("touchesForView")]        public NSSet TouchesForView(UIView view) { return null; }                /// <summary>        /// Returns the touch objects that belong to a given window for the event represented by the receiver.        /// </summary>        /// <param name="window">The UIWindow object on which the touches related to the event were made.</param>        /// <returns>A set of UITouch objects representing the touches for the specified window related to the event represented by the receiver.</returns>        [iOSVersion(2)]        [Export("touchesForWindow")]        public NSSet TouchesForWindow(UIWindow window) { return null; }                /// <summary>        /// The time when the event occurred. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("timestamp")]        public NSTimeinterval Timestamp { get; private set; }                /// <summary>        /// Returns the type of the event. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("type")]        public UIEventType Type { get; private set; }                /// <summary>        /// Returns the subtype of the event. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("subtype")]        public UIEventSubtype Subtype { get; private set; }                /// <summary>        /// Returns the touch objects that are being delivered to the specified gesture recognizer.        /// </summary>        /// <param name="gesture">An instance of a subclass of the abstract base class UIGestureRecognizer. This gesture-recognizer object must be attached to a view to receive the touches hit-tested to that view and its subviews.</param>        /// <returns>A set of UITouch objects representing the touches being delivered to the specified gesture recognizer for the event represented by the receiver.</returns>        [iOSVersion(3.2)]        [Export("touchesForGestureRecognizer")]        public NSSet TouchesForGestureRecognizer(UIGestureRecognizer gesture) { return null; }
    }

    /// <summary>
    /// Specifies the general type of an event
    /// </summary>
    public enum UIEventType
    {
        /// <summary>
        /// The event is related to touches on the screen.
        /// </summary>
        [iOSVersion(3)]
        Touches,

        /// <summary>
        /// The event is related to motion of the device, such as when the user shakes it.
        /// </summary>
        [iOSVersion(3)]
        Motion,

        /// <summary>
        /// The event is a remote-control event. Remote-control events originate as commands received from a headset or external accessory for the purposes of controlling multimedia on the device.
        /// </summary>
        [iOSVersion(4)]
        RemoteControl,
    }
    /// <summary>
    /// Specifies the subtype of the event in relation to its general type.
    /// </summary>
    public enum UIEventSubtype
    {
        /// <summary>
        /// The event has no subtype. This is the subtype for events of the UIEventTypeTouches general type.
        /// </summary>
        [iOSVersion(3)]
        None,

        /// <summary>
        /// The event is related to the user shaking the device. It is a subtype for the UIEventTypeMotion general event type.
        /// </summary>
        [iOSVersion(3)]
        MotionShake,

        /// <summary>
        /// A remote-control event for playing audio or video. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlPlay,

        /// <summary>
        /// A remote-control event for pausing audio or video. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlPause,

        /// <summary>
        /// A remote-control event for stopping audio or video from playing. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlStop,

        /// <summary>
        /// A remote-control event for toggling audio or video between play and pause. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlTogglePlayPause,

        /// <summary>
        /// A remote-control event for skipping to the next audio or video track. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlNextTrack,

        /// <summary>
        /// A remote-control event for skipping to the previous audio or video track. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlPreviousTrack,

        /// <summary>
        /// A remote-control event to start seeking backward through the audio or video medium. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlBeginSeekingBackward,

        /// <summary>
        /// A remote-control event to end seeking backward through the audio or video medium. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlEndSeekingBackward,

        /// <summary>
        /// A remote-control event to start seeking forward through the audio or video medium. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlBeginSeekingForward,

        /// <summary>
        /// A remote-control event to end seeking forward through the audio or video medium. It is a subtype of the UIEventTypeRemoteControl general event type.
        /// </summary>
        [iOSVersion(4)]
        RemoteControlEndSeekingForward,
    }}