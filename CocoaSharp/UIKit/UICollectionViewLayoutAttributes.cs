using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewLayoutAttributes_class/index.html#//apple_ref/occ/cl/UICollectionViewLayoutAttributes	/// <summary>	/// An UICollectionViewLayoutAttributes object manages the layout-related attributes for a given item in a collection view. Layout objects create instances of this class when asked to do so by the collection view. In turn, the collection view uses the layout information to position cells and supplementary views inside its bounds.	/// </summary>	[iOSVersion(6)]	public class UICollectionViewLayoutAttributes : NSObject	{		/// <summary>		/// Creates and returns a layout attributes object that represents a cell with the specified index path.		/// </summary>		/// <param name="forCellWithIndexPath">The index path of the cell.</param>		/// <returns>A new layout attributes object whose precise type matches the type of the class used to call this method.</returns>		[iOSVersion(6)]		public UICollectionViewLayoutAttributes(NSIndexPath forCellWithIndexPath) { }				/// <summary>		/// Creates and returns a layout attributes object that represents the specified supplementary view.		/// </summary>		/// <param name="forSupplementaryViewOfKind">A string that identifies the type of supplementary view.</param>		/// <param name="withIndexPath">The index path of the view.</param>		/// <returns>A new layout attributes object whose precise type matches the type of the class used to call this method.</returns>		[iOSVersion(6)]		public UICollectionViewLayoutAttributes(string forSupplementaryViewOfKind, NSIndexPath withIndexPath) { }				/// <summary>		/// Creates and returns a layout attributes object that represents the specified decoration view.		/// </summary>		/// <param name="forDecorationViewOfKind">The kind identifier for the specified decoration view.</param>		/// <param name="withIndexPath">An index path related to the decoration view.</param>		/// <returns>A new layout attributes object whose precise type matches the type of the class used to call this method.</returns>		[iOSVersion(6)]		public UICollectionViewLayoutAttributes(string forDecorationViewOfKind, NSIndexPath withIndexPath) { }				/// <summary>		/// The index path of the item in the collection view.		/// </summary>		[iOSVersion(6)]		[Export("indexPath")]		public NSIndexPath IndexPath { get; set; }				/// <summary>		/// The type of the item. (read-only)		/// </summary>		[iOSVersion(6)]		[Export("representedElementCategory")]		public UICollectionElementCategory RepresentedElementCategory { get; private set; }				/// <summary>		/// The layout-specific identifier for the target view. (read-only)		/// </summary>		[iOSVersion(6)]		[Export("representedElementKind")]		public string RepresentedElementKind { get; private set; }				/// <summary>		/// The frame rectangle of the item.		/// </summary>		[iOSVersion(6)]		[Export("frame")]		public CGRect Frame { get; set; }				/// <summary>		/// The bounds of the item.		/// </summary>		[iOSVersion(7)]		[Export("bounds")]		public CGRect Bounds { get; set; }				/// <summary>		/// The center point of the item.		/// </summary>		[iOSVersion(6)]		[Export("center")]		public CGPoint Center { get; set; }				/// <summary>		/// The size of the item.		/// </summary>		[iOSVersion(6)]		[Export("size")]		public CGSize Size { get; set; }				/// <summary>		/// The 3D transform of the item.		/// </summary>		[iOSVersion(6)]		[Export("transform3D")]		public CATransform3D Transform3D { get; set; }				/// <summary>		/// The affine transform of the item		/// </summary>		[iOSVersion(7)]		[Export("transform")]		public CGAffineTransform Transform { get; set; }				/// <summary>		/// The transparency of the item.		/// </summary>		[iOSVersion(6)]		[Export("alpha")]		public CGFloat Alpha { get; set; }				/// <summary>		/// Specifies the item’s position on the z axis.		/// </summary>		[iOSVersion(6)]		[Export("zIndex")]		public int ZIndex { get; set; }				/// <summary>		/// Determines whether the item is currently displayed.		/// </summary>		[iOSVersion(6)]		[Export("hidden")]		public bool Hidden { get; set; }				/// <summary>		/// Constants specifying the type of view.		/// </summary>		public enum UICollectionElementCategory		{			/// <summary>			/// The view is a cell.			/// </summary>			[iOSVersion(6)]			Cell,						/// <summary>			/// The view is a supplementary view.			/// </summary>			[iOSVersion(6)]			SupplementaryView,						/// <summary>			/// The view is a decoration view.			/// </summary>			[iOSVersion(6)]			DecorationView,		}	}}