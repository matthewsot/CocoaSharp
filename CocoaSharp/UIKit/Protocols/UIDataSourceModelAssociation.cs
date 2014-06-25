using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDataSourceModelAssociation_protocol/index.html#//apple_ref/occ/intf/UIDataSourceModelAssociation	/// <summary>	/// The UIDataSourceModelAssociation protocol defines an interface for providing persistent references to data objects in your app. Your data source objects can adopt this protocol in order to assist a corresponding table or collection view during the state restoration process. Those classes use the methods of this protocol to ensure that the same data objects (and not just the same row indexes) are scrolled into view and selected.	/// </summary>	[iOSVersion(6)]	public interface UIDataSourceModelAssociation	{		/// <summary>		/// Returns the string that uniquely identifies the data at the specified location in the view. (required)		/// </summary>		/// <param name="idx">The index path to the requested data object.</param>		/// <param name="inView">The view that contains the data object.</param>		/// <returns>A string that uniquely identifies the data object.</returns>		[iOSVersion(6)]		[Export("modelIdentifierForElementAtIndexPath")]		string ModelIdentifierForElementAtIndexPath(NSIndexPath idx, UIView inView);				/// <summary>		/// Returns the current index of the data object with the specified identifier. (required)		/// </summary>		/// <param name="identifier">The identifier for the requested data object. Use this identifier to locate the matching object in your data source object. This is the same string that your app’s modelIdentifierForElementAtIndexPath:inView: method returned when encoding the data originally.</param>		/// <param name="inView">The view into which the object is being inserted.</param>		/// <returns>The current index of the object whose data matches the value in identifier, or nil if the object was not found.</returns>		[iOSVersion(6)]		[Export("indexPathForElementWithModelIdentifier")]		NSIndexPath IndexPathForElementWithModelIdentifier(string identifier, UIView inView);	}}