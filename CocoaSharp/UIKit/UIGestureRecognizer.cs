using CoreGraphics;
using ObjectiveC;

    /// <summary>
    /// The current state a gesture recognizer is in.
    /// </summary>
    public enum UIGestureRecognizerState
    {
        /// <summary>
        /// The gesture recognizer has not yet recognized its gesture, but may be evaluating touch events. This is the default state.
        /// </summary>
        [iOSVersion(3.2)]
        Possible,

        /// <summary>
        /// The gesture recognizer has received touch objects recognized as a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop.
        /// </summary>
        [iOSVersion(3.2)]
        Began,

        /// <summary>
        /// The gesture recognizer has received touches recognized as a change to a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop.
        /// </summary>
        [iOSVersion(3.2)]
        Changed,

        /// <summary>
        /// The gesture recognizer has received touches recognized as the end of a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop and resets its state to UIGestureRecognizerStatePossible.
        /// </summary>
        [iOSVersion(3.2)]
        Ended,

        /// <summary>
        /// The gesture recognizer has received touches resulting in the cancellation of a continuous gesture. It sends its action message (or messages) at the next cycle of the run loop and resets its state to UIGestureRecognizerStatePossible.
        /// </summary>
        [iOSVersion(3.2)]
        Cancelled,

        /// <summary>
        /// The gesture recognizer has received a multi-touch sequence that it cannot recognize as its gesture. No action message is sent and the gesture recognizer is reset to UIGestureRecognizerStatePossible.
        /// </summary>
        [iOSVersion(3.2)]
        Failed,
    }