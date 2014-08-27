using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A collision behavior confers, to a specified array of dynamic items, the ability of those items to engage in collisions with each other and with the behavior’s specified boundaries. A collision behavior also specifies some characteristics of its items’ collisions, with other characteristics optionally specified by a UIDynamicItemBehavior object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollisionBehavior_Class/index.html#//apple_ref/occ/cl/UICollisionBehavior"/>    [iOSVersion(7)]    public class UICollisionBehavior : UIDynamicBehavior//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Adds a dynamic item to the collision behavior’s item array.        /// </summary>        /// <param name="item">The dynamic item to add to the item array.</param>        [iOSVersion(7)]        [Export("addItem")]        public void AddItem(UIDynamicItem item) {  }                /// <summary>        /// Initializes a collision behavior with an array of dynamic items.        /// </summary>        /// <param name="items">The dynamic items that you want to participate in the collision behavior.</param>        [iOSVersion(7)]        public UICollisionBehavior(AnyObject[] items) { }                /// <summary>        /// Removes a specific dynamic item from the collision behavior.        /// </summary>        /// <param name="item">The dynamic item that you want to remove.</param>        [iOSVersion(7)]        [Export("removeItem")]        public void RemoveItem(UIDynamicItem item) {  }                /// <summary>        /// Adds a collision boundary, specified as a Bezier path, to the collision behavior.        /// </summary>        /// <param name="identifier">An arbitrary identifier for the boundary you are adding.</param>        /// <param name="forPath">An arbitrary Bezier path that specifies the collision boundary you are adding.         ///   The coordinate system and origin point for the path depend on how you’ve initialized the dynamic animator (that you’re adding the behavior to). See the overview in UIDynamicAnimator Class Reference for more information.</param>        [iOSVersion(7)]        [Export("addBoundaryWithIdentifier")]        public void AddBoundaryWithIdentifier(NSCopying identifier, UIBezierPath forPath) {  }                /// <summary>        /// Adds a collision boundary, specified as a line segment, to the collision behavior.        /// </summary>        /// <param name="identifier">An arbitrary identifier for the boundary you are adding.</param>        /// <param name="fromPoint">The starting point for the boundary line segment.</param>        /// <param name="toPoint">The ending point for the boundary line segment.</param>        [iOSVersion(7)]        [Export("addBoundaryWithIdentifier")]        public void AddBoundaryWithIdentifier(NSCopying identifier, CGPoint fromPoint, CGPoint toPoint) {  }                /// <summary>        /// Returns a specified Bezier-path boundary.        /// </summary>        /// <param name="identifier">A boundary identifier that you’ve previously added to the collision behavior.</param>        [iOSVersion(7)]        [Export("boundaryWithIdentifier")]        public UIBezierPath BoundaryWithIdentifier(NSCopying identifier) { return default(UIBezierPath); }                /// <summary>        /// Removes all previously-specified collision boundaries from the collision behavior.        /// </summary>        [iOSVersion(7)]        [Export("removeAllBoundaries")]        public void RemoveAllBoundaries() {  }                /// <summary>        /// Removes a specific collision boundary from the collision behavior.        /// </summary>        /// <param name="identifier">The identifier of the boundary you want to remove.</param>        [iOSVersion(7)]        [Export("removeBoundaryWithIdentifier")]        public void RemoveBoundaryWithIdentifier(NSCopying identifier) {  }                /// <summary>        /// Specifies a collision boundary based on the bounds of the animation reference system, with optional insets.        /// </summary>        /// <param name="insets">Insets to apply to the reference system’s bounds when defining the collision boundary.</param>        [iOSVersion(7)]        [Export("setTranslatesReferenceBoundsIntoBoundaryWithInsets")]        public void SetTranslatesReferenceBoundsIntoBoundaryWithInsets(UIEdgeInsets insets) {  }                /// <summary>        /// Returns the set of dynamic items you’ve added to the collision behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("items")]        public AnyObject[] Items { get; private set; }                /// <summary>        /// The set of boundary identifiers that you’ve added to the collision behavior. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("boundaryIdentifiers")]        public AnyObject[] BoundaryIdentifiers { get; private set; }                /// <summary>        /// The delegate object that you want to respond to collisions for the collision behavior.        /// </summary>        [iOSVersion(7)]        [Export("collisionDelegate")]        public UICollisionBehaviorDelegate CollisionDelegate { get; set; }                /// <summary>        /// The type of edges that participate in collisions for the collision behavior.        /// </summary>        [iOSVersion(7)]        [Export("collisionMode")]        public UICollisionBehaviorMode CollisionMode { get; set; }                /// <summary>        /// Specifies whether a boundary based on the reference system is active.        /// </summary>        [iOSVersion(7)]        [Export("translatesReferenceBoundsIntoBoundary")]        public bool TranslatesReferenceBoundsIntoBoundary { get; set; }    }    /// <summary>    /// The types of edges that participate in collisions for a collision behavior.    /// </summary>    [iOSVersion(7)]    public enum UICollisionBehaviorMode    {        /// <summary>        /// Specifies that the dynamic items, associated with the collision behavior, collide only with each other and not with specified collision boundaries.        /// </summary>        [iOSVersion(7)]        Items,        /// <summary>        /// Specifies that the dynamic items, associated with the collision behavior, collide only with specified collision boundaries and do not collide with each other.        /// </summary>        [iOSVersion(7)]        Boundaries,        /// <summary>        /// Specifies that the dynamic items, associated with the collision behavior, collide with each other and with specified collision boundaries.        /// This is the default collision behavior mode.        /// </summary>        [iOSVersion(7)]        Everything,    }}