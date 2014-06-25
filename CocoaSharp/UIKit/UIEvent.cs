using ObjectiveC;
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
    }