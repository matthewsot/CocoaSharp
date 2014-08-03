using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A tab bar is a control, usually appearing across the bottom of the screen in the context of a tab bar controller, for giving the user one-tap, modal access to a set of views in an app. Each button in a tab bar is called a tab bar item and is an instance of the UITabBarItem class.  If you instead want to give the user a bar of buttons that each perform an action, use a UIToolbar object.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITabBar_Class/index.html#//apple_ref/occ/cl/UITabBar"/>    [iOSVersion(2)]    public class UITabBar : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Sets the items on the tab bar, with or without animation.        /// </summary>        /// <param name="items">The items to display on the tab bar.</param>        /// <param name="animated">If true, animates the transition to the items; otherwise, does not.</param>        [iOSVersion(2)]        [Export("setItems")]        public void SetItems(AnyObject[] items, bool animated) {  }                /// <summary>        /// Presents a modal view allowing the user to customize the tab bar by adding, removing, and rearranging items on the tab bar.        /// </summary>        /// <param name="items">The items to display on the modal view that can be rearranged.        ///   The items parameter should contain all items that can be added to the tab bar. Visible items not in items are fixed in place—they can not be removed or replaced by the user.</param>        [iOSVersion(2)]        [Export("beginCustomizingItems")]        public void BeginCustomizingItems(AnyObject[] items) {  }                /// <summary>        /// Dismisses the modal view used to modify items on the tab bar.        /// </summary>        /// <param name="animated">If true, animates the transition; otherwise, does not.</param>        [iOSVersion(2)]        [Export("endCustomizingAnimated")]        public bool EndCustomizingAnimated(bool animated) { return default(bool); }                /// <summary>        /// Returns a Boolean value indicating whether the user is customizing the tab bar.        /// </summary>        [iOSVersion(2)]        [Export("isCustomizing")]        public bool IsCustomizing() { return default(bool); }                /// <summary>        /// The tab bar’s delegate object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public UITabBarDelegate Delegate { get; set; }                /// <summary>        /// The items displayed on the tab bar.        /// </summary>        [iOSVersion(2)]        [Export("items")]        public AnyObject[] Items { get; set; }                /// <summary>        /// The currently selected item on the tab bar.        /// </summary>        [iOSVersion(2)]        [Export("selectedItem")]        public UITabBarItem SelectedItem { get; set; }                /// <summary>        /// The tab bar style that specifies its appearance.        /// </summary>        [iOSVersion(7)]        [Export("barStyle")]        public UIBarStyle BarStyle { get; set; }                /// <summary>        /// The tint color to apply to the tab bar background.        /// </summary>        [iOSVersion(7)]        [Export("barTintColor")]        public UIColor BarTintColor { get; set; }                /// <summary>        /// The positioning scheme for the tab bar items in the tab bar.        /// </summary>        [iOSVersion(7)]        [Export("itemPositioning")]        public UITabBarItemPositioning ItemPositioning { get; set; }                /// <summary>        /// The custom inter-item spacing for tab bar items, in points, when using centered-style positioning.        /// </summary>        [iOSVersion(7)]        [Export("itemSpacing")]        public CGFloat ItemSpacing { get; set; }                /// <summary>        /// The custom item width for tab bar items, in points, when using centered-style positioning.        /// </summary>        [iOSVersion(7)]        [Export("itemWidth")]        public CGFloat ItemWidth { get; set; }                /// <summary>        /// The tint color to apply to the tab bar’s tab bar items.        /// </summary>        [iOSVersion(5)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// The tint color applied to the selected tab bar item.        /// </summary>        [iOSVersion(5)]        [Export("selectedImageTintColor")]        public UIColor SelectedImageTintColor { get; set; }                /// <summary>        /// A Boolean value that indicates whether the tab bar is translucent (true) or not (false).        /// </summary>        [iOSVersion(7)]        [Export("translucent")]        public bool Translucent { get; set; }                /// <summary>        /// The background image for the tab bar.        /// </summary>        [iOSVersion(5)]        [Export("backgroundImage")]        public UIImage BackgroundImage { get; set; }                /// <summary>        /// The shadow image to be used for the tab bar.        /// </summary>        [iOSVersion(6)]        [Export("shadowImage")]        public UIImage ShadowImage { get; set; }                /// <summary>        /// The image used for the selection indicator.        /// </summary>        [iOSVersion(5)]        [Export("selectionIndicatorImage")]        public UIImage SelectionIndicatorImage { get; set; }    }    /// <summary>    /// Constants that specify tab bar item positioning.    /// </summary>    [iOSVersion(7)]    public enum UITabBarItemPositioning    {        /// <summary>        /// Specifies automatic tab bar item positioning according to the user interface idiom, as follows:        /// </summary>        [iOSVersion(7)]        Automatic,        /// <summary>        /// Default tab bar item positioning on iPhone. Specifies that tab bar items should be distributed to fill the width of the tab bar.        /// </summary>        [iOSVersion(7)]        Fill,        /// <summary>        /// Default tab bar item positioning on iPad. Specifies that tab bar items should be positioned closely adjacent to each other with a default width and inter-item spacing (customizable with the itemWidth and itemSpacing properties). The group of tab bar items is centered in the tab bar, potentially leaving space in the tab bar at its left and right edges.        /// </summary>        [iOSVersion(7)]        Centered,    }}