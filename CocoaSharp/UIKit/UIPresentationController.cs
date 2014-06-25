using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPresentationController_class/index.html#//apple_ref/occ/cl/UIPresentationController	/// <summary>	/// A UIPresentationController object provides advanced view and transition management for presented view controllers. From the time a view controller is presented until the time it is dismissed, UIKit uses a presentation controller to manage various aspects of the presentation process for that view controller. The presentation controller can add its own animations on top of those provided by animator objects, it can respond to size changes, and it can manage other aspects of how the view controller is presented onscreen.	/// </summary>	[iOSVersion(8)]	public class UIPresentationController : NSObject	{		/// <summary>		/// Initializes and returns a presentation controller for transitioning between the specified view controllers		/// </summary>		/// <param name="presentingViewController">The view controller whose content represents the starting point of the transition.</param>		/// <param name="presentedViewController">The view controller being presented modally.</param>		/// <returns>An initialized presentation controller object or nil if the presentation controller could not be initialized.</returns>		[iOSVersion(8)]		public UIPresentationController(UIViewController presentingViewController, UIViewController presentedViewController) { }				/// <summary>		/// The view controller that is the starting point for the presentation. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("presentingViewController")]		public UIViewController PresentingViewController { get; private set; }				/// <summary>		/// The view controller being presented. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("presentedViewController")]		public UIViewController PresentedViewController { get; private set; }				/// <summary>		/// The view in which the presentation occurs. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("containerView")]		public UIView ContainerView { get; private set; }				/// <summary>		/// The view to be animated during the presentation.		/// </summary>		/// <returns>The view to present. This view must be either the presented view controller’s view or an ancestor of that view.</returns>		[iOSVersion(8)]		[Export("presentedView")]		public UIView PresentedView() { return null; }				/// <summary>		/// The frame rectangle to assign to the presented view at the end of the animations.		/// </summary>		/// <returns>The rectangle of the presented view controller’s view, specified in the container view’s coordinate system.</returns>		[iOSVersion(8)]		[Export("frameOfPresentedViewInContainerView")]		public CGRect FrameOfPresentedViewInContainerView() { return null; }				/// <summary>		/// Additional traits to apply to the managed view controllers.		/// </summary>		[iOSVersion(8)]		[Export("overrideTraitCollection")]		public UITraitCollection OverrideTraitCollection { get; set; }				/// <summary>		/// Notifies the presentation controller that layout is about to begin on the views of the container view.		/// </summary>		[iOSVersion(8)]		[Export("containerViewWillLayoutSubviews")]		public void ContainerViewWillLayoutSubviews() { }				/// <summary>		/// Called to notify the presentation controller that layout ended on the views of the container view.		/// </summary>		[iOSVersion(8)]		[Export("containerViewDidLayoutSubviews")]		public void ContainerViewDidLayoutSubviews() { }				/// <summary>		/// Notifies the presentation controller that the presentation animations are about to start.		/// </summary>		[iOSVersion(8)]		[Export("presentationTransitionWillBegin")]		public void PresentationTransitionWillBegin() { }				/// <summary>		/// Notifies the presentation controller that the presentation animations finished.		/// </summary>		/// <param name="completed">true if the animations completed and the presented view controller is now visible or false if the animations were canceled and the presenting view controller is still visible.</param>		[iOSVersion(8)]		[Export("presentationTransitionDidEnd")]		public void PresentationTransitionDidEnd(bool completed) { }				/// <summary>		/// Notifies the presentation controller that the dismissal animations are about to start.		/// </summary>		[iOSVersion(8)]		[Export("dismissalTransitionWillBegin")]		public void DismissalTransitionWillBegin() { }				/// <summary>		/// Notifies the presentation controller that the dismissal animations finished.		/// </summary>		/// <param name="completed">true if the animations completed and the presented view controller was dismissed or false if the animations were canceled and the presented view controller is still visible.</param>		[iOSVersion(8)]		[Export("dismissalTransitionDidEnd")]		public void DismissalTransitionDidEnd(bool completed) { }				/// <summary>		/// The preferred presentation style of the interface. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("presentationStyle")]		public UIModalPresentationStyle PresentationStyle { get; private set; }				/// <summary>		/// Returns the presentation style to use when the app’s size changes.		/// </summary>		/// <returns>The value provided by the presentation controller’s delegate or UIModalPresentationFullScreen if a delegate was not provided or does not return a valid value.</returns>		[iOSVersion(8)]		[Export("adaptivePresentationStyle")]		public UIModalPresentationStyle AdaptivePresentationStyle() { return null; }				/// <summary>		/// A Boolean value indicating whether the presentation covers the entire screen.		/// </summary>		/// <returns>true if the presentation covers the screen or false if it covers all or part of the current view controller only.</returns>		[iOSVersion(8)]		[Export("shouldPresentInFullscreen")]		public bool ShouldPresentInFullscreen() { return false; }				/// <summary>		/// A Boolean value indicating whether the presenting view controller’s view should be removed when the presentation animations finish.		/// </summary>		/// <returns>true if the view should be removed or false if it should not.</returns>		[iOSVersion(8)]		[Export("shouldRemovePresentersView")]		public bool ShouldRemovePresentersView() { return false; }				/// <summary>		/// The delegate object for managing adaptive presentations.		/// </summary>		[iOSVersion(8)]		[Export("delegate")]		public UIAdaptivePresentationControllerDelegate Delegate { get; set; }	}}