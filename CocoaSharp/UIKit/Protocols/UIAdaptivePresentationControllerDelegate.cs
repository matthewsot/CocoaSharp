using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIAdaptivePresentationControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UIAdaptivePresentationControllerDelegate	/// <summary>	/// An object that conforms to the UIAdaptivePresentationControllerDelegate protocol works with a presentation controller to determine how to respond to size changes in your app. The delegate object is consulted only for presentations that use the UIModalPresentationFormSheet, UIModalPresentationPopover, or UIModalPresentationCustom style. Your delegate can suggest both a new full-screen presentation style and an entirely new view controller for the content.	/// </summary>	[iOSVersion(8)]	public interface UIAdaptivePresentationControllerDelegate	{		/// <summary>		/// Asks the delegate for the new presentation style to use.		/// </summary>		/// <param name="controller">The presentation controller that is managing the size change. Use this object to retrieve the view controllers involved in the presentation.</param>		/// <returns>The new presentation style, which must be either UIModalPresentationFullScreen or UIModalPresentationOverFullScreen.</returns>		[iOSVersion(8)]		[Export("adaptivePresentationStyleForPresentationController")]		[Optional]		UIModalPresentationStyle AdaptivePresentationStyleForPresentationController(UIPresentationController controller);				/// <summary>		/// Asks the delegate for the view controller to use when adapting from the specified presentation style.		/// </summary>		/// <param name="controller">The presentation controller that is managing the size class change.</param>		/// <param name="viewControllerForAdaptivePresentationStyle">The new presentation style being employed for the view controller.</param>		/// <returns>The view controller to display in place of the existing presented view controller.</returns>		[iOSVersion(8)]		[Export("presentationController")]		[Optional]		UIViewController PresentationController(UIPresentationController controller, UIModalPresentationStyle viewControllerForAdaptivePresentationStyle);	}}