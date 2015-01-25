using ObjectiveC;
using System;
using SharpSwift.Attributes;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using NSObject = ObjectiveC.NSObject;

namespace Foundation
{
    /// <summary>
    /// The NSCoder abstract class declares the interface used by concrete subclasses to transfer objects and other values between memory and some other format. This capability provides the basis for archiving (where objects and data items are stored on disk) and distribution (where objects and data items are copied between different processes or threads). The concrete subclasses provided by Foundation for these purposes are NSArchiver, NSUnarchiver, NSKeyedArchiver, NSKeyedUnarchiver, and NSPortCoder. Concrete subclasses of NSCoder are referred to in general as coder classes, and instances of these classes as coder objects (or simply coders). A coder object that can only encode values is referred to as an encoder object, and one that can only decode values as a decoder object.
    /// </summary>
    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCoder_Class/index.html#//apple_ref/occ/cl/NSCoder"/>
    [iOSVersion(2)]
    [Export("")]
    public class NSCoder : NSObject//, AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable
    {
        public NSCoder() { }
        /// <summary>
        /// Returns a Boolean value that indicates whether an encoded value is available for a string.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("containsValueForKey")]
        public virtual bool ContainsValueForKey(string key) { return default(bool); }
        
        /// <summary>
        /// Encodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="at"></param>
        [iOSVersion(2)]
        [Export("encodeArrayOfObjCType")]
        public virtual void EncodeArrayOfObjCType(UnsafePointer<Int8> type, int count, UnsafePointer at) {  }
        
        /// <summary>
        /// Encodes boolv and associates it with the string key.
        /// </summary>
        /// <param name="boolv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeBool")]
        public virtual void EncodeBool(bool boolv, string forKey) {  }
        
        /// <summary>
        /// Can be overridden by subclasses to encode object so that a copy, rather than a proxy, is created upon decoding.
        /// </summary>
        /// <param name="anObject"></param>
        [iOSVersion(2)]
        [Export("encodeBycopyObject")]
        public virtual void EncodeBycopyObject([Optional] AnyObject anObject) {  }
        
        /// <summary>
        /// Can be overridden by subclasses to encode object so that a proxy, rather than a copy, is created upon decoding.
        /// </summary>
        /// <param name="anObject"></param>
        [iOSVersion(2)]
        [Export("encodeByrefObject")]
        public virtual void EncodeByrefObject([Optional] AnyObject anObject) {  }
        
        /// <summary>
        /// Encodes a buffer of data whose types are unspecified.
        /// </summary>
        /// <param name="byteaddr"></param>
        /// <param name="length"></param>
        [iOSVersion(2)]
        [Export("encodeBytes")]
        public virtual void EncodeBytes(UnsafePointer byteaddr, int length) {  }
        
        /// <summary>
        /// Encodes a buffer of data, bytesp, whose length is specified by lenv, and associates it with the string key.
        /// </summary>
        /// <param name="bytesp"></param>
        /// <param name="length"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeBytes")]
        public virtual void EncodeBytes(UnsafePointer<UInt8> bytesp, int length, string forKey) {  }
        
        /// <summary>
        /// Can be overridden by subclasses to conditionally encode object, preserving common references to that object.
        /// </summary>
        /// <param name="@object"></param>
        [iOSVersion(2)]
        [Export("encodeConditionalObject")]
        public virtual void EncodeConditionalObject([Optional] AnyObject @object) {  }
        
        /// <summary>
        /// Conditionally encodes a reference to objv and associates it with the string key only if objv has been unconditionally encoded with encodeObject:forKey:.
        /// </summary>
        /// <param name="objv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeConditionalObject")]
        public virtual void EncodeConditionalObject([Optional] AnyObject objv, string forKey) {  }
        
        /// <summary>
        /// Encodes a given NSData object.
        /// </summary>
        /// <param name="data"></param>
        [iOSVersion(2)]
        [Export("encodeDataObject")]
        public virtual void EncodeDataObject(NSData data) {  }
        
        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        /// <param name="realv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeDouble")]
        public virtual void EncodeDouble(Double realv, string forKey) {  }
        
        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        /// <param name="realv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeFloat")]
        public virtual void EncodeFloat(float realv, string forKey) {  }
        
        /// <summary>
        /// Encodes intv and associates it with the string key.
        /// </summary>
        /// <param name="intv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeInt")]
        public virtual void EncodeInt(int intv, string forKey) {  }
        
