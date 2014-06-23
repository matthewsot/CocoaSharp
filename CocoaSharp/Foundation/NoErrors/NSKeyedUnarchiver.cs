using System;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSKeyedUnarchiver_Class/index.html#//apple_ref/occ/cl/NSKeyedUnarchiver
    /// <summary>
    /// NSKeyedUnarchiver, a concrete subclass of NSCoder, defines methods for decoding a set of named objects (and scalar values) from a keyed archive. Such archives are produced by instances of the NSKeyedArchiver class.
    /// </summary>
    [iOSVersion(2)]
    public class NSKeyedUnarchiver : NSCoder
    {
        /// <summary>
        /// Initializes the receiver for decoding an archive previously encoded by NSKeyedArchiver.
        /// </summary>
        /// <param name="forReadingWithData">An archive previously encoded by NSKeyedArchiver.</param>
        /// <returns>An NSKeyedUnarchiver object initialized for for decoding data.</returns>
        [iOSVersion(2)]
        [Export("init")]
        public void Init(NSData forReadingWithData) { }

        /// <summary>
        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver and stored in a given NSData object.
        /// </summary>
        /// <param name="data">An object graph previously encoded by NSKeyedArchiver.</param>
        /// <returns>The object graph previously encoded by NSKeyedArchiver and stored in data.</returns>
        [iOSVersion(2)]
        [Export("unarchiveObjectWithData")]
        public static AnyObject UnarchiveObjectWithData(NSData data) { return null; }

        /// <summary>
        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver written to the file at a given path.
        /// </summary>
        /// <param name="path">A path to a file that contains an object graph previously encoded by NSKeyedArchiver.</param>
        /// <returns>The object graph previously encoded by NSKeyedArchiver written to the file path. Returns nil if there is no file at path.</returns>
        [iOSVersion(2)]
        [Export("unarchiveObjectWithFile")]
        public static AnyObject UnarchiveObjectWithFile(string path) { return null; }

        /// <summary>
        /// Indicates whether the receiver requires all unarchived classes to conform to NSSecureCoding.
        /// </summary>
        /// <param name="flag">true if the receiver requires NSSecureCoding; false if not.</param>
        [iOSVersion(6)]
        [Export("setRequiresSecureCoding")]
        public void SetRequiresSecureCoding(bool flag) { }

        /// <summary>
        /// Returns a Boolean value that indicates whether the archive contains a value for a given key within the current decoding scope.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>true if the archive contains a value for key within the current decoding scope, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("containsValueForKey")]
        public new bool ContainsValueForKey(string key) { return false; }

        /// <summary>
        /// Decodes a Boolean value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The Boolean value associated with the key key. Returns false if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeBoolForKey")]
        public new bool DecodeBoolForKey(string key) { return false; }

        /// <summary>
        /// Decodes a stream of bytes associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <param name="returnedLength">Upon return, contains the number of bytes returned.</param>
        /// <returns>The stream of bytes associated with the key key. Returns NULL if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeBytesForKey")]
        public new UnsafePointer<uint> DecodeBytesForKey(string key, CMutablePointer<int> returnedLength) { return null; }

        /// <summary>
        /// Decodes a double-precision floating-point value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The double-precision floating-point value associated with the key key. Returns 0.0 if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeDoubleForKey")]
        public new CDouble DecodeDoubleForKey(string key) { return null; }

        /// <summary>
        /// Decodes a single-precision floating-point value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The single-precision floating-point value associated with the key key. Returns 0.0 if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeFloatForKey")]
        public new CFloat DecodeFloatForKey(string key) { return null; }

        /// <summary>
        /// Decodes an integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeIntForKey")]
        public new CInt DecodeIntForKey(string key) { return null; }

        /// <summary>
        /// Decodes a 32-bit integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The 32-bit integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeInt32ForKey")]
        public new Int32 DecodeInt32ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes a 64-bit integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The 64-bit integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [iOSVersion(2)]
        [Export("decodeInt64ForKey")]
        public new Int64 DecodeInt64ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns an object associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The object associated with the key key. Returns nil if key does not exist, or if the value for key is nil.</returns>
        [iOSVersion(2)]
        [Export("decodeObjectForKey")]
        public new AnyObject DecodeObjectForKey(string key) { return null; }

        /// <summary>
        /// Tells the receiver that you are finished decoding objects.
        /// </summary>
        [iOSVersion(2)]
        [Export("finishDecoding")]
        public void FinishDecoding() { }

        /// <summary>
        /// Sets or returns the receiver’s delegate.
        /// </summary>
        /// <returns>The receiver’s delegate.</returns>
        [iOSVersion(2)]
        [Export("delegate")]
        public NSKeyedUnarchiverDelegate Delegate { get; set; }

        /// <summary>
        /// Adds a class translation mapping to NSKeyedUnarchiver whereby objects encoded with a given class name are decoded as instances of a given class instead.
        /// </summary>
        /// <param name="cls">The class with which to replace instances of the class named codedName.</param>
        /// <param name="forClassName">The ostensible name of a class in an archive.</param>
        [iOSVersion(2)]
        [Export("setClass")]
        public static void SetClass(AnyClass cls, string forClassName) { }

        /// <summary>
        /// Returns the class from which NSKeyedUnarchiver instantiates an encoded object with a given class name.
        /// </summary>
        /// <param name="codedName">The ostensible name of a class in an archive.</param>
        /// <returns>The class from which NSKeyedUnarchiver instantiates an object encoded with the class name codedName. Returns nil if NSKeyedUnarchiver does not have a translation mapping for codedName.</returns>
        [iOSVersion(2)]
        [Export("classForClassName")]
        public static AnyClass ClassForClassName(string codedName) { return null; }

        /// <summary>
        /// It's not necessary to use this
        /// Adds a class translation mapping to the receiver whereby objects encoded with a given class name are decoded as instances of a given class instead.
        /// </summary>
        /// <param name="cls">The class with which to replace instances of the class named codedName.</param>
        /// <param name="forClassName">The ostensible name of a class in an archive.</param>
        [iOSVersion(2)]
        [Export("setClass")]
        public void SetClassInstance(AnyClass cls, string forClassName) { }

        /// <summary>
        /// It's not necessary to use this
        /// Returns the class from which the receiver instantiates an encoded object with a given class name.
        /// </summary>
        /// <param name="codedName">The name of a class.</param>
        /// <returns>The class from which the receiver instantiates an encoded object with the class name codedName. Returns nil if the receiver does not have a translation mapping for codedName.</returns>
        [iOSVersion(2)]
        [Export("classForClassName")]
        public AnyClass ClassForClassNameInstance(string codedName) { return null; }

        //TODO: NSInvalidUnarchiveOperatorException is a constant

        /// <summary>
        /// Names of exceptions that are raised by NSKeyedUnarchiver if there is a problem extracting an archive.
        /// </summary>
        [Export("NSInvalidUnarchiveOperationException")]
        public static string NSInvalidUnarchiveOperationException { get; private set; }
    }
}
