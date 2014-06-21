using System;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCoder_Class/index.html#//apple_ref/occ/cl/NSCoder
    /// <summary>
    /// The NSCoder abstract class declares the interface used by concrete subclasses to transfer objects and other Objective-C data items between memory and some other format. This capability provides the basis for archiving (where objects and data items are stored on disk) and distribution (where objects and data items are copied between different processes or threads). The concrete subclasses provided by Foundation for these purposes are NSArchiver, NSUnarchiver, NSKeyedArchiver, NSKeyedUnarchiver, and NSPortCoder. Concrete subclasses of NSCoder are referred to in general as coder classes, and instances of these classes as coder objects (or simply coders). A coder object that can only encode values is referred to as an encoder object, and one that can only decode values as a decoder object.
    /// </summary>
    [iOSVersion(2)]
    public class NSCoder : NSObject
    {
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver supports keyed coding of objects.
        /// </summary>
        [iOSVersion(2)]
        [Export("allowsKeyedCoding")]
        public bool AllowsKeyedCoding { get; private set; }

        /// <summary>
        /// Returns a Boolean value that indicates whether an encoded value is available for a string.
        /// </summary>
        [iOSVersion(2)]
        [Export("containsValueForKey")]
        public bool ContainsValueForKey(string key) { return false; }

        /// <summary>
        /// Encodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeArrayOfObjCType")]
        public void EncodeArrayOfObjCType(CString type, int count, CConstVoidPointer at) { }

        /// <summary>
        /// Encodes boolv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeBool")]
        public void EncodeBool(bool boolv, string forKey) { }

        /// <summary>
        /// Can be overridden by subclasses to encode object so that a copy, rather than a proxy, is created upon decoding.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeBycopyObject")]
        public void EncodeBycopyObject(AnyObject anObject) { }

        /// <summary>
        /// Can be overridden by subclasses to encode object so that a proxy, rather than a copy, is created upon decoding.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeByrefObject")]
        public void EncodeByrefObject(AnyObject anObject) { }

        /// <summary>
        /// Encodes a buffer of data whose types are unspecified.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeBytes")]
        public void EncodeBytes(CConstVoidPointer byteaddr, int length) { }

        /// <summary>
        /// Encodes a buffer of data, bytesp, whose length is specified by lenv, and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeBytes")]
        public void EncodeBytes(CConstPointer<uint> bytesp, int length, string forKey) { }

        /// <summary>
        /// Can be overridden by subclasses to conditionally encode object, preserving common references to that object.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeConditionalObject")]
        public void EncodeConditionalObject(AnyObject @object) { }

        /// <summary>
        /// Conditionally encodes a reference to objv and associates it with the string key only if objv has been unconditionally encoded with encodeObject:forKey:.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeConditionalObject")]
        public void EncodeConditionalObject(AnyObject objv, string forKey) { }

        /// <summary>
        /// Encodes a given NSData object.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeDataObject")]
        public void EncodeDataObject(NSData data) { }

        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeDouble")]
        public void EncodeDouble(CDouble realv, string forKey) { }

        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeFloat")]
        public void EncodeFloat(CFloat realv, string forKey) { }

        /// <summary>
        /// Encodes intv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeInt")]
        public void EncodeInt(CInt intv, string forKey) { }

        /// <summary>
        /// Encodes a given NSInteger and associates it with a given key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeInteger")]
        public void EncodeInteger(int intv, string forKey) { }

        /// <summary>
        /// Encodes the 32-bit integer intv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeInt32")]
        public void EncodeInt32(Int32 intv, string forKey) { }

        /// <summary>
        /// Encodes the 64-bit integer intv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeInt64")]
        public void EncodeInt64(Int64 intv, string forKey) { }

        /// <summary>
        /// Encodes object.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeObject")]
        public void EncodeObject(AnyObject @object) { }

        /// <summary>
        /// Encodes the object objv and associates it with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeObject")]
        public void EncodeObject(AnyObject objv, string forKey) { }

        /// <summary>
        /// Can be overridden by subclasses to encode an interconnected group of Objective-C objects, starting with rootObject.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeRootObject")]
        public void EncodeRootObject(AnyObject rootObject) { }

        /// <summary>
        /// Must be overridden by subclasses to encode a single value residing at address, whose Objective-C type is given by valueType.
        /// </summary>
        [iOSVersion(2)]
        [Export("encodeValueOfObjCType")]
        public void EncodeValueOfObjCType(CString type, CConstVoidPointer at) { }

        /// <summary>
        /// Decodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeArrayOfObjCType")]
        public void DecodeArrayOfObjCType(CString itemType, int count, CMutableVoidPointer at) { }

        /// <summary>
        /// Decodes and returns a boolean value that was previously encoded with encodeBool:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeBoolForKey")]
        public bool DecodeBoolForKey(string key) { return false; }

        /// <summary>
        /// Decodes a buffer of data that was previously encoded with encodeBytes:length:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeBytesForKey")]
        public UnsafePointer<uint> DecodeBytesForKey(string key, CMutablePointer<int> returnedLength) { return null; }

        /// <summary>
        /// Decodes a buffer of data whose types are unspecified.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeBytesWithReturnedLength")]
        public COpaquePointer DecodeBytesWithReturnedLength(CMutablePointer<int> lengthp) { return null; }

        /// <summary>
        /// Decodes and returns an NSData object that was previously encoded with encodeDataObject:. Subclasses must override this method.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeDataObject")]
        public NSData DecodeDataObject() { return null; }

        /// <summary>
        /// Decodes and returns a double value that was previously encoded with either encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeDoubleForKey")]
        public CDouble DecodeDoubleForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns a float value that was previously encoded with encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeFloatForKey")]
        public CFloat DecodeFloatForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns an int value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeIntForKey")]
        public CInt DecodeIntForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns an NSInteger value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeIntegerForKey")]
        public int DecodeIntegerForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns a 32-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeInt32ForKey")]
        public Int32 DecodeInt32ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns a 64-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeInt64ForKey")]
        public Int64 DecodeInt64ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes an Objective-C object that was previously encoded with any of the encode...Object: methods.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeObject")]
        public AnyObject DecodeObject() { return null; }

        /// <summary>
        /// Decodes and returns an Objective-C object that was previously encoded with encodeObject:forKey: or encodeConditionalObject:forKey: and associated with the string key.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeObjectForKey")]
        public AnyObject DecodeObjectForKey(string key) { return null; }

        /// <summary>
        /// Decodes a single value, whose Objective-C type is given by valueType.
        /// </summary>
        [iOSVersion(2)]
        [Export("decodeValueOfObjCType")]
        public void DecodeValueOfObjCType(CString type, CMutableVoidPointer at) { }

        /// <summary>
        /// Decodes an object for the key, restricted to the specified class.
        /// </summary>
        /// <param name="aClass">The expect class type.</param>
        /// <param name="forKey">The coder key.</param>
        /// <returns>The decoded object.</returns>
        [iOSVersion(6)]
        [Export("decodeObjectOfClass")]
        public AnyObject DecodeObjectOfClass(AnyClass aClass, string forKey) { return null; }

        /// <summary>
        /// Decodes an object for the key, restricted to the specified classes.
        /// </summary>
        /// <param name="classes">A set of the expected classes.</param>
        /// <param name="forKey">The coder key.</param>
        /// <returns>The decoded object.</returns>
        [iOSVersion(6)]
        [Export("decodeObjectOfClasses")]
        public AnyObject DecodeObjectOfClasses(NSSet classes, string forKey) { return null; }

        /// <summary>
        /// Returns a decoded property list for the specified key.
        /// </summary>
        /// <param name="key">The coder key.</param>
        /// <returns>A decoded object containing a property list.</returns>
        [iOSVersion(6)]
        [Export("decodePropertyListForKey")]
        public AnyObject DecodePropertyListForKey(string key) { return null; }

        /// <summary>
        /// Returns whether the coder requires secure coding.
        /// </summary>
        /// <returns>true if this coder requires secure coding; false otherwise.</returns>
        [iOSVersion(6)]
        [Export("requiresSecureCoding")]
        public bool RequiresSecureCoding { get; private set; }

        /// <summary>
        /// Get the current set of coded classes that allow secure coding.
        /// </summary>
        /// <returns>The allowed classes.</returns>
        [iOSVersion(6)]
        [Export("allowedClasses")]
        public NSSet AllowedClasses { get; private set; }

        /// <summary>
        /// During encoding, this method should return the system version currently in effect.
        /// </summary>
        [iOSVersion(2)]
        [Export("systemVersion")]
        public CUnsignedInt SystemVersion { get; private set; }

        /// <summary>
        /// This method is present for historical reasons and is not used with keyed archivers.
        /// </summary>
        /// <returns>The version in effect for the class named className or NSNotFound if no class named className exists.</returns>
        [iOSVersion(2)]
        [Export("versionForClassName")]
        public int VersionForClassName(string className) { return 0; }
    }
}
