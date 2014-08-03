using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// UIBarItem is an abstract superclass for items added to a bar that appears at the bottom of the screen. Items on a bar behave in a way similar to buttons (instances of UIButton). They have a title, image, action, and target. You can also enable and disable an item on a bar.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIBarItem_Class/index.html#//apple_ref/occ/cl/UIBarItem"/>    [iOSVersion(2)]    public class UIBarItem : NSObject//, AnyObject, NSObjectProtocol, UIAccessibilityIdentification, UIAppearance    {        /// <summary>        /// Sets the title’s text attributes for a given control state.        /// </summary>        /// <param name="attributes">A dictionary containing key-value pairs for text attributes.        ///   You can specify the font, text color, text shadow color, and text shadow offset using the keys listed in NSString UIKit Additions Reference.</param>        /// <param name="forState">The control state for which you want to set the text attributes for the title.</param>        [iOSVersion(5)]        [Export("setTitleTextAttributes")]        public void SetTitleTextAttributes(Dictionary<NSObject, AnyObject> attributes, UIControlState forState) {  }                /// <summary>        /// Returns the title’s text attributes for a given control state.        /// </summary>        /// <param name="state">The control state for which you want to know the text attributes for the title.</param>        [iOSVersion(5)]        [Export("titleTextAttributesForState")]        public Dictionary<NSObject, AnyObject> TitleTextAttributesForState(UIControlState state) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// A Boolean value indicating whether the item is enabled.        /// </summary>        [iOSVersion(2)]        [Export("enabled")]        public bool Enabled { get; set; }                /// <summary>        /// The image used to represent the item.        /// </summary>        [iOSVersion(2)]        [Export("image")]        public UIImage Image { get; set; }                /// <summary>        /// The image to use to represent the item in landscape orientation when using the iPhone appearance idiom.        /// </summary>        [iOSVersion(5)]        [Export("landscapeImagePhone")]        public UIImage LandscapeImagePhone { get; set; }                /// <summary>        /// The image inset or outset for each edge.        /// </summary>        [iOSVersion(2)]        [Export("imageInsets")]        public UIEdgeInsets ImageInsets { get; set; }                /// <summary>        /// The image inset or outset for each edge of the image in landscape orientation when using the iPhone appearance idiom.        /// </summary>        [iOSVersion(5)]        [Export("landscapeImagePhoneInsets")]        public UIEdgeInsets LandscapeImagePhoneInsets { get; set; }                /// <summary>        /// The title displayed on the item.        /// </summary>        [iOSVersion(2)]        [Export("title")]        public string Title { get; set; }                /// <summary>        /// The receiver’s tag, an application-supplied integer that you can use to identify bar item objects in your application.        /// </summary>        [iOSVersion(2)]        [Export("tag")]        public int Tag { get; set; }    }}