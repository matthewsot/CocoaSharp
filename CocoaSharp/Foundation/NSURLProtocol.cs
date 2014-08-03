using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSURLProtocol is an abstract class that provides the basic structure for performing protocol-specific loading of URL data. Concrete subclasses handle the specifics associated with one or more protocols or URL schemes.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURLProtocol_Class/index.html#//apple_ref/occ/cl/NSURLProtocol"/>	[iOSVersion(2)]	public class NSURLProtocol : NSObject//, AnyObject, NSObjectProtocol	{		/// <summary>		/// Initializes an NSURLProtocol object.		/// </summary>		/// <param name="request">The URL request for the URL protocol object. This request is retained.</param>		/// <param name="cachedResponse">A cached response for the request; may be nil if there is no existing cached response for the request.</param>		/// <param name="client">An object that provides an implementation of the NSURLProtocolClient protocol that the receiver uses to communicate with the URL loading system. This client object is retained.</param>		[iOSVersion(2)]		public NSURLProtocol(NSURLRequest request, NSCachedURLResponse cachedResponse, NSURLProtocolClient client) { }				/// <summary>		/// Attempts to register a subclass of NSURLProtocol, making it visible to the URL loading system.		/// </summary>		/// <param name="protocolClass">The subclass of NSURLProtocol to register.</param>		[iOSVersion(2)]		[Export("registerClass")]		public static bool RegisterClass(AnyClass protocolClass) { return default(bool); }				/// <summary>		/// Unregisters the specified subclass of NSURLProtocol.		/// </summary>		/// <param name="protocolClass">The subclass of NSURLProtocol to unregister.</param>		[iOSVersion(2)]		[Export("unregisterClass")]		public static void UnregisterClass(AnyClass protocolClass) {  }				/// <summary>		/// Returns the property associated with the specified key in the specified request.		/// </summary>		/// <param name="key">The key of the desired property.</param>		/// <param name="inRequest">The request whose properties are to be queried.</param>		[iOSVersion(2)]		[Export("propertyForKey")]		public static AnyObject PropertyForKey(string key, NSURLRequest inRequest) { return default(AnyObject); }				/// <summary>		/// Sets the property associated with the specified key in the specified request.		/// </summary>		/// <param name="value">The value to set for the specified property.</param>		/// <param name="forKey">The key for the specified property.</param>		/// <param name="inRequest">The request for which to create the property.</param>		[iOSVersion(2)]		[Export("setProperty")]		public static void SetProperty(AnyObject value, string forKey, NSMutableURLRequest inRequest) {  }				/// <summary>		/// Removes the property associated with the specified key in the specified request.		/// </summary>		/// <param name="key">The key whose value should be removed.</param>		/// <param name="inRequest">The request from which to remove the property value.</param>		[iOSVersion(2)]		[Export("removePropertyForKey")]		public static void RemovePropertyForKey(string key, NSMutableURLRequest inRequest) {  }				/// <summary>		/// Returns whether the protocol subclass can handle the specified request.		/// </summary>		/// <param name="request">The request to be handled.</param>		[iOSVersion(2)]		[Export("canInitWithRequest")]		public static bool CanInitWithRequest(NSURLRequest request) { return default(bool); }				/// <summary>		/// Returns a canonical version of the specified request.		/// </summary>		/// <param name="request">The request whose canonical version is desired.</param>		[iOSVersion(2)]		[Export("canonicalRequestForRequest")]		public static NSURLRequest CanonicalRequestForRequest(NSURLRequest request) { return default(NSURLRequest); }				/// <summary>		/// Returns whether two requests are equivalent for cache purposes.		/// </summary>		/// <param name="aRequest">The request to compare with bRequest.</param>		/// <param name="toRequest">The request to compare with aRequest.</param>		[iOSVersion(2)]		[Export("requestIsCacheEquivalent")]		public static bool RequestIsCacheEquivalent(NSURLRequest aRequest, NSURLRequest toRequest) { return default(bool); }				/// <summary>		/// Starts protocol-specific loading of the request.		/// </summary>		[iOSVersion(2)]		[Export("startLoading")]		public void StartLoading() {  }				/// <summary>		/// Stops protocol-specific loading of the request.		/// </summary>		[iOSVersion(2)]		[Export("stopLoading")]		public void StopLoading() {  }				/// <summary>		/// The receiver’s cached response. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("cachedResponse")]		public NSCachedURLResponse CachedResponse { get; private set; }				/// <summary>		/// The object the receiver uses to communicate with the URL loading system. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("client")]		public NSURLProtocolClient Client { get; private set; }				/// <summary>		/// The receiver’s request. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("request")]		public NSURLRequest Request { get; private set; }	}}