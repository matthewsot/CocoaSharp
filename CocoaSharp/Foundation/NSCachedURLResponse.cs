using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCachedURLResponse_Class/index.html#//apple_ref/occ/cl/NSCachedURLResponse	/// <summary>	/// An NSCachedURLResponse object represents a cached response to a URL request. It provides the server’s response metadata in the form of an NSURLResponse object, along with an NSData object containing the actual cached content data. Its storage policy determines whether the response should be cached on disk, in memory, or not at all.	/// </summary>	[iOSVersion(2)]	public class NSCachedURLResponse : NSObject	{		/// <summary>		/// Initializes an NSCachedURLResponse object.		/// </summary>		/// <param name="response">The response to cache.</param>		/// <param name="data">The data to cache.</param>		/// <returns>The NSCachedURLResponse object, initialized using the given data.</returns>		[iOSVersion(2)]		public NSCachedURLResponse(NSURLResponse response, NSData data) { }				/// <summary>		/// Initializes an NSCachedURLResponse object.		/// </summary>		/// <param name="response">The response to cache.</param>		/// <param name="data">The data to cache.</param>		/// <param name="userInfo">An optional dictionary of user information. May be nil.</param>		/// <param name="storagePolicy">The storage policy for the cached response.</param>		/// <returns>The NSCachedURLResponse object, initialized using the given data.</returns>		[iOSVersion(2)]		public NSCachedURLResponse(NSURLResponse response, NSData data, NSDictionary userInfo, NSURLCacheStoragePolicy storagePolicy) { }				/// <summary>		/// Returns the receiver’s cached data.		/// </summary>		/// <returns>The receiver’s cached data.</returns>		[iOSVersion(2)]		[Export("data")]		public NSData Data { get; private set; }				/// <summary>		/// Returns the NSURLResponse object associated with the receiver.		/// </summary>		/// <returns>The NSURLResponse object associated with the receiver.</returns>		[iOSVersion(2)]		[Export("response")]		public NSURLResponse Response { get; private set; }				/// <summary>		/// Returns the receiver’s cache storage policy.		/// </summary>		/// <returns>The receiver’s cache storage policy.</returns>		[iOSVersion(2)]		[Export("storagePolicy")]		public NSURLCacheStoragePolicy StoragePolicy { get; private set; }				/// <summary>		/// Returns the receiver’s user info dictionary.		/// </summary>		/// <returns>An NSDictionary object containing the receiver’s user info, or nil if there is no such object.</returns>		[iOSVersion(2)]		[Export("userInfo")]		public NSDictionary UserInfo { get; private set; }

        //TODO: check if NSURLCacheStoragePolicy enum is correct

	    /// <summary>
	    /// These constants specify the caching strategy used by an NSCachedURLResponse object.
	    /// </summary>
	    [iOSVersion(2)]
	    public enum NSURLCacheStoragePolicy
	    {
            /// <summary>
            /// Specifies that storage in NSURLCache is allowed without restriction.
            /// 
            /// iOS prior to version 5 ignores this cache policy, and instead treats it as NSURLCacheStorageAllowedInMemoryOnly. 
            /// </summary>
            [iOSVersion(2)]
	        Allowed,

            /// <summary>
            /// Specifies that storage in NSURLCache is allowed; however storage should be restricted to memory only.
            /// </summary>
            [iOSVersion(2)]
	        AllowedInMemoryOnly,

            /// <summary>
            /// Specifies that storage in NSURLCache is not allowed in any fashion, either in memory or on disk.
            /// </summary>
            [iOSVersion(2)]
	        NotAllowed
	    }
	}}