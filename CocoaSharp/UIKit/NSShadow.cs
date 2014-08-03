using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// An NSShadow object encapsulates the attributes used to create a drop shadow during drawing operations.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/ApplicationKit/Classes/NSShadow_Class/index.html#//apple_ref/occ/cl/NSShadow"/>    [iOSVersion(6)]    public class NSShadow : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// The offset values of the shadow.        /// </summary>        [iOSVersion(6)]        [Export("shadowOffset")]        public CGSize ShadowOffset { get; set; }                /// <summary>        /// The blur radius of the shadow.        /// </summary>        [iOSVersion(6)]        [Export("shadowBlurRadius")]        public CGFloat ShadowBlurRadius { get; set; }                /// <summary>        /// The color of the shadow.        /// </summary>        [iOSVersion(6)]        [Export("shadowColor")]        public AnyObject ShadowColor { get; set; }    }}