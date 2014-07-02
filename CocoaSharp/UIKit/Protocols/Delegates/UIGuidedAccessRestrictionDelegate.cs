using ObjectiveC;

    /// <summary>
    /// The state of a restriction, either allow or deny.
    /// </summary>
    public enum UIGuidedAccessRestrictionState
    {
        /// <summary>
        /// The app should allow the user to perform the action controlled by the restriction.
        /// </summary>
        [iOSVersion(7)]
        Allow,

        /// <summary>
        /// The app should deny the user from performing the action controlled by the restriction.
        /// </summary>
        [iOSVersion(7)]
        Deny,
    }