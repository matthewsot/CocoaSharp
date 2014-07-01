using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIBarPositioning_Protocol/index.html#//apple_ref/occ/intf/UIBarPositioning    /// <summary>    /// The UIBarPositioning protocol defines the ways that bars can be positioned on iOS devices. Bars can be positioned at the bottom of their enclosing view, at the top of their enclosing view, or at both the top of their enclosing view and also the top of the screen. In this last case, the bar will abut the status bar displayed by the system. Bars in this position need to have their background extend above their own frame to the top of the screen. This allows the background to show through the status bar.    /// </summary>    [iOSVersion(7)]    public interface UIBarPositioning    {        /// <summary>        /// The position of the bar. (required)        /// </summary>        [iOSVersion(7)]        [Export("barPosition")]        UIBarPosition BarPosition { get; }
    }

    /// <summary>
    /// Constants to specify metrics to use for appearance.
    /// </summary>
    public enum UIBarMetrics
    {
        /// <summary>
        /// Specifies default metrics for the device.
        /// </summary>
        [iOSVersion(5)]
        Default,
        Compact,
        Condensed,

        /// <summary>
        /// Specifies default metrics for the device for bars with the prompt property, such as UINavigationBar and UISearchBar.
        /// </summary>
        [iOSVersion(7)]
        DefaultPrompt,
        CompactPrompt,
    }
    /// <summary>
    /// Constants to identify the position of a bar.
    /// </summary>
    public enum UIBarPosition
    {
        /// <summary>
        /// Specifies that the position is unspecified.
        /// </summary>
        [iOSVersion(7)]
        Any,

        /// <summary>
        /// Specifies that the bar is at the bottom of its containing view.
        /// </summary>
        [iOSVersion(7)]
        Bottom,

        /// <summary>
        /// Specifies that the bar is at the top of its containing view.
        /// </summary>
        [iOSVersion(7)]
        Top,

        /// <summary>
        /// Specifies that the bar is at the top of the screen, as well as its containing view.
        /// </summary>
        [iOSVersion(7)]
        TopAttached,
    }}