        /// <summary>
        /// Encodes a given NSInteger and associates it with a given key.
        /// </summary>
        /// <param name="intv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeInteger")]
        public virtual void EncodeInteger(int intv, string forKey) {  }
        
        /// <summary>
        /// Encodes the 32-bit integer intv and associates it with the string key.
        /// </summary>
        /// <param name="intv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeInt32")]
        public virtual void EncodeInt32(int intv, string forKey) {  }
        
        /// <summary>
        /// Encodes the 64-bit integer intv and associates it with the string key.
        /// </summary>
        /// <param name="intv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeInt64")]
        public virtual void EncodeInt64(Int64 intv, string forKey) {  }
        
        /// <summary>
        /// Encodes object.
        /// </summary>
        /// <param name="@object"></param>
        [iOSVersion(2)]
        [Export("encodeObject")]
        public virtual void EncodeObject([Optional] AnyObject @object) {  }
        
        /// <summary>
        /// Encodes the object objv and associates it with the string key.
        /// </summary>
        /// <param name="objv"></param>
        /// <param name="forKey"></param>
        [iOSVersion(2)]
        [Export("encodeObject")]
        public virtual void EncodeObject([Optional] AnyObject objv, string forKey) {  }
        
        /// <summary>
        /// Can be overridden by subclasses to encode an interconnected group of Objective-C objects, starting with rootObject.
        /// </summary>
        /// <param name="rootObject"></param>
        [iOSVersion(2)]
        [Export("encodeRootObject")]
        public virtual void EncodeRootObject(AnyObject rootObject) {  }
        
        /// <summary>
        /// Must be overridden by subclasses to encode a single value residing at address, whose Objective-C type is given by valueType.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="at"></param>
        [iOSVersion(2)]
        [Export("encodeValueOfObjCType")]
        public virtual void EncodeValueOfObjCType(UnsafePointer<Int8> type, UnsafePointer at) {  }
        
