using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A dynamic animator provides physics-related capabilities and animations for its dynamic items, and provides the context for those animations. It does this by intermediating between the underlying iOS physics engine and dynamic items, via behavior objects you add to the animator.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDynamicAnimator_Class/index.html#//apple_ref/occ/cl/UIDynamicAnimator"/>    [iOSVersion(7)]    public class UIDynamicAnimator : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Initializes a dynamic animator with a specified view as its reference view.        /// </summary>        /// <param name="referenceView">The view for the dynamic animator, called the reference view.</param>        [iOSVersion(7)]        public UIDynamicAnimator(UIView referenceView) { }                /// <summary>        /// Initializes a dynamic animator with a specified collection view layout.        /// </summary>        /// <param name="collectionViewLayout">The collection view layout for the dynamic animator, serving as the reference view for a dynamic animator in collection-view mode.</param>        [iOSVersion(7)]        public UIDynamicAnimator(UICollectionViewLayout collectionViewLayout) { }                /// <summary>        /// Returns the dynamic items, from the animator’s behaviors, that intersect a specified rectangle.        /// </summary>        /// <param name="rect">The rectangle you are interested in.</param>        [iOSVersion(7)]        [Export("itemsInRect")]        public AnyObject[] ItemsInRect(CGRect rect) { return default(AnyObject[]); }                /// <summary>        /// Adds a dynamic behavior to a dynamic animator.        /// </summary>        /// <param name="behavior">The dynamic behavior instance you are adding.        ///   The dynamic animator ignores your use of this method if you:        ///   Provide a nil value        ///   Provide a behavior instance that you’ve already added to the animator at the same level in the behavior hierarchy        ///     Important        ///     The dynamic animator raises an exception if you provide a behavior instance that you’ve already added to the animator at a different level in the behavior hierarchy.</param>        [iOSVersion(7)]        [Export("addBehavior")]        public void AddBehavior(UIDynamicBehavior behavior) {  }                /// <summary>        /// Removes a specified dynamic behavior from a dynamic animator.        /// </summary>        /// <param name="behavior">The dynamic behavior instance that you want to remove from the animator.        ///   The dynamic animator ignores your use of this method if you:        ///   Provide a nil value        ///   Provide a dynamic behavior instance that is not part of the animator’s behavior hierarchy</param>        [iOSVersion(7)]        [Export("removeBehavior")]        public void RemoveBehavior(UIDynamicBehavior behavior) {  }                /// <summary>        /// Removes all of the dynamic behaviors from a dynamic animator.        /// </summary>        [iOSVersion(7)]        [Export("removeAllBehaviors")]        public void RemoveAllBehaviors() {  }                /// <summary>        /// Returns the time interval since the dynamic animator started running.        /// </summary>        [iOSVersion(7)]        [Export("elapsedTime")]        public NSTimeInterval ElapsedTime() { return default(NSTimeInterval); }                /// <summary>        /// Asks a dynamic animator to read the current state of a dynamic item, replacing the animator’s internal representation of the item’s state.        /// </summary>        /// <param name="item">The dynamic item whose state was changed by your app.</param>        [iOSVersion(7)]        [Export("updateItemUsingCurrentState")]        public void UpdateItemUsingCurrentState(UIDynamicItem item) {  }                /// <summary>        /// A convenience method for returning the layout attributes for a collection view cell.        /// </summary>        /// <param name="indexPath">The index path for the cell whose layout attributes you want.</param>        [iOSVersion(7)]        [Export("layoutAttributesForCellAtIndexPath")]        public UICollectionViewLayoutAttributes LayoutAttributesForCellAtIndexPath(NSIndexPath indexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// A convenience method for returning the layout attributes for a collection view decoration view.        /// </summary>        /// <param name="decorationViewKind">The kind identifier for the specified decoration view.</param>        /// <param name="atIndexPath">The index path for the cell whose decoration view layout attributes you want.</param>        [iOSVersion(7)]        [Export("layoutAttributesForDecorationViewOfKind")]        public UICollectionViewLayoutAttributes LayoutAttributesForDecorationViewOfKind(string decorationViewKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// A convenience method for returning the layout attributes for a collection view supplementary view.        /// </summary>        /// <param name="kind">A string that identifies the type of supplementary view whose layout attributes you want.</param>        /// <param name="atIndexPath">The index path for the cell whose supplementary view layout attributes you want.</param>        [iOSVersion(7)]        [Export("layoutAttributesForSupplementaryViewOfKind")]        public UICollectionViewLayoutAttributes LayoutAttributesForSupplementaryViewOfKind(string kind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns true if the dynamic animator is running. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("running")]        public bool Running { get; private set; }                /// <summary>        /// The dynamic behaviors managed by a dynamic animator. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("behaviors")]        public AnyObject[] Behaviors { get; private set; }                /// <summary>        /// The view that a dynamic animator was initialized with. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("referenceView")]        public UIView ReferenceView { get; private set; }                /// <summary>        /// The delegate for responding to pausing or resumption of animation.        /// </summary>        [iOSVersion(7)]        [Export("delegate")]        public UIDynamicAnimatorDelegate Delegate { get; set; }    }}