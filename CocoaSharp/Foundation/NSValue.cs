using ObjectiveC;
using System;
using SharpSwift.Attributes;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;

namespace UIKit
{
    /// <summary>
    /// An NSValue object is a simple container for a single C or Objective-C data item. It can hold any of the scalar types such as int, float, and char, as well as pointers, structures, and object id references. Use this class to work with such data types in collections (such as NSArray and NSSet), key-value coding, and other APIs that require Objective-C objects. NSValue objects are always immutable.
    /// </summary>
    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSValue_Class/index.html#//apple_ref/occ/cl/NSValue"/>
    [iOSVersion(2)]
    [Export("")]
    public class NSValue : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding, Printable
    {
        public NSValue() { }
        /// <summary>
        /// Initializes a value object to contain the specified value, interpreted with the specified Objective-C type.
        /// </summary>
        /// <param name="bytes">A pointer to data to be stored in the new value object.</param>
        /// <param name="objCType">The Objective-C type of value, as provided by the @encode() compiler directive. Do not hard-code this parameter as a C string.</param>
        [iOSVersion(2)]
        public NSValue(UnsafePointer bytes, UnsafePointer<Int8> objCType) { }
        
        /// <summary>
        /// Creates a value object containing the specified value, interpreted with the specified Objective-C type.
        /// </summary>
        /// <param name="value">A pointer to data to be stored in the new value object.</param>
        /// <param name="withObjCType">The Objective-C type of value, as provided by the @encode() compiler directive. Do not hard-code this parameter as a C string.</param>
        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>
        [iOSVersion(2)]
        [IgnoreParameter("NAME_YOUR_PARAMS")]
        public NSValue(UnsafePointer value, UnsafePointer<Int8> withObjCType, bool NAME_YOUR_PARAMS = false) { }
        
        /// <summary>
        /// Copies the value into the specified buffer.
        /// </summary>
        /// <param name="buffer">A buffer into which to copy the value. The buffer must be large enough to hold the value.</param>
        [iOSVersion(2)]
        [Export("getValue")]
        public virtual void GetValue(UnsafeMutablePointer buffer) {  }
        
        /// <summary>
        /// Creates a value object containing the specified pointer.
        /// </summary>
        /// <param name="pointer">The value for the new object.</param>
        [iOSVersion(2)]
        public NSValue(UnsafePointer pointer) { }
        
        /// <summary>
        /// Creates a value object containing the specified object.
        /// </summary>
        /// <param name="nonretainedObject">The value for the new object.</param>
        [iOSVersion(2)]
        public NSValue([Optional] AnyObject nonretainedObject) { }
        
        /// <summary>
        /// Returns the value as an untyped pointer.
        /// </summary>
        [iOSVersion(2)]
        [Export("pointerValue")]
        public virtual UnsafeMutablePointer PointerValue() { return default(UnsafeMutablePointer); }
        
        /// <summary>
        /// Creates a new value object containing the specified Foundation range structure.
        /// </summary>
        /// <param name="range">The value for the new object.</param>
        [iOSVersion(2)]
        public NSValue(NSRange range) { }
        
        /// <summary>
        /// Returns the CoreGraphics point structure representation of the value.
        /// </summary>
        [iOSVersion(2)]
        public virtual CGPoint CGPointValue() { return default(CGPoint); }
        
        /// <summary>
        /// Returns the CoreGraphics vector structure representation of the value.
        /// </summary>
        [iOSVersion(8)]
        public virtual CGVector CGVectorValue() { return default(CGVector); }
        
        /// <summary>
        /// Returns the CoreGraphics size structure representation of the value.
        /// </summary>
        [iOSVersion(2)]
        public virtual CGSize CGSizeValue() { return default(CGSize); }
        
        /// <summary>
        /// Returns the CoreGraphics rectangle structure representation of the value.
        /// </summary>
        [iOSVersion(2)]
        public virtual CGRect CGRectValue() { return default(CGRect); }
        
        /// <summary>
        /// Returns the CoreGraphics affine transform representation of the value.
        /// </summary>
        [iOSVersion(2)]
        public virtual CGAffineTransform CGAffineTransformValue() { return default(CGAffineTransform); }
        
        /// <summary>
        /// Returns the UIKit edge insets structure representation of the value.
        /// </summary>
        [iOSVersion(2)]
        public virtual UIEdgeInsets UIEdgeInsetsValue() { return default(UIEdgeInsets); }
        
        /// <summary>
        /// Returns the UIKit offset structure representation of the value.
        /// </summary>
        [iOSVersion(5)]
        public virtual UIOffset UIOffsetValue() { return default(UIOffset); }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the value object and another value object are equal.
        /// </summary>
        /// <param name="aValue">The other value object with which to compare the value object.</param>
        [iOSVersion(2)]
        [Export("isEqualToValue")]
        public virtual bool IsEqualToValue(NSValue aValue) { return default(bool); }
        
        /// <summary>
        /// A C string containing the Objective-C type of the data contained in the value object.
        /// </summary>
        [iOSVersion(2)]
        [Export("objCType")]
        public UnsafePointer<Int8> ObjCType { get; private set; }
        
        /// <summary>
        /// The value as a non-retained pointer to an object. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("nonretainedObjectValue")]
        [Optional]
        public AnyObject NonretainedObjectValue { get; private set; }
        
        /// <summary>
        /// The Foundation range structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("rangeValue")]
        public NSRange RangeValue { get; private set; }
        
        /// <summary>
        /// The CoreAnimation transform structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(2)]
        public CATransform3D CATransform3DValue { get; private set; }
        
        /// <summary>
        /// The CoreMedia time structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(4)]
        public CMTime CMTimeValue { get; private set; }
        
        /// <summary>
        /// The CoreMedia time range structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(4)]
        public CMTimeRange CMTimeRangeValue { get; private set; }
        
        /// <summary>
        /// The CoreMedia time mapping structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(4)]
        public CMTimeMapping CMTimeMappingValue { get; private set; }
        
        /// <summary>
        /// The CoreLocation geographic coordinate structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(6)]
        public CLLocationCoordinate2D MKCoordinateValue { get; private set; }
        
        /// <summary>
        /// The MapKit coordinate span structure representation of the value. (read-only)
        /// </summary>
        [iOSVersion(6)]
        public MKCoordinateSpan MKCoordinateSpanValue { get; private set; }
        
        /// <summary>
        /// The three-element Scene Kit vector representation of the value. (read-only)
        /// </summary>
        [iOSVersion(8)]
        public SCNVector3 SCNVector3Value { get; private set; }
        
        /// <summary>
        /// The four-element Scene Kit vector representation of the value. (read-only)
        /// </summary>
        [iOSVersion(8)]
        public SCNVector4 SCNVector4Value { get; private set; }
        
        /// <summary>
        /// The Scene Kit 4 x 4 matrix representation of the value. (read-only)
        /// </summary>
        [iOSVersion(8)]
        public SCNMatrix4 SCNMatrix4Value { get; private set; }
    }
}
