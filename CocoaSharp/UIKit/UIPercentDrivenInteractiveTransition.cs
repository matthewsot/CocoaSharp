using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPercentDriveninteractiveTransition_class/index.html#//apple_ref/occ/cl/UIPercentDriveninteractiveTransition	/// <summary>	/// A percent-driven interactive transition object drives the custom animation between the disappearance of one view controller and the appearance of another. It relies on a transition animator delegate—a custom object that adopts the UIViewControllerAnimatorTransitioning protocol—to set up and perform the animations.	/// </summary>	[iOSVersion(7)]	public class UIPercentDriveninteractiveTransition : NSObject	{		/// <summary>		/// Indicates the animation completion curve for an interactive transition.		/// </summary>		[iOSVersion(7)]		[Export("completionCurve")]		public UIViewAnimationCurve CompletionCurve { get; set; }				/// <summary>		/// The overall duration (in seconds) of the transition animation. (read-only)		/// </summary>		[iOSVersion(7)]		[Export("duration")]		public CGFloat Duration { get; private set; }				/// <summary>		/// The amount of the transition (specified as a percentage of the overall duration) that is complete. (read-only)		/// </summary>		[iOSVersion(7)]		[Export("percentComplete")]		public CGFloat PercentComplete { get; private set; }				/// <summary>		/// The speed of the transition animation.		/// </summary>		[iOSVersion(7)]		[Export("completionSpeed")]		public CGFloat CompletionSpeed { get; set; }				/// <summary>		/// Updates the completion percentage of the transition.		/// </summary>		/// <param name="percentComplete">The percentage of the transition that is currently complete, specified as a floating-point number in the range 0.0 to 1.0. If you specify a value less than 0.0, this method changes it to 0.0. Specifying a value greater than 1.0 would cause the animation to appear complete already.</param>		[iOSVersion(7)]		[Export("updateinteractiveTransition")]		public void UpdateinteractiveTransition(CGFloat percentComplete) { }				/// <summary>		/// Notifies the system that user interactions canceled the transition.		/// </summary>		[iOSVersion(7)]		[Export("cancelinteractiveTransition")]		public void CancelinteractiveTransition() { }				/// <summary>		/// Notifies the system that user interactions signaled the completion of the transition.		/// </summary>		[iOSVersion(7)]		[Export("finishinteractiveTransition")]		public void FinishinteractiveTransition() { }	}}