using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UINavigationController_Class/index.html#//apple_ref/occ/cl/UINavigationController	/// <summary>	/// The UINavigationController class implements a specialized view controller that manages the navigation of hierarchical content. This navigation interface makes it possible to present your data efficiently and makes it easier for the user to navigate that content. You generally use this class as-is but in iOS 6 and later you may subclass to customize the class behavior.	/// </summary>	[iOSVersion(2)]	public class UINavigationController : UIViewController	{		/// <summary>		/// Initializes and returns a newly created navigation controller.		/// </summary>		/// <param name="rootViewController">The view controller that resides at the bottom of the navigation stack. This object cannot be an instance of the UITabBarController class.</param>		/// <returns>The initialized navigation controller object or nil if there was a problem initializing the object.</returns>		[iOSVersion(2)]		public UINavigationController(UIViewController rootViewController) { }				/// <summary>		/// Initializes and returns a newly created navigation controller that uses your custom bar subclasses.		/// </summary>		/// <param name="navigationBarClass">Specify the custom UINavigationBar subclass you want to use, or specify nil to use the standard UINavigationBar class.</param>		/// <param name="toolbarClass">Specify the custom UIToolbar subclass you want to use, or specify nil to use the standard UIToolbar class.</param>		/// <returns>The initialized navigation controller object or nil if there was a problem initializing the object.</returns>		[iOSVersion(5)]		public UINavigationController(AnyClass navigationBarClass, AnyClass toolbarClass) { }				/// <summary>		/// The view controller at the top of the navigation stack. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("topViewController")]		public UIViewController TopViewController { get; private set; }				/// <summary>		/// The view controller associated with the currently visible view in the navigation interface. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("visibleViewController")]		public UIViewController VisibleViewController { get; private set; }				/// <summary>		/// The view controllers currently on the navigation stack.		/// </summary>		[iOSVersion(2)]		[Export("viewControllers")]		public AnyObject[] ViewControllers { get; set; }				/// <summary>		/// Replaces the view controllers currently managed by the navigation controller with the specified items.		/// </summary>		/// <param name="viewControllers">The view controllers to place in the stack. The front-to-back order of the controllers in this array represents the new bottom-to-top order of the controllers in the navigation stack. Thus, the last item added to the array becomes the top item of the navigation stack.</param>		/// <param name="animated">If true, animate the pushing or popping of the top view controller. If false, replace the view controllers without any animations.</param>		[iOSVersion(3)]		[Export("setViewControllers")]		public void SetViewControllers(AnyObject[] viewControllers, bool animated) { }				/// <summary>		/// Pushes a view controller onto the receiver’s stack and updates the display.		/// </summary>		/// <param name="viewController">The view controller to push onto the stack. This object cannot be a tab bar controller. If the view controller is already on the navigation stack, this method throws an exception.</param>		/// <param name="animated">Specify true to animate the transition or false if you do not want the transition to be animated. You might specify false if you are setting up the navigation controller at launch time.</param>		[iOSVersion(2)]		[Export("pushViewController")]		public void PushViewController(UIViewController viewController, bool animated) { }				/// <summary>		/// Pops the top view controller from the navigation stack and updates the display.		/// </summary>		/// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>		/// <returns>The view controller that was popped from the stack.</returns>		[iOSVersion(2)]		[Export("popViewControllerAnimated")]		public UIViewController PopViewControllerAnimated(bool animated) { return null; }				/// <summary>		/// Pops all the view controllers on the stack except the root view controller and updates the display.		/// </summary>		/// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>		/// <returns>An array of view controllers representing the items that were popped from the stack.</returns>		[iOSVersion(2)]		[Export("popToRootViewControllerAnimated")]		public AnyObject[] PopToRootViewControllerAnimated(bool animated) { return null; }				/// <summary>		/// Pops view controllers until the specified view controller is at the top of the navigation stack.		/// </summary>		/// <param name="viewController">The view controller that you want to be at the top of the stack. This view controller must currently be on the navigation stack.</param>		/// <param name="animated">Set this value to true to animate the transition. Pass false if you are setting up a navigation controller before its view is displayed.</param>		/// <returns>An array containing the view controllers that were popped from the stack.</returns>		[iOSVersion(2)]		[Export("popToViewController")]		public AnyObject[] PopToViewController(UIViewController viewController, bool animated) { return null; }				/// <summary>		/// The gesture recognizer responsible for popping the top view controller off the navigation stack. (read-only)		/// </summary>		[iOSVersion(7)]		[Export("interactivePopGestureRecognizer")]		public UIGestureRecognizer interactivePopGestureRecognizer { get; private set; }				/// <summary>		/// The navigation bar managed by the navigation controller. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("navigationBar")]		public UINavigationBar NavigationBar { get; private set; }				/// <summary>		/// Sets whether the navigation bar is hidden.		/// </summary>		/// <param name="hidden">Specify true to hide the navigation bar or false to show it.</param>		/// <param name="animated">Specify true if you want to animate the change in visibility or false if you want the navigation bar to appear immediately.</param>		[iOSVersion(2)]		[Export("setNavigationBarHidden")]		public void SetNavigationBarHidden(bool hidden, bool animated) { }				/// <summary>		/// A Boolean value indicating whether the navigation controller allows hiding of its bars using a tap gesture.		/// </summary>		[iOSVersion(8)]		[Export("hidesBarsOnTap")]		public bool HidesBarsOnTap { get; set; }				/// <summary>		/// A Boolean value indicating whether the navigation controller hides its bars in a vertically compact environment.		/// </summary>		[iOSVersion(8)]		[Export("hidesBarsWhenVerticallyCompact")]		public bool HidesBarsWhenVerticallyCompact { get; set; }				/// <summary>		/// A Boolean value that indicates whether the navigation bar is hidden.		/// </summary>		[iOSVersion(2)]		[Export("navigationBarHidden")]		public bool NavigationBarHidden { get; set; }				/// <summary>		/// The gesture recognizer used to hide and show the navigation and toolbar. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("barHideGestureRecognizer")]		public UITapGestureRecognizer BarHideGestureRecognizer { get; private set; }				/// <summary>		/// A Boolean value indicating whether the navigation bar allows the height of its bars to be reduced in response to a swipe gesture.		/// </summary>		[iOSVersion(8)]		[Export("condensesBarsOnSwipe")]		public bool CondensesBarsOnSwipe { get; set; }				/// <summary>		/// A Boolean value indicating whether the navigation controller condenses its bars when the keyboard appears.		/// </summary>		[iOSVersion(8)]		[Export("condensesBarsWhenKeyboardAppears")]		public bool CondensesBarsWhenKeyboardAppears { get; set; }				/// <summary>		/// A Boolean value indicating whether the navigation bar is currently condensed.		/// </summary>		[iOSVersion(8)]		[Export("navigationBarCondensed")]		public bool NavigationBarCondensed { get; set; }				/// <summary>		/// The gesture recognizer used to condense and expand the navigation bar and toolbar. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("barCondenseGestureRecognizer")]		public UIPanGestureRecognizer BarCondenseGestureRecognizer { get; private set; }				/// <summary>		/// The delegate of the navigation controller object.		/// </summary>		[iOSVersion(2)]		[Export("delegate")]		public UINavigationControllerDelegate Delegate { get; set; }				/// <summary>		/// The custom toolbar associated with the navigation controller. (read-only)		/// </summary>		[iOSVersion(3)]		[Export("toolbar")]		public UIToolbar Toolbar { get; private set; }				/// <summary>		/// Changes the visibility of the navigation controller’s built-in toolbar.		/// </summary>		/// <param name="hidden">Specify true to hide the toolbar or false to show it.</param>		/// <param name="animated">Specify true if you want the toolbar to be animated on or off the screen.</param>		[iOSVersion(3)]		[Export("setToolbarHidden")]		public void SetToolbarHidden(bool hidden, bool animated) { }				/// <summary>		/// A Boolean indicating whether the navigation controller’s built-in toolbar is visible.		/// </summary>		[iOSVersion(3)]		[Export("toolbarHidden")]		public bool ToolbarHidden { get; set; }				/// <summary>		/// Presents the specified view controller in the navigation interface.		/// </summary>		/// <param name="vc">The view controller to display.</param>		/// <param name="sender">The object that made the request to show the view controller.</param>		[iOSVersion(8)]		[Export("showViewController")]		public void ShowViewController(UIViewController vc, AnyObject sender) { }				/// <summary>		/// A global constant that specifies a preferred duration when animating the navigation bar.		/// </summary>		[Export("UINavigationControllerHideShowBarDuration")]		public CGFloat UINavigationControllerHideShowBarDuration { get; private set; }	}}