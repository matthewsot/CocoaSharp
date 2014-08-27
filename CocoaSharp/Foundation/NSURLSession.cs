using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSURLSession class and related classes provide an API for downloading content via HTTP. This API provides a rich set of delegate methods for supporting authentication and gives your app the ability to perform background downloads when your app is not running or, in iOS, while your app is suspended.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLSession_class/index.html#//apple_ref/occ/cl/NSURLSession"/>    [iOSVersion(7)]    public class NSURLSession : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Creates a session with the specified session configuration.        /// </summary>        /// <param name="configuration">A configuration object that specifies certain behaviors, such as caching policies, timeouts, proxies, pipelining, TLS versions to support, cookie policies, credential storage, and so on. For more information, see NSURLSessionConfiguration Class Reference.</param>        [iOSVersion(7)]        public NSURLSession(NSURLSessionConfiguration configuration) { }                /// <summary>        /// Creates a session with the specified session configuration, delegate, and operation queue.        /// </summary>        /// <param name="configuration">A configuration object that specifies certain behaviors, such as caching policies, timeouts, proxies, pipelining, TLS versions to support, cookie policies, and credential storage.        ///   Because the session copies the configuration object, it is safe to modify the configuration object and use it to construct additional sessions.        ///   For more information, see NSURLSessionConfiguration Class Reference.</param>        /// <param name="@delegate">A session delegate object that handles requests for authentication and other session-related events.        ///   This delegate object is responsible for handling authentication challenges, for making caching decisions, and for handling other session-related events. If nil, the class uses a system-provided delegate and should be used only with methods that take completion handlers.        ///     Important        ///     The session object keeps a strong reference to the delegate until your app explicitly invalidates the session. If you do not invalidate the session by calling the invalidateAndCancel or resetWithCompletionHandler: method, your app leaks memory.</param>        /// <param name="delegateQueue">A queue for scheduling the delegate calls and completion handlers. If nil, the session creates a serial operation queue for performing all delegate method calls and completion handler calls.</param>        [iOSVersion(7)]        public NSURLSession(NSURLSessionConfiguration configuration, NSURLSessionDelegate @delegate, NSOperationQueue delegateQueue) { }                /// <summary>        /// Returns a shared singleton session object.        /// </summary>        [iOSVersion(7)]        [Export("sharedSession")]        public static NSURLSession SharedSession() { return default(NSURLSession); }                /// <summary>        /// Creates an HTTP GET request for the specified URL.        /// </summary>        /// <param name="url">The http or https URL to be retrieved.</param>        [iOSVersion(7)]        [Export("dataTaskWithURL")]        public NSURLSessionDataTask DataTaskWithURL(NSURL url) { return default(NSURLSessionDataTask); }                /// <summary>        /// Creates an HTTP GET request for the specified URL, then calls a handler upon completion.        /// </summary>        /// <param name="url">The http or https URL to be retrieved.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. If sent to a session created by calling sessionWithConfiguration:delegate:delegateQueue: with a non-nil value for the delegateQueue parameter, this handler is executed on that delegate queue.        ///   Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("dataTaskWithURL")]        public NSURLSessionDataTask DataTaskWithURL(NSURL url, Action<NSData, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionDataTask); }                /// <summary>        /// Creates an HTTP request based on the specified URL request object.        /// </summary>        /// <param name="request">An object that provides request-specific information such as the URL, cache policy, request type, and body data or body stream.</param>        [iOSVersion(7)]        [Export("dataTaskWithRequest")]        public NSURLSessionDataTask DataTaskWithRequest(NSURLRequest request) { return default(NSURLSessionDataTask); }                /// <summary>        /// Creates an HTTP request for the specified URL request object, and calls a handler upon completion.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, body data or body stream, and so on.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue.        ///   Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("dataTaskWithRequest")]        public NSURLSessionDataTask DataTaskWithRequest(NSURLRequest request, Action<NSData, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionDataTask); }                /// <summary>        /// Creates a download task for the specified URL and saves the results to a file.        /// </summary>        /// <param name="url">An NSURL object that provides the URL to download.</param>        [iOSVersion(7)]        [Export("downloadTaskWithURL")]        public NSURLSessionDownloadTask DownloadTaskWithURL(NSURL url) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates a download task for the specified URL, saves the results to a file, and calls a handler upon completion.        /// </summary>        /// <param name="url">An NSURL object that provides the URL to download.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue.        ///   Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("downloadTaskWithURL")]        public NSURLSessionDownloadTask DownloadTaskWithURL(NSURL url, Action<NSURL, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates a download task for the specified URL request and saves the results to a file.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, body data or body stream, and so on.</param>        [iOSVersion(7)]        [Export("downloadTaskWithRequest")]        public NSURLSessionDownloadTask DownloadTaskWithRequest(NSURLRequest request) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates a download task for the specified URL request, saves the results to a file, and calls a handler upon completion.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, body data or body stream, and so on.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue.        ///   Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("downloadTaskWithRequest")]        public NSURLSessionDownloadTask DownloadTaskWithRequest(NSURLRequest request, Action<NSURL, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates a download task to resume a previously canceled or failed download.        /// </summary>        /// <param name="resumeData">A data object that provides the data necessary to resume a download.</param>        [iOSVersion(7)]        [Export("downloadTaskWithResumeData")]        public NSURLSessionDownloadTask DownloadTaskWithResumeData(NSData resumeData) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates a download task to resume a previously canceled or failed download and calls a handler upon completion.        /// </summary>        /// <param name="resumeData">A data object that provides the data necessary to resume the download.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue.        ///   Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("downloadTaskWithResumeData")]        public NSURLSessionDownloadTask DownloadTaskWithResumeData(NSData resumeData, Action<NSURL, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionDownloadTask); }                /// <summary>        /// Creates an HTTP request for the specified URL request object and uploads the provided data object.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, and so on. The body stream and body data in this request object are ignored.</param>        /// <param name="fromData">The body data for the request.</param>        [iOSVersion(7)]        [Export("uploadTaskWithRequest")]        public NSURLSessionUploadTask UploadTaskWithRequest(NSURLRequest request, NSData fromData) { return default(NSURLSessionUploadTask); }                /// <summary>        /// Creates an HTTP request for the specified URL request object, uploads the provided data object, and calls a handler upon completion.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, and so on. The body stream and body data in this request object are ignored.</param>        /// <param name="fromData">The body data for the request.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue.        ///   Unless you have provided a custom delegate, this parameter should not be nil, because there is no other way to retrieve the response data. If you do not need the response data, use key-value observing to watch for changes to the task’s status to determine when it completes.</param>        [iOSVersion(7)]        [Export("uploadTaskWithRequest")]        public NSURLSessionUploadTask UploadTaskWithRequest(NSURLRequest request, NSData fromData, Action<NSData, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionUploadTask); }                /// <summary>        /// Creates an HTTP request for uploading the specified file URL.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, and so on. The body stream and body data in this request object are ignored.</param>        /// <param name="fromFile">The URL of the file to upload.</param>        [iOSVersion(7)]        [Export("uploadTaskWithRequest")]        public NSURLSessionUploadTask UploadTaskWithRequest(NSURLRequest request, NSURL fromFile) { return default(NSURLSessionUploadTask); }                /// <summary>        /// Creates an HTTP request for uploading the specified file URL, then calls a handler upon completion.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, and so on. The body stream and body data in this request object are ignored.</param>        /// <param name="fromFile">The URL of the file to upload.</param>        /// <param name="completionHandler">The completion handler to call when the load request is complete. This handler is executed on the delegate queue. Unless you have provided a custom delegate, this parameter must not be nil, because there is no other way to retrieve the response data.</param>        [iOSVersion(7)]        [Export("uploadTaskWithRequest")]        public NSURLSessionUploadTask UploadTaskWithRequest(NSURLRequest request, NSURL fromFile, Action<NSData, NSURLResponse, NSError> completionHandler) { return default(NSURLSessionUploadTask); }                /// <summary>        /// Creates an HTTP request for uploading data based on the specified URL request.        /// </summary>        /// <param name="request">An NSURLRequest object that provides the URL, cache policy, request type, and so on. The body stream and body data in this request object are ignored, and NSURLSession calls its delegate’s URLSession:task:needNewBodyStream: method to provide the body data.</param>        [iOSVersion(7)]        [Export("uploadTaskWithStreamedRequest")]        public NSURLSessionUploadTask UploadTaskWithStreamedRequest(NSURLRequest request) { return default(NSURLSessionUploadTask); }                /// <summary>        /// Invalidates the object, allowing any outstanding tasks to finish.        /// </summary>        [iOSVersion(7)]        [Export("finishTasksAndInvalidate")]        public void FinishTasksAndInvalidate() {  }                /// <summary>        /// Ensures that future requests occur on a new socket and that any in-transit download data is flushed to disk.        /// </summary>        /// <param name="completionHandler">The completion handler to call when the flush operation is complete. This handler is executed on the delegate queue.</param>        [iOSVersion(7)]        [Export("flushWithCompletionHandler")]        public void FlushWithCompletionHandler(Action completionHandler) {  }                /// <summary>        /// Asynchronously calls a completion callback with all outstanding data, upload, and download tasks in a session.        /// </summary>        /// <param name="completionHandler">The completion handler to call with the list of currently outstanding tasks. This handler is executed on the delegate queue.</param>        [iOSVersion(7)]        [Export("getTasksWithCompletionHandler")]        public void GetTasksWithCompletionHandler(Action<AnyObject[], AnyObject[], AnyObject[]> completionHandler) {  }                /// <summary>        /// Cancels all outstanding tasks and then invalidates the session object.        /// </summary>        [iOSVersion(7)]        [Export("invalidateAndCancel")]        public void InvalidateAndCancel() {  }                /// <summary>        /// Resets the session asynchronously.        /// </summary>        /// <param name="completionHandler">The completion handler to call when the reset operation is complete. This handler is executed on the delegate queue.</param>        [iOSVersion(7)]        [Export("resetWithCompletionHandler")]        public void ResetWithCompletionHandler(Action completionHandler) {  }                /// <summary>        /// A copy of the configuration object for this session. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("configuration")]        public NSURLSessionConfiguration Configuration { get; private set; }                /// <summary>        /// The delegate assigned when this object was created. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("delegate")]        public NSURLSessionDelegate Delegate { get; private set; }                /// <summary>        /// The operation queue provided when this object was created. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("delegateQueue")]        public NSOperationQueue DelegateQueue { get; private set; }                /// <summary>        /// An app-defined descriptive label for the session.        /// </summary>        [iOSVersion(7)]        [Export("sessionDescription")]        public string SessionDescription { get; set; }                /// <summary>        /// Constants that indicate why a background task was cancelled.        /// </summary>        public int NSURLErrorCancelledReasonUserForceQuitApplication { get; set; }    }    /// <summary>    /// Constants for determining the current state of a task.    /// </summary>    [iOSVersion(7)]    public enum NSURLSessionTaskState    {        /// <summary>        /// The task is currently being serviced by the session. A task in this state is subject to the request and resource timeouts specified in the session configuration object.        /// </summary>        [iOSVersion(7)]        Running,        /// <summary>        /// The task was suspended by the app. No further processing takes place until it is resumed. A task in this state is not subject to timeouts.        /// </summary>        [iOSVersion(7)]        Suspended,        /// <summary>        /// The task has received a cancel message. The delegate may or may not have received a URLSession:task:didCompleteWithError: message yet. A task in this state is not subject to timeouts.        /// </summary>        [iOSVersion(7)]        Canceling,        /// <summary>        /// The task has completed (without being canceled), and the task's delegate receives no further callbacks. If the task completed successfully, the task’s error property is nil. Otherwise, it provides an error object that tells what went wrong. A task in this state is not subject to timeouts.        /// </summary>        [iOSVersion(7)]        Completed,    }}