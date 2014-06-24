using System;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Options used when creating file bookmark data
    /// </summary>
    // [iOSVersion(4)]
    using NSURLBookmarkFileCreationOptions = Int32;

    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURL_Class/index.html#//apple_ref/occ/cl/NSURL
    /// <summary>
    /// An NSURL object represents a URL that can potentially contain the location of a resource on a remote server, the path of a local file on disk, or even an arbitrary piece of encoded data.
    /// </summary>
    [iOSVersion(2)]
    public class NSURL : NSObject
    {
        /// <summary>
        /// Initializes a newly created NSURL with a specified scheme, host, and path.
        /// </summary>
        /// <param name="scheme">The scheme for the NSURL object. For example, in the URL http://www.example.com/index.html, the scheme is http.</param>
        /// <param name="host">The host for the NSURL object (for example, www.example.com). May be the empty string.</param>
        /// <param name="path">The path for the NSURL object (for example, /index.html). If the path begins with a tilde, you must first expand it by calling stringByExpandingTildeInPath.</param>
        /// <returns>The newly initialized NSURL object.</returns>
        [iOSVersion(2)]
        public NSURL(string scheme, string host, string path) { }

        /// <summary>
        /// Creates and returns an NSURL object initialized with a provided URL string.
        /// </summary>
        /// <param name="URLString">The URL string with which to initialize the NSURL object. Must be a URL that conforms to RFC 2396. This method parses URLString according to RFCs 1738 and 1808.</param>
        /// <returns>An NSURL object initialized with URLString. If the URL string was malformed or nil, returns nil.</returns>
        [iOSVersion(2)]
        [Export("URLWithString")]
        public static NSURL URLWithString(string URLString) { return null; }

        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using
        /// 
        /// Initializes a newly created NSURL referencing the local file or directory at path.
        /// Initializes an NSURL object with a provided URL string.
        /// </summary>
        /// <param name="fileURLWithPath">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.   Passing nil for this parameter produces an exception.</param>
        /// <param name="string">The URL string with which to initialize the NSURL object. This URL string must conform to URL format as described in RFC 2396, and must not be nil. This method parses URLString according to RFCs 1738 and 1808.</param>
        /// <returns>An NSURL object initialized with path.</returns>
        /// <returns>An NSURL object initialized with URLString. If the URL string was malformed, returns nil.</returns>
        [iOSVersion(2)]
        public NSURL(string fileURLWithPath = "", string @string = "") { }

        /// <summary>
        /// Creates and returns an NSURL object initialized with a base URL and a relative string.
        /// </summary>
        /// <param name="URLString">The URL string with which to initialize the NSURL object. May not be nil. Must conform to RFC 2396. URLString is interpreted relative to baseURL.</param>
        /// <param name="relativeToURL">The base URL for the NSURL object.</param>
        /// <returns>An NSURL object initialized with URLString and baseURL. If URLString was malformed or nil, returns nil.</returns>
        [iOSVersion(2)]
        [Export("URLWithString")]
        public static NSURL URLWithString(string URLString, NSURL relativeToURL) { return null; }

        /// <summary>
        /// Initializes an NSURL object with a base URL and a relative string.
        /// </summary>
        /// <param name="string">The URL string with which to initialize the NSURL object. Must conform to RFC 2396. URLString is interpreted relative to baseURL.</param>
        /// <param name="relativeToURL">The base URL for the NSURL object.</param>
        /// <returns>An NSURL object initialized with URLString and baseURL. If URLString was malformed, returns nil.</returns>
        [iOSVersion(2)]
        public NSURL(string @string, NSURL relativeToURL) { }

        /// <summary>
        /// Initializes and returns a newly created NSURL object as a file URL with a specified path.
        /// </summary>
        /// <param name="path">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.   Passing nil for this parameter produces an exception.</param>
        /// <param name="isDirectory">A Boolean value that specifies whether path is treated as a directory path when resolving against relative path components. Pass true if the path indicates a directory, false otherwise.</param>
        /// <returns>An NSURL object initialized with path.</returns>
        [iOSVersion(2)]
        [Export("fileURLWithPath")]
        public static NSURL FileURLWithPath(string path, bool isDirectory) { return null; }

        /// <summary>
        /// Initializes a newly created NSURL referencing the local file or directory at path.
        /// </summary>
        /// <param name="fileURLWithPath">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.   Passing nil for this parameter produces an exception.</param>
        /// <param name="isDirectory">A Boolean value that specifies whether path is treated as a directory path when resolving against relative path components. Pass true if the path indicates a directory, false otherwise</param>
        /// <returns>An NSURL object initialized with path.</returns>
        [iOSVersion(2)]
        public NSURL(string fileURLWithPath, bool isDirectory) { }

        /// <summary>
        /// Initializes and returns a newly created NSURL object as a file URL with a specified path.
        /// </summary>
        /// <param name="path">The path that the NSURL object will represent. path should be a valid system path. If path begins with a tilde, it must first be expanded with stringByExpandingTildeInPath. If path is a relative path, it is treated as being relative to the current working directory.   Passing nil for this parameter produces an exception.</param>
        /// <returns>An NSURL object initialized with path.</returns>
        [iOSVersion(2)]
        [Export("fileURLWithPath")]
        public static NSURL FileURLWithPath(string path) { return null; }

        /// <summary>
        /// Initializes and returns a newly created NSURL object as a file URL with specified path components.
        /// </summary>
        /// <param name="components">An array of path components.   Passing nil for this parameter produces an exception.</param>
        /// <returns>An NSURL object initialized with components.</returns>
        [iOSVersion(4)]
        [Export("fileURLWithPathComponents")]
        public static NSURL FileURLWithPathComponents(AnyObject[] components) { return null; }

        /// <summary>
        /// Returns a new URL made by resolving the alias file at url.
        /// </summary>
        /// <param name="url">The URL pointing to the alias file.</param>
        /// <param name="options">Options taken into account when resolving the bookmark data. The NSURLBookmarkResolutionWithSecurityScope option is not supported by this method.</param>
        /// <param name="error">The error that occurred while trying to resolve the provided URL.</param>
        /// <returns>A new URL created by resolving the bookmark data derived from the provided alias file. If an error occurs, this method returns nil.</returns>
        [iOSVersion(8)]
        [Export("URLByResolvingAliasFileAtURL")]
        public static NSURL URLByResolvingAliasFileAtURL(NSURL url, NSURLBookmarkResolutionOptions options, NSErrorPointer error) { return null; }

        /// <summary>
        /// Returns a new URL made by resolving bookmark data.
        /// </summary>
        /// <param name="bookmarkData">The bookmark data the URL is derived from.</param>
        /// <param name="options">Options taken into account when resolving the bookmark data.   To resolve a security-scoped bookmark to support App Sandbox, you must include (by way of bitwise OR operators with any other options in this parameter) the NSURLBookmarkResolutionWithSecurityScope option.</param>
        /// <param name="relativeToURL">The base URL that the bookmark data is relative to.   If you are resolving a security-scoped bookmark to obtain a security-scoped URL, use this parameter as follows:    To resolve an app-scoped bookmark, use a value of nil.   To resolve a document-scoped bookmark, use the absolute path (despite this parameter’s name) to the document from which you retrieved the bookmark.</param>
        /// <param name="bookmarkDataIsStale">On return, if true, the bookmark data is stale. Your app should create a new bookmark using the returned URL and use it in place of any stored copies of the existing bookmark.</param>
        /// <param name="error">The error that occurred in the case that the URL cannot be created.</param>
        /// <returns>A new URL made by resolving bookmarkData.</returns>
        [iOSVersion(5)]
        [Export("URLByResolvingBookmarkData")]
        public static NSURL URLByResolvingBookmarkData(NSData bookmarkData, NSURLBookmarkResolutionOptions options, NSURL relativeToURL, CMutablePointer<ObjCBool> bookmarkDataIsStale, NSErrorPointer error) { return null; }

        /// <summary>
        /// Initializes a newly created NSURL that points to a location specified by resolving bookmark data.
        /// </summary>
        /// <param name="byResolvingBookmarkData">The bookmark data the URL is derived from.</param>
        /// <param name="options">Options taken into account when resolving the bookmark data.</param>
        /// <param name="relativeToURL">The base URL that the bookmark data is relative to.</param>
        /// <param name="bookmarkDataIsStale">If true, the bookmark data is stale.</param>
        /// <param name="error">The error that occurred in the case that the URL cannot be created.</param>
        /// <returns>An NSURL initialized by resolving bookmarkData.</returns>
        [iOSVersion(5)]
        public NSURL(NSData byResolvingBookmarkData, NSURLBookmarkResolutionOptions options, NSURL relativeToURL, CMutablePointer<ObjCBool> bookmarkDataIsStale, NSErrorPointer error) { }

        /// <summary>
        /// Returns a new URL object initialized with a C string representing a local file system path.
        /// </summary>
        /// <param name="path">A null-terminated C string in file system representation containing the path to represent as a URL. If this path is a relative path, it is treated as being relative to the current working directory.</param>
        /// <param name="isDirectory">true if the last path part is a directory, otherwise false.</param>
        /// <param name="relativeToURL">The base URL for the new URL object. This must be a file URL. If path is absolute, this URL is ignored.</param>
        /// <returns>Returns the new object or nil if an error occurred.</returns>
        [iOSVersion(7)]
        [Export("fileURLWithFileSystemRepresentation")]
        public static NSURL FileURLWithFileSystemRepresentation(CString path, bool isDirectory, NSURL relativeToURL) { return null; }

        /// <summary>
        /// Fills the provided buffer with a C string representing a local file system path.
        /// </summary>
        /// <param name="buffer">A buffer large enough to hold the path. On return, contains a null-terminated C string in file system representation.</param>
        /// <param name="maxLength">The size of buffer in bytes (typically MAXPATHLEN or PATH_MAX).</param>
        /// <returns>Returns true if the URL could be converted into a file system representation, otherwise false.</returns>
        [iOSVersion(7)]
        [Export("getFileSystemRepresentation")]
        public bool GetFileSystemRepresentation(CMutablePointer<CChar> buffer, int maxLength) { return false; }

        /// <summary>
        /// Initializes a URL object with a C string representing a local file system path.
        /// </summary>
        /// <param name="fileURLWithFileSystemRepresentation">A null-terminated C string in file system representation containing the path to represent as a URL. If this path is a relative path, it is treated as being relative to the current working directory.</param>
        /// <param name="isDirectory">true if the last path part is a directory, otherwise false.</param>
        /// <param name="relativeToURL">The base URL for the new URL object. This must be a file URL. If path is absolute, this URL is ignored.</param>
        /// <returns>Returns the initialized object or nil if an error occurred.</returns>
        [iOSVersion(7)]
        public NSURL(CString fileURLWithFileSystemRepresentation, bool isDirectory, NSURL relativeToURL) { }

        /// <summary>
        /// Returns whether the resource pointed to by a file URL can be reached.
        /// </summary>
        /// <param name="error">The error that occurred when the resource could not be reached.</param>
        /// <returns>true if the resource is reachable; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("checkResourceIsReachableAndReturnError")]
        public bool CheckResourceIsReachableAndReturnError(NSErrorPointer error) { return false; }

        /// <summary>
        /// Returns whether the URL is a file reference URL.
        /// </summary>
        /// <returns>true if the URL is a file reference URL; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("isFileReferenceURL")]
        public bool IsFileReferenceURL() { return false; }

        /// <summary>
        /// A boolean value that determines whether the receiver is a file URL. (read-only)
        /// </summary>
        [iOSVersion(8)]
        [Export("fileURL")]
        public static bool FileURL { get; private set; }

        /// <summary>
        /// The URL string for the receiver as an absolute URL. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("absoluteString")]
        public static string AbsoluteString { get; private set; }

        /// <summary>
        /// An absolute URL that refers to the same resource as the receiver. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("absoluteURL")]
        public static NSURL AbsoluteURL { get; private set; }

        /// <summary>
        /// The base URL. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("baseURL")]
        public static NSURL BaseURL { get; private set; }

        /// <summary>
        /// A C string containing the URL’s file system path. (read-only)
        /// </summary>
        [iOSVersion(7)]
        [Export("fileSystemRepresentation")]
        public static CString FileSystemRepresentation { get; private set; }

        /// <summary>
        /// The fragment identifier, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("fragment")]
        public static string Fragment { get; private set; }

        /// <summary>
        /// The host, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("host")]
        public static string Host { get; private set; }

        /// <summary>
        /// The last path component. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("lastPathComponent")]
        public static string LastPathComponent { get; private set; }

        /// <summary>
        /// The parameter string conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("parameterString")]
        public static string ParameterString { get; private set; }

        /// <summary>
        /// The password conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("password")]
        public static string Password { get; private set; }

        /// <summary>
        /// The path, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("path")]
        public static string Path { get; private set; }

        /// <summary>
        /// An array containing the path components. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("pathComponents")]
        public static AnyObject[] PathComponents { get; private set; }

        /// <summary>
        /// The path extension. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("pathExtension")]
        public static string PathExtension { get; private set; }

        /// <summary>
        /// The port, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("port")]
        public static NSNumber Port { get; private set; }

        /// <summary>
        /// The query string, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("query")]
        public static string Query { get; private set; }

        /// <summary>
        /// The relative path, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("relativePath")]
        public static string RelativePath { get; private set; }

        /// <summary>
        /// A string representation of the relative portion of the URL. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("relativeString")]
        public static string RelativeString { get; private set; }

        /// <summary>
        /// The resource specifier. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("resourceSpecifier")]
        public static string ResourceSpecifier { get; private set; }

        /// <summary>
        /// The scheme. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("scheme")]
        public static string Scheme { get; private set; }

        /// <summary>
        /// A copy of the URL with any instances of &quot;..&quot; or &quot;.&quot; removed from its path. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("standardizedURL")]
        public static NSURL StandardizedURL { get; private set; }

        /// <summary>
        /// The user name, conforming to RFC 1808. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("user")]
        public static string User { get; private set; }

        /// <summary>
        /// A file path URL that points to the same resource as the receiver. (read-only)
        /// </summary>
        [iOSVersion(5)]
        [Export("filePathURL")]
        public static NSURL FilePathURL { get; private set; }

        /// <summary>
        /// Returns a new file reference URL that points to the same resource as the receiver.
        /// </summary>
        /// <returns>The new file reference URL.</returns>
        [iOSVersion(5)]
        [Export("fileReferenceURL")]
        public NSURL FileReferenceURL() { return null; }

        /// <summary>
        /// Returns a new URL made by appending a path component to the original URL.
        /// </summary>
        /// <param name="pathComponent">The path component to add to the URL, in its original form (not URL encoded).</param>
        /// <returns>A new URL with pathComponent appended.</returns>
        [iOSVersion(4)]
        [Export("URLByAppendingPathComponent")]
        public NSURL URLByAppendingPathComponent(string pathComponent) { return null; }

        /// <summary>
        /// Returns a new URL made by appending a path component to the original URL, along with a trailing slash if the component is designated a directory.
        /// </summary>
        /// <param name="pathComponent">The path component to add to the URL.</param>
        /// <param name="isDirectory">If true, a trailing slash is appended after pathComponent.</param>
        /// <returns>A new URL with pathComponent appended.</returns>
        [iOSVersion(5)]
        [Export("URLByAppendingPathComponent")]
        public NSURL URLByAppendingPathComponent(string pathComponent, bool isDirectory) { return null; }

        /// <summary>
        /// Returns a new URL made by appending a path extension to the original URL.
        /// </summary>
        /// <param name="pathExtension">The path extension to add to the URL.</param>
        /// <returns>A new URL with pathExtension appended.</returns>
        [iOSVersion(4)]
        [Export("URLByAppendingPathExtension")]
        public NSURL URLByAppendingPathExtension(string pathExtension) { return null; }

        /// <summary>
        /// A URL created by taking the receiver and removing the last path component. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("URLByDeletingLastPathComponent")]
        public static NSURL URLByDeletingLastPathComponent { get; private set; }

        /// <summary>
        /// A URL created by taking the receiver and removing the path extension, if any. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("URLByDeletingPathExtension")]
        public static NSURL URLByDeletingPathExtension { get; private set; }

        /// <summary>
        /// A URL that points to the same resource as the receiver and includes no symbolic links. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("URLByResolvingSymlinksInPath")]
        public static NSURL URLByResolvingSymlinksInPath { get; private set; }

        /// <summary>
        /// A URL that points to the same resource as the original URL using an absolute path. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("URLByStandardizingPath")]
        public static NSURL URLByStandardizingPath { get; private set; }

        /// <summary>
        /// Initializes and returns bookmark data derived from an alias file pointed to by a specified URL.
        /// </summary>
        /// <param name="bookmarkFileURL">The URL that points to the alias file.</param>
        /// <param name="error">The error that occurred in the case that the bookmark data cannot be derived.</param>
        /// <returns>The bookmark data for the alias file.</returns>
        [iOSVersion(5)]
        [Export("bookmarkDataWithContentsOfURL")]
        public static NSData BookmarkDataWithContentsOfURL(NSURL bookmarkFileURL, NSErrorPointer error) { return null; }

        /// <summary>
        /// Returns a bookmark for the URL, created with specified options and resource values.
        /// </summary>
        /// <param name="options">Options taken into account when creating the bookmark for the URL. The possible flags (which can be combined with bitwise OR operations) are described in Bookmark Data Creation Options.   To create a security-scoped bookmark to support App Sandbox, include the NSURLBookmarkCreationWithSecurityScope flag. When you later resolve the bookmark, you can use the resulting security-scoped URL to obtain read/write access to the file-system resource pointed to by the URL.   If you instead want to create a security-scoped bookmark that, when resolved, enables you to obtain read-only access to a file-system resource, bitwise OR this parameter’s value with both the NSURLBookmarkCreationWithSecurityScope option and the NSURLBookmarkCreationSecurityScopeAllowOnlyReadAccess option.</param>
        /// <param name="includingResourceValuesForKeys">An array of names of URL resource properties to store as part of the bookmark. You can later access these values (without resolving the bookmark) by calling the resourceValuesForKeys:fromBookmarkData: method.   The values of these properties must be of a type that the bookmark generation code can serialize. Specifically, the values can contain any of the following primitive types:    NSString or CFString   NSData or CFData   NSDate or CFDate   NSNumber or CFNumber   CFBoolean   NSURL or CFURL   kCFNull or NSNull   CFUUID    In addition, the properties can contain the following collection classes:    NSArray or CFArray containing only the above primitive types   NSDictionary or CFDictionary with NSString or CFString keys, in which all values contain only the above primitive types</param>
        /// <param name="relativeToURL">The URL that the bookmark data will be relative to.   If you are creating a security-scoped bookmark to support App Sandbox, use this parameter as follows:    To create an app-scoped bookmark, use a value of nil.   To create a document-scoped bookmark, use the absolute path (despite this parameter’s name) to the document file that is to own the new security-scoped bookmark.</param>
        /// <param name="error">The error that occurred in the case that the bookmark data cannot be created.</param>
        /// <returns>A bookmark for the URL.</returns>
        [iOSVersion(5)]
        [Export("bookmarkDataWithOptions")]
        public NSData BookmarkDataWithOptions(NSURLBookmarkCreationOptions options, AnyObject[] includingResourceValuesForKeys, NSURL relativeToURL, NSErrorPointer error) { return null; }

        /// <summary>
        /// Returns the resource values for properties identified by a specified array of keys contained in specified bookmark data.
        /// </summary>
        /// <param name="keys">An array of names of URL resource properties. In addition to the standard, system-defined resource properties, you can also request any custom properties that you provided when you created the bookmark. See the bookmarkDataWithOptions:includingResourceValuesForKeys:relativeToURL:error: method for details.</param>
        /// <param name="fromBookmarkData">The bookmark data from which you want to retrieve resource values.</param>
        /// <returns>A dictionary of the requested resource values contained in bookmarkData.</returns>
        [iOSVersion(5)]
        [Export("resourceValuesForKeys")]
        public static NSDictionary ResourceValuesForKeys(AnyObject[] keys, NSData fromBookmarkData) { return null; }

        /// <summary>
        /// Creates an alias file on disk at a specified location with specified bookmark data.
        /// </summary>
        /// <param name="bookmarkData">The bookmark data containing information for the alias file.</param>
        /// <param name="toURL">The desired location of the alias file.</param>
        /// <param name="options">Options taken into account when creating the alias file.</param>
        /// <param name="error">The error that occurred in the case that the alias file cannot be created.</param>
        /// <returns>true if the alias file is successfully created; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("writeBookmarkData")]
        public static bool WriteBookmarkData(NSData bookmarkData, NSURL toURL, NSURLBookmarkFileCreationOptions options, NSErrorPointer error) { return false; }

        /// <summary>
        /// In an app that has adopted App Sandbox, makes the resource pointed to by a security-scoped URL available to the app.
        /// </summary>
        /// <returns>true if the request to access the resource succeeded; otherwise, false.</returns>
        [iOSVersion(8)]
        [Export("startAccessingSecurityScopedResource")]
        public bool StartAccessingSecurityScopedResource() { return false; }

        /// <summary>
        /// In an app that adopts App Sandbox, revokes access to the resource pointed to by a security-scoped URL.
        /// </summary>
        [iOSVersion(8)]
        [Export("stopAccessingSecurityScopedResource")]
        public void StopAccessingSecurityScopedResource() { }

        /// <summary>
        /// Returns the value of the resource property for the specified key.
        /// </summary>
        /// <param name="value">The location where the value for the resource property identified by key should be stored.</param>
        /// <param name="forKey">The name of one of the URL’s resource properties.</param>
        /// <param name="error">The error that occurred in the case that the resource value cannot be retrieved.</param>
        /// <returns>true if value is successfully populated; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("getResourceValue")]
        public bool GetResourceValue(AutoreleasingUnsafePointer<AnyObject> value, string forKey, NSErrorPointer error) { return false; }

        /// <summary>
        /// Returns the resource values for the properties identified by specified array of keys.
        /// </summary>
        /// <param name="keys">An array of names of URL resource properties.</param>
        /// <param name="error">The error that occurred in the case that one or more resource values cannot be retrieved.</param>
        /// <returns>A dictionary of resource values indexed by key.</returns>
        [iOSVersion(5)]
        [Export("resourceValuesForKeys")]
        public NSDictionary ResourceValuesForKeys(AnyObject[] keys, NSErrorPointer error) { return null; }

        /// <summary>
        /// Sets the resource property of the URL specified by a given key to a given value.
        /// </summary>
        /// <param name="value">The value for the resource property defined by key.</param>
        /// <param name="forKey">The name of one of the URL’s resource properties.</param>
        /// <param name="error">The error that occurred in the case that the resource value cannot be set.</param>
        /// <returns>true if the resource property named key is successfully set to value; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("setResourceValue")]
        public bool SetResourceValue(AnyObject value, string forKey, NSErrorPointer error) { return false; }

        /// <summary>
        /// Sets resource properties of the URL specified by a given set of keys to a given set of values.
        /// </summary>
        /// <param name="keyedValues">A dictionary of resource values to be set.</param>
        /// <param name="error">The error that occurred in the case that one or more resource values cannot be set.</param>
        /// <returns>true if all resource values in keyedValues are successfully set; otherwise, false.</returns>
        [iOSVersion(5)]
        [Export("setResourceValues")]
        public bool SetResourceValues(NSDictionary keyedValues, NSErrorPointer error) { return false; }

        /// <summary>
        /// Removes all cached resource values and temporary resource values from the URL object.
        /// </summary>
        [iOSVersion(7)]
        [Export("removeAllCachedResourceValues")]
        public void RemoveAllCachedResourceValues() { }

        /// <summary>
        /// Removes the cached resource value identified by a given resource value key from the URL object.
        /// </summary>
        /// <param name="key">The resource value key whose cached values you wish to remove.</param>
        [iOSVersion(7)]
        [Export("removeCachedResourceValueForKey")]
        public void RemoveCachedResourceValueForKey(string key) { }

        /// <summary>
        /// Sets a temporary resource value on the URL object.
        /// </summary>
        /// <param name="value">The value to store.</param>
        /// <param name="forKey">The key where the value should be stored. This key must be unique and must not conflict with any system-defined keys. Reverse-domain-name notation is recommended.</param>
        [iOSVersion(7)]
        [Export("setTemporaryResourceValue")]
        public void SetTemporaryResourceValue(AnyObject value, string forKey) { }

        /// <summary>
        /// Returns whether the promised item can be reached.
        /// </summary>
        /// <param name="error">The error that occurred when the promised item could not be reached.</param>
        /// <returns>true if the promised item is reachable; otherwise, false.</returns>
        [iOSVersion(8)]
        [Export("checkPromisedItemIsReachableAndReturnError")]
        public bool CheckPromisedItemIsReachableAndReturnError(NSErrorPointer error) { return false; }

        /// <summary>
        /// Returns the value of the resource property for the specified key.
        /// </summary>
        /// <param name="value">The location where the value for the resource property identified by key should be stored.</param>
        /// <param name="forKey">The name of one of the URL’s resource properties.</param>
        /// <param name="error">The error that occurred in the case that the resource value cannot be retrieved.</param>
        /// <returns>true if value is successfully populated; otherwise, false.</returns>
        [iOSVersion(8)]
        [Export("getPromisedItemResourceValue")]
        public bool GetPromisedItemResourceValue(AutoreleasingUnsafePointer<AnyObject> value, string forKey, NSErrorPointer error) { return false; }

        /// <summary>
        /// Returns the resource values for the properties identified by specified array of keys.
        /// </summary>
        /// <param name="keys">An array of names of URL resource properties.</param>
        /// <param name="error">The error that occurred in the case that one or more resource values cannot be retrieved.</param>
        /// <returns>A dictionary of resource values indexed by key.</returns>
        [iOSVersion(8)]
        [Export("promisedItemResourceValuesForKeys")]
        public NSDictionary PromisedItemResourceValuesForKeys(AnyObject[] keys, NSErrorPointer error) { return null; }



        /// <summary>
        /// These schemes are the ones that NSURL can parse.
        /// </summary>
        [Export("NSURLFileScheme")]
        public string NSURLFileScheme { get; private set; }

        /// <summary>
        /// Keys that apply to file system URLs.
        /// </summary>

        /// <summary>
        /// The time at which the resource’s was created or renamed into or within its parent directory, returned as an NSDate. Inconsistent behavior may be observed when this attribute is requested on hard-linked items. This property is not supported by all volumes. (read-only)
        /// </summary>
        public string NSURLAddedToDirectoryDateKey { get; private set; }

        /// <summary>
        /// The time at which the resource’s attributes were most recently modified, returned as an NSDate object if the volume supports attribute modification dates, or nil if attribute modification dates are unsupported (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLAttributeModificationDateKey { get; set; }

        /// <summary>
        /// The time at which the resource was most recently accessed, returned as an NSDate object if the volume supports access dates, or nil if access dates are unsupported (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLContentAccessDateKey { get; private set; }

        /// <summary>
        /// The time at which the resource was most recently modified, returned as an NSDate object if the volume supports modification dates, or nil if modification dates are unsupported (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLContentModificationDateKey { get; set; }

        /// <summary>
        /// The resource’s creation date, returned as an NSDate object if the volume supports creation dates, or nil if creation dates are unsupported (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLCreationDateKey { get; set; }

        /// <summary>
        /// The icon stored with the resource, returned as an NSImage object, or nil if the resource has no custom icon.
        /// </summary>
        public string NSURLCustomIconKey { get; private set; }

        /// <summary>
        /// The document identifier returned as an NSNumber (read-only).
        /// </summary>
        public string NSURLDocumentIdentifierKey { get; private set; }

        /// <summary>
        /// The resource’s normal icon, returned as an NSImage object (read-only).
        /// </summary>
        public string NSURLEffectiveIconKey { get; private set; }

        /// <summary>
        /// The resource’s unique identifier, returned as an id (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceIdentifierKey { get; private set; }

        /// <summary>
        /// The resource’s object type, returned as an NSString object (read-only). See File Resource Types for possible values.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeKey { get; private set; }

        /// <summary>
        /// The resource’s security information, returned as an NSFileSecurity object (read-write).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileSecurityKey { get; set; }

        /// <summary>
        /// An opaque generation identifier, returned as an id &lt;NSCopying, NSCoding, NSObject&gt; (read-only)
        /// </summary>
        public string NSURLGenerationIdentifierKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource’s extension is normally removed from its localized name, returned as a Boolean NSNumber object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLHasHiddenExtensionKey { get; set; }

        /// <summary>
        /// Key for determining whether the resource is a directory, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsDirectoryKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource is excluded from all backups of app data, returned as a Boolean NSNumber object (read-write).
        /// </summary>
        [iOSVersion(5.1)]
        public string NSURLIsExcludedFromBackupKey { get; set; }

        /// <summary>
        /// Key for determining whether the current process (as determined by the EUID) can execute the resource (if it is a file) or search the resource (if it is a directory), returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLIsExecutableKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource is normally not displayed to users, returned as a Boolean NSNumber object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsHiddenKey { get; set; }

        /// <summary>
        /// Key for determining whether the URL is a file system trigger directory, returned as a Boolean NSNumber object (read-only). Traversing or opening a file system trigger directory causes an attempt to mount a file system on the directory.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLIsMountTriggerKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource is a file package, returned as a Boolean NSNumber object (read-write in OS X v10.8 and later, read-only in previous versions). A true value means that the resource is a file package.
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsPackageKey { get; set; }

        /// <summary>
        /// Key for determining whether the current process (as determined by the EUID) can read the resource, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLIsReadableKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource is a regular file, as opposed to a directory or a symbolic link. Returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsRegularFileKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource is a symbolic link, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsSymbolicLinkKey { get; private set; }

        /// <summary>
        /// Key for determining whether the resource's system immutable bit is set, returned as a Boolean NSNumber object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsSystemImmutableKey { get; set; }

        /// <summary>
        /// Key for determining whether the resource's user immutable bit is set, returned as a Boolean NSNumber object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsUserImmutableKey { get; set; }

        /// <summary>
        /// Key for determining whether the resource is the root directory of a volume, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsVolumeKey { get; private set; }

        /// <summary>
        /// Key for determining whether the current process (as determined by the EUID) can write to the resource, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLIsWritableKey { get; private set; }

        /// <summary>
        /// The resource’s label color, returned as an NSColor object, or nil if the resource has no label color (read-only).
        /// </summary>
        public string NSURLLabelColorKey { get; private set; }

        /// <summary>
        /// The resource’s label number, returned as an NSNumber object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLLabelNumberKey { get; set; }

        /// <summary>
        /// The number of hard links to the resource, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLLinkCountKey { get; private set; }

        /// <summary>
        /// The resource’s localized label text, returned as an NSString object, or nil if the resource has no localized label text (read-only).
        /// </summary>
        public string NSURLLocalizedLabelKey { get; private set; }

        /// <summary>
        /// The resource’s localized or extension-hidden name, returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLLocalizedNameKey { get; private set; }

        /// <summary>
        /// The resource’s localized type description, returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLLocalizedTypeDescriptionKey { get; private set; }

        /// <summary>
        /// The resource’s name in the file system, returned as an NSString object (read-write).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLNameKey { get; set; }

        /// <summary>
        /// The parent directory of the resource, returned as an NSURL object, or nil if the resource is the root directory of its volume (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLParentDirectoryURLKey { get; private set; }

        /// <summary>
        /// The file system path for the URL, returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(6)]
        public string NSURLPathKey { get; private set; }

        /// <summary>
        /// The optimal block size to use when reading or writing this file's data, returned as an NSNumber object, or nil if the preferred size is not available (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLPreferredIOBlockSizeKey { get; private set; }

        /// <summary>
        /// A dictionary of NSImage/UIImage objects keyed by size (read-write). See Thumbnail Property Keys for a list of possible keys.
        /// </summary>
        public string NSURLThumbnailDictionaryKey { get; set; }

        /// <summary>
        /// The resource’s uniform type identifier (UTI), returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLTypeIdentifierKey { get; private set; }

        /// <summary>
        /// The unique identifier of the resource’s volume, returned as an id (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIdentifierKey { get; private set; }

        /// <summary>
        /// The root directory of the resource’s volume, returned as an NSURL object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeURLKey { get; private set; }

        /// <summary>
        /// Possible values for the NSURLFileResourceTypeKey key.
        /// </summary>

        /// <summary>
        /// The resource is a named pipe.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeNamedPipe { get; private set; }

        /// <summary>
        /// The resource is a character special file.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeCharacterSpecial { get; private set; }

        /// <summary>
        /// The resource is a directory.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeDirectory { get; private set; }

        /// <summary>
        /// The resource is a block special file.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeBlockSpecial { get; private set; }

        /// <summary>
        /// The resource is a regular file.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeRegular { get; private set; }

        /// <summary>
        /// The resource is a symbolic link.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeSymbolicLink { get; private set; }

        /// <summary>
        /// The resource is a socket.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeSocket { get; private set; }

        /// <summary>
        /// The resource’s type is unknown.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLFileResourceTypeUnknown { get; private set; }

        /// <summary>
        /// Possible keys for the NSURLThumbnailDictionaryKey dictionary.
        /// </summary>
        [Export("NSThumbnail1024x1024SizeKey")]
        public string NSThumbnail1024x1024SizeKey { get; private set; }

        /// <summary>
        /// Keys that apply to properties of files.
        /// </summary>

        /// <summary>
        /// Key for the file’s size in bytes, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLFileSizeKey { get; private set; }

        /// <summary>
        /// Key for the total size allocated on disk for the file, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLFileAllocatedSizeKey { get; private set; }

        /// <summary>
        /// Key for the total displayable size of the file in bytes, returned as an NSNumber object (read-only). This includes the size of any file metadata.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLTotalFileSizeKey { get; private set; }

        /// <summary>
        /// Key for the total allocated size of the file in bytes, returned as an NSNumber object (read-only). This includes the size of any file metadata.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLTotalFileAllocatedSizeKey { get; private set; }

        /// <summary>
        /// Key for determining whether the file is an alias, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLIsAliasFileKey { get; private set; }

        /// <summary>
        /// Keys that apply to volumes.
        /// </summary>

        /// <summary>
        /// Key for the volume’s descriptive format name, returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeLocalizedFormatDescriptionKey { get; private set; }

        /// <summary>
        /// Key for the volume’s capacity in bytes, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeTotalCapacityKey { get; private set; }

        /// <summary>
        /// Key for the volume’s available capacity in bytes, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeAvailableCapacityKey { get; private set; }

        /// <summary>
        /// Key for the total number of resources on the volume, returned as an NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeResourceCountKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports persistent IDs, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsPersistentIDsKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports symbolic links, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsSymbolicLinksKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports hard links, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsHardLinksKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports journaling, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsJournalingKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is currently journaling, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeIsJournalingKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports sparse files, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsSparseFilesKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports zero runs, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsZeroRunsKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports case-sensitive names, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsCaseSensitiveNamesKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports case-preserved names, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(4)]
        public string NSURLVolumeSupportsCasePreservedNamesKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports reliable storage of times for the root directory, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeSupportsRootDirectoryDatesKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports returning volume size information, returned as a Boolean NSNumber object (read-only). If true, volume size information is available as values of the NSURLVolumeTotalCapacityKey andNSURLVolumeAvailableCapacityKey keys.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeSupportsVolumeSizesKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume can be renamed, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeSupportsRenamingKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume implements whole-file advisory locks in the style of flock, along with the O_EXLOCK and O_SHLOCK flags of the open function, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeSupportsAdvisoryFileLockingKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume supports extended security (access control lists), returned as a Boolean NSNumber object (read-only) (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeSupportsExtendedSecurityKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is visible in GUI-based file-browsing environments, such as the Desktop or the Finder application, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsBrowsableKey { get; private set; }

        /// <summary>
        /// Key for the largest file size supported by the volume in bytes, returned as a Boolean NSNumber object, or nil if it cannot be determined (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeMaximumFileSizeKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is ejectable from the drive mechanism under software control, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsEjectableKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is removable from the drive mechanism, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsRemovableKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is connected to an internal bus, returned as a Boolean NSNumber object, or nil if it cannot be determined (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsinternalKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is automounted, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsAutomountedKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is stored on a local device, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsLocalKey { get; private set; }

        /// <summary>
        /// Key for determining whether the volume is read-only, returned as a Boolean NSNumber object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeIsReadOnlyKey { get; private set; }

        /// <summary>
        /// Key for the volume’s creation date, returned as an NSDate object, or NULL if it cannot be determined (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeCreationDateKey { get; private set; }

        /// <summary>
        /// Key for the URL needed to remount the network volume, returned as an NSURL object, or nil if a URL is not available (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeURLForRemountingKey { get; private set; }

        /// <summary>
        /// Key for the volume’s persistent UUID, returned as an NSString object, or nil if a persistent UUID is not available (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeUUIDStringKey { get; private set; }

        /// <summary>
        /// The name of the volume, returned as an NSString object (read-write). Settable only if NSURLVolumeSupportsRenamingKey is true.
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeNameKey { get; set; }

        /// <summary>
        /// The name of the volume as it should be displayed in the user interface, returned as an NSString object (read-only).
        /// </summary>
        [iOSVersion(5)]
        public string NSURLVolumeLocalizedNameKey { get; private set; }
    }

    /// <summary>
    /// Options used when creating bookmark data.
    /// </summary>
    [iOSVersion(4)]
    public enum NSURLBookmarkCreationOptions
    {
        /// <summary>
        /// Specifies that when a bookmark created with this option is resolved, its embedded file ID should take precedence over other sources of information (file system path, for example) in the event of a conflict.
        /// Deprecated in iOS 7
        /// </summary>
        [Obsolete]
        [iOSVersion(4)]
        PreferFileIDResolution,
        
        /// <summary>
        /// Specifies that a bookmark created with this option should be created with minimal information. This produces a smaller bookmark that can be resolved in fewer ways.
        /// </summary>
        [iOSVersion(4)]
        MinimalBookmark,

        /// <summary>
        /// Specifies that the bookmark data should include properties required to create Finder alias files.
        /// </summary>
        [iOSVersion(4)]
        SuitableForBookmarkFile,

        WithSecurityScope,
        SecurityScopeAllowOnlyReadAccess
    }

    /// <summary>
    /// Options used when resolving bookmark data.
    /// </summary>
    [iOSVersion(4)]
    public enum NSURLBookmarkResolutionOptions
    {
        /// <summary>
        /// Specifies that no UI feedback should accompany resolution of the bookmark data.
        /// </summary>
        [iOSVersion(4)]
        WithoutUI,

        /// <summary>
        /// Specifies that no volume should be mounted during resolution of the bookmark data.
        /// </summary>
        [iOSVersion(4)]
        WithoutMounting,
        WithSecurityScope,
    }
}
