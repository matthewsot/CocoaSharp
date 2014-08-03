using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSURLRequest objects represent a URL load request in a manner independent of protocol and URL scheme.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSURLRequest_Class/index.html#//apple_ref/occ/cl/NSURLRequest"/>	[iOSVersion(2)]	public class NSURLRequest : NSObject//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Returns a URL request for a specified URL with default cache policy and timeout value.		/// </summary>		/// <param name="URL">The URL for the request.</param>		[iOSVersion(2)]		[Export("convenience init")]		public NSURLRequest(NSURL URL) { }				/// <summary>		/// Returns an initialized URL request with specified values.		/// </summary>		/// <param name="URL">The URL for the request.</param>		/// <param name="cachePolicy">The cache policy for the request.</param>		/// <param name="timeoutInterval">The timeout interval for the request, in seconds.</param>		[iOSVersion(2)]		public NSURLRequest(NSURL URL, NSURLRequestCachePolicy cachePolicy, NSTimeInterval timeoutInterval) { }				/// <summary>		/// Returns the value of the specified HTTP header field.		/// </summary>		/// <param name="field">The name of the header field whose value is to be returned. In keeping with the HTTP RFC, HTTP header field names are case-insensitive.</param>		[iOSVersion(2)]		[Export("valueForHTTPHeaderField")]		public string ValueForHTTPHeaderField(string field) { return default(string); }				/// <summary>		/// The receiver’s cache policy. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("cachePolicy")]		public NSURLRequestCachePolicy CachePolicy { get; private set; }				/// <summary>		/// A boolean value that indicates whether the request should continue transmitting data before receiving a response from an earlier transmission.		/// </summary>		[iOSVersion(4)]		public bool HTTPShouldUsePipelining { get; private set; }				/// <summary>		/// The main document URL associated with the request. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("mainDocumentURL")]		public NSURL MainDocumentURL { get; private set; }				/// <summary>		/// The receiver’s timeout interval, in seconds. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("timeoutInterval")]		public NSTimeInterval TimeoutInterval { get; private set; }				/// <summary>		/// The network service type of the request. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("networkServiceType")]		public NSURLRequestNetworkServiceType NetworkServiceType { get; private set; }				/// <summary>		/// The request's URL. (read-only)		/// </summary>		[iOSVersion(2)]		public NSURL URL { get; private set; }				/// <summary>		/// All of the receiver’s HTTP header fields. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("allHTTPHeaderFields")]		public Dictionary<NSObject, AnyObject> AllHTTPHeaderFields { get; private set; }				/// <summary>		/// The receiver’s HTTP body data. (read-only)		/// </summary>		[iOSVersion(2)]		public NSData HTTPBody { get; private set; }				/// <summary>		/// The receiver’s HTTP body stream. (read-only)		/// </summary>		[iOSVersion(2)]		public NSInputStream HTTPBodyStream { get; private set; }				/// <summary>		/// The receiver’s HTTP request method. (read-only)		/// </summary>		[iOSVersion(2)]		public string HTTPMethod { get; private set; }				/// <summary>		/// A boolean value that indicates whether the default cookie handling will be used for this request. (read-only)		/// </summary>		[iOSVersion(2)]		public bool HTTPShouldHandleCookies { get; private set; }				/// <summary>		/// A boolean value that indicates whether the request is allowed to use the cellular radio (if present). (read-only)		/// </summary>		[iOSVersion(6)]		[Export("allowsCellularAccess")]		public bool AllowsCellularAccess { get; private set; }	}}