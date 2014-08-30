using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The methods of the UIPopoverPresentationControllerDelegate protocol let you customize the behavior of a popover-based presentation. A popover presentation controller notifies your delegate at appropriate points during the presentation process. You can use the delegate methods to customize this process and respond to changes dynamically.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPopoverPresentationControllerDelegate_protocol/index.html#//apple_ref/occ/intf/UIPopoverPresentationControllerDelegate"/>    [iOSVersion(8)]    public interface UIPopoverPresentationControllerDelegate//: NSObjectProtocol, UIAdaptivePresentationControllerDelegate    {        /// <summary>        /// Notifies the delegate that the popover is about to be presented.        /// </summary>        /// <param name="popoverPresentationController">The popover presentation controller that is about to display the popover.</param>        //[iOSVersion(8)]        //[Export("prepareForPopoverPresentation")]        //[Optional]        //void PrepareForPopoverPresentation(UIPopoverPresentationController popoverPresentationController);                /// <summary>        /// Asks the delegate if the popover should be dismissed.        /// </summary>        /// <param name="popoverPresentationController">The popover presentation controller that is managing the popover interface.</param>        //[iOSVersion(8)]        //[Export("popoverPresentationControllerShouldDismissPopover")]        //[Optional]        //bool PopoverPresentationControllerShouldDismissPopover(UIPopoverPresentationController popoverPresentationController);                /// <summary>        /// Tells the delegate that the popover was dismissed.        /// </summary>        /// <param name="popoverPresentationController">The popover presentation controller that is managing the popover interface.</param>        //[iOSVersion(8)]        //[Export("popoverPresentationControllerDidDismissPopover")]        //[Optional]        //void PopoverPresentationControllerDidDismissPopover(UIPopoverPresentationController popoverPresentationController);                /// <summary>        /// Tells the delegate that UIKit needs to reposition the popover’s location.        /// </summary>        /// <param name="popoverPresentationController">The popover presentation controller that is managing the popover interface.</param>        /// <param name="willRepositionPopoverToRect">On input, the new rectangle for the popover. This popover is in the coordinate space of the view in the view parameter. If you want to propose a different rectangle for the popover, put the new value in this parameter.</param>        /// <param name="inView">On input, the new view for containing the popover. If you want to propose a different view for the popover, put that view in this parameter</param>        //[iOSVersion(8)]        //[Export("popoverPresentationController")]        //[Optional]        //void PopoverPresentationController(UIPopoverPresentationController popoverPresentationController, UnsafeMutablePointer<CGRect> willRepositionPopoverToRect, AutoreleasingUnsafeMutablePointer<Optional<UIView>> inView);    }}