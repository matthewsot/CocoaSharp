using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_Constants/index.html#//apple_ref/doc/uid/TP40003793
    /// <summary>
    /// This document defines constants in the Foundation framework that are not associated with a particular class.
    /// </summary>

    /// <summary>
    /// Options for Block enumeration operations.
    /// </summary>
    [iOSVersion(4)]
    public enum NSEnumerationOptions
    {
        /// <summary>
        /// Specifies that the Block enumeration should be concurrent.
        /// </summary>
        [iOSVersion(4)] Concurrent,

        /// <summary>
        /// Specifies that the enumeration should be performed in reverse.
        /// </summary>
        [iOSVersion(4)] Reverse,
    }

    /// <summary>
    /// These constants are used to indicate how items in a request are ordered.
    /// </summary>
    public enum NSComparisonResult
    {
        /// <summary>
        /// The left operand is smaller than the right operand.
        /// </summary>
        [iOSVersion(2)] OrderedAscending,

        /// <summary>
        /// The two operands are equal.
        /// </summary>
        [iOSVersion(2)] OrderedSame,

        /// <summary>
        /// The left operand is greater than the right operand.
        /// </summary>
        [iOSVersion(2)] OrderedDescending,
    }

    /// <summary>
    /// Options for Block sorting operations.
    /// </summary>
    [iOSVersion(4)]
    public enum NSSortOptions
    {
        /// <summary>
        /// Specifies that the Block sort operation should be concurrent.
        /// </summary>
        [iOSVersion(4)] Concurrent,

        /// <summary>
        /// Specifies that the sorted results should return compared items have equal value in the order they occurred originally.
        /// </summary>
        [iOSVersion(4)] Stable,
    }

    /// <summary>
    /// These constants specify the location of a variety of directories by the URLsForDirectory:inDomains: and URLForDirectory:inDomain:appropriateForURL:create:error: NSFileManager methods.
    /// </summary>
    [iOSVersion(2)]
    public enum NSSearchPathDirectory
    {
        /// <summary>
        /// Supported applications (/Applications).
        /// </summary>
        [iOSVersion(2)] ApplicationDirectory,

        /// <summary>
        /// Unsupported applications and demonstration versions.
        /// </summary>
        [iOSVersion(2)] DemoApplicationDirectory,

        /// <summary>
        /// Developer applications (/Developer/Applications).
        /// </summary>
        [iOSVersion(2)] DeveloperApplicationDirectory,

        /// <summary>
        /// System and network administration applications.
        /// </summary>
        [iOSVersion(2)] AdminApplicationDirectory,

        /// <summary>
        /// Various user-visible documentation, support, and configuration files (/Library).
        /// </summary>
        [iOSVersion(2)] LibraryDirectory,

        /// <summary>
        /// Developer resources (/Developer).
        /// </summary>
        [iOSVersion(2)] DeveloperDirectory,

        /// <summary>
        /// User home directories (/Users).
        /// </summary>
        [iOSVersion(2)] UserDirectory,

        /// <summary>
        /// Documentation.
        /// </summary>
        [iOSVersion(2)] DocumentationDirectory,

        /// <summary>
        /// Document directory.
        /// </summary>
        [iOSVersion(2)] DocumentDirectory,

        /// <summary>
        /// Location of core services (System/Library/CoreServices).
        /// </summary>
        [iOSVersion(2)] CoreServiceDirectory,

        /// <summary>
        /// Location of user’s autosaved documents Library/Autosave Information
        /// </summary>
        [iOSVersion(4)] AutosavedInformationDirectory,

        /// <summary>
        /// Location of user’s desktop directory.
        /// </summary>
        [iOSVersion(2)] DesktopDirectory,

        /// <summary>
        /// Location of discardable cache files (Library/Caches).
        /// </summary>
        [iOSVersion(2)] CachesDirectory,

        /// <summary>
        /// Location of application support files (Library/Application Support).
        /// </summary>
        [iOSVersion(2)] ApplicationSupportDirectory,

        /// <summary>
        /// Location of the user’s downloads directory.
        /// </summary>
        [iOSVersion(2)] DownloadsDirectory,

        /// <summary>
        /// Location of Input Methods (Library/Input Methods)
        /// </summary>
        [iOSVersion(4)] InputMethodsDirectory,

        /// <summary>
        /// Location of user's Movies directory (~/Movies)
        /// </summary>
        [iOSVersion(4)] MoviesDirectory,

        /// <summary>
        /// Location of user's Music directory (~/Music)
        /// </summary>
        [iOSVersion(4)] MusicDirectory,

        /// <summary>
        /// Location of user's Pictures directory (~/Pictures)
        /// </summary>
        [iOSVersion(4)] PicturesDirectory,

        /// <summary>
        /// Location of system's PPDs directory (Library/Printers/PPDs)
        /// </summary>
        [iOSVersion(4)] PrinterDescriptionDirectory,

        /// <summary>
        /// Location of user's Public sharing directory (~/Public)
        /// </summary>
        [iOSVersion(4)] SharedPublicDirectory,

        /// <summary>
        /// Location of the PreferencePanes directory for use with System Preferences (Library/PreferencePanes)
        /// </summary>
        [iOSVersion(4)] PreferencePanesDirectory,

        /// <summary>
        /// No info
        /// </summary>
        ApplicationScriptsDirectory,

        /// <summary>
        /// For use with NSFileManager method URLForDirectory:inDomain:appropriateForURL:create:error:
        /// </summary>
        [iOSVersion(4)] ItemReplacementDirectory,

        /// <summary>
        /// All directories where applications can occur.
        /// </summary>
        [iOSVersion(2)] AllApplicationsDirectory,

        /// <summary>
        /// All directories where resources can occur.
        /// </summary>
        [iOSVersion(2)] AllLibrariesDirectory,

        /// <summary>
        /// No info
        /// </summary>
        TrashDirectory,
    }

    /// <summary>
    /// Search path domain constants specifying base locations for the NSSearchPathDirectory type. These constants are used by the URLsForDirectory:inDomains: and URLForDirectory:inDomain:appropriateForURL:create:error: NSFileManager methods.
    /// </summary>
    public enum NSSearchPathDomainMask
    {
        /// <summary>
        /// The user’s home directory—the place to install user’s personal items (~).
        /// </summary>
        [iOSVersion(2)] UserDomainMask,

        /// <summary>
        /// Local to the current machine—the place to install items available to everyone on this machine.
        /// </summary>
        [iOSVersion(2)] LocalDomainMask,

        /// <summary>
        /// Publicly available location in the local area network—the place to install items available on the network (/Network).
        /// </summary>
        [iOSVersion(2)] NetworkDomainMask,

        /// <summary>
        /// Provided by Apple—can’t be modified (/System) .
        /// </summary>
        [iOSVersion(2)] SystemDomainMask,

        /// <summary>
        /// All domains.
        /// </summary>
        [iOSVersion(2)] AllDomainsMask,
    }

    /// <summary>
    /// NSError codes in the Cocoa error domain.
    /// </summary>
    [Global]
    public static class NSErrorCodes
    {
        /// <summary>
        /// File-system operation attempted on non-existent file
        /// </summary>
        [iOSVersion(2)] public const int NSFileNoSuchFileError = 0;

        /// <summary>
        /// Failure to get a lock on file
        /// </summary>
        [iOSVersion(2)] public const int NSFileLockingError = 0;

        /// <summary>
        /// Read error, reason unknown
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadUnknownError = 0;

        /// <summary>
        /// Read error because of a permission problem
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadNoPermissionError = 0;

        /// <summary>
        /// Read error because of an invalid file name
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadInvalidFileNameError = 0;

        /// <summary>
        /// Read error because of a corrupted file, bad format, or similar reason
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadCorruptFileError = 0;

        /// <summary>
        /// Read error because no such file was found
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadNoSuchFileError = 0;

        /// <summary>
        /// Read error because the string encoding was not applicable.
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadInapplicableStringEncodingError = 0;

        /// <summary>
        /// Read error because the specified URL scheme is unsupported
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadUnsupportedSchemeError = 0;

        /// <summary>
        /// Read error because the specified file was too large.
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadTooLargeError = 0;

        /// <summary>
        /// Read error because the string coding of the file could not be determined
        /// </summary>
        [iOSVersion(2)] public const int NSFileReadUnknownStringEncodingError = 0;

        /// <summary>
        /// Write error, reason unknown
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteUnknownError = 0;

        /// <summary>
        /// Write error because of a permission problem
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteNoPermissionError = 0;

        /// <summary>
        /// Write error because of an invalid file name
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteInvalidFileNameError = 0;

        /// <summary>
        /// Write error returned when NSFileManager class’s copy, move, and link methods report errors when the destination file already exists.
        /// </summary>
        [iOSVersion(5)] public const int NSFileWriteFileExistsError = 0;

        /// <summary>
        /// Write error because the string encoding was not applicable.
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteInapplicableStringEncodingError = 0;

        /// <summary>
        /// Write error because the specified URL scheme is unsupported
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteUnsupportedSchemeError = 0;

        /// <summary>
        /// Write error because of a lack of disk space
        /// </summary>
        [iOSVersion(2)] public const int NSFileWriteOutOfSpaceError = 0;

        /// <summary>
        /// Write error because because the volume is read only.
        /// </summary>
        [iOSVersion(4)] public const int NSFileWriteVolumeReadOnlyError = 0;

        /// <summary>
        /// Key-value coding validation error
        /// </summary>
        [iOSVersion(2)] public const int NSKeyValueValidationError = 0;

        /// <summary>
        /// Formatting error (related to display of data)
        /// </summary>
        [iOSVersion(2)] public const int NSFormattingError = 0;

        /// <summary>
        /// The user cancelled the operation (for example, by pressing Command-period).
        /// </summary>
        [iOSVersion(2)] public const int NSUserCancelledError = 0;

        /// <summary>
        /// Marks the start of the range of error codes reserved for file errors
        /// </summary>
        [iOSVersion(2)] public const int NSFileErrorMinimum = 0;

        /// <summary>
        /// Marks the end of the range of error codes reserved for file errors
        /// </summary>
        [iOSVersion(2)] public const int NSFileErrorMaximum = 0;

        /// <summary>
        /// Marks the start of the range of error codes reserved for validation errors.
        /// </summary>
        [iOSVersion(2)] public const int NSValidationErrorMinimum = 0;

        /// <summary>
        /// Marks the start and end of the range of error codes reserved for validation errors.
        /// </summary>
        [iOSVersion(2)] public const int NSValidationErrorMaximum = 0;

        /// <summary>
        /// Marks the start of the range of error codes reserved for formatting errors.
        /// </summary>
        [iOSVersion(2)] public const int NSFormattingErrorMinimum = 0;

        /// <summary>
        /// Marks end of the range of error codes reserved for formatting errors.
        /// </summary>
        [iOSVersion(2)] public const int NSFormattingErrorMaximum = 0;

        /// <summary>
        /// An error was encountered while parsing the property list.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListReadCorruptError = 0;

        /// <summary>
        /// The version number of the property list is unable to be determined.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListReadUnknownVersionError = 0;

        /// <summary>
        /// An stream error was encountered while reading the property list.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListReadStreamError = 0;

        /// <summary>
        /// An stream error was encountered while writing the property list.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListWriteStreamError = 0;

        /// <summary>
        /// Marks beginning of the range of error codes reserved for property list errors.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListErrorMinimum = 0;

        /// <summary>
        /// Marks end of the range of error codes reserved for property list errors.
        /// </summary>
        [iOSVersion(4)] public const int NSPropertyListErrorMaximum = 0;

        /// <summary>
        /// Marks beginning of the range of error codes reserved for errors related to executable files.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableErrorMinimum = 0;

        /// <summary>
        /// Executable is of a type that is not loadable in the current process.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableNotLoadableError = 0;

        /// <summary>
        /// Executable does not provide an architecture compatible with the current process.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableArchitectureMismatchError = 0;

        /// <summary>
        /// Executable has Objective C runtime information incompatible with the current process.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableRuntimeMismatchError = 0;

        /// <summary>
        /// Executable cannot be loaded for some other reason, such as a problem with a library it depends on.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableLoadError = 0;

        /// <summary>
        /// Executable fails due to linking issues.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableLinkError = 0;

        /// <summary>
        /// Marks end of the range of error codes reserved for errors related to executable files.
        /// </summary>
        [iOSVersion(2)] public const int NSExecutableErrorMaximum = 0;
    }

    /// <summary>
    /// These values are returned as the error code property of an NSError object with the domain “NSURLErrorDomain”.
    /// </summary>
    [Global]
    public static class URLLoadingSystemErrorCodes
    {
        /// <summary>
        /// Returned when the URL Loading system encounters an error that it cannot interpret.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorUnknown = 0;

        /// <summary>
        /// Returned when an asynchronous load is canceled.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCancelled = 0;

        /// <summary>
        /// Returned when a URL is sufficiently malformed that a URL request cannot be initiated
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorBadURL = 0;

        /// <summary>
        /// Returned when an asynchronous operation times out.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorTimedOut = 0;

        /// <summary>
        /// Returned when a properly formed URL cannot be handled by the framework.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorUnsupportedURL = 0;

        /// <summary>
        /// Returned when the host name for a URL cannot be resolved.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotFindHost = 0;

        /// <summary>
        /// Returned when an attempt to connect to a host has failed.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotConnectToHost = 0;

        /// <summary>
        /// Returned when the length of the resource data exceeds the maximum allowed.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorDataLengthExceedsMaximum = 0;

        /// <summary>
        /// Returned when a client or server connection is severed in the middle of an in-progress load.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorNetworkConnectionLost = 0;

        /// <summary>
        /// See NSURLErrorCannotFindHost
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorDNSLookupFailed = 0;

        /// <summary>
        /// Returned when a redirect loop is detected or when the threshold for number of allowable redirects has been exceeded (currently 16).
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorHTTPTooManyRedirects = 0;

        /// <summary>
        /// Returned when a requested resource cannot be retrieved.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorResourceUnavailable = 0;

        /// <summary>
        /// Returned when a network resource was requested, but an internet connection is not established and cannot be established automatically, either through a lack of connectivity, or by the user's choice not to make a network connection automatically.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorNotConnectedTointernet = 0;

        /// <summary>
        /// Returned when a redirect is specified by way of server response code, but the server does not accompany this code with a redirect URL.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorRedirectToNonExistentLocation = 0;

        /// <summary>
        /// Returned when the URL Loading system receives bad data from the server.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorBadServerResponse = 0;

        /// <summary>
        /// Returned when an asynchronous request for authentication is cancelled by the user.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorUserCancelledAuthentication = 0;

        /// <summary>
        /// Returned when authentication is required to access a resource.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorUserAuthenticationRequired = 0;

        /// <summary>
        /// Returned when a server reports that a URL has a non-zero content length, but terminates the network connection “gracefully” without sending any data.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorZeroByteResource = 0;

        /// <summary>
        /// Returned when content data received during an NSURLConnection request cannot be decoded for a known content encoding.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotDecodeRawData = 0;

        /// <summary>
        /// Returned when content data received during an NSURLConnection request has an unknown content encoding.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotDecodeContentData = 0;

        /// <summary>
        /// Returned when a response to an NSURLConnection request cannot be parsed.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotParseResponse = 0;

        /// <summary>
        /// Returned when a connection would require activating a data context while roaming, but international roaming is disabled.
        /// </summary>
        [iOSVersion(3)] public const int NSURLErrorinternationalRoamingOff = 0;

        /// <summary>
        /// Returned when a connection is attempted while a phone call is active on a network that does not support simultaneous phone and data communication (EDGE or GPRS).
        /// </summary>
        [iOSVersion(3)] public const int NSURLErrorCallIsActive = 0;

        /// <summary>
        /// Returned when the cellular network disallows a connection.
        /// </summary>
        [iOSVersion(3)] public const int NSURLErrorDataNotAllowed = 0;

        /// <summary>
        /// Returned when a body stream is needed but the client does not provide one. This impacts clients on iOS that send a POST request using a body stream but do not implement the NSURLConnection delegate method connection:needNewBodyStream.
        /// </summary>
        [iOSVersion(3)] public const int NSURLErrorRequestBodyStreamExhausted = 0;

        /// <summary>
        /// Returned when a file does not exist.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorFileDoesNotExist = 0;

        /// <summary>
        /// Returned when a request for an FTP file results in the server responding that the file is not a plain file, but a directory.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorFileIsDirectory = 0;

        /// <summary>
        /// Returned when a resource cannot be read due to insufficient permissions.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorNoPermissionsToReadFile = 0;

        /// <summary>
        /// Returned when an attempt to establish a secure connection fails for reasons which cannot be expressed more specifically.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorSecureConnectionFailed = 0;

        /// <summary>
        /// Returned when a server certificate has a date which indicates it has expired, or is not yet valid.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorServerCertificateHasBadDate = 0;

        /// <summary>
        /// Returned when a server certificate is signed by a root server which is not trusted.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorServerCertificateUntrusted = 0;

        /// <summary>
        /// Returned when a server certificate is not signed by any root server.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorServerCertificateHasUnknownRoot = 0;

        /// <summary>
        /// Returned when a server certificate is not yet valid.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorServerCertificateNotYetValid = 0;

        /// <summary>
        /// Returned when a server certificate is rejected.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorClientCertificateRejected = 0;

        /// <summary>
        /// Returned when a client certificate is required to authenticate an SSL connection during an NSURLConnection request.
        /// </summary>
        [iOSVersion(4)] public const int NSURLErrorClientCertificateRequired = 0;

        /// <summary>
        /// Returned when a specific request to load an item only from the cache cannot be satisfied.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotLoadFromNetwork = 0;

        /// <summary>
        /// Returned when NSURLDownload object was unable to create the downloaded file on disk due to a I/O failure.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotCreateFile = 0;

        /// <summary>
        /// Returned when NSURLDownload was unable to open the downloaded file on disk.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotOpenFile = 0;

        /// <summary>
        /// Returned when NSURLDownload was unable to close the downloaded file on disk.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotCloseFile = 0;

        /// <summary>
        /// Returned when NSURLDownload was unable to write to the downloaded file on disk.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotWriteToFile = 0;

        /// <summary>
        /// Returned when NSURLDownload was unable to remove a downloaded file from disk.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotRemoveFile = 0;

        /// <summary>
        /// Returned when NSURLDownload was unable to move a downloaded file on disk.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorCannotMoveFile = 0;

        /// <summary>
        /// Returned when NSURLDownload failed to decode an encoded file during the download.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorDownloadDecodingFailedMidStream = 0;

        /// <summary>
        /// Returned when NSURLDownload failed to decode an encoded file after downloading.
        /// </summary>
        [iOSVersion(2)] public const int NSURLErrorDownloadDecodingFailedToComplete = 0;

        /// <summary>
        /// These error codes are used by error objects associated with the NSURLUbiquitousItemDownloadingErrorKey on an NSURL object when an iCloud-related error occurs.
        /// </summary>

        /// <summary>
        /// The minimum error code value that represents an iCloud error.
        /// </summary>
        [iOSVersion(7)] public const int NSUbiquitousFileErrorMinimum = 0;

        /// <summary>
        /// The item has not been uploaded to iCloud by another device yet.
        /// </summary>
        [iOSVersion(7)] public const int NSUbiquitousFileUnavailableError = 0;

        /// <summary>
        /// The item could not be uploaded to iCloud because it would make the account go over its quota.
        /// </summary>
        [iOSVersion(7)] public const int NSUbiquitousFileNotUploadedDueToQuotaError = 0;

        /// <summary>
        /// Connecting to the iCloud servers failed.
        /// </summary>
        [iOSVersion(7)] public const int NSUbiquitousFileUbiquityServerNotAvailable = 0;

        /// <summary>
        /// The maximum error code value that represents an iCloud error.
        /// </summary>
        [iOSVersion(7)] public const int NSUbiquitousFileErrorMaximum = 0;
    }

    /// <summary>
    /// Errors returned by XPC connections. Note that these are not currently available on iOS.
    /// </summary>
    [Global]
    public static class XPCErrors
    {
        /// <summary>
        /// The XPC connection was interrupted.
        /// </summary>
        [iOSVersion(6)] public const int NSXPCConnectioninterrupted = 0;

        /// <summary>
        /// The XPC connection was invalid.
        /// </summary>
        [iOSVersion(6)] public const int NSXPCConnectionInvalid = 0;

        /// <summary>
        /// The XPC connection reply was invalid.
        /// </summary>
        [iOSVersion(6)] public const int NSXPCConnectionReplyInvalid = 0;

        /// <summary>
        /// The XPC connection minimum error.
        /// </summary>
        [iOSVersion(6)] public const int NSXPCConnectionErrorMinimum = 0;

        /// <summary>
        /// The XPC connection maximum error.
        /// </summary>
        [iOSVersion(6)] public const int NSXPCConnectionErrorMaximum = 0;
    }

    /// <summary>
    /// These constants defines the Cocoa error domain.
    /// </summary>
    [Global]
    public static class CocoaErrors
    {
        public const string NSCocoaErrorDomain = "";
    }

    /// <summary>
    /// This error domain is defined for NSURL.
    /// </summary>
    [Global]
    public static class NSURLError
    {
        public const string NSURLErrorDomain = "";
    }

    /// <summary>
    /// Constants used by NSDecimal.
    /// </summary>
    [Global]
    public static class NSDecimalConstants
    {
        /// <summary>
        /// The maximum size of NSDecimal.
        /// </summary>
        [iOSVersion(2)] public const Cint NSDecimalMaxSize = null;

        /// <summary>
        /// Specifies that the number of digits allowed after the decimal separator in a decimal number should not be limited.
        /// </summary>
        [iOSVersion(2)] public const Cint NSDecimalNoScale = null;
    }

    /// <summary>
    /// Constants representing the maximum and minimum values of NSinteger and NSUinteger.
    /// </summary>
    [Global]
    public static class NSIntegerConstants
    {
        /// <summary>
        /// The maximum value for an NSinteger.
        /// </summary>
        [iOSVersion(2)] public const CLong NSintegerMax = null;

        /// <summary>
        /// The maximum value for an NSUinteger.
        /// </summary>
        [iOSVersion(2)] public const CUnsignedLong NSUintegerMax = null;
    }

    /// <summary>
    /// Exceptions defined by NSException.
    /// </summary>
    [Global]
    public class NSExceptionExceptions
    {
        /// <summary>
        /// A generic name for an exception.
        /// </summary>
        [iOSVersion(2)] public const string NSGenericException = null;

        /// <summary>
        /// Name of an exception that occurs when attempting to access outside the bounds of some data, such as beyond the end of a string.
        /// </summary>
        [iOSVersion(2)] public const string NSRangeException = null;

        /// <summary>
        /// Name of an exception that occurs when you pass an invalid argument to a method, such as a nil pointer where a non-nil object is required.
        /// </summary>
        [iOSVersion(2)] public const string NSInvalidArgumentException = null;

        /// <summary>
        /// Name of an exception that occurs when an internal assertion fails and implies an unexpected condition within the called code.
        /// </summary>
        [iOSVersion(2)] public const string NSinternalInconsistencyException = null;

        /// <summary>
        /// Obsolete; not currently used.
        /// </summary>
        [iOSVersion(2)] public const string NSMallocException = null;

        /// <summary>
        /// Name of an exception that occurs when a remote object is accessed from a thread that should not access it.
        /// </summary>
        [iOSVersion(2)] public const string NSObjectInaccessibleException = null;

        /// <summary>
        /// Name of an exception that occurs when the remote side of the NSConnection refused to send the message to the object because the object has never been vended.
        /// </summary>
        [iOSVersion(2)] public const string NSObjectNotAvailableException = null;

        /// <summary>
        /// Name of an exception that occurs when an internal assertion fails and implies an unexpected condition within the distributed objects.
        /// </summary>
        [iOSVersion(2)] public const string NSDestinationInvalidException = null;

        /// <summary>
        /// Name of an exception that occurs when a timeout set on a port expires during a send or receive operation.
        /// </summary>
        [iOSVersion(2)] public const string NSPortTimeoutException = null;

        /// <summary>
        /// Name of an exception that occurs when the send port of an NSConnection has become invalid.
        /// </summary>
        [iOSVersion(2)] public const string NSInvalidSendPortException = null;

        /// <summary>
        /// Name of an exception that occurs when the receive port of an NSConnection has become invalid.
        /// </summary>
        [iOSVersion(2)] public const string NSInvalidReceivePortException = null;

        /// <summary>
        /// Generic error occurred on send.
        /// </summary>
        [iOSVersion(2)] public const string NSPortSendException = null;

        /// <summary>
        /// Generic error occurred on receive.
        /// </summary>
        [iOSVersion(2)] public const string NSPortReceiveException = null;

        /// <summary>
        /// No longer used.
        /// </summary>
        [iOSVersion(2)] public const string NSOldStyleException = null;
    }

    [Global]
    public static class FoundationVersionNumber
    {
        /// <summary>
        /// Version of the Foundation framework in the current environment.
        /// </summary>
        public const CDouble NSFoundationVersionNumber = null;
    }

    /// <summary>
    /// Constants to define Foundation Framework version numbers.
    /// </summary>
    [Global]
    public static class FoundationVersionNumbers
    {
        /// <summary>
        /// Foundation version released in OS X version 10.0.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_0 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.1.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_1_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.1.2.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_1_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.1.3.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_1_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.1.4.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_1_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.2.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.3.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.4.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.5.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.6.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.7.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.2.8.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_2_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.2.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.3.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.4.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.5.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.6.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.7.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.8.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.3.9.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_3_9 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.2.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.3.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.4 for intel.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_4_intel = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.4 for PowerPC.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_4_PowerPC = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.5.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.6.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.7.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.8.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.9.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_9 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.10.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_10 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.4.11.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_4_11 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.0.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.1.
        /// </summary>
        [iOSVersion(2)] public const CDouble NSFoundationVersionNumber10_5_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.2.
        /// </summary>
        [iOSVersion(2.2)] public const CDouble NSFoundationVersionNumber10_5_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.3.
        /// </summary>
        [iOSVersion(2.2)] public const CDouble NSFoundationVersionNumber10_5_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.4.
        /// </summary>
        [iOSVersion(2.2)] public const CDouble NSFoundationVersionNumber10_5_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.5.
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_5_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.6.
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_5_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.7.
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_5_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.5.8.
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_5_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.1
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_6_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.2
        /// </summary>
        [iOSVersion(4)] public const CDouble NSFoundationVersionNumber10_6_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.3
        /// </summary>
        [iOSVersion(4.3)] public const CDouble NSFoundationVersionNumber10_6_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.4
        /// </summary>
        [iOSVersion(4.3)] public const CDouble NSFoundationVersionNumber10_6_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.5
        /// </summary>
        [iOSVersion(4.3)] public const CDouble NSFoundationVersionNumber10_6_5 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.6
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_6_6 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.7
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_6_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.6.8
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_6_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.7
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_7 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.7.1
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_7_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.7.2
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_7_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.7.3
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_7_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.7.4
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber10_7_4 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.8
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber10_8 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.8.1
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber10_8_1 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.8.2
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber10_8_2 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.8.3
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber10_8_3 = null;

        /// <summary>
        /// Foundation version released in OS X version 10.8.4
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber10_8_4 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 2.0.
        /// </summary>
        [iOSVersion(2.2)] public const CDouble NSFoundationVersionNumber_iPhoneOS_2_0 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 2.1.
        /// </summary>
        [iOSVersion(2.2)] public const CDouble NSFoundationVersionNumber_iPhoneOS_2_1 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 2.2.
        /// </summary>
        [iOSVersion(3)] public const CDouble NSFoundationVersionNumber_iPhoneOS_2_2 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 3.0.
        /// </summary>
        [iOSVersion(3.2)] public const CDouble NSFoundationVersionNumber_iPhoneOS_3_0 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 3.1.
        /// </summary>
        [iOSVersion(3.2)] public const CDouble NSFoundationVersionNumber_iPhoneOS_3_1 = null;

        /// <summary>
        /// Foundation version released in iPhone OS version 3.2.
        /// </summary>
        [iOSVersion(4.2)] public const CDouble NSFoundationVersionNumber_iPhoneOS_3_2 = null;

        /// <summary>
        /// Foundation version released in iOS version 4.0.
        /// </summary>
        [iOSVersion(4.2)] public const CDouble NSFoundationVersionNumber_iOS_4_0 = null;

        /// <summary>
        /// Foundation version released in iOS version 4.1.
        /// </summary>
        [iOSVersion(4.3)] public const CDouble NSFoundationVersionNumber_iOS_4_1 = null;

        /// <summary>
        /// Foundation version released in iOS version 4.2.
        /// </summary>
        [iOSVersion(4.3)] public const CDouble NSFoundationVersionNumber_iOS_4_2 = null;

        /// <summary>
        /// Foundation version released in iOS version 4.3.
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber_iOS_4_3 = null;

        /// <summary>
        /// Foundation version released in iOS version 5.0.
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber_iOS_5_0 = null;

        /// <summary>
        /// Foundation version released in iOS version 5.1.
        /// </summary>
        [iOSVersion(6)] public const CDouble NSFoundationVersionNumber_iOS_5_1 = null;

        /// <summary>
        /// Foundation version released in iOS version 6.0.1.
        /// </summary>
        [iOSVersion(7)] public const CDouble NSFoundationVersionNumber_iOS_6_1 = null;
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