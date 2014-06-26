using CoreGraphics;
using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewDelegateFlowLayout_protocol/index.html#//apple_ref/occ/intf/UICollectionViewDelegateFlowLayout
	/// <summary>
	/// The UICollectionViewDelegateFlowLayout protocol defines methods that let you coordinate with a UICollectionViewFlowLayout object to implement a grid-based layout. The methods of this protocol define the size of items and the spacing between items in the grid.
	/// </summary>
	[iOSVersion(6)]
	public interface UICollectionViewDelegateFlowLayout
	{
		/// <summary>
		/// Asks the delegate for the size of the specified item’s cell.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="sizeForItemAtIndexPath">The index path of the item.</param>
		/// <returns>The width and height of the specified item. Both values must be greater than 0.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		CGSize CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath sizeForItemAtIndexPath);
		
		/// <summary>
		/// Asks the delegate for the margins to apply to content in the specified section.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="insetForSectionAtIndex">The index number of the section whose insets are needed.</param>
		/// <returns>The margins to apply to items in the section.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		UIEdgeInsets CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, int insetForSectionAtIndex);
		
		/// <summary>
		/// Asks the delegate for the spacing between successive rows or columns of a section.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="minimumLineSpacingForSectionAtIndex">The index number of the section whose line spacing is needed.</param>
		/// <returns>The minimum space (measured in points) to apply between successive lines in a section.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		CGFloat CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, int minimumLineSpacingForSectionAtIndex);
		
		/// <summary>
		/// Asks the delegate for the spacing between successive items in the rows or columns of a section.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="minimuminteritemSpacingForSectionAtIndex">The index number of the section whose inter-item spacing is needed.</param>
		/// <returns>The minimum space (measured in points) to apply between successive items in the lines of a section.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		CGFloat CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, int minimuminteritemSpacingForSectionAtIndex);
		
		/// <summary>
		/// Asks the delegate for the size of the header view in the specified section.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="referenceSizeForHeaderInSection">The index of the section whose header size is being requested.</param>
		/// <returns>The size of the header. If you return a value of size (0, 0), no header is added.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		CGSize CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, int referenceSizeForHeaderInSection);
		
		/// <summary>
		/// Asks the delegate for the size of the footer view in the specified section.
		/// </summary>
		/// <param name="collectionView">The collection view object displaying the flow layout.</param>
		/// <param name="layout">The layout object requesting the information.</param>
		/// <param name="referenceSizeForFooterInSection">The index of the section whose footer size is being requested.</param>
		/// <returns>The size of the footer. If you return a value of size (0, 0), no footer is added.</returns>
		[iOSVersion(6)]
		[Export("collectionView")]
		[Optional]
		CGSize CollectionView(UICollectionView collectionView, UICollectionViewLayout layout, int referenceSizeForFooterInSection);
	}
}