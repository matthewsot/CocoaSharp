using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIViewControllerRestoration_protocol/index.html#//apple_ref/occ/intf/UIViewControllerRestoration	/// <summary>	/// The UIViewControllerRestoration protocol should be adopted by classes that act as &quot;restoration classes” for view controllers during the state restoration process. The method in this protocol should be used to create the view controller, if it does not yet exist, or return an existing view controller object, if one does exist.	/// </summary>	[iOSVersion(6)]	public interface UIViewControllerRestoration	{		/// <summary>		/// Asks the receiver to provide the view controller that corresponds to the specified identifier information. (required)		/// </summary>		/// <param name="identifierComponents">An array of NSString objects corresponding to the restoration identifiers of the desired view controller and all of its ancestors in the view controller hierarchy. The last value in the array is the restoration identifier of the desired view controller. Earlier entries represent the restoration identifiers of its ancestors.</param>		/// <param name="coder">The keyed archiver containing the app’s saved state information.</param>		/// <returns>The view controller object to use or nil if you do not want to restore this view controller now.</returns>		[iOSVersion(6)]		[Export("viewControllerWithRestorationIdentifierPath")]		static UIViewController ViewControllerWithRestorationIdentifierPath(AnyObject[] identifierComponents, NSCoder coder);	}}