using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectiveC;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSKeyedUnarchiver_Class/index.html#//apple_ref/occ/cl/NSKeyedUnarchiver
    /// <summary>
    /// NSKeyedUnarchiver, a concrete subclass of NSCoder, defines methods for decoding a set of named objects (and scalar values) from a keyed archive. Such archives are produced by instances of the NSKeyedArchiver class.
    /// </summary>
    public class NSKeyedUnarchiver : NSCoder
    {
        /// <summary>
        /// Initializes the receiver for decoding an archive previously encoded by NSKeyedArchiver.
        /// </summary>
        /// <param name="data">An archive previously encoded by NSKeyedArchiver.</param>
        /// <returns>An NSKeyedUnarchiver object initialized for for decoding data.</returns>
        [Export("init")]
        public void Init(NSData forReadingWithData) { }

        /// <summary>
        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver and stored in a given NSData object.
        /// </summary>
        /// <param name="data">An object graph previously encoded by NSKeyedArchiver.</param>
        /// <returns>The object graph previously encoded by NSKeyedArchiver and stored in data.</returns>
        [Export("unarchiveObjectWithData")]
        public static AnyObject UnarchiveObjectWithData(NSData data) { return null; }

        /// <summary>
        /// Decodes and returns the object graph previously encoded by NSKeyedArchiver written to the file at a given path.
        /// </summary>
        /// <param name="path">A path to a file that contains an object graph previously encoded by NSKeyedArchiver.</param>
        /// <returns>The object graph previously encoded by NSKeyedArchiver written to the file path. Returns nil if there is no file at path.</returns>
        [Export("unarchiveObjectWithFile")]
        public static AnyObject UnarchiveObjectWithFile(string path) { return null; }

        /// <summary>
        /// Indicates whether the receiver requires all unarchived classes to conform to NSSecureCoding.
        /// </summary>
        /// <param name="flag">true if the receiver requires NSSecureCoding; false if not.</param>
        [Export("setRequiresSecureCoding")]
        public void SetRequiresSecureCoding(bool flag) { }

        /// <summary>
        /// Returns a Boolean value that indicates whether the archive contains a value for a given key within the current decoding scope.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>true if the archive contains a value for key within the current decoding scope, otherwise false.</returns>
        [Export("containsValueForKey")]
        public bool ContainsValueForKey(string key) { return false; }

        /// <summary>
        /// Decodes a Boolean value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The Boolean value associated with the key key. Returns false if key does not exist.</returns>
        [Export("decodeBoolForKey")]
        public bool DecodeBoolForKey(string key) { return false; }

        /// <summary>
        /// Decodes a stream of bytes associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <param name="lengthp">Upon return, contains the number of bytes returned.</param>
        /// <returns>The stream of bytes associated with the key key. Returns NULL if key does not exist.</returns>
        [Export("decodeBytesForKey")]
        public UnsafePointer<uint> DecodeBytesForKey(string key, CMutablePointer<int> returnedLength) { return null; }

        /// <summary>
        /// Decodes a double-precision floating-point value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The double-precision floating-point value associated with the key key. Returns 0.0 if key does not exist.</returns>
        [Export("decodeDoubleForKey")]
        public CDouble DecodeDoubleForKey(string key) { return null; }

        /// <summary>
        /// Decodes a single-precision floating-point value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The single-precision floating-point value associated with the key key. Returns 0.0 if key does not exist.</returns>
        [Export("decodeFloatForKey")]
        public CFloat DecodeFloatForKey(string key) { return null; }

        /// <summary>
        /// Decodes an integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [Export("decodeIntForKey")]
        public CInt DecodeIntForKey(string key) { return null; }

        /// <summary>
        /// Decodes a 32-bit integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The 32-bit integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [Export("decodeInt32ForKey")]
        public Int32 DecodeInt32ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes a 64-bit integer value associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The 64-bit integer value associated with the key key. Returns 0 if key does not exist.</returns>
        [Export("decodeInt64ForKey")]
        public Int64 DecodeInt64ForKey(string key) { return 0; }

        /// <summary>
        /// Decodes and returns an object associated with a given key.
        /// </summary>
        /// <param name="key">A key in the archive within the current decoding scope. key must not be nil.</param>
        /// <returns>The object associated with the key key. Returns nil if key does not exist, or if the value for key is nil.</returns>
        [Export("decodeObjectForKey")]
        public AnyObject DecodeObjectForKey(string key) { return null; }

        /// <summary>
        /// Tells the receiver that you are finished decoding objects.
        /// </summary>
        [Export("finishDecoding")]
        public void FinishDecoding() { }

        /// <summary>
        /// Gets or sets the receiver’s delegate.
        /// </summary>
        /// <returns>The receiver’s delegate.</returns>
        [Export("delegate")]
        public static NSKeyedUnarchiverDelegate Delegate { get; set; }

        /// <summary>
        /// Adds a class translation mapping to NSKeyedUnarchiver whereby objects encoded with a given class name are decoded as instances of a given class instead.
        /// </summary>
        /// <param name="cls">The class with which to replace instances of the class named codedName.</param>
        /// <param name="codedName">The ostensible name of a class in an archive.</param>
        [Export("setClass")]
        public static void SetClass(AnyClass cls, string forClassName) { }

        /// <summary>
        /// Returns the class from which NSKeyedUnarchiver instantiates an encoded object with a given class name.
        /// </summary>
        /// <param name="codedName">The ostensible name of a class in an archive.</param>
        /// <returns>The class from which NSKeyedUnarchiver instantiates an object encoded with the class name codedName. Returns nil if NSKeyedUnarchiver does not have a translation mapping for codedName.</returns>
        [Export("classForClassName")]
        public static AnyClass ClassForClassName(string codedName) { return null; }

        /// <summary>
        /// Names of exceptions that are raised by NSKeyedUnarchiver if there is a problem extracting an archive.
        /// </summary>
        [Export("NSInvalidUnarchiveOperationException")]
        public static string NSInvalidUnarchiveOperationException { get; private set; }
    }
}
