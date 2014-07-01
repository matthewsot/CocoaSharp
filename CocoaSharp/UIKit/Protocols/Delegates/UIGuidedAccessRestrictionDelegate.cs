using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIGuidedAccessRestrictionsDelegate_Protocol/index.html#//apple_ref/occ/intf/UIGuidedAccessRestrictionDelegate    /// <summary>    /// Adopting the UIGuidedAccessRestrictionDelegate protocol in your application delegate allows you to add custom restrictions for the Guided Access feature in iOS.    /// </summary>    [iOSVersion(7)]    public interface UIGuidedAccessRestrictionDelegate    {        /// <summary>        /// Returns an array of strings identifying custom restrictions. (required)        /// </summary>        /// <returns>An array of NSString objects, each of which represents a custom restriction.</returns>        [iOSVersion(7)]        [Export("guidedAccessRestrictionIdentifiers")]        AnyObject[] GuidedAccessRestrictionIdentifiers();                /// <summary>        /// Returns a succinct description of the restriction for the provided identifier. (required)        /// </summary>        /// <param name="restrictionIdentifier">The identifer of the restriction the system is interested in.</param>        /// <returns>A localized, human-readable string that succinctly describes the restriction for the provided identifier.</returns>        [iOSVersion(7)]        [Export("textForGuidedAccessRestrictionWithIdentifier")]        string TextForGuidedAccessRestrictionWithIdentifier(string restrictionIdentifier);                /// <summary>        /// Returns more detailed information about the restriction for the provided identifier.        /// </summary>        /// <param name="restrictionIdentifier">The identifer of the restriction the system is interested in.</param>        /// <returns>A localized, human-readable string that provides additional information about the restriction for the provided identifier.</returns>        [iOSVersion(7)]        [Export("detailTextForGuidedAccessRestrictionWithIdentifier")]        [Optional]        string DetailTextForGuidedAccessRestrictionWithIdentifier(string restrictionIdentifier);                /// <summary>        /// Para (required)        /// </summary>        /// <param name="restrictionIdentifier">The identifer of the restriction whose state has changed.</param>        /// <param name="didChangeState">The new state for the restriction.</param>        [iOSVersion(7)]        [Export("guidedAccessRestrictionWithIdentifier")]        void GuidedAccessRestrictionWithIdentifier(string restrictionIdentifier, UIGuidedAccessRestrictionState didChangeState);    }

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
    }}