using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSURLSessionTaskDelegate protocol defines the task-specific delegate methods that you should implement when working with any type of NSURLSession task.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLSessionTaskDelegate_protocol/index.html#//apple_ref/occ/intf/NSURLSessionTaskDelegate"/>	[iOSVersion(7)]	public interface NSURLSessionTaskDelegate//: NSObjectProtocol, NSURLSessionDelegate	{		/// <summary>		/// Tells the delegate that the task finished transferring data.		/// </summary>		/// <param name="session">The session containing the task whose request finished transferring data.</param>		/// <param name="task">The task whose request finished transferring data.</param>		/// <param name="didCompleteWithError">If an error occurred, an error object indicating how the transfer failed, otherwise NULL.</param>		[iOSVersion(7)]		void URLSession(NSURLSession session, NSURLSessionTask task, NSError didCompleteWithError);				/// <summary>		/// Requests credentials from the delegate in response to an authentication request from the remote server.		/// </summary>		/// <param name="session">The session containing the task whose request requires authentication.</param>		/// <param name="task">The task whose request requires authentication.</param>		/// <param name="didReceiveChallenge">An object that contains the request for authentication.</param>		/// <param name="completionHandler">A handler that your delegate method must call. Its parameters are:		///   disposition—One of several constants that describes how the challenge should be handled.		///   credential—The credential that should be used for authentication if disposition is NSURLSessionAuthChallengeUseCredential; otherwise, NULL.</param>		[iOSVersion(7)]		void URLSession(NSURLSession session, NSURLSessionTask task, NSURLAuthenticationChallenge didReceiveChallenge, Action<NSURLSessionAuthChallengeDisposition, NSURLCredential> completionHandler);				/// <summary>		/// Periodically informs the delegate of the progress of sending body content to the server.		/// </summary>		/// <param name="session">The session containing the data task.</param>		/// <param name="task">The data task.</param>		/// <param name="didSendBodyData">The number of bytes sent since the last time this delegate method was called.</param>		/// <param name="totalBytesSent">The total number of bytes sent so far.</param>		/// <param name="totalBytesExpectedToSend">The expected length of the body data. The URL loading system can determine the length of the upload data in three ways:		///   From the length of the NSData object provided as the upload body.		///   From the length of the file on disk provided as the upload body of an upload task (not a download task).		///   From the Content-Length in the request object, if you explicitly set it.		///   Otherwise, the value is NSURLSessionTransferSizeUnknown (-1) if you provided a stream or body data object, or zero (0) if you did not.</param>		[iOSVersion(7)]		void URLSession(NSURLSession session, NSURLSessionTask task, Int64 didSendBodyData, Int64 totalBytesSent, Int64 totalBytesExpectedToSend);				/// <summary>		/// Tells the delegate when a task requires a new request body stream to send to the remote server.		/// </summary>		/// <param name="session">The session containing the task that needs a new body stream.</param>		/// <param name="task">The task that needs a new body stream.</param>		/// <param name="needNewBodyStream">A completion handler that your delegate method should call with the new body stream.</param>		[iOSVersion(7)]		void URLSession(NSURLSession session, NSURLSessionTask task, Action<NSInputStream> needNewBodyStream);				/// <summary>		/// Tells the delegate that the remote server requested an HTTP redirect.		/// </summary>		/// <param name="session">The session containing the task whose request resulted in a redirect.</param>		/// <param name="task">The task whose request resulted in a redirect.</param>		/// <param name="willPerformHTTPRedirection">An object containing the server’s response to the original request.</param>		/// <param name="newRequest">A URL request object filled out with the new location.</param>		/// <param name="completionHandler">A block that your handler should call with either the value of the request parameter, a modified URL request object, or NULL to refuse the redirect and return the body of the redirect response.</param>		[iOSVersion(7)]		void URLSession(NSURLSession session, NSURLSessionTask task, NSHTTPURLResponse willPerformHTTPRedirection, NSURLRequest newRequest, Action<NSURLRequest> completionHandler);	}}