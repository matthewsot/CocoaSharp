﻿using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSCopying_Protocol/index.html#//apple_ref/occ/intf/NSCopying
    /// <summary>
    /// The NSCopying protocol declares a method for providing functional copies of an object. The exact meaning of “copy” can vary from class to class, but a copy must be a functionally independent object with values identical to the original at the time the copy was made. A copy produced with NSCopying is implicitly retained by the sender, who is responsible for releasing it.
    /// </summary>
    [iOSVersion(2)]
    public interface NSCopying
    {
        /// <summary>
        /// Returns a new instance that’s a copy of the receiver. (required)
        /// </summary>
        /// <param name="zone">The zone identifies an area of memory from which to allocate for the new instance. If zone is NULL, the new instance is allocated from the default zone, which is returned from the function NSDefaultMallocZone.</param>
        [iOSVersion(2)]
        [Export("copyWithZone")]
        AnyObject CopyWithZone(NSZone zone);
    }
}