        /// <summary>
        /// Encodes a point and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="point">The point to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(2)]
        [Export("encodeCGPoint")]
        public virtual void EncodeCGPoint(CGPoint point, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes a rectangle and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="rect">The rectangle to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(2)]
        [Export("encodeCGRect")]
        public virtual void EncodeCGRect(CGRect rect, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes size information and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="size">The size information to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(2)]
        [Export("encodeCGSize")]
        public virtual void EncodeCGSize(CGSize size, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes an affine transform and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="transform">The transform information to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(2)]
        [Export("encodeCGAffineTransform")]
        public virtual void EncodeCGAffineTransform(CGAffineTransform transform, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes edge inset data and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="insets">The edge insets data to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(2)]
        [Export("encodeUIEdgeInsets")]
        public virtual void EncodeUIEdgeInsets(UIEdgeInsets insets, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes offset data and associates it with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="offset">The offset data to encode.</param>
        /// <param name="forKey">The key identifying the data.</param>
        [iOSVersion(5)]
        [Export("encodeUIOffset")]
        public virtual void EncodeUIOffset(UIOffset offset, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes a given CMTime structure and associates it with a specified key.
        /// </summary>
        /// <param name="time">A CMTime structure.</param>
        /// <param name="forKey">The key with which to associate time in the archive.</param>
        [iOSVersion(4)]
        [Export("encodeCMTime")]
        public virtual void EncodeCMTime(CMTime time, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes a given CMTimeRange structure and associates it with a specified key.
        /// </summary>
        /// <param name="timeRange">A CMTimeRange structure.</param>
        /// <param name="forKey">The key with which to associate timeRange in the archive.</param>
        [iOSVersion(4)]
        [Export("encodeCMTimeRange")]
        public virtual void EncodeCMTimeRange(CMTimeRange timeRange, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Encodes a given CMTimeMapping structure and associates it with a specified key.
        /// </summary>
        /// <param name="timeMapping">A CMTimeMapping structure.</param>
        /// <param name="forKey">The key with which to associate timeMapping in the archive.</param>
        [iOSVersion(4)]
        [Export("encodeCMTimeMapping")]
        public virtual void EncodeCMTimeMapping(CMTimeMapping timeMapping, [Unwrapped] string forKey) {  }
        
        /// <summary>
        /// Decodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="count"></param>
        /// <param name="at"></param>
        [iOSVersion(2)]
        [Export("decodeArrayOfObjCType")]
        public virtual void DecodeArrayOfObjCType(UnsafePointer<Int8> itemType, int count, UnsafeMutablePointer at) {  }
        
        /// <summary>
        /// Decodes and returns a boolean value that was previously encoded with encodeBool:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeBoolForKey")]
        public virtual bool DecodeBoolForKey(string key) { return default(bool); }
        
        /// <summary>
        /// Decodes a buffer of data that was previously encoded with encodeBytes:length:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="returnedLength"></param>
        [iOSVersion(2)]
        [Export("decodeBytesForKey")]
        public virtual UnsafePointer<UInt8> DecodeBytesForKey(string key, UnsafeMutablePointer<int> returnedLength) { return default(UnsafePointer<UInt8>); }
        
        /// <summary>
        /// Decodes a buffer of data whose types are unspecified.
        /// </summary>
        /// <param name="lengthp"></param>
        [iOSVersion(2)]
        [Export("decodeBytesWithReturnedLength")]
        public virtual UnsafeMutablePointer DecodeBytesWithReturnedLength(UnsafeMutablePointer<int> lengthp) { return default(UnsafeMutablePointer); }
        
        /// <summary>
        /// Decodes and returns an NSData object that was previously encoded with encodeDataObject:. Subclasses must override this method.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeDataObject")]
        [return:Optional]
        public virtual NSData DecodeDataObject() { return default(NSData); }
        
        /// <summary>
        /// Decodes and returns a double value that was previously encoded with either encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeDoubleForKey")]
        public virtual Double DecodeDoubleForKey(string key) { return default(Double); }
        
        /// <summary>
        /// Decodes and returns a float value that was previously encoded with encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeFloatForKey")]
        public virtual float DecodeFloatForKey(string key) { return default(float); }
        
        /// <summary>
        /// Decodes and returns an int value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeIntForKey")]
        public virtual int DecodeIntForKey(string key) { return default(int); }
        
        /// <summary>
        /// Decodes and returns an NSInteger value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeIntegerForKey")]
        public virtual int DecodeIntegerForKey(string key) { return default(int); }
        
        /// <summary>
        /// Decodes and returns a 32-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeInt32ForKey")]
        public virtual int DecodeInt32ForKey(string key) { return default(int); }
        
        /// <summary>
        /// Decodes and returns a 64-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeInt64ForKey")]
        public virtual Int64 DecodeInt64ForKey(string key) { return default(Int64); }
        
        /// <summary>
        /// Decodes an Objective-C object that was previously encoded with any of the encode...Object: methods.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeObject")]
        [return:Optional]
        public virtual AnyObject DecodeObject() { return default(AnyObject); }
        
        /// <summary>
        /// Decodes and returns an Objective-C object that was previously encoded with encodeObject:forKey: or encodeConditionalObject:forKey: and associated with the string key.
        /// </summary>
        /// <param name="key"></param>
        [iOSVersion(2)]
        [Export("decodeObjectForKey")]
        [return:Optional]
        public virtual AnyObject DecodeObjectForKey(string key) { return default(AnyObject); }
        
        /// <summary>
        /// Decodes a single value, whose Objective-C type is given by valueType.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="at"></param>
        [iOSVersion(2)]
        [Export("decodeValueOfObjCType")]
        public virtual void DecodeValueOfObjCType(UnsafePointer<Int8> type, UnsafeMutablePointer at) {  }
        
        /// <summary>
        /// Decodes an object for the key, restricted to the specified class.
        /// </summary>
        /// <param name="aClass">The expect class type.</param>
        /// <param name="forKey">The coder key.</param>
        [iOSVersion(6)]
        [Export("decodeObjectOfClass")]
        [return:Optional]
        public virtual AnyObject DecodeObjectOfClass(AnyClass aClass, string forKey) { return default(AnyObject); }
        
        /// <summary>
        /// Decodes an object for the key, restricted to the specified classes.
        /// </summary>
        /// <param name="classes">A set of the expected classes.</param>
        /// <param name="forKey">The coder key.</param>
        [iOSVersion(6)]
        [Export("decodeObjectOfClasses")]
        [return:Optional]
        public virtual AnyObject DecodeObjectOfClasses(NSSet classes, string forKey) { return default(AnyObject); }
        
        /// <summary>
        /// Returns a decoded property list for the specified key.
        /// </summary>
        /// <param name="key">The coder key.</param>
        [iOSVersion(6)]
        [Export("decodePropertyListForKey")]
        [return:Optional]
        public virtual AnyObject DecodePropertyListForKey(string key) { return default(AnyObject); }
        
        /// <summary>
        /// Decodes and returns the CGPoint structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the point.</param>
        [iOSVersion(2)]
        [Export("decodeCGPointForKey")]
        public virtual CGPoint DecodeCGPointForKey([Unwrapped] string key) { return default(CGPoint); }
        
        /// <summary>
        /// Decodes and returns the CGRect structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the rectangle.</param>
        [iOSVersion(2)]
        [Export("decodeCGRectForKey")]
        public virtual CGRect DecodeCGRectForKey([Unwrapped] string key) { return default(CGRect); }
        
        /// <summary>
        /// Decodes and returns the CGSize structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the size information.</param>
        [iOSVersion(2)]
        [Export("decodeCGSizeForKey")]
        public virtual CGSize DecodeCGSizeForKey([Unwrapped] string key) { return default(CGSize); }
        
        /// <summary>
        /// Decodes and returns the CGAffineTransform structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the affine transform.</param>
        [iOSVersion(2)]
        [Export("decodeCGAffineTransformForKey")]
        public virtual CGAffineTransform DecodeCGAffineTransformForKey([Unwrapped] string key) { return default(CGAffineTransform); }
        
        /// <summary>
        /// Decodes and returns the UIEdgeInsets structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the edge insets.</param>
        [iOSVersion(2)]
        [Export("decodeUIEdgeInsetsForKey")]
        public virtual UIEdgeInsets DecodeUIEdgeInsetsForKey([Unwrapped] string key) { return default(UIEdgeInsets); }
        
        /// <summary>
        /// Decodes and returns the UIOffset structure associated with the specified key in the receiver’s archive.
        /// </summary>
        /// <param name="key">The key that identifies the offset.</param>
        [iOSVersion(5)]
        [Export("decodeUIOffsetForKey")]
        public virtual UIOffset DecodeUIOffsetForKey([Unwrapped] string key) { return default(UIOffset); }
        
        /// <summary>
        /// Returns the CMTime structure associated with a given key.
        /// </summary>
        /// <param name="key">The key for a CMTime structure encoded in the receiver.</param>
        [iOSVersion(4)]
        [Export("decodeCMTimeForKey")]
        public virtual CMTime DecodeCMTimeForKey([Unwrapped] string key) { return default(CMTime); }
        
        /// <summary>
        /// Returns the CMTimeRange structure associated with a given key.
        /// </summary>
        /// <param name="key">The key for a CMTimeRange structure encoded in the receiver.</param>
        [iOSVersion(4)]
        [Export("decodeCMTimeRangeForKey")]
        public virtual CMTimeRange DecodeCMTimeRangeForKey([Unwrapped] string key) { return default(CMTimeRange); }
        
        /// <summary>
        /// Returns the CMTimeMapping structure associated with a given key.
        /// </summary>
        /// <param name="key">The key for a CMTimeMapping structure encoded in the receiver.</param>
        [iOSVersion(4)]
        [Export("decodeCMTimeMappingForKey")]
        public virtual CMTimeMapping DecodeCMTimeMappingForKey([Unwrapped] string key) { return default(CMTimeMapping); }
        
        /// <summary>
        /// This method is present for historical reasons and is not used with keyed archivers.
        /// </summary>
        /// <param name="className"></param>
        [iOSVersion(2)]
        [Export("versionForClassName")]
        public virtual int VersionForClassName(string className) { return default(int); }
        
        /// <summary>
        /// A Boolean value that indicates whether the receiver supports keyed coding of objects. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("allowsKeyedCoding")]
        public bool AllowsKeyedCoding { get; private set; }
        
        /// <summary>
        /// Boolean value that indicates whether the coder requires secure coding. (read-only)
        /// </summary>
        [iOSVersion(6)]
        [Export("requiresSecureCoding")]
        public bool RequiresSecureCoding { get; private set; }
        
        /// <summary>
        /// The set of coded classes allowed for secure coding. (read-only)
        /// </summary>
        [iOSVersion(6)]
        [Export("allowedClasses")]
        [Optional]
        public NSSet AllowedClasses { get; private set; }
        
        /// <summary>
        /// The system version in effect for the archive. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("systemVersion")]
        public uint SystemVersion { get; private set; }
    }
}
