using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableData_Class/index.html#//apple_ref/swift/cl/NSMutableData
    /// <summary>
    /// NSMutableData (and its superclass NSData) provide data objects, object-oriented wrappers for byte buffers. Data objects let simple allocated buffers (that is, data with no embedded pointers) take on the behavior of Foundation objects. They are typically used for data storage and are also useful in Distributed Objects applications, where data contained in data objects can be copied or moved between applications. NSData creates static data objects, and NSMutableData creates dynamic data objects. You can easily convert one type of data object to the other with the initializer that takes an NSData object or an NSMutableData object as an argument.
    /// </summary>
    [iOSVersion(2)]
    public class NSMutableData : NSData
    {
        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using
        /// Initializes and returns an NSMutableData object capable containing a given number of bytes.
        /// If you pass 'length' those bytes will be zeroed.
        /// </summary>
        /// <param name="capacity">The number of bytes the data object can initially contain.</param>
        /// <param name="length">The number of bytes the object initially contains.</param>
        [iOSVersion(2)]
        public NSMutableData(int capacity = 0, int length = 0) { }

        /// <summary>
        /// Increases the length of the receiver by a given number of bytes.
        /// </summary>
        /// <param name="extraLength">The number of bytes by which to increase the receiver's length.</param>
        [iOSVersion(2)]
        [Export("increaseLengthBy")]
        public void IncreaseLengthBy(int extraLength) { }

        /// <summary>
        /// Extends or truncates a mutable data object to a given length.
        /// </summary>
        [iOSVersion(2)]
        [Export("length")]
        public new int Length { get; set; }

        /// <summary>
        /// Returns a pointer to the receiver’s data.
        /// </summary>
        /// <returns>A pointer to the receiver’s data.</returns>
        [iOSVersion(2)]
        [Export("mutableBytes")]
        public COpaquePointer MutableBytes { get; private set; }

        /// <summary>
        /// Appends to the receiver a given number of bytes from a given buffer.
        /// </summary>
        /// <param name="bytes">A buffer containing data to append to the receiver's content.</param>
        /// <param name="length">The number of bytes from bytes to append.</param>
        [iOSVersion(2)]
        [Export("appendBytes")]
        public void AppendBytes(CConstVoidPointer bytes, int length) { }

        /// <summary>
        /// Appends the content of another NSData object to the receiver.
        /// </summary>
        /// <param name="otherData">The data object whose content is to be appended to the contents of the receiver.</param>
        [iOSVersion(2)]
        [Export("appendData")]
        public void AppendData(NSData otherData) { }

        /// <summary>
        /// Replaces with a given set of bytes a given range within the contents of the receiver.
        /// </summary>
        /// <param name="range">The range within the receiver's contents to replace with bytes. The range must not exceed the bounds of the receiver.</param>
        /// <param name="withBytes">The data to insert into the receiver's contents.</param>
        [iOSVersion(2)]
        [Export("replaceBytesInRange")]
        public void ReplaceBytesInRange(NSRange range, CConstVoidPointer withBytes) { }

        /// <summary>
        /// Replaces with a given set of bytes a given range within the contents of the receiver.
        /// </summary>
        /// <param name="range">The range within the receiver's contents to replace with bytes. The range must not exceed the bounds of the receiver.</param>
        /// <param name="withBytes">The data to insert into the receiver's contents.</param>
        /// <param name="length">The number of bytes to take from replacementBytes.</param>
        [iOSVersion(2)]
        [Export("replaceBytesInRange")]
        public void ReplaceBytesInRange(NSRange range, CConstVoidPointer withBytes, int length) { }

        /// <summary>
        /// Replaces with zeroes the contents of the receiver in a given range.
        /// </summary>
        /// <param name="range">The range within the contents of the receiver to be replaced by zeros. The range must not exceed the bounds of the receiver.</param>
        [iOSVersion(2)]
        [Export("resetBytesInRange")]
        public void ResetBytesInRange(NSRange range) { }

        /// <summary>
        /// Replaces the entire contents of the receiver with the contents of another data object.
        /// </summary>
        /// <param name="aData">The data object whose content replaces that of the receiver.</param>
        [iOSVersion(2)]
        [Export("setData")]
        public void SetData(NSData aData) { }
    }
}
