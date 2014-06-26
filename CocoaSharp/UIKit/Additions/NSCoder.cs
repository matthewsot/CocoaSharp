using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSCoder_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40007292    /// <summary>    /// This category adds methods to the Foundation framework’s NSCoder class. The methods in this category let you encode and decode geometry-based data used by the UIKit framework.    /// </summary>    [iOSVersion(2)]    [Export("NSCoder")]    public class NSCoderAdditions    {        //ObjC only    }}