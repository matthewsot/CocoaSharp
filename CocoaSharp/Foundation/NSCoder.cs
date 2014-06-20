using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectiveC;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCoder_Class/index.html#//apple_ref/occ/cl/NSCoder
    public class NSCoder : NSObject
    {
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver supports keyed coding of objects.
        /// </summary>
        [Export("allowsKeyedCoding")]
        public static bool AllowsKeyedCoding { get; private set; }

        /// <summary>
        /// Returns a Boolean value that indicates whether an encoded value is available for a string.
        /// </summary>
        [Export("containsValueForKey")]
        public bool ContainsValueForKey(string key) { return false; }

        /// <summary>
        /// Encodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        [Export("encodeArrayOfObjCType")]
        public void EncodeArrayOfObjCType(CString type, int count, CConstVoidPointer array) { }

        /// <summary>
        /// Encodes boolv and associates it with the string key.
        /// </summary>
        [Export("encodeBool")]
        public void EncodeBool(bool boolv, string key) { }

        /// <summary>
        /// Can be overridden by subclasses to encode object so that a copy, rather than a proxy, is created upon decoding.
        /// </summary>
        [Export("encodeBycopyObject")]
        public void EncodeBycopyObject(AnyObject anObject) { }

        /// <summary>
        /// Can be overridden by subclasses to encode object so that a proxy, rather than a copy, is created upon decoding.
        /// </summary>
        [Export("encodeByrefObject")]
        public void EncodeByrefObject(AnyObject anObject) { }

        /// <summary>
        /// Encodes a buffer of data whose types are unspecified.
        /// </summary>
        [Export("encodeBytes")]
        public void EncodeBytes(CConstVoidPointer byteaddr, int length) { }

        /// <summary>
        /// Encodes a buffer of data, bytesp, whose length is specified by lenv, and associates it with the string key.
        /// </summary>
        [Export("encodeBytes")]
        public void EncodeBytes(CConstPointer<uint> bytesp, int lenv, string key) { }

        /// <summary>
        /// Can be overridden by subclasses to conditionally encode object, preserving common references to that object.
        /// </summary>
        [Export("encodeConditionalObject")]
        public void EncodeConditionalObject(AnyObject @object) { }

        /// <summary>
        /// Conditionally encodes a reference to objv and associates it with the string key only if objv has been unconditionally encoded with encodeObject:forKey:.
        /// </summary>
        [Export("encodeConditionalObject")]
        public void EncodeConditionalObject(AnyObject objv, string key) { }

        /// <summary>
        /// Encodes a given NSData object.
        /// </summary>
        [Export("encodeDataObject")]
        public void EncodeDataObject(NSData data) { }

        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        [Export("encodeDouble")]
        public void EncodeDouble(CDouble realv, string key) { }

        /// <summary>
        /// Encodes realv and associates it with the string key.
        /// </summary>
        [Export("encodeFloat")]
        public void EncodeFloat(CFloat realv, string key) { }

        /// <summary>
        /// Encodes intv and associates it with the string key.
        /// </summary>
        [Export("encodeInt")]
        public void EncodeInt(CInt intv, string key) { }

        /// <summary>
        /// Encodes a given NSInteger and associates it with a given key.
        /// </summary>
        [Export("encodeInteger")]
        public void EncodeInteger(int intv, string key) { }

        /// <summary>
        /// Encodes the 32-bit integer intv and associates it with the string key.
        /// </summary>
        [Export("encodeInt32")]
        public void EncodeInt32(Int32 intv, string key) { }

        /// <summary>
        /// Encodes the 64-bit integer intv and associates it with the string key.
        /// </summary>
        [Export("encodeInt64")]
        public void EncodeInt64(Int64 intv, string key) { }

        /// <summary>
        /// Encodes object.
        /// </summary>
        [Export("encodeObject")]
        public void EncodeObject(AnyObject @object) { }

        /// <summary>
        /// Encodes the object objv and associates it with the string key.
        /// </summary>
        [Export("encodeObject")]
        public void EncodeObject(AnyObject objv, string key) { }

        /// <summary>
        /// Can be overridden by subclasses to encode an interconnected group of Objective-C objects, starting with rootObject.
        /// </summary>
        [Export("encodeRootObject")]
        public void EncodeRootObject(AnyObject rootObject) { }

        /// <summary>
        /// Must be overridden by subclasses to encode a single value residing at address, whose Objective-C type is given by valueType.
        /// </summary>
        [Export("encodeValueOfObjCType")]
        public void EncodeValueOfObjCType(CString type, CConstVoidPointer addr) { }

        /// <summary>
        /// Decodes an array of count items, whose Objective-C type is given by itemType.
        /// </summary>
        [Export("decodeArrayOfObjCType")]
        public void DecodeArrayOfObjCType(CString itemType, int count, CMutableVoidPointer array) { }

        /// <summary>
        /// Decodes and returns a boolean value that was previously encoded with encodeBool:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeBoolForKey")]
        public bool DecodeBoolForKey(string key) { return false; }

        /// <summary>
        /// Decodes a buffer of data that was previously encoded with encodeBytes:length:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeBytesForKey")]
        public UnsafePointer<uint> DecodeBytesForKey(string key, CMutablePointer<int> lengthp) { return null; }

        /// <summary>
        /// Decodes a buffer of data whose types are unspecified.
        /// </summary>
        [Export("decodeBytesWithReturnedLength")]
        public COpaquePointer DecodeBytesWithReturnedLength(CMutablePointer<int> lengthp) { return null; }

        /// <summary>
        /// Decodes and returns an NSData object that was previously encoded with encodeDataObject:. Subclasses must override this method.
        /// </summary>
        [Export("decodeDataObject")]
        public NSData DecodeDataObject() { return null; }

        /// <summary>
        /// Decodes and returns a double value that was previously encoded with either encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeDoubleForKey")]
        public CDouble DecodeDoubleForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns a float value that was previously encoded with encodeFloat:forKey: or encodeDouble:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeFloatForKey")]
        public CFloat DecodeFloatForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns an int value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeIntForKey")]
        public CInt DecodeIntForKey(string key) { return null; }

        /// <summary>
        /// Decodes and returns an NSInteger value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeIntegerForKey")]
        public int DecodeIntegerForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns a 32-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeInt32ForKey")]
        public Int32 DecodeInt32ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns a 64-bit integer value that was previously encoded with encodeInt:forKey:, encodeInteger:forKey:, encodeInt32:forKey:, or encodeInt64:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeInt64ForKey")]
        public Int64 DecodeInt64ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes an Objective-C object that was previously encoded with any of the encode...Object: methods.
        /// </summary>
        [Export("decodeObject")]
        public AnyObject DecodeObject() { return null; }

        /// <summary>
        /// Decodes and returns an Objective-C object that was previously encoded with encodeObject:forKey: or encodeConditionalObject:forKey: and associated with the string key.
        /// </summary>
        [Export("decodeObjectForKey")]
        public AnyObject DecodeObjectForKey(string key) { return null; }

        /// <summary>
        /// Decodes a single value, whose Objective-C type is given by valueType.
        /// </summary>
        [Export("decodeValueOfObjCType")]
        public void DecodeValueOfObjCType(CString type, CMutableVoidPointer data) { }

        /// <summary>
        /// Decodes an object for the key, restricted to the specified class.
        /// </summary>
        /// <param name="aClass">The expect class type.</param>
        /// <param name="key">The coder key.</param>
        /// <returns>The decoded object.</returns>
        [Export("decodeObjectOfClass")]
        public AnyObject DecodeObjectOfClass(AnyClass aClass, string key) { return null; }

        /// <summary>
        /// Decodes an object for the key, restricted to the specified classes.
        /// </summary>
        /// <param name="classes">A set of the expected classes.</param>
        /// <param name="key">The coder key.</param>
        /// <returns>The decoded object.</returns>
        [Export("decodeObjectOfClasses")]
        public AnyObject DecodeObjectOfClasses(NSSet classes, string key) { return null; }

        /// <summary>
        /// Returns a decoded property list for the specified key.
        /// </summary>
        /// <param name="key">The coder key.</param>
        /// <returns>A decoded object containing a property list.</returns>
        [Export("decodePropertyListForKey")]
        public AnyObject DecodePropertyListForKey(string key) { return null; }

        /// <summary>
        /// Returns whether the coder requires secure coding.
        /// </summary>
        /// <returns>true if this coder requires secure coding; false otherwise.</returns>
        [Export("requiresSecureCoding")]
        public static bool RequiresSecureCoding { get; private set; }

        /// <summary>
        /// Get the current set of coded classes that allow secure coding.
        /// </summary>
        /// <returns>The allowed classes.</returns>
        [Export("allowedClasses")]
        public static NSSet AllowedClasses { get; private set; }

        /// <summary>
        /// During encoding, this method should return the system version currently in effect.
        /// </summary>
        [Export("systemVersion")]
        public static CUnsignedInt SystemVersion { get; private set; }

        /// <summary>
        /// This method is present for historical reasons and is not used with keyed archivers.
        /// </summary>
        /// <returns>The version in effect for the class named className or NSNotFound if no class named className exists.</returns>
        [Export("versionForClassName")]
        public int VersionForClassName(string className) { return 0; }
    }
}
