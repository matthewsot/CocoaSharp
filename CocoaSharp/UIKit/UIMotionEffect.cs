using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMotionEffect_class/index.html#//apple_ref/occ/cl/UIMotionEffect	/// <summary>	/// The UIMotionEffect class is an abstract superclass for defining motion-based modifiers for views. Subclasses are responsible for defining the behavior to apply to a view when motion is detected. They do this by overriding the keyPathsAndRelativeValuesForViewerOffset: method and returning one or more key paths representing the view properties to modify.	/// </summary>	[iOSVersion(7)]	public class UIMotionEffect : NSObject	{		/// <summary>		/// For a given set of offset values, returns the view properties (and corresponding values) to update.		/// </summary>		/// <param name="viewerOffset">The direction that the device is facing relative to the viewer. The range of each offset value is -1 to 1. When the device’s screen is pointed directly at the user, the offset values are (0, 0). Rotating the phone so that the screen points down or to the right of the viewer yields a positive value. Rotating the phone so that the screen points above the user or to the user’s left yields a negative value.</param>		/// <returns>A dictionary containing one or more key path strings representing the properties of the view to modify. The value associated with each key path string is the value to add to the given property—that is, it is the amount by which to change the current value of the property. Specify each key path relative to the view containing the motion effect object.</returns>		[iOSVersion(7)]		[Export("keyPathsAndRelativeValuesForViewerOffset")]		public NSDictionary KeyPathsAndRelativeValuesForViewerOffset(UIOffset viewerOffset) { return null; }	}}