using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPinchGestureRecognizer_Class/index.html#//apple_ref/occ/cl/UIPinchGestureRecognizer	/// <summary>	/// UIPinchGestureRecognizer is a concrete subclass of UIGestureRecognizer that looks for pinching gestures involving two touches. When the user moves the two fingers toward each other, the conventional meaning is zoom-out; when the user moves the two fingers away from each other, the conventional meaning is zoom-in.	/// </summary>	[iOSVersion(3.2)]	public class UIPinchGestureRecognizer : UIGestureRecognizer	{		/// <summary>		/// The scale factor relative to the points of the two touches in screen coordinates.		/// </summary>		[iOSVersion(3.2)]		[Export("scale")]		public CGFloat Scale { get; set; }				/// <summary>		/// The velocity of the pinch in scale factor per second. (read-only)		/// </summary>		[iOSVersion(3.2)]		[Export("velocity")]		public CGFloat Velocity { get; private set; }	}}