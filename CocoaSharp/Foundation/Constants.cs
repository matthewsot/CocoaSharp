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

    public enum NSSearchPathDirectory
    {
        NSApplicationDirectory = 1,
        NSDemoApplicationDirectory,
        NSDeveloperApplicationDirectory,
        NSAdminApplicationDirectory,
        NSLibraryDirectory,
        NSDeveloperDirectory,
        NSUserDirectory,
        NSDocumentationDirectory,
        NSDocumentDirectory,
        NSCoreServiceDirectory,
        NSAutosavedInformationDirectory = 11,
        NSDesktopDirectory = 12,
        NSCachesDirectory = 13,
        NSApplicationSupportDirectory = 14,
        NSDownloadsDirectory = 15,
        NSInputMethodsDirectory = 16,
        NSMoviesDirectory = 17,
        NSMusicDirectory = 18,
        NSPicturesDirectory = 19,
        NSPrinterDescriptionDirectory = 20,
        NSSharedPublicDirectory = 21,
        NSPreferencePanesDirectory = 22,
        NSItemReplacementDirectory = 99,
        NSAllApplicationsDirectory = 100,
        NSAllLibrariesDirectory = 101,
    }

    public enum NSSearchPathDomainMask
    {
        NSUserDomainMask = 1,
        NSLocalDomainMask = 2,
        NSNetworkDomainMask = 4,
        NSSystemDomainMask = 8,
        NSAllDomainsMask = 0x0ffff
    }


    //from https://developer.apple.com/library/prerelease/ios/documentation/Security/Reference/secureTransportRef/index.html#//apple_ref/swift/struct/SSLProtocol
    public enum SSLProtocol
    {
        kSSLProtocolUnknown = 0,
        kSSLProtocol3 = 2,
        kTLSProtocol1 = 4,
        kTLSProtocol11 = 7,
        kTLSProtocol12 = 8,
        kDTLSProtocol1 = 9, /* DEPRECATED on iOS */
        kSSLProtocol2 = 1,
        kSSLProtocol3Only = 3,
        kTLSProtocol1Only = 5,
        kSSLProtocolAll = 6,
    }
}
