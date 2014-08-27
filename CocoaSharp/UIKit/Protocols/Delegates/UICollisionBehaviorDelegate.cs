using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// To respond to UIKit dynamic item collisions, configure a custom class to adopt the UICollisionBehaviorDelegate protocol. Then, in a collision behavior (an instance of the UICollisionBehavior class), set the delegate to be an instance of your custom class.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollisionBehaviorDelegate_Protocol/index.html#//apple_ref/occ/intf/UICollisionBehaviorDelegate"/>    [iOSVersion(7)]    public interface UICollisionBehaviorDelegate//: NSObjectProtocol    {        /// <summary>        /// Called when a collision, between a dynamic item and a collision boundary, has begun.        /// </summary>        /// <param name="behavior">The collision behavior that owns the dynamic item that has started contact with a boundary.</param>        /// <param name="beganContactForItem">The dynamic item that has started contact with a boundary.</param>        /// <param name="withBoundaryIdentifier">The identifier of the boundary that the dynamic item has started contact with.</param>        /// <param name="atPoint">The collision point on the boundary.</param>        [iOSVersion(7)]        [Export("collisionBehavior")]        void CollisionBehavior(UICollisionBehavior behavior, UIDynamicItem beganContactForItem, NSCopying withBoundaryIdentifier, CGPoint atPoint);                /// <summary>        /// Called when a collision between two dynamic items has begun.        /// </summary>        /// <param name="behavior">The collision behavior that owns the dynamic items that have started to contact each other.</param>        /// <param name="beganContactForItem">The first of the two dynamic items participating in the collision.</param>        /// <param name="withItem">The second of the two dynamic items participating in the collision.</param>        /// <param name="atPoint">The contact point for the collision. The coordinate system that pertains to a collision depends on how you initialized the associated animator. For details, read the Overview of UIDynamicAnimator Class Reference.</param>        [iOSVersion(7)]        [Export("collisionBehavior")]        void CollisionBehavior(UICollisionBehavior behavior, UIDynamicItem beganContactForItem, UIDynamicItem withItem, CGPoint atPoint);                /// <summary>        /// Called when a collision between a dynamic item and a boundary has ended.        /// </summary>        /// <param name="behavior">The collision behavior that owns the dynamic item that has ended contact.</param>        /// <param name="endedContactForItem">The dynamic item that collided.</param>        /// <param name="withBoundaryIdentifier">The identifier of the boundary that the dynamic item collided with.</param>        [iOSVersion(7)]        [Export("collisionBehavior")]        void CollisionBehavior(UICollisionBehavior behavior, UIDynamicItem endedContactForItem, NSCopying withBoundaryIdentifier);                /// <summary>        /// Called when a collision between two dynamic items has ended.        /// </summary>        /// <param name="behavior">The collision behavior that owns the dynamic items that collided.</param>        /// <param name="endedContactForItem">The first of the two dynamic items participating in the collision.</param>        /// <param name="withItem">The second of the two dynamic items participating in the collision.</param>        [iOSVersion(7)]        [Export("collisionBehavior")]        void CollisionBehavior(UICollisionBehavior behavior, UIDynamicItem endedContactForItem, UIDynamicItem withItem);    }}