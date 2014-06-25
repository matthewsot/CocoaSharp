using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITabBarController_Class/index.html#//apple_ref/occ/cl/UITabBarController	/// <summary>	/// The UITabBarController class implements a specialized view controller that manages a radio-style selection interface. This tab bar interface displays tabs at the bottom of the window for selecting between the different modes and for displaying the views for that mode. This class is generally used as-is but may be subclassed in iOS 6 and later.	/// </summary>	[iOSVersion(2)]	public class UITabBarController : UIViewController	{		/// <summary>		/// The tab bar controller’s delegate object.		/// </summary>		[iOSVersion(2)]		[Export("delegate")]		public UITabBarControllerDelegate Delegate { get; set; }				/// <summary>		/// The tab bar view associated with this controller. (read-only)		/// </summary>		[iOSVersion(3)]		[Export("tabBar")]		public UITabBar TabBar { get; private set; }				/// <summary>		/// An array of the root view controllers displayed by the tab bar interface.		/// </summary>		[iOSVersion(2)]		[Export("viewControllers")]		public AnyObject[] ViewControllers { get; set; }				/// <summary>		/// Sets the root view controllers of the tab bar controller.		/// </summary>		/// <param name="viewControllers">The array of custom view controllers to display in the tab bar interface. The order of the view controllers in this array corresponds to the display order in the tab bar, with the controller at index 0 representing the left-most tab, the controller at index 1 the next tab to the right, and so on.</param>		/// <param name="animated">If true, the tab bar items for the view controllers are animated into position. If false, changes to the tab bar items are reflected immediately.</param>		[iOSVersion(2)]		[Export("setViewControllers")]		public void SetViewControllers(AnyObject[] viewControllers, bool animated) { }				/// <summary>		/// The subset of view controllers managed by this tab bar controller that can be customized.		/// </summary>		[iOSVersion(2)]		[Export("customizableViewControllers")]		public AnyObject[] CustomizableViewControllers { get; set; }				/// <summary>		/// The view controller that manages the More navigation interface. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("moreNavigationController")]		public UINavigationController MoreNavigationController { get; private set; }				/// <summary>		/// The view controller associated with the currently selected tab item.		/// </summary>		[iOSVersion(2)]		[Export("selectedViewController")]		public UIViewController SelectedViewController { get; set; }				/// <summary>		/// The index of the view controller associated with the currently selected tab item.		/// </summary>		[iOSVersion(2)]		[Export("selectedIndex")]		public int SelectedIndex { get; set; }	}}