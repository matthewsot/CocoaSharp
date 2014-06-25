using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPopoverPresentationController_class/index.html#//apple_ref/occ/cl/UIPopoverPresentationController	/// <summary>	/// A UIPopoverPresentationController object manages the display of content in a popover. From the time a popover is presented until the time it is dismissed, UIKit uses an instance of this class to manage the presentation behavior. You use instances of this class as-is to configure aspects of the popover appearance and behavior for view controllers whose presentation style is set to UIModalPresentationPopover.	/// </summary>	[iOSVersion(8)]	public class UIPopoverPresentationController : UIPresentationController	{		/// <summary>		/// The size of the popover’s content view.		/// </summary>		[iOSVersion(8)]		[Export("popoverContentSize")]		public CGSize PopoverContentSize { get; set; }				/// <summary>		/// The margins that define the portion of the screen in which it is permissible to display the popover.		/// </summary>		[iOSVersion(8)]		[Export("popoverLayoutMargins")]		public UIEdgeInsets PopoverLayoutMargins { get; set; }				/// <summary>		/// The color of the popover’s backdrop view.		/// </summary>		[iOSVersion(8)]		[Export("backgroundColor")]		public UIColor BackgroundColor { get; set; }				/// <summary>		/// An array of views that the user can interact with while the popover is visible.		/// </summary>		[iOSVersion(8)]		[Export("passthroughViews")]		public AnyObject[] PassthroughViews { get; set; }				/// <summary>		/// The class to use for displaying the popover background content.		/// </summary>		[iOSVersion(8)]		[Export("popoverBackgroundViewClass")]		public AnyObject.Type PopoverBackgroundViewClass { get; set; }				/// <summary>		/// The bar button item on which to anchor the popover.		/// </summary>		[iOSVersion(8)]		[Export("barButtonItem")]		public UIBarButtonItem BarButtonItem { get; set; }				/// <summary>		/// The view containing the anchor rectangle for the popover.		/// </summary>		[iOSVersion(8)]		[Export("sourceView")]		public UIView SourceView { get; set; }				/// <summary>		/// The rectangle in the specified view in which to anchor the popover.		/// </summary>		[iOSVersion(8)]		[Export("sourceRect")]		public CGRect SourceRect { get; set; }				/// <summary>		/// The delegate that handles popover-related messages.		/// </summary>		[iOSVersion(8)]		[Export("delegate")]		public UIPopoverPresentationControllerDelegate Delegate { get; set; }				/// <summary>		/// The arrow directions that you prefer for the popover.		/// </summary>		[iOSVersion(8)]		[Export("permittedArrowDirections")]		public UIPopoverArrowDirection PermittedArrowDirections { get; set; }				/// <summary>		/// The arrow direction in use by the popover. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("arrowDirection")]		public UIPopoverArrowDirection ArrowDirection { get; private set; }	}}