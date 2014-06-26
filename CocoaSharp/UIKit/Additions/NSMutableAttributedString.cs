using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSMutableAttributedString_UIKit_Additions/index.html#//apple_ref/occ/cl/NSMutableAttributedString    /// <summary>    /// The UIKit framework adds methods to NSMutableAttributedString to support replacing the string with contents of an external document and fixing attribute inconsistencies within a character range.    /// </summary>    [iOSVersion(3.2)]    [Export("NSMutableAttributedString")]    public class NSMutableAttributedStringAdditions    {        //ObjC only    }}