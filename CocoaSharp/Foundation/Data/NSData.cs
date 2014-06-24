using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSData_Class/index.html#//apple_ref/occ/cl/NSData
    /// <summary>
    /// NSData and its mutable subclass NSMutableData provide data objects, object-oriented wrappers for byte buffers. Data objects let simple allocated buffers (that is, data with no embedded pointers) take on the behavior of Foundation objects.
    /// </summary>
    [iOSVersion(2)]
    public class NSData : NSObject
    {
        /// <summary>
        /// !!IMPORTANT!! Name the parameter you're using!
        /// Returns a data object initialized with the given Base-64 encoded string.
        /// Deprecation Statement: You should transition to either initWithBase64EncodedString:options: or initWithBase64EncodedData:options:.
        /// </summary>
        /// <param name="base64Encoding">A Base-64 encoded string.</param>
        /// <returns>A data object built by Base-64 decoding the provided string. Returns nil if the data object could not be decoded.</returns>
        [iOSVersion(4)]
        [Obsolete]
        public NSData(string base64Encoding) { }

        /// <summary>
        /// !!IMPORTANT!! Name the parameter you're using!
        /// Returns a data object initialized by reading from the source
        /// </summary>
        /// <param name="contentsOfFile">The absolute path of the file from which to read data.</param>
        /// <param name="contentsOfMappedFile">The absolute path of the file from which to read data.</param>
        [iOSVersion(2)]
        public NSData(string contentsOfFile = "", string contentsOfMappedFile = "") { }

        /// <summary>
        /// Creates and returns a data object by reading every byte from the file specified by a given path.
        /// </summary>
        /// <param name="path">The absolute path of the file from which to read data.</param>
        /// <param name="options">A mask that specifies options for reading the data. Constant components are described in “NSDataReadingOptions”.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem.</param>
        /// <returns>A data object by reading every byte from the file specified by path. Returns nil if the data object could not be created.</returns>
        [iOSVersion(2)]
        [Export("dataWithContentsOfFile")]
        public static NSData DataWithContentsOfFile(string path, NSDataReadingOptions options, NSErrorPointer error) { return null; }

        /// <summary>
        /// Creates and returns a data object from the mapped file specified by path.
        /// </summary>
        /// <param name="path">The absolute path of the file from which to read data.</param>
        /// <returns>A data object from the mapped file specified by path. Returns nil if the data object could not be created.</returns>
        [iOSVersion(2)]
        [Export("dataWithContentsOfMappedFile")]
        public static AnyObject DataWithContentsOfMappedFile(string path) { return null; }

        /// <summary>
        /// Creates and returns a data object containing the data from the location specified by aURL.
        /// </summary>
        /// <param name="aURL">The URL from which to read data.</param>
        /// <param name="options">A mask that specifies options for reading the data. Constant components are described in “NSDataReadingOptions”.</param>
        /// <param name="error">If there is an error reading in the data, upon return contains an NSError object that describes the problem.</param>
        [iOSVersion(2)]
        [Export("dataWithContentsOfURL")]
        public static NSData DataWithContentsOfURL(NSURL aURL, NSDataReadingOptions options, NSErrorPointer error) { return null; }

        /// <summary>
        /// Creates and returns a data object containing the contents of another data object.
        /// </summary>
        /// <param name="aData">A data object.</param>
        /// <returns>A data object containing the contents of aData. Returns nil if the data object could not be created.</returns>
        [iOSVersion(2)]
        [Export("dataWithData")]
        public static NSData DataWithData(NSData aData) { return null; }

        /// <summary>
        /// Returns a data object initialized with the given Base-64 encoded data.
        /// </summary>
        /// <param name="base64EncodedData">A Base-64, UTF-8 encoded data object.</param>
        /// <param name="options">A mask that specifies options for Base-64 decoding the data. Possible values are given in “NSDataBase64DecodingOptions”.</param>
        /// <returns>A data object containing the Base-64 decoded data. Returns nil if the data object could not be decoded.</returns>
        [iOSVersion(7)]
        public NSData(NSData base64EncodedData, NSDataBase64DecodingOptions options) { }

        /// <summary>
        /// Returns a data object initialized with the given Base-64 encoded string.
        /// </summary>
        /// <param name="base64EncodedString">A Base-64 encoded string.</param>
        /// <param name="options">A mask that specifies options for Base-64 decoding the data. Possible values are given in “NSDataBase64DecodingOptions”.</param>
        /// <returns>A data object built by Base-64 decoding the provided string. Returns nil if the data object could not be decoded.</returns>
        [iOSVersion(7)]
        public NSData(string base64EncodedString, NSDataBase64DecodingOptions options) { }

        /// <summary>
        /// Returns a data object initialized by adding to it a given number of bytes of data copied from a given buffer.
        /// </summary>
        [iOSVersion(2)]
        public NSData(CConstVoidPointer bytes, int length) { }

        /// <summary>
        /// Returns a data object initialized by adding to it a given number of bytes of data from a given buffer.
        /// </summary>
        /// <param name="bytesNoCopy">A buffer containing data for the new object. bytes must point to a memory block allocated with malloc.</param>
        /// <param name="length">The number of bytes to hold from bytes. This value must not exceed the length of bytes.</param>
        /// <returns>A data object initialized by adding to it length bytes of data from the buffer bytes. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSData(CMutableVoidPointer bytesNoCopy, int length) { }

        /// <summary>
        /// Returns a data object initialized by adding to it a given number of bytes of data from a given buffer, with a custom deallocator block.
        /// </summary>
        /// <param name="bytesNoCopy">A buffer containing data for the new object.</param>
        /// <param name="length">The number of bytes to hold from bytes. This value must not exceed the length of bytes.</param>
        /// <param name="deallocator">A block to invoke when the resulting NSData object is deallocated.</param>
        /// <returns>A data object initialized by adding to it length bytes of data from the buffer bytes. The returned object might be different than the original receiver.</returns>
        [iOSVersion(7)]
        public NSData(CMutableVoidPointer bytesNoCopy, int length, Action<CMutableVoidPointer, int> deallocator) { }

        /// <summary>
        /// Initializes a newly allocated data object by adding to it length bytes of data from the buffer bytes.
        /// </summary>
        /// <param name="bytesNoCopy">A buffer containing data for the new object. If flag is true, bytes must point to a memory block allocated with malloc.</param>
        /// <param name="length">The number of bytes to hold from bytes. This value must not exceed the length of bytes.</param>
        /// <param name="freeWhenDone">If true, the returned object takes ownership of the bytes pointer and frees it on deallocation.</param>
        [iOSVersion(2)]
        public NSData(CMutableVoidPointer bytesNoCopy, int length, bool freeWhenDone) { }

        /// <summary>
        /// Returns a data object initialized by reading into it the data from the file specified by a given path.
        /// </summary>
        /// <param name="contentsOfFile">The absolute path of the file from which to read data.</param>
        /// <param name="options">A mask that specifies options for reading the data. Constant components are described in “NSDataReadingOptions”.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem.</param>
        /// <returns>A data object initialized by reading into it the data from the file specified by path. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSData(string contentsOfFile, NSDataReadingOptions options, NSErrorPointer error) { }

        /// <summary>
        /// Initializes a newly allocated data object initialized with the data from the location specified by aURL.
        /// </summary>
        /// <param name="contentsOfURL">The URL from which to read data</param>
        /// <returns>An NSData object initialized with the data from the location specified by aURL. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSData(NSURL contentsOfURL) { }

        /// <summary>
        /// Returns a data object initialized with the data from the location specified by a given URL.
        /// </summary>
        /// <param name="contentsOfURL">The URL from which to read data.</param>
        /// <param name="options">A mask that specifies options for reading the data. Constant components are described in “NSDataReadingOptions”.</param>
        /// <param name="error">If there is an error reading in the data, upon return contains an NSError object that describes the problem.</param>
        /// <returns>A data object initialized with the data from the location specified by aURL. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSData(NSURL contentsOfURL, NSDataReadingOptions options, NSErrorPointer error) { }

        /// <summary>
        /// Returns a data object initialized with the contents of another data object.
        /// </summary>
        /// <param name="data">A data object.</param>
        /// <returns>A data object initialized with the contents data. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSData(NSData data) { }

        /// <summary>
        /// Returns a pointer to the receiver’s contents.
        /// </summary>
        /// <returns>A read-only pointer to the receiver’s contents.</returns>
        [iOSVersion(2)]
        [Export("bytes")]
        public COpaquePointer Bytes { get; private set; }

        /// <summary>
        /// Returns an NSString object that contains a hexadecimal representation of the receiver’s contents.
        /// </summary>
        /// <returns>An NSString object that contains a hexadecimal representation of the receiver’s contents in NSData property list format.</returns>
        [iOSVersion(2)]
        [Export("description")]
        public new string Description { get; private set; }

        /// <summary>
        /// Enumerate through each range of bytes in the data object using a block.
        /// </summary>
        /// <param name="block">The block to apply to byte ranges in the array.
        /// The block takes three arguments:        
        /// bytes: The bytes for the current range.
        /// byteRange: The range of the current data bytes.
        /// stop: A reference to a Boolean value. The block can set the value to true to stop further processing of the data. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(7)]
        [Export("enumerateByteRangesUsingBlock")]
        public void EnumerateByteRangesUsingBlock(Action<CConstVoidPointer, NSRange, CMutablePointer<ObjCBool>> block) { }

        /// <summary>
        /// Copies a data object’s contents into a given buffer.
        /// Deprecation Statement: This method is unsafe because it could potentially cause buffer overruns. You should use getBytes:length: or getBytes:range: instead.
        /// </summary>
        /// <param name="buffer">A buffer into which to copy the receiver's data. The buffer must be at least length bytes.</param>
        [iOSVersion(2)]
        [Obsolete]
        [Export("getBytes")]
        public void GetBytes(CMutableVoidPointer buffer) { }

        /// <summary>
        /// Copies a number of bytes from the start of the receiver's data into a given buffer.
        /// </summary>
        /// <param name="buffer">A buffer into which to copy data.</param>
        /// <param name="length">The number of bytes from the start of the receiver's data to copy to buffer.</param>
        [iOSVersion(2)]
        [Export("getBytes")]
        public void GetBytes(CMutableVoidPointer buffer, int length) { }

        /// <summary>
        /// Copies a range of bytes from the receiver’s data into a given buffer.
        /// </summary>
        /// <param name="buffer">A buffer into which to copy data.</param>
        /// <param name="range">The range of bytes in the receiver's data to copy to buffer. The range must lie within the range of bytes of the receiver's data.</param>
        [iOSVersion(2)]
        [Export("getBytes")]
        public void GetBytes(CMutableVoidPointer buffer, NSRange range) { }

        /// <summary>
        /// Returns a data object containing the receiver’s bytes that fall within the limits specified by a given range.
        /// </summary>
        /// <param name="range">The range in the receiver from which to get the data. The range must not exceed the bounds of the receiver.</param>
        /// <returns>A data object containing the receiver’s bytes that fall within the limits specified by range. If range isn’t within the receiver’s range of bytes, raises NSRangeException.</returns>
        [iOSVersion(2)]
        [Export("subdataWithRange")]
        public NSData SubdataWithRange(NSRange range) { return null; }

        /// <summary>
        /// Finds and returns the range of the first occurrence of the given data, within the given range, subject to given options.
        /// </summary>
        /// <param name="dataToFind">The data for which to search. This value must not be nil.       Important     Raises an NSInvalidArgumentException if dataToFind is nil.</param>
        /// <param name="mask">A mask specifying search options. The NSDataSearchOptions options may be specified singly or by combining them with the C bitwise OR operator.</param>
        /// <param name="searchRange">The range within the receiver in which to search for dataToFind. If this range is not within the receiver’s range of bytes, an NSRangeException raised.</param>
        /// <returns>An NSRange structure giving the location and length of dataToFind within searchRange, modulo the options in mask. The range returned is relative to the start of the searched data, not the passed-in search range. Returns {NSNotFound, 0} if dataToFind is not found or is empty (@&quot;&quot;).</returns>
        [iOSVersion(4)]
        [Export("rangeOfData")]
        public NSRange RangeOfData(NSData dataToFind, NSDataSearchOptions options, NSRange range) { return new NSRange(); }

        /// <summary>
        /// Create a Base-64, UTF-8 encoded NSData from the receiver's contents using the given options.
        /// </summary>
        /// <param name="options">A mask that specifies options for Base-64 encoding the data. Possible values are given in “NSDataBase64EncodingOptions”.</param>
        /// <returns>A Base-64, UTF-8 encoded data object.</returns>
        [iOSVersion(7)]
        [Export("base64EncodedDataWithOptions")]
        public NSData Base64EncodedDataWithOptions(NSDataBase64EncodingOptions options) { return null; }

        /// <summary>
        /// Create a Base-64 encoded NSString from the receiver's contents using the given options.
        /// </summary>
        /// <param name="options">A mask that specifies options for Base-64 encoding the data. Possible values are given in “NSDataBase64EncodingOptions”.</param>
        /// <returns>A Base-64 encoded string.</returns>
        [iOSVersion(7)]
        [Export("base64EncodedStringWithOptions")]
        public string Base64EncodedStringWithOptions(NSDataBase64EncodingOptions options) { return ""; }

        /// <summary>
        /// Create a Base-64 encoded NSString from the receiver's contents.
        /// Deprecation Statement: You should transition to either base64EncodedStringWithOptions: or base64EncodedDataWithOptions:
        /// </summary>
        /// <returns>A Base-64 encoded string.</returns>
        [iOSVersion(4)]
        [Obsolete]
        [Export("base64Encoding")]
        public string Base64Encoding() { return ""; }

        /// <summary>
        /// Compares the receiving data object to otherData.
        /// </summary>
        /// <param name="otherData">The data object with which to compare the receiver.</param>
        /// <returns>true if the contents of otherData are equal to the contents of the receiver, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isEqualToData")]
        public bool IsEqualToData(NSData otherData) { return false; }

        /// <summary>
        /// Returns the number of bytes contained in the receiver.
        /// </summary>
        /// <returns>The number of bytes contained in the receiver.</returns>
        [iOSVersion(2)]
        [Export("length")]
        public int Length { get; private set; }

        /// <summary>
        /// Writes the bytes in the receiver to the file specified by a given path.
        /// </summary>
        /// <param name="path">The location to which to write the receiver's bytes. If path contains a tilde (~) character, you must expand it with stringByExpandingTildeInPath before invoking this method.</param>
        /// <param name="atomically">If true, the data is written to a backup file, and then—assuming no errors occur—the backup file is renamed to the name specified by path; otherwise, the data is written directly to path.</param>
        /// <returns>true if the operation succeeds, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically) { return false; }

        /// <summary>
        /// Writes the bytes in the receiver to the file specified by a given path.
        /// </summary>
        /// <param name="path">The location to which to write the receiver's bytes.</param>
        /// <param name="options">A mask that specifies options for writing the data. Constant components are described in “NSDataWritingOptions”.</param>
        /// <param name="error">If there is an error writing out the data, upon return contains an NSError object that describes the problem.</param>
        /// <returns>true if the operation succeeds, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, NSDataWritingOptions options, NSErrorPointer error) { return false; }

        /// <summary>
        /// Writes the bytes in the receiver to the location specified by aURL.
        /// </summary>
        /// <param name="aURL">The location to which to write the receiver's bytes. Only file:// URLs are supported.</param>
        /// <param name="atomically">If true, the data is written to a backup location, and then—assuming no errors occur—the backup location is renamed to the name specified by aURL; otherwise, the data is written directly to aURL. atomically is ignored if aURL is not of a type the supports atomic writes.</param>
        /// <returns>true if the operation succeeds, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL aURL, bool atomically) { return false; }

        /// <summary>
        /// Writes the bytes in the receiver to the location specified by a given URL.
        /// </summary>
        /// <param name="aURL">The location to which to write the receiver's bytes.</param>
        /// <param name="options">A mask that specifies options for writing the data. Constant components are described in “NSDataWritingOptions”.</param>
        /// <param name="error">If there is an error writing out the data, upon return contains an NSError object that describes the problem.</param>
        /// <returns>true if the operation succeeds, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL aURL, NSDataWritingOptions options, NSErrorPointer error) { return false; }

        /// <summary>
        /// Options for methods used to read NSData objects.
        /// </summary>
        [iOSVersion(4)]
        public enum NSDataReadingOptions 
        { 
            /// <summary>
            /// A hint indicating the file should be mapped into virtual memory, if possible and safe.
            /// </summary>
            [iOSVersion(5)]
            DataReadingMappedIfSafe,
            /// <summary>
            ///  A hint indicating the file should not be stored in the file-system caches.
            ///  For data being read once and discarded, this option can improve performance. 
            /// </summary>
            [iOSVersion(4)]
            DataReadingUncached,
            /// <summary>
            ///  Hint to map the file in if possible.
            ///  This takes precedence over NSDataReadingMappedIfSafe if both are given. 
            /// </summary>
            [iOSVersion(5)]
            DataReadingMappedAlways,
            /// <summary>
            /// Deprecated name for NSDataReadingMappedIfSafe.
            /// </summary>
            [iOSVersion(4)]
            [Obsolete]
            DataReadingMapped,
            /// <summary>
            /// Deprecated name for NSDataReadingMapped. 
            /// </summary>
            [iOSVersion(2)]
            [Obsolete]
            MappedRead,
            /// <summary>
            /// Deprecated name for NSDataReadingUncached. 
            /// </summary>
            [iOSVersion(2)]
            [Obsolete]
            UncachedRead
        }

        /// <summary>
        /// Options for methods used to Base-64 encode data.
        /// </summary>
        [iOSVersion(7)]
        public enum NSDataBase64EncodingOptions {
            /// <summary>
            /// Set the maximum line length to 64 characters, after which a line ending is inserted.
            /// </summary>
            [iOSVersion(7)]
            Encoding64CharacterLineLength,
            /// <summary>
            /// Set the maximum line length to 76 characters, after which a line ending is inserted.
            /// </summary>
            [iOSVersion(7)]
            Encoding76CharacterLineLength,
            /// <summary>
            /// When a maximum line length is set, specify that the line ending to insert should include a carriage return.
            /// </summary>
            [iOSVersion(7)]
            EncodingEndLineWithCarriageReturn,
            /// <summary>
            /// When a maximum line length is set, specify that the line ending to insert should include a line feed.
            /// </summary>
            [iOSVersion(7)]
            EncodingEndLineWithLineFeed
        }

        /// <summary>
        /// Options to modify the decoding algorithm used to decode Base-64 encoded NSData objects.
        /// </summary>
        [iOSVersion(7)]
        public enum NSDataBase64DecodingOptions {
            /// <summary>
            /// Modify the decoding algorithm so that it ignores unknown non-Base-64 bytes, including line ending characters. 
            /// </summary>
            [iOSVersion(7)]
            IgnoreUnknownCharacters
        }

        /// <summary>
        /// Options for methods used to write NSData objects.
        /// </summary>
        [iOSVersion(4)]
        public enum NSDataWritingOptions {
            /// <summary>
            /// A hint to write data to an auxiliary file first and then exchange the files. This option is equivalent to using a write method taking the parameter atomically:YES. 
            /// </summary>
            [iOSVersion(4)]
            DataWritingAtomic,
            /// <summary>
            /// Hint to return prevent overwriting an existing file. Cannot be combined with NSDataWritingAtomic. 
            /// </summary>
            [iOSVersion(6)]
            DataWritingWithoutOverwriting,
            /// <summary>
            /// A hint to set the content protection attribute of the file when writing it out. In this case, the file is not stored in an encrypted format and may be accessed at boot time and while the device is unlocked. 
            /// </summary>
            [iOSVersion(4)]
            DataWritingFileProtectionNone,
            /// <summary>
            /// A hint to set the content protection attribute of the file when writing it out. In this case, the file is stored in an encrypted format and may be read from or written to only while the device is unlocked. At all other times, attempts to read and write the file result in failure. 
            /// </summary>
            [iOSVersion(4)]
            DataWritingFileProtectionComplete,
            /// <summary>
            /// A hint to set the content protection attribute of the file when writing it out. In this case, the file cannot be opened for reading or writing when the device is locked, although new files can be created with this class. If one of these files is open when the device is locked, reading and writing are still allowed. 
            /// </summary>
            [iOSVersion(5)]
            DataWritingFileProtectionCompleteUnlessOpen,
            /// <summary>
            /// A hint to set the content protection attribute of the file when writing it out. In this case, the file can be read or written to while the device is locked, but while it is booting up, they have protection equivalent to NSDataWritingFileProtectionComplete.
            /// </summary>
            [iOSVersion(5)]
            DataWritingFileProtectionCompleteUntilFirstUserAuthentication,
            /// <summary>
            /// A mask to use when determining the file protection options assigned to the data. 
            /// </summary>
            [iOSVersion(4)]
            DataWritingFileProtectionMask,
            /// <summary>
            /// Deprecated name for NSDataWritingAtomic.
            /// </summary>
            [iOSVersion(2)]
            [Obsolete]
            AtomicWrite
        }

        /// <summary>
        /// Options for method used to search NSData objects. These options are used with the rangeOfData:options:range: method.
        /// </summary>
        [iOSVersion(4)]
        public enum NSDataSearchOptions {
            /// <summary>
            /// Search from the end of NSData object.
            /// </summary>
            [iOSVersion(4)]
            Backwards,
            /// <summary>
            ///  Search is limited to start (or end, if NSDataSearchBackwards) of NSData object.
            ///  This option performs searching only on bytes at the beginning or end of the range. No match at the beginning or end means nothing is found, even if a matching sequence of bytes occurs elsewhere in the data object. 
            /// </summary>
            [iOSVersion(4)]
            Anchored
        }
    }
}
