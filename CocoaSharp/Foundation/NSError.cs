using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An NSError object encapsulates richer and more extensible error information than is possible using only an error code or error string. The core attributes of an NSError object are an error domain (represented by a string), a domain-specific error code and a user info dictionary containing application specific information.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSError_Class/index.html#//apple_ref/occ/cl/NSError"/>	[iOSVersion(2)]	public class NSError : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Creates and initializes an NSError object for a given domain and code with a given userInfo dictionary.		/// </summary>		/// <param name="domain">The error domain—this can be one of the predefined NSError domains, or an arbitrary string describing a custom domain. domain must not be nil. See Error Domains for a list of predefined domains.</param>		/// <param name="code">The error code for the error.</param>		/// <param name="userInfo">The userInfo dictionary for the error. userInfo may be nil.</param>		[iOSVersion(2)]		[Export("errorWithDomain")]		public static Self ErrorWithDomain(string domain, int code, Dictionary<NSObject, AnyObject> userInfo) { return default(Self); }				/// <summary>		/// Returns an NSError object initialized for a given domain and code with a given userInfo dictionary.		/// </summary>		/// <param name="domain">The error domain—this can be one of the predefined NSError domains, or an arbitrary string describing a custom domain. domain must not be nil. See Error Domains for a list of predefined domains.</param>		/// <param name="code">The error code for the error.</param>		/// <param name="userInfo">The userInfo dictionary for the error. userInfo may be nil.</param>		[iOSVersion(2)]		public NSError(string domain, int code, Dictionary<NSObject, AnyObject> userInfo) { }				/// <summary>		/// The error code. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("code")]		public int Code { get; private set; }				/// <summary>		/// A string containing the error domain. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("domain")]		public string Domain { get; private set; }				/// <summary>		/// The user info dictionary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("userInfo")]		public Dictionary<NSObject, AnyObject> UserInfo { get; private set; }				/// <summary>		/// A string containing the localized description of the error. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localizedDescription")]		public string LocalizedDescription { get; private set; }				/// <summary>		/// An array containing the localized titles of buttons appropriate for displaying in an alert panel. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localizedRecoveryOptions")]		public AnyObject[] LocalizedRecoveryOptions { get; private set; }				/// <summary>		/// A string containing the localized recovery suggestion for the error. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localizedRecoverySuggestion")]		public string LocalizedRecoverySuggestion { get; private set; }				/// <summary>		/// A string containing the localized explanation of the reason for the error. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localizedFailureReason")]		public string LocalizedFailureReason { get; private set; }				/// <summary>		/// An object that conforms to the NSErrorRecoveryAttempting informal protocol. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("recoveryAttempter")]		public AnyObject RecoveryAttempter { get; private set; }				/// <summary>		/// A string to display in response to an alert panel help anchor button being pressed. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("helpAnchor")]		public string HelpAnchor { get; private set; }	}}