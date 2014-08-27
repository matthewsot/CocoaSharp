using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The NSStringDrawingContext class manages metrics used when drawing attributed strings. Prior to drawing, you can create an instance of this class and use it to specify the minimum scale factor and tracking adjustments for a string. After drawing, you can retrieve the actual values that were used during drawing.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSStringDrawingContext_class/index.html#//apple_ref/occ/cl/NSStringDrawingContext"/>    [iOSVersion(6)]    public class NSStringDrawingContext : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// The scale factor that determines the smallest font size to use during drawing.        /// </summary>        [iOSVersion(6)]        [Export("minimumScaleFactor")]        public CGFloat MinimumScaleFactor { get; set; }                /// <summary>        /// The actual scale factor that was applied to the font during drawing. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("actualScaleFactor")]        public CGFloat ActualScaleFactor { get; private set; }                /// <summary>        /// The bounding rectangle that was last used when drawing the string. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("totalBounds")]        public CGRect TotalBounds { get; private set; }    }}