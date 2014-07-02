using CoreGraphics;
using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITraitSet_ClassReference/index.html#//apple_ref/occ/cl/UITraitCollection
	/// <summary>
	/// A UITraitCollection object provides details about the characteristics of a view controller. These characteristics define the size class, display scale, and device idiom of the view controller. When a view controller is created, a set of trait collections is automatically created for that view controller.
	/// </summary>
	[iOSVersion(8)]
	public class UITraitCollection : NSObject
	{
		/// <summary>
		/// Returns a new trait collection containing only the indicated scale.
		/// </summary>
		/// <param name="displayScale">The scale for the new trait collection.</param>
		/// <returns>A new trait collection containing the specified scale.</returns>
		[iOSVersion(8)]
		public UITraitCollection(CGFloat displayScale) { }
		
		/// <summary>
		/// Returns a trait collection created using the traits contained within an array.
		/// </summary>
		/// <param name="traitsFromCollections">An array of traits.</param>
		/// <returns>A trait collection created from the traitCollections array.</returns>
		[iOSVersion(8)]
		public UITraitCollection(AnyObject[] traitsFromCollections) { }
		
		/// <summary>
		/// Creates a new trait collection containing only the indicated device idiom.
		/// </summary>
		/// <param name="userinterfaceIdiom">The interface idiom for the new trait collection.</param>
		/// <returns>A new trait collection containing the interface idiom.</returns>
		[iOSVersion(8)]
		public UITraitCollection(UIUserinterfaceIdiom userinterfaceIdiom) { }
		
		/// <summary>
		/// Creates a new trait collection containing only the indicated size class.
		/// </summary>
		/// <param name="horizontalSizeClass">The size class to be used for the new trait collection.</param>
		/// <returns>A new trait collection containing the specified horizontal size class.</returns>
		[iOSVersion(8)]
		public UIHorizontaTraitCollection(UIUserinterfaceSizeClass horizontalSizeClass) { }
		
		/// <summary>
		/// Creates a new trait collection containing only the indicated size class.
		/// </summary>
		/// <param name="verticalSizeClass">The size class to be used for the new trait collection.</param>
		/// <returns>A new trait collection containing the specified vertical size class.</returns>
		[iOSVersion(8)]
		public UITraitCollection(UIUserinterfaceSizeClass verticalSizeClass) { }
		
		/// <summary>
		/// The horizontal size class for the view. (read-only)
		/// </summary>
		[iOSVersion(8)]
		[Export("horizontalSizeClass")]
		public UIUserinterfaceSizeClass HorizontalSizeClass { get; private set; }
		
		/// <summary>
		/// The current scale used by the display. (read-only)
		/// </summary>
		[iOSVersion(8)]
		[Export("displayScale")]
		public CGFloat DisplayScale { get; private set; }
		
		/// <summary>
		/// The current device idiom. (read-only)
		/// </summary>
		[iOSVersion(8)]
		[Export("userinterfaceIdiom")]
		public UIUserinterfaceIdiom UserinterfaceIdiom { get; private set; }
		
		/// <summary>
		/// The vertical size class for the view. (read-only)
		/// </summary>
		[iOSVersion(8)]
		[Export("verticalSizeClass")]
		public UIUserinterfaceSizeClass VerticalSizeClass { get; private set; }
		
		/// <summary>
		/// Returns a Boolean value that indicates whether a view contains a specific set of traits.
		/// </summary>
		/// <param name="trait">A collection of traits.</param>
		/// <returns>This method returns true if the receiver contains all of the traits found in trait.</returns>
		[iOSVersion(8)]
		[Export("containsTraitsInCollection")]
		public bool ContainsTraitsInCollection(UITraitCollection trait) { return false; }
	}
}