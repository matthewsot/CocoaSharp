using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UICollectionViewDelegate protocol defines methods that allow you to manage the selection and highlighting of items in a collection view and to perform actions on those items. The methods of this protocol are all optional.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewDelegate_protocol/index.html#//apple_ref/occ/intf/UICollectionViewDelegate"/>    [iOSVersion(6)]    public interface UICollectionViewDelegate//: NSObjectProtocol, UIScrollViewDelegate    {        /// <summary>        /// Asks the delegate if the specified item should be selected.        /// </summary>        /// <param name="collectionView">The collection view object that is asking whether the selection should change.</param>        /// <param name="shouldSelectItemAtIndexPath">The index path of the cell to be selected.</param>        [iOSVersion(6)]        [Export("collectionView")]        bool CollectionView(UICollectionView collectionView, NSIndexPath shouldSelectItemAtIndexPath);                /// <summary>        /// Tells the delegate that the item at the specified index path was selected.        /// </summary>        /// <param name="collectionView">The collection view object that is notifying you of the selection change.</param>        /// <param name="didSelectItemAtIndexPath">The index path of the cell that was selected.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void CollectionView(UICollectionView collectionView, NSIndexPath didSelectItemAtIndexPath, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Asks the delegate if the specified item should be deselected.        /// </summary>        /// <param name="collectionView">The collection view object that is asking whether the selection should change.</param>        /// <param name="shouldDeselectItemAtIndexPath">The index path of the cell to be deselected.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        bool CollectionView(UICollectionView collectionView, NSIndexPath shouldDeselectItemAtIndexPath, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Tells the delegate that the item at the specified path was deselected.        /// </summary>        /// <param name="collectionView">The collection view object that is notifying you of the selection change.</param>        /// <param name="didDeselectItemAtIndexPath">The index path of the cell that was deselected.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void CollectionView(UICollectionView collectionView, NSIndexPath didDeselectItemAtIndexPath, string NAME_YOUR_PARAMS = "");                /// <summary>        /// Asks the delegate if the item should be highlighted during tracking.        /// </summary>        /// <param name="collectionView">The collection view object that is asking about the highlight change.</param>        /// <param name="shouldHighlightItemAtIndexPath">The index path of the cell to be highlighted.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        bool CollectionView(UICollectionView collectionView, NSIndexPath shouldHighlightItemAtIndexPath, double NAME_YOUR_PARAMS = 4.2);                /// <summary>        /// Tells the delegate that the item at the specified index path was highlighted.        /// </summary>        /// <param name="collectionView">The collection view object that is notifying you of the highlight change.</param>        /// <param name="didHighlightItemAtIndexPath">The index path of the cell that was highlighted.</param>        [iOSVersion(6)]        [Export("collectionView")]        void CollectionView(UICollectionView collectionView, NSIndexPath didHighlightItemAtIndexPath);                /// <summary>        /// Tells the delegate that the highlight was removed from the item at the specified index path.        /// </summary>        /// <param name="collectionView">The collection view object that is notifying you of the highlight change.</param>        /// <param name="didUnhighlightItemAtIndexPath">The index path of the cell that had its highlight removed.</param>        [iOSVersion(6)]        [Export("collectionView")]        void CollectionView(UICollectionView collectionView, NSIndexPath didUnhighlightItemAtIndexPath);                /// <summary>        /// Tells the delegate that the specified cell is about to be displayed in the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that is adding the cell.</param>        /// <param name="willDisplayCell">The cell object being added.</param>        /// <param name="forItemAtIndexPath">The index path of the data item that the cell represents.</param>        [iOSVersion(8)]        [Export("collectionView")]        void CollectionView(UICollectionView collectionView, UICollectionViewCell willDisplayCell, NSIndexPath forItemAtIndexPath);                /// <summary>        /// Tells the delegate that the specified supplementary view is about to be displayed in the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that is adding the supplementary view.</param>        /// <param name="willDisplaySupplementaryView">The view being added.</param>        /// <param name="forElementKind">The type of the supplementary view. This string is defined by the layout that presents the view.</param>        /// <param name="atIndexPath">The index path of the data item that the supplementary view represents.</param>        [iOSVersion(8)]        [Export("collectionView")]        void CollectionView(UICollectionView collectionView, UICollectionReusableView willDisplaySupplementaryView, string forElementKind, NSIndexPath atIndexPath);                /// <summary>        /// Tells the delegate that the specified cell was removed from the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that removed the cell.</param>        /// <param name="didEndDisplayingCell">The cell object that was removed.</param>        /// <param name="forItemAtIndexPath">The index path of the data item that the cell represented.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void CollectionView(UICollectionView collectionView, UICollectionViewCell didEndDisplayingCell, NSIndexPath forItemAtIndexPath, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Tells the delegate that the specified supplementary view was removed from the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that removed the supplementary view.</param>        /// <param name="didEndDisplayingSupplementaryView">The view that was removed.</param>        /// <param name="forElementOfKind">The type of the supplementary view. This string is defined by the layout that presents the view.</param>        /// <param name="atIndexPath">The index path of the data item that the supplementary view represented.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void CollectionView(UICollectionView collectionView, UICollectionReusableView didEndDisplayingSupplementaryView, string forElementOfKind, NSIndexPath atIndexPath, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Asks for the custom transition layout to use when moving between the specified layouts.        /// </summary>        /// <param name="collectionView">The collection view whose layout object is changing.</param>        /// <param name="transitionLayoutForOldLayout">The current layout of the collection view. This is the starting point for the transition.</param>        /// <param name="newLayout">The new layout for the collection view.</param>        [iOSVersion(7)]        [Export("collectionView")]        UICollectionViewTransitionLayout CollectionView(UICollectionView collectionView, UICollectionViewLayout transitionLayoutForOldLayout, UICollectionViewLayout newLayout);                /// <summary>        /// Asks the delegate if an action menu should be displayed for the specified item.        /// </summary>        /// <param name="collectionView">The collection view object that is making the request.</param>        /// <param name="shouldShowMenuForItemAtIndexPath">The index path of the affected item.</param>        [iOSVersion(6)]        [Export("collectionView")]        bool CollectionView(UICollectionView collectionView, NSIndexPath shouldShowMenuForItemAtIndexPath);                /// <summary>        /// Asks the delegate if it can perform the specified action on an item in the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that is making the request.</param>        /// <param name="canPerformAction">The selector identifying the action to be performed.</param>        /// <param name="forItemAtIndexPath">The index path of the affected item.</param>        /// <param name="withSender">The object that wants to initiate the action.</param>        [iOSVersion(6)]        [Export("collectionView")]        bool CollectionView(UICollectionView collectionView, Selector canPerformAction, NSIndexPath forItemAtIndexPath, AnyObject withSender);                /// <summary>        /// Tells the delegate to perform the specified action on an item in the collection view.        /// </summary>        /// <param name="collectionView">The collection view object that is making the request.</param>        /// <param name="performAction">The selector representing the action to be performed.</param>        /// <param name="forItemAtIndexPath">The index path of the affected item.</param>        /// <param name="withSender">The object that initiated the action.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(6)]        [Export("collectionView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void CollectionView(UICollectionView collectionView, Selector performAction, NSIndexPath forItemAtIndexPath, AnyObject withSender, bool NAME_YOUR_PARAMS = false);    }}