using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UINavigationBar class provides a control for navigating hierarchical content. It’s a bar, typically displayed at the top of the screen, containing buttons for navigating within a hierarchy of screens. The primary properties are a left (back) button, a center title, and an optional right button. You can use a navigation bar as a standalone object or in conjunction with a navigation controller object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UINavigationBar_Class/index.html#//apple_ref/occ/cl/UINavigationBar"/>    [iOSVersion(2)]    public class UINavigationBar : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UIBarPositioning, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Pushes the given navigation item onto the receiver’s stack and updates the navigation bar.        /// </summary>        /// <param name="item">The navigation item to push on the stack.</param>        /// <param name="animated">true if the navigation bar should be animated; otherwise, false.</param>        [iOSVersion(2)]        [Export("pushNavigationItem")]        public void PushNavigationItem(UINavigationItem item, bool animated) {  }                /// <summary>        /// Pops the top item from the receiver’s stack and updates the navigation bar.        /// </summary>        /// <param name="animated">true if the navigation bar should be animated; otherwise, false.</param>        [iOSVersion(2)]        [Export("popNavigationItemAnimated")]        public UINavigationItem PopNavigationItemAnimated(bool animated) { return default(UINavigationItem); }                /// <summary>        /// Replaces the navigation items currently managed by the navigation bar with the specified items.        /// </summary>        /// <param name="items">The UINavigationItem objects to place in the stack. The front-to-back order of the items in this array represents the new bottom-to-top order of the items in the navigation stack. Thus, the last item added to the array becomes the top item of the navigation stack.</param>        /// <param name="animated">If true, animate the pushing or popping of the top stack item. If false, replace the stack items without any animations.</param>        [iOSVersion(3)]        [Export("setItems")]        public void SetItems(AnyObject[] items, bool animated) {  }                /// <summary>        /// Returns the background image for given bar metrics.        /// </summary>        /// <param name="barMetrics">A bar metrics constant.</param>        [iOSVersion(5)]        [Export("backgroundImageForBarMetrics")]        public UIImage BackgroundImageForBarMetrics(UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the background image for given bar metrics.        /// </summary>        /// <param name="backgroundImage">The background image to use for barMetrics.</param>        /// <param name="forBarMetrics">A bar metrics constant.</param>        [iOSVersion(5)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// Returns the background image to use for a given bar position and set of metrics.        /// </summary>        /// <param name="barPosition">The location of the navigation bar.</param>        /// <param name="barMetrics">The metrics of the navigation bar.</param>        [iOSVersion(7)]        [Export("backgroundImageForBarPosition")]        public UIImage BackgroundImageForBarPosition(UIBarPosition barPosition, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the background image to use for a given bar position and set of metrics.        /// </summary>        /// <param name="backgroundImage">The image to use for the specified location and metrics.</param>        /// <param name="forBarPosition">The location of the navigation bar.</param>        /// <param name="barMetrics">The metrics of the navigation bar.</param>        [iOSVersion(7)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIBarPosition forBarPosition, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the title’s vertical position adjustment for given bar metrics.        /// </summary>        /// <param name="barMetrics">A bar metrics constant.</param>        [iOSVersion(5)]        [Export("titleVerticalPositionAdjustmentForBarMetrics")]        public CGFloat TitleVerticalPositionAdjustmentForBarMetrics(UIBarMetrics barMetrics) { return default(CGFloat); }                /// <summary>        /// Sets the title’s vertical position adjustment for given bar metrics.        /// </summary>        /// <param name="adjustment">The title’s vertical position adjustment for barMetrics.</param>        /// <param name="forBarMetrics">A bar metrics constant.</param>        [iOSVersion(5)]        [Export("setTitleVerticalPositionAdjustment")]        public void SetTitleVerticalPositionAdjustment(CGFloat adjustment, UIBarMetrics forBarMetrics) {  }                /// <summary>        /// The navigation bar’s delegate object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public UINavigationBarDelegate Delegate { get; set; }                /// <summary>        /// An array of navigation items managed by the navigation bar.        /// </summary>        [iOSVersion(2)]        [Export("items")]        public AnyObject[] Items { get; set; }                /// <summary>        /// The navigation item at the top of the navigation bar’s stack. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("topItem")]        public UINavigationItem TopItem { get; private set; }                /// <summary>        /// The navigation item that is immediately below the topmost item on navigation bar’s stack. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("backItem")]        public UINavigationItem BackItem { get; private set; }                /// <summary>        /// The image shown beside the back button.        /// </summary>        [iOSVersion(7)]        [Export("backIndicatorImage")]        public UIImage BackIndicatorImage { get; set; }                /// <summary>        /// The image used as a mask for content during push and pop transitions.        /// </summary>        [iOSVersion(7)]        [Export("backIndicatorTransitionMaskImage")]        public UIImage BackIndicatorTransitionMaskImage { get; set; }                /// <summary>        /// The navigation bar style that specifies its appearance.        /// </summary>        [iOSVersion(2)]        [Export("barStyle")]        public UIBarStyle BarStyle { get; set; }                /// <summary>        /// The tint color to apply to the navigation bar background.        /// </summary>        [iOSVersion(7)]        [Export("barTintColor")]        public UIColor BarTintColor { get; set; }                /// <summary>        /// The shadow image to be used for the navigation bar.        /// </summary>        [iOSVersion(6)]        [Export("shadowImage")]        public UIImage ShadowImage { get; set; }                /// <summary>        /// The tint color to apply to the navigation items and bar button items.        /// </summary>        [iOSVersion(2)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// A Boolean value indicating whether the navigation bar is translucent (true) or not (false).        /// </summary>        [iOSVersion(3)]        [Export("translucent")]        public bool Translucent { get; set; }                /// <summary>        /// Display attributes for the bar’s title text.        /// </summary>        [iOSVersion(5)]        [Export("titleTextAttributes")]        public Dictionary<NSObject, AnyObject> TitleTextAttributes { get; set; }    }}