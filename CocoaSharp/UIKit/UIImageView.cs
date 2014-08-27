using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// An image view object provides a view-based container for displaying either a single image or for animating a series of images. For animating the images, the UIImageView class provides controls to set the duration and frequency of the animation. You can also start and stop the animation freely.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIImageView_Class/index.html#//apple_ref/occ/cl/UIImageView"/>    [iOSVersion(2)]    public class UIImageView : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Returns an image view initialized with the specified image.        /// </summary>        /// <param name="image">The initial image to display in the image view.</param>        [iOSVersion(2)]        public UIImageView(UIImage image) : base(new CGRect()) { }                /// <summary>        /// Returns an image view initialized with the specified regular and highlighted images.        /// </summary>        /// <param name="image">The initial image to display in the image view.</param>        /// <param name="highlightedImage">The image to display if the image view is highlighted.</param>        [iOSVersion(3)]        public UIImageView(UIImage image, UIImage highlightedImage) : base(new CGRect()) { }                /// <summary>        /// Starts animating the images in the receiver.        /// </summary>        [iOSVersion(2)]        [Export("startAnimating")]        public void StartAnimating() {  }                /// <summary>        /// Stops animating the images in the receiver.        /// </summary>        [iOSVersion(2)]        [Export("stopAnimating")]        public void StopAnimating() {  }                /// <summary>        /// Returns a Boolean value indicating whether the animation is running.        /// </summary>        [iOSVersion(2)]        [Export("isAnimating")]        public bool IsAnimating() { return default(bool); }                /// <summary>        /// The image displayed in the image view.        /// </summary>        [iOSVersion(2)]        [Export("image")]        public UIImage Image { get; set; }                /// <summary>        /// The highlighted image displayed in the image view.        /// </summary>        [iOSVersion(3)]        [Export("highlightedImage")]        public UIImage HighlightedImage { get; set; }                /// <summary>        /// An array of UIImage objects to use for an animation.        /// </summary>        [iOSVersion(2)]        [Export("animationImages")]        public AnyObject[] AnimationImages { get; set; }                /// <summary>        /// An array of UIImage objects to use for an animation when the view is highlighted.        /// </summary>        [iOSVersion(3)]        [Export("highlightedAnimationImages")]        public AnyObject[] HighlightedAnimationImages { get; set; }                /// <summary>        /// The amount of time it takes to go through one cycle of the images.        /// </summary>        [iOSVersion(2)]        [Export("animationDuration")]        public NSTimeInterval AnimationDuration { get; set; }                /// <summary>        /// Specifies the number of times to repeat the animation.        /// </summary>        [iOSVersion(2)]        [Export("animationRepeatCount")]        public int AnimationRepeatCount { get; set; }                /// <summary>        /// A Boolean value that determines whether user events are ignored and removed from the event queue.        /// </summary>        [iOSVersion(2)]        [Export("userInteractionEnabled")]        public bool UserInteractionEnabled { get; set; }                /// <summary>        /// A Boolean value that determines whether the image is highlighted.        /// </summary>        [iOSVersion(3)]        [Export("highlighted")]        public bool Highlighted { get; set; }                /// <summary>        /// A color used to tint template images in the view hierarchy.        /// </summary>        [iOSVersion(7)]        [Export("tintColor")]        public UIColor TintColor { get; set; }    }}