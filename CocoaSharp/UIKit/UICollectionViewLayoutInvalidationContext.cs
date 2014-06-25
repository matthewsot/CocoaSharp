using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewLayoutInvalidationContext_class/index.html#//apple_ref/occ/cl/UICollectionViewLayoutInvalidationContext	/// <summary>	/// A UICollectionViewLayoutInvalidationContext object declares which parts of your layout need to be updated when the layout is invalidated. Layout objects that are designed to support invalidation contexts can use that information to optimize their behavior during the invalidation cycle.	/// </summary>	[iOSVersion(7)]	public class UICollectionViewLayoutInvalidationContext : NSObject	{		/// <summary>		/// A Boolean that indicates that all layout data should be marked as invalid. (read-only)		/// </summary>		[iOSVersion(7)]		[Export("invalidateEverything")]		public bool InvalidateEverything { get; private set; }				/// <summary>		/// A Boolean that indicates whether the layout should ask for new section and item counts. (read-only)		/// </summary>		[iOSVersion(7)]		[Export("invalidateDataSourceCounts")]		public bool InvalidateDataSourceCounts { get; private set; }				/// <summary>		/// The delta value to be applied to the collection view’s content offset.		/// </summary>		[iOSVersion(8)]		[Export("contentOffsetAdjustment")]		public CGPoint ContentOffsetAdjustment { get; set; }				/// <summary>		/// The delta value to be applied to the collection view’s content size.		/// </summary>		[iOSVersion(8)]		[Export("contentSizeAdjustment")]		public CGSize ContentSizeAdjustment { get; set; }				/// <summary>		/// Adds the cells at the specified index paths to the list of invalid items.		/// </summary>		/// <param name="indexPaths">An array of NSIndexPath objects. Each index path represents a cell whose layout needs to be recomputed.</param>		[iOSVersion(8)]		[Export("invalidateItemsAtIndexPaths")]		public void InvalidateItemsAtIndexPaths(AnyObject[] indexPaths) { }				/// <summary>		/// Adds the supplementary views at the specified index paths to the list of invalid items.		/// </summary>		/// <param name="elementKind">A string that identifies the type of the supplementary views. This parameter must not be nil.</param>		/// <param name="atIndexPaths">An array of NSIndexPath objects. Each index path represents a supplementary view of the given kind whose layout needs to be recomputed.</param>		[iOSVersion(8)]		[Export("invalidateSupplementaryElementsOfKind")]		public void InvalidateSupplementaryElementsOfKind(string elementKind, AnyObject[] atIndexPaths) { }				/// <summary>		/// Adds the decoration views at the specified index paths to the list of invalid items.		/// </summary>		/// <param name="elementKind">A string that identifies the type of the decoration views. This parameter must not be nil.</param>		/// <param name="atIndexPaths">An array of NSIndexPath objects. Each index path represents a supplementary view of the given kind whose layout needs to be recomputed.</param>		[iOSVersion(8)]		[Export("invalidateDecorationElementsOfKind")]		public void InvalidateDecorationElementsOfKind(string elementKind, AnyObject[] atIndexPaths) { }				/// <summary>		/// An array of index paths representing the cells that were invalidated. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("invalidatedItemIndexPaths")]		public AnyObject[] InvalidatedItemIndexPaths { get; private set; }				/// <summary>		/// A dictionary that identifies the supplementary views that were invalidated. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("invalidatedSupplementaryIndexPaths")]		public NSDictionary InvalidatedSupplementaryIndexPaths { get; private set; }				/// <summary>		/// A dictionary that identifies the decoration views that were invalidated. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("invalidatedDecorationIndexPaths")]		public NSDictionary InvalidatedDecorationIndexPaths { get; private set; }	}}