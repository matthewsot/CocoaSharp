using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// You use the UITabBarControllerDelegate protocol when you want to augment the behavior of a tab bar. In particular, you can use it to determine whether specific tabs should be selected, to perform actions after a tab is selected, or to perform actions before or after the user customizes the order of the tabs. After implementing these methods in your custom object, you should then assign that object to the delegate property of the corresponding UITabBarController object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITabBarControllerDelegate_Protocol/index.html#//apple_ref/occ/intf/UITabBarControllerDelegate"/>    [iOSVersion(2)]    public interface UITabBarControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Asks the delegate whether the specified view controller should be made active.        /// </summary>        /// <param name="tabBarController">The tab bar controller containing viewController.</param>        /// <param name="shouldSelectViewController">The view controller belonging to the tab that was tapped by the user.</param>        [iOSVersion(3)]        [Export("tabBarController")]        bool TabBarController(UITabBarController tabBarController, UIViewController shouldSelectViewController);                /// <summary>        /// Tells the delegate that the user selected an item in the tab bar.        /// </summary>        /// <param name="tabBarController">The tab bar controller containing viewController.</param>        /// <param name="didSelectViewController">The view controller that the user selected. In iOS v3.0 and later, this could be the same view controller that was already selected.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tabBarController")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void TabBarController(UITabBarController tabBarController, UIViewController didSelectViewController, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Tells the delegate that the tab bar customization sheet is about to be displayed.        /// </summary>        /// <param name="tabBarController">The tab bar controller that is being customized.</param>        /// <param name="willBeginCustomizingViewControllers">The view controllers to be displayed in the customization sheet. This list typically contains all custom view controllers you added but does not include some standard controllers, such as the one that manages the More tab.</param>        [iOSVersion(3)]        [Export("tabBarController")]        void TabBarController(UITabBarController tabBarController, AnyObject[] willBeginCustomizingViewControllers);                /// <summary>        /// Tells the delegate that the tab bar customization sheet is about to be dismissed.        /// </summary>        /// <param name="tabBarController">The tab bar controller that is being customized.</param>        /// <param name="willEndCustomizingViewControllers">The view controllers of the tab bar controller. The arrangement of the controllers in the array represents the new display order within the tab bar.</param>        /// <param name="changed">A Boolean value indicating whether items changed on the tab bar. true if items changed or false if they did not.</param>        [iOSVersion(3)]        [Export("tabBarController")]        void TabBarController(UITabBarController tabBarController, AnyObject[] willEndCustomizingViewControllers, bool changed);                /// <summary>        /// Tells the delegate that the tab bar customization sheet was dismissed.        /// </summary>        /// <param name="tabBarController">The tab bar controller that is being customized.</param>        /// <param name="didEndCustomizingViewControllers">The view controllers of the tab bar controller. The arrangement of the controllers in the array represents the new display order within the tab bar.</param>        /// <param name="changed">A Boolean value indicating whether items changed on the tab bar. true if items changed or false if they did not.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tabBarController")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void TabBarController(UITabBarController tabBarController, AnyObject[] didEndCustomizingViewControllers, bool changed, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Called to allow the delegate to provide the complete set of supported interface orientations for the tab bar controller.        /// </summary>        /// <param name="tabBarController">The tab bar controller that is asking the delegate object for the supported interface orientations.</param>        [iOSVersion(7)]        [Export("tabBarControllerSupportedInterfaceOrientations")]        int TabBarControllerSupportedInterfaceOrientations(UITabBarController tabBarController);                /// <summary>        /// Called to allow the delegate to provide the preferred orientation for presentation of the tab bar controller.        /// </summary>        /// <param name="tabBarController">The tab bar controller that is asking the delegate object for the preferred presentation orientation.</param>        [iOSVersion(7)]        [Export("tabBarControllerPreferredInterfaceOrientationForPresentation")]        UIInterfaceOrientation TabBarControllerPreferredInterfaceOrientationForPresentation(UITabBarController tabBarController);                /// <summary>        /// Called to allow the delegate to return a UIViewControllerAnimatedTransitioning delegate object for use during a noninteractive tab bar view controller transition.        /// </summary>        /// <param name="tabBarController">The tab bar controller whose view controller is transitioning.</param>        /// <param name="animationControllerForTransitionFromViewController">The currently visible view controller.</param>        /// <param name="toViewController">The view controller intended to be visible after the transition ends.</param>        [iOSVersion(7)]        [Export("tabBarController")]        UIViewControllerAnimatedTransitioning TabBarController(UITabBarController tabBarController, UIViewController animationControllerForTransitionFromViewController, UIViewController toViewController);                /// <summary>        /// Called to allow the delegate to return a UIViewControllerInteractiveTransitioning delegate object for use during an animated tab bar transition.        /// </summary>        /// <param name="tabBarController">The tab bar controller participating in the interactive, animated transition.</param>        /// <param name="interactionControllerForAnimationController">The noninteractive animation controller</param>        [iOSVersion(7)]        [Export("tabBarController")]        UIViewControllerInteractiveTransitioning TabBarController(UITabBarController tabBarController, UIViewControllerAnimatedTransitioning interactionControllerForAnimationController);    }}