using ObjectiveC;

    /// <summary>
    /// These constants indicate which modifier keys are pressed.
    /// </summary>
    public enum UIKeyModifierFlags
    {
        /// <summary>
        /// The Caps Lock key is currently engaged.
        /// </summary>
        [iOSVersion(7)]
        AlphaShift,

        /// <summary>
        /// The Shift key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Shift,

        /// <summary>
        /// The Control key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Control,

        /// <summary>
        /// The Option key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Alternate,

        /// <summary>
        /// The Command key is pressed.
        /// </summary>
        [iOSVersion(7)]
        Command,

        /// <summary>
        /// The key is located on the numeric keypad.
        /// </summary>
        [iOSVersion(7)]
        NumericPad,
    }