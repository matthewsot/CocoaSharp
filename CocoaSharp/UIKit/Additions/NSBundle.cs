using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSBundle_UIKitAdditions/index.html#//apple_ref/doc/uid/TP40007485    /// <summary>    /// This category adds methods to the Foundation framework’s NSBundle class. The method in this category provides support for loading nib files into your application.    /// </summary>    [iOSVersion(2)]    [Export("NSBundle")]    public class NSBundleAdditions    {        //ObjC only    }}