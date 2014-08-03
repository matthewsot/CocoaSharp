using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The fast enumeration protocol NSFastEnumeration must be adopted and implemented by objects used in conjunction with the for language construct used in conjunction with Cocoa objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSFastEnumeration_protocol/index.html#//apple_ref/occ/intf/NSFastEnumeration"/>    [iOSVersion(2)]    public interface NSFastEnumeration//:    {        /// <summary>        /// Returns by reference a C array of objects over which the sender should iterate, and as the return value the number of objects in the array. (required)        /// </summary>        /// <param name="state">Context information that is used in the enumeration to, in addition to other possibilities, ensure that the collection has not been mutated.</param>        /// <param name="objects">A C array of objects over which the sender is to iterate.</param>        /// <param name="count">The maximum number of objects to return in stackbuf.</param>        [iOSVersion(2)]        [Export("countByEnumeratingWithState")]        int CountByEnumeratingWithState(UnsafePointer<NSFastEnumerationState> state, AutoreleasingUnsafePointer<AnyObject> objects, int count);    }

    /// <summary>
    /// This defines the structure used as contextual information in the NSFastEnumeration protocol
    /// </summary>
    [iOSVersion(2)]
    public struct NSFastEnumerationState
    {
        [Export("state")]
        uint State { get; set; }

        [Export("itemsPtr")]
        AutoreleasingUnsafePointer<AnyObject> ItemsPtr { get; set; }

        [Export("mutationsPtr")]
        UnsafePointer<uint> MutationsPtr { get; set; }

        [Export("extra")]
        Tuple<uint, uint, uint, uint, uint> Extra { get; set; }
    }
}