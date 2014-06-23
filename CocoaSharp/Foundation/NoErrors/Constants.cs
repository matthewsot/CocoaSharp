using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace Foundation
{
    //TODO: more from https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_Constants/index.html#//apple_ref/swift/struct/NSEnumerationOptions

    /// <summary>
    /// Options for Block enumeration operations. 
    /// </summary>
    [iOSVersion(4)]
    public enum NSEnumerationOptions
    {
        /// <summary>
        /// Specifies that the Block enumeration should be concurrent.
        /// The order of invocation is nondeterministic and undefined; this flag is a hint and may be ignored by the implementation under some circumstances; the code of the Block must be safe against concurrent invocation. 
        /// </summary>
        [iOSVersion(4)]
        Concurrent,

        /// <summary>
        /// Specifies that the enumeration should be performed in reverse.
        /// This option is available for NSArray and NSIndexSet classes; its behavior is undefined for NSDictionary and NSSet classes, or when combined with the NSEnumerationConcurrent flag. 
        /// </summary>
        [iOSVersion(4)]
        Reverse
    }

    /// <summary>
    /// Options for Block sorting operations
    /// </summary>
    [iOSVersion(4)]
    public enum NSSortOptions
    {
        /// <summary>
        ///  Specifies that the Block sort operation should be concurrent.
        /// This option is a hint and may be ignored by the implementation under some circumstances; the code of the Block must be safe against concurrent invocation. 
        /// </summary>
        [iOSVersion(4)]
        Concurrent,

        /// <summary>
        /// Specifies that the sorted results should return compared items have equal value in the order they occurred originally.
        /// If this option is unspecified equal objects may, or may not, be returned in their original order. 
        /// </summary>
        [iOSVersion(4)]
        Stable
    }
}
