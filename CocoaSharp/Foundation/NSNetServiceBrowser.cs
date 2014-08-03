using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSNetServiceBrowser class defines an interface for finding published services on a network using multicast DNS. An instance of NSNetServiceBrowser is known as a network service browser.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNetServiceBrowser_Class/index.html#//apple_ref/occ/cl/NSNetServiceBrowser"/>	[iOSVersion(2)]	public class NSNetServiceBrowser : NSObject//, AnyObject, NSObjectProtocol	{		/// <summary>		/// Initializes an allocated NSNetServiceBrowser object.		/// </summary>		[iOSVersion(2)]		public NSNetServiceBrowser() { }				/// <summary>		/// Initiates a search for domains visible to the host. This method returns immediately.		/// </summary>		[iOSVersion(2)]		[Export("searchForBrowsableDomains")]		public void SearchForBrowsableDomains() {  }				/// <summary>		/// Initiates a search for domains in which the host may register services.		/// </summary>		[iOSVersion(2)]		[Export("searchForRegistrationDomains")]		public void SearchForRegistrationDomains() {  }				/// <summary>		/// Starts a search for services of a particular type within a specific domain.		/// </summary>		/// <param name="serviceType">Type of the service to search for.</param>		/// <param name="inDomain">Domain name in which to perform the search.</param>		[iOSVersion(2)]		[Export("searchForServicesOfType")]		public void SearchForServicesOfType(string serviceType, string inDomain) {  }				/// <summary>		/// Halts a currently running search or resolution.		/// </summary>		[iOSVersion(2)]		[Export("stop")]		public void Stop() {  }				/// <summary>		/// Adds the receiver to the specified run loop.		/// </summary>		/// <param name="runLoop">Run loop in which to schedule the receiver.</param>		/// <param name="forMode">Run loop mode in which to perform this operation, such as NSDefaultRunLoopMode. See the Run Loop Modes section of the NSRunLoop class for other run loop mode values.</param>		[iOSVersion(2)]		[Export("scheduleInRunLoop")]		public void ScheduleInRunLoop(NSRunLoop runLoop, string forMode) {  }				/// <summary>		/// Removes the receiver from the specified run loop.		/// </summary>		/// <param name="runLoop">Run loop from which to remove the receiver.</param>		/// <param name="forMode">Run loop mode in which to perform this operation, such as NSDefaultRunLoopMode. See the Run Loop Modes section of the NSRunLoop class for other run loop mode values.</param>		[iOSVersion(2)]		[Export("removeFromRunLoop")]		public void RemoveFromRunLoop(NSRunLoop runLoop, string forMode) {  }				/// <summary>		/// The delegate object for this instance.		/// </summary>		[iOSVersion(2)]		[Export("delegate")]		public NSNetServiceBrowserDelegate Delegate { get; set; }	}}