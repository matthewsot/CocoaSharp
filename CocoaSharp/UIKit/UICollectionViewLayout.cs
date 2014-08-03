using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UICollectionViewLayout class is an abstract base class that you subclass and use to generate layout information for a collection view. The job of a layout object is to determine the placement of cells, supplementary views, and decoration views inside the collection view’s bounds and to report that information to the collection view when asked. The collection view then applies the provided layout information to the corresponding views so that they can be presented onscreen.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewLayout_class/index.html#//apple_ref/occ/cl/UICollectionViewLayout"/>    [iOSVersion(6)]    public class UICollectionViewLayout : NSObject//, AnyObject, NSCoding, NSObjectProtocol    {        /// <summary>        /// Returns the width and height of the collection view’s contents.        /// </summary>        [iOSVersion(6)]        [Export("collectionViewContentSize")]        public CGSize CollectionViewContentSize() { return default(CGSize); }                /// <summary>        /// Returns the class to use when creating layout attributes objects.        /// </summary>        [iOSVersion(6)]        [Export("layoutAttributesClass")]        public static AnyClass LayoutAttributesClass() { return default(AnyClass); }                /// <summary>        /// Tells the layout object to update the current layout.        /// </summary>        [iOSVersion(6)]        [Export("prepareLayout")]        public void PrepareLayout() {  }                /// <summary>        /// Returns the layout attributes for all of the cells and views in the specified rectangle.        /// </summary>        /// <param name="rect">The rectangle (specified in the collection view’s coordinate system) containing the target views.</param>        [iOSVersion(6)]        [Export("layoutAttributesForElementsInRect")]        public AnyObject[] LayoutAttributesForElementsInRect(CGRect rect) { return default(AnyObject[]); }                /// <summary>        /// Returns the layout attributes for the item at the specified index path.        /// </summary>        /// <param name="indexPath">The index path of the item.</param>        [iOSVersion(6)]        [Export("layoutAttributesForItemAtIndexPath")]        public UICollectionViewLayoutAttributes LayoutAttributesForItemAtIndexPath(NSIndexPath indexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the layout attributes for the specified supplementary view.        /// </summary>        /// <param name="kind">A string that identifies the type of the supplementary view.</param>        /// <param name="atIndexPath">The index path of the view.</param>        [iOSVersion(6)]        [Export("layoutAttributesForSupplementaryViewOfKind")]        public UICollectionViewLayoutAttributes LayoutAttributesForSupplementaryViewOfKind(string kind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the layout attributes for the specified decoration view.        /// </summary>        /// <param name="decorationViewKind">A string that identifies the type of the decoration view.</param>        /// <param name="atIndexPath">The index path of the decoration view.</param>        [iOSVersion(6)]        [Export("layoutAttributesForDecorationViewOfKind")]        public UICollectionViewLayoutAttributes LayoutAttributesForDecorationViewOfKind(string decorationViewKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the content offset to use after an animated layout update or change.        /// </summary>        /// <param name="proposedContentOffset">The proposed point (in the coordinate space of the collection view’s content view) for the upper-left corner of the visible content. This represents the point that the collection view has calculated as the most likely value to use at the end of the animation.</param>        [iOSVersion(7)]        [Export("targetContentOffsetForProposedContentOffset")]        public CGPoint TargetContentOffsetForProposedContentOffset(CGPoint proposedContentOffset) { return default(CGPoint); }                /// <summary>        /// Returns the point at which to stop scrolling.        /// </summary>        /// <param name="proposedContentOffset">The proposed point (in the collection view’s content view) at which to stop scrolling. This is the value at which scrolling would naturally stop if no adjustments were made. The point reflects the upper-left corner of the visible content.</param>        /// <param name="withScrollingVelocity">The current scrolling velocity along both the horizontal and vertical axes. This value is measured in points per second.</param>        [iOSVersion(6)]        [Export("targetContentOffsetForProposedContentOffset")]        public CGPoint TargetContentOffsetForProposedContentOffset(CGPoint proposedContentOffset, CGPoint withScrollingVelocity) { return default(CGPoint); }                /// <summary>        /// Notifies the layout object that the contents of the collection view are about to change.        /// </summary>        /// <param name="updateItems">An array of UICollectionViewUpdateItem objects that identify the changes being made.</param>        [iOSVersion(6)]        [Export("prepareForCollectionViewUpdates")]        public void PrepareForCollectionViewUpdates(AnyObject[] updateItems) {  }                /// <summary>        /// Performs any additional animations or clean up needed during a collection view update.        /// </summary>        [iOSVersion(6)]        [Export("finalizeCollectionViewUpdates")]        public void FinalizeCollectionViewUpdates() {  }                /// <summary>        /// Returns an array of index paths for the supplementary views you want to add to the layout.        /// </summary>        /// <param name="kind">The specific type of supplementary view.</param>        [iOSVersion(7)]        [Export("indexPathsToInsertForSupplementaryViewOfKind")]        public AnyObject[] IndexPathsToInsertForSupplementaryViewOfKind(string kind) { return default(AnyObject[]); }                /// <summary>        /// Returns an array of index paths representing the decoration views to add.        /// </summary>        /// <param name="kind">The specific type of decoration view.</param>        [iOSVersion(7)]        [Export("indexPathsToInsertForDecorationViewOfKind")]        public AnyObject[] IndexPathsToInsertForDecorationViewOfKind(string kind) { return default(AnyObject[]); }                /// <summary>        /// Returns the starting layout information for an item being inserted into the collection view.        /// </summary>        /// <param name="itemIndexPath">The index path of the item being inserted. You can use this path to locate the item in the collection view’s data source.</param>        [iOSVersion(6)]        [Export("initialLayoutAttributesForAppearingItemAtIndexPath")]        public UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingItemAtIndexPath(NSIndexPath itemIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the starting layout information for a supplementary view being inserted into the collection view.        /// </summary>        /// <param name="elementKind">A string that identifies the type of supplementary view.</param>        /// <param name="atIndexPath">The index path of the item being inserted.</param>        [iOSVersion(6)]        [Export("initialLayoutAttributesForAppearingSupplementaryElementOfKind")]        public UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingSupplementaryElementOfKind(string elementKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the starting layout information for a decoration view being inserted into the collection view.        /// </summary>        /// <param name="elementKind">A string that identifies the type of decoration view.</param>        /// <param name="atIndexPath">The index path of the item being inserted.</param>        [iOSVersion(6)]        [Export("initialLayoutAttributesForAppearingDecorationElementOfKind")]        public UICollectionViewLayoutAttributes InitialLayoutAttributesForAppearingDecorationElementOfKind(string elementKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns an array of index paths representing the supplementary views to remove.        /// </summary>        /// <param name="kind">The specific type of supplementary view.</param>        [iOSVersion(7)]        [Export("indexPathsToDeleteForSupplementaryViewOfKind")]        public AnyObject[] IndexPathsToDeleteForSupplementaryViewOfKind(string kind) { return default(AnyObject[]); }                /// <summary>        /// Returns an array of index paths representing the decoration views to remove.        /// </summary>        /// <param name="kind">The specific type of decoration view.</param>        [iOSVersion(7)]        [Export("indexPathsToDeleteForDecorationViewOfKind")]        public AnyObject[] IndexPathsToDeleteForDecorationViewOfKind(string kind) { return default(AnyObject[]); }                /// <summary>        /// Returns the final layout information for an item that is about to be removed from the collection view.        /// </summary>        /// <param name="itemIndexPath">The index path of the item being deleted.</param>        [iOSVersion(6)]        [Export("finalLayoutAttributesForDisappearingItemAtIndexPath")]        public UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingItemAtIndexPath(NSIndexPath itemIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the final layout information for a supplementary view that is about to be removed from the collection view.        /// </summary>        /// <param name="elementKind">A string that identifies the type of supplementary view.</param>        /// <param name="atIndexPath">The index path of the view being deleted.</param>        [iOSVersion(6)]        [Export("finalLayoutAttributesForDisappearingSupplementaryElementOfKind")]        public UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingSupplementaryElementOfKind(string elementKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Returns the final layout information for a decoration view that is about to be removed from the collection view.        /// </summary>        /// <param name="elementKind">A string that identifies the type of decoration view.</param>        /// <param name="atIndexPath">The index path of the view being deleted.</param>        [iOSVersion(6)]        [Export("finalLayoutAttributesForDisappearingDecorationElementOfKind")]        public UICollectionViewLayoutAttributes FinalLayoutAttributesForDisappearingDecorationElementOfKind(string elementKind, NSIndexPath atIndexPath) { return default(UICollectionViewLayoutAttributes); }                /// <summary>        /// Invalidates the current layout and triggers a layout update.        /// </summary>        [iOSVersion(6)]        [Export("invalidateLayout")]        public void InvalidateLayout() {  }                /// <summary>        /// Invalidates the current layout using the information in the provided context object.        /// </summary>        /// <param name="context">The context object indicating which parts of the layout to refresh.</param>        [iOSVersion(7)]        [Export("invalidateLayoutWithContext")]        public void InvalidateLayoutWithContext(UICollectionViewLayoutInvalidationContext context) {  }                /// <summary>        /// Returns the class to use when creating an invalidation context for the layout.        /// </summary>        [iOSVersion(7)]        [Export("invalidationContextClass")]        public static AnyClass InvalidationContextClass() { return default(AnyClass); }                /// <summary>        /// Asks the layout object if the new bounds require a layout update.        /// </summary>        /// <param name="newBounds">The new bounds of the collection view.</param>        [iOSVersion(6)]        [Export("shouldInvalidateLayoutForBoundsChange")]        public bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds) { return default(bool); }                /// <summary>        /// Returns a context object that defines the portions of the layout that should change when a bounds change occurs.        /// </summary>        /// <param name="newBounds">The new bounds for the collection view.</param>        [iOSVersion(7)]        [Export("invalidationContextForBoundsChange")]        public UICollectionViewLayoutInvalidationContext InvalidationContextForBoundsChange(CGRect newBounds) { return default(UICollectionViewLayoutInvalidationContext); }                /// <summary>        /// Asks the layout object if changes to a self-sizing cell require a layout update.        /// </summary>        /// <param name="preferredAttributes">The layout attributes returned by the cell’s preferredLayoutAttributesFittingAttributes: method.</param>        /// <param name="withOriginalAttributes">The attributes that the layout object originally suggested for the cell.</param>        [iOSVersion(8)]        [Export("shouldInvalidateLayoutForPreferredLayoutAttributes")]        public bool ShouldInvalidateLayoutForPreferredLayoutAttributes(UICollectionViewLayoutAttributes preferredAttributes, UICollectionViewLayoutAttributes withOriginalAttributes) { return default(bool); }                /// <summary>        /// Returns a context object that defines the portions of the layout that should change in response to dynamic cell changes.        /// </summary>        /// <param name="preferredAttributes">The layout attributes returned by the cell’s preferredLayoutAttributesFittingAttributes: method.</param>        /// <param name="withOriginalAttributes">The attributes that the layout object originally suggested for the cell.</param>        [iOSVersion(8)]        [Export("invalidationContextForPreferredLayoutAttributes")]        public UICollectionViewLayoutInvalidationContext InvalidationContextForPreferredLayoutAttributes(UICollectionViewLayoutAttributes preferredAttributes, UICollectionViewLayoutAttributes withOriginalAttributes) { return default(UICollectionViewLayoutInvalidationContext); }                /// <summary>        /// Prepares the layout object for animated changes to the view’s bounds or the insertion or deletion of items.        /// </summary>        /// <param name="oldBounds">The current bounds of the collection view.</param>        [iOSVersion(6)]        [Export("prepareForAnimatedBoundsChange")]        public void PrepareForAnimatedBoundsChange(CGRect oldBounds) {  }                /// <summary>        /// Cleans up after any animated changes to the view’s bounds or after the insertion or deletion of items.        /// </summary>        [iOSVersion(6)]        [Export("finalizeAnimatedBoundsChange")]        public void FinalizeAnimatedBoundsChange() {  }                /// <summary>        /// Tells the layout object to prepare to be installed as the layout for the collection view.        /// </summary>        /// <param name="oldLayout">The layout object installed in the collection view at the beginning of the transition. You might use this object to provide different ending attributes based on the starting layout object.</param>        [iOSVersion(7)]        [Export("prepareForTransitionFromLayout")]        public void PrepareForTransitionFromLayout(UICollectionViewLayout oldLayout) {  }                /// <summary>        /// Tells the layout object that it is about to be removed as the layout for the collection view.        /// </summary>        /// <param name="newLayout">The layout object to be installed in the collection view at the end of the transition. You might use this object to provide different starting attributes depending on the final layout object.</param>        [iOSVersion(7)]        [Export("prepareForTransitionToLayout")]        public void PrepareForTransitionToLayout(UICollectionViewLayout newLayout) {  }                /// <summary>        /// Tells the layout object to perform any final steps before the transition animations occur.        /// </summary>        [iOSVersion(7)]        [Export("finalizeLayoutTransition")]        public void FinalizeLayoutTransition() {  }                /// <summary>        /// Registers a class for use in creating decoration views for a collection view.        /// </summary>        /// <param name="viewClass">The class to use for the supplementary view.</param>        /// <param name="forDecorationViewOfKind">The element kind of the decoration view. You can use this string to distinguish between decoration views with different purposes in the layout. This parameter must not be nil and must not be an empty string.</param>        [iOSVersion(6)]        [Export("registerClass")]        public void RegisterClass(AnyClass viewClass, string forDecorationViewOfKind) {  }                /// <summary>        /// Registers a nib file for use in creating decoration views for a collection view.        /// </summary>        /// <param name="nib">The nib object containing the cell definition. The nib file must contain only one top-level object and that object must be of the type UICollectionReusableView.</param>        /// <param name="forDecorationViewOfKind">The element kind of the decoration view. You can use this string to distinguish between decoration views with different purposes in the layout. This parameter must not be nil and must not be an empty string.</param>        [iOSVersion(6)]        [Export("registerNib")]        public void RegisterNib(UINib nib, string forDecorationViewOfKind) {  }                /// <summary>        /// The collection view object currently using this layout object. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("collectionView")]        public UICollectionView CollectionView { get; private set; }    }}