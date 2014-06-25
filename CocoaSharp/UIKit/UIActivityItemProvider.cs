using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIActivityItemProvider_Class/index.html#//apple_ref/occ/cl/UIActivityItemProvider	/// <summary>	/// A UIActivityItemProvider object is a proxy for data passed to an activity view controller. You can use a provider object in situations where you want to make data available for use by an activity but you want to delay providing that data until it is actually needed. For example, you might use a provider object to represent a large video file that needs to be processed before it can be shared to a user’s social media account.	/// </summary>	[iOSVersion(6)]	public class UIActivityItemProvider : NSOperation	{		/// <summary>		/// Initializes and returns a provider object with the specified placeholder data.		/// </summary>		/// <param name="placeholderItem">An object that can stand in for the actual object you plan to create. The contents of the object may be empty but the class of the object must match the class of the object you plan to provide later.</param>		/// <returns>An initialized provider object.</returns>		[iOSVersion(6)]		public UIActivityItemProvider(AnyObject placeholderItem) { }				/// <summary>		/// Generates and returns the actual data-bearing object.		/// </summary>		[iOSVersion(6)]		[Export("item")]		public AnyObject Item() { return null; }				/// <summary>		/// The placeholder object you specified at initialization time. (read-only)		/// </summary>		[iOSVersion(6)]		[Export("placeholderItem")]		public AnyObject PlaceholderItem { get; private set; }				/// <summary>		/// The type of the activity object that is expecting the data. (read-only)		/// </summary>		[iOSVersion(6)]		[Export("activityType")]		public string ActivityType { get; private set; }	}}