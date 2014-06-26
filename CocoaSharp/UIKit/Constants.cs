using CoreGraphics;
using ObjectiveC;
using System;
using SwiftSharp.Attributes;
using Foundation;

namespace UIKit
{
    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKitDataTypesReference/index.html#//apple_ref/doc/uid/TP40007525
    /// <summary>
    /// The UIKit framework defines data types that are used in multiple places throughout the framework.
    /// </summary>
    

    /// <summary>
    /// Defines the stylistic appearance of different types of views.
    /// </summary>
    public enum UIBarStyle
    {
        /// <summary>
        /// Use the default style normally associated with the given view. For example, navigation bars typically use a white background with dark content.
        /// </summary>
        [iOSVersion(2)]
        Default,
            
        /// <summary>
        /// Use a black background with light content.
        /// </summary>
        [iOSVersion(3)]
        Black,
            
        /// <summary>
        /// Deprecated. Use UIBarStyleBlack and set the translucent property to true instead.
        /// </summary>
        [iOSVersion(2)]
        BlackTranslucent,
    }

    /// <summary>
    /// Defines the types of information that can be detected in text-based content.
    /// </summary>
    public enum UIDataDetectorTypes
    {
        /// <summary>
        /// Detect strings formatted as phone numbers.
        /// </summary>
        [iOSVersion(3)]
        PhoneNumber,
            
        /// <summary>
        /// Detect strings formatted as URLs.
        /// </summary>
        [iOSVersion(3)]
        Link,
            
        /// <summary>
        /// Detect strings formatted as addresses.
        /// </summary>
        [iOSVersion(4)]
        Address,
            
        /// <summary>
        /// Detect strings formatted as calendar events.
        /// </summary>
        [iOSVersion(4)]
        CalendarEvent,
            
        /// <summary>
        /// Do no data detection.
        /// </summary>
        [iOSVersion(3)]
        None,
            
        /// <summary>
        /// Detect all available types of data.
        /// </summary>
        [iOSVersion(3)]
        All,
    }

    /// <summary>
    /// Defines inset distances for views. 
    /// </summary>
    [iOSVersion(2)]
    public struct UIEdgeInsets
    {
        public CGFloat top { get; set; }
        public CGFloat left { get; set; }
        public CGFloat bottom { get; set; }
        public CGFloat right { get; set; }
    } 
    
    /// <summary>
    /// Defines a structure that specifies an amount to offset a position.
    /// </summary>
    [iOSVersion(5)]
    public struct UIOffset
    {
        public CGFloat horizontal { get; set; }
        public CGFloat vertical { get; set; }
    }

        
    /// <summary>
    /// Defines the size class of a view.
    /// </summary>
    public enum UIUserinterfaceSizeClass
    {
        /// <summary>
        /// Indicates the size class has not been specified.
        /// </summary>
        [iOSVersion(8)]
        Unspecified,
            
        /// <summary>
        /// Indicates a compact size class.
        /// </summary>
        [iOSVersion(8)]
        Compact,
            
        /// <summary>
        /// Indicates a regular size class.
        /// </summary>
        [iOSVersion(8)]
        Regular,
    }
}