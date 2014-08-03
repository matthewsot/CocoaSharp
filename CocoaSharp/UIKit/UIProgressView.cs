using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// You use the UIProgressView class to depict the progress of a task over time. An example of a progress bar is the one shown at the bottom of the Mail application when it’s downloading messages.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIProgressView_Class/index.html#//apple_ref/occ/cl/UIProgressView"/>    [iOSVersion(2)]    public class UIProgressView : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Initializes and returns an progress-view object.        /// </summary>        /// <param name="progressViewStyle">A constant that specifies the style of the object to be created. See UIProgressViewStyle for descriptions of the style constants.</param>        [iOSVersion(2)]        public UIProgressView(UIProgressViewStyle progressViewStyle) { }                /// <summary>        /// Adjusts the current progress shown by the receiver, optionally animating the change.        /// </summary>        /// <param name="progress">The new progress value.</param>        /// <param name="animated">true if the change should be animated, false if the change should happen immediately.</param>        [iOSVersion(5)]        [Export("setProgress")]        public void SetProgress(float progress, bool animated) {  }                /// <summary>        /// The current progress shown by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("progress")]        public float Progress { get; set; }                /// <summary>        /// The current graphical style of the receiver.        /// </summary>        [iOSVersion(2)]        [Export("progressViewStyle")]        public UIProgressViewStyle ProgressViewStyle { get; set; }                /// <summary>        /// The color shown for the portion of the progress bar that is filled.        /// </summary>        [iOSVersion(5)]        [Export("progressTintColor")]        public UIColor ProgressTintColor { get; set; }                /// <summary>        /// An image to use for the portion of the progress bar that is filled.        /// </summary>        [iOSVersion(5)]        [Export("progressImage")]        public UIImage ProgressImage { get; set; }                /// <summary>        /// The color shown for the portion of the progress bar that is not filled.        /// </summary>        [iOSVersion(5)]        [Export("trackTintColor")]        public UIColor TrackTintColor { get; set; }                /// <summary>        /// An image to use for the portion of the track that is not filled.        /// </summary>        [iOSVersion(5)]        [Export("trackImage")]        public UIImage TrackImage { get; set; }    }    /// <summary>    /// The styles permitted for the progress bar.    /// </summary>    [iOSVersion(2)]    public enum UIProgressViewStyle    {        /// <summary>        /// The standard progress-view style. This is the default.        /// </summary>        [iOSVersion(2)]        Default,        /// <summary>        /// The style of progress view that is used in a toolbar.        /// </summary>        [iOSVersion(2)]        Bar,    }}