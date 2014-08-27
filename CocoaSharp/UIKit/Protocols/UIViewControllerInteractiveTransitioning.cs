using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// To enable an object (such as a navigation controller) to drive a view controller transition, configure a custom class to adopt the UIViewControllerInteractiveTransitioning protocol. An object that supports this protocol is called an interactive transition delegate.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIViewControllerInteractiveTransitioning_protocol/index.html#//apple_ref/occ/intf/UIViewControllerInteractiveTransitioning"/>    [iOSVersion(7)]    public interface UIViewControllerInteractiveTransitioning//: NSObjectProtocol    {        /// <summary>        /// Called when the system needs to set up the interactive portions of a view controller transition and start the animations. (required)        /// </summary>        /// <param name="transitionContext">The context object containing information about the transition.</param>        [iOSVersion(7)]        [Export("startInteractiveTransition")]        void StartInteractiveTransition(UIViewControllerContextTransitioning transitionContext);                /// <summary>        /// Called when the system needs the animation completion curve for an interactive view controller transition.        /// </summary>        [iOSVersion(7)]        [Export("completionCurve")]        UIViewAnimationCurve CompletionCurve();                /// <summary>        /// Called when the system needs the speed at which to complete an interactive transition, after the interactive portion is finished.        /// </summary>        [iOSVersion(7)]        [Export("completionSpeed")]        CGFloat CompletionSpeed();    }}