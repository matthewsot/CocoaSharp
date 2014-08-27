using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIBarPositioningDelegate protocol supports the positioning of a bar that conforms to the UIBarPositioning protocol. Navigation bars, toolbars, and search bars all have delegates that support this protocol. The delegate can use the method of this protocol to specify the bar’s position when that bar is moved to a window.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIBarPositioningDelegate_Protocol/index.html#//apple_ref/occ/intf/UIBarPositioningDelegate"/>    [iOSVersion(7)]    public interface UIBarPositioningDelegate//: NSObjectProtocol    {        /// <summary>        /// Asks the delegate for the position of the specified bar in its new window. (required)        /// </summary>        /// <param name="bar">The bar that was added to the window.</param>        [iOSVersion(7)]        [Export("positionForBar")]        UIBarPosition PositionForBar(UIBarPositioning bar);    }}