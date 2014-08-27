using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A push behavior applies a continuous or instantaneous force to one or more dynamic items, causing those items to change position accordingly.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPushBehavior_Class/index.html#//apple_ref/occ/cl/UIPushBehavior"/>    [iOSVersion(7)]    public class UIPushBehavior : UIDynamicBehavior//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Adds a dynamic item to the behavior’s dynamic item array.        /// </summary>        /// <param name="item">The dynamic item to add to the item array.</param>        [iOSVersion(7)]        [Export("addItem")]        public void AddItem(UIDynamicItem item) {  }                /// <summary>        /// Initializes a push behavior with an array of dynamic items.        /// </summary>        /// <param name="items">The dynamic items that you want to be subject to the push behavior.</param>        /// <param name="mode">The mode for the new push behavior; one of the values defined in the UIPushBehaviorMode enumeration. You must supply a value.</param>        [iOSVersion(7)]        public UIPushBehavior(AnyObject[] items, UIPushBehaviorMode mode) { }                /// <summary>        /// Removes a specific dynamic item from the behavior.        /// </summary>        /// <param name="item">The dynamic item that you want to remove.</param>        [iOSVersion(7)]        [Export("removeItem")]        public void RemoveItem(UIDynamicItem item) {  }                /// <summary>        /// Sets the angle and magnitude of the force vector for the behavior.        /// </summary>        /// <param name="angle">The angle, in radians, of the force vector for the push behavior.        ///   The default angle is 0 radians, using standard UIKit geometry.</param>        /// <param name="magnitude">The magnitude of the force vector for the push behavior.         ///   The default magnitude is nil, equivalent to no force. A force vector with a magnitude of 1.0, applied to a 100 point x 100 point view whose density value is 1.0, results in view acceleration of 100 points / second².        ///     Setting the magnitude parameter to a negative value reverses the direction of the force.</param>        [iOSVersion(7)]        [Export("setAngle")]        public void SetAngle(CGFloat angle, CGFloat magnitude) {  }                /// <summary>        /// Sets the offset, from the center of a dynamic item, at which to apply the push behavior’s force vector.        /// </summary>        /// <param name="o">The offset, from the center of the dynamic item, at which to apply the push behavior’s force vector.</param>        /// <param name="forItem">The dynamic item for which you’re setting a target offset.</param>        [iOSVersion(7)]        [Export("setTargetOffsetFromCenter")]        public void SetTargetOffsetFromCenter(UIOffset o, UIDynamicItem forItem) {  }                /// <summary>        /// Returns the offset, from the center of a dynamic item, at which the push behavior’s force vector is applied.        /// </summary>        /// <param name="item">The dynamic item for which you’re retrieving the target offset.</param>        [iOSVersion(7)]        [Export("targetOffsetFromCenterForItem")]        public UIOffset TargetOffsetFromCenterForItem(UIDynamicItem item) { return default(UIOffset); }                /// <summary>        /// The state of the push behavior’s force: either active or inactive.        /// </summary>        [iOSVersion(7)]        [Export("active")]        public bool Active { get; set; }                /// <summary>        /// Returns the set of dynamic items you’ve added to the push behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("items")]        public AnyObject[] Items { get; private set; }                /// <summary>        /// The angle, in radians, of the force vector for the behavior.        /// </summary>        [iOSVersion(7)]        [Export("angle")]        public CGFloat Angle { get; set; }                /// <summary>        /// The magnitude of the force vector for the push behavior.        /// </summary>        [iOSVersion(7)]        [Export("magnitude")]        public CGFloat Magnitude { get; set; }                /// <summary>        /// Returns the force mode for the push behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("mode")]        public UIPushBehaviorMode Mode { get; private set; }                /// <summary>        /// The direction of the force vector for the behavior, expressed as x and y components and using standard UIKit geometry.        /// </summary>        [iOSVersion(7)]        [Export("pushDirection")]        public CGVector PushDirection { get; set; }    }    /// <summary>    /// The type of force for the push behavior.    /// </summary>    [iOSVersion(7)]    public enum UIPushBehaviorMode    {        /// <summary>        /// Option for continuous force.        /// </summary>        [iOSVersion(7)]        Continuous,        /// <summary>        /// Option for instantaneous force.        /// </summary>        [iOSVersion(7)]        Instantaneous,    }}