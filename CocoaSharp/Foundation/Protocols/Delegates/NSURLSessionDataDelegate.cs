using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLSessionDataDelegate_protocol/index.html#//apple_ref/occ/intf/NSURLSessionDataDelegate    /// <summary>    /// The NSURLSessionDataDelegate protocol defines the methods that a delegate of an NSURLSession object can implement to handle task-level events specific to data tasks and upload tasks. Your session delegate should also implement the methods in the NSURLSessionTaskDelegate protocol to handle task-level events that are common to all task types, and methods in the NSURLSessionDelegate protocol to handle session-level events.    /// </summary>    [iOSVersion(7)]    public interface NSURLSessionDataDelegate    {        /// <summary>        /// Tells the delegate that the data task received the initial reply (headers) from the server.        /// </summary>        /// <param name="session">The session containing the data task that received an initial reply.</param>        /// <param name="dataTask">The data task that received an initial reply.</param>        /// <param name="didReceiveResponse">A URL response object populated with headers.</param>        /// <param name="completionHandler">A completion handler that your code calls to continue the transfer, passing a constant to indicate whether the transfer should continue as a data task or should become a download task.    If you pass NSURLSessionResponseAllow, the task continues normally.   If you pass NSURLSessionResponseCancel, the task is canceled.   If you pass NSURLSessionResponseBecomeDownload as the disposition, your delegate’s URLSession:dataTask:didBecomeDownloadTask: method is called to provide you with the new download task that supersedes the current task.</param>        [iOSVersion(7)]        [Export("URLSession")]        [Optional]        void URLSession(NSURLSession session, NSURLSessionDataTask dataTask, NSURLResponse didReceiveResponse, Action<NSURLSessionResponseDisposition> completionHandler);                /// <summary>        /// Tells the delegate that the data task was changed to a download task.        /// </summary>        /// <param name="session">The session containing the task that was replaced by a download task.</param>        /// <param name="dataTask">The data task that was replaced by a download task.</param>        /// <param name="didBecomeDownloadTask">The new download task that replaced the data task.</param>        [iOSVersion(7)]        [Export("URLSession")]        [Optional]        void URLSession(NSURLSession session, NSURLSessionDataTask dataTask, NSURLSessionDownloadTask didBecomeDownloadTask);                /// <summary>        /// Tells the delegate that the data task has received some of the expected data.        /// </summary>        /// <param name="session">The session containing the data task that provided data.</param>        /// <param name="dataTask">The data task that provided data.</param>        /// <param name="didReceiveData">A data object containing the transferred data.</param>        [iOSVersion(7)]        [Export("URLSession")]        [Optional]        void URLSession(NSURLSession session, NSURLSessionDataTask dataTask, NSData didReceiveData);                /// <summary>        /// Asks the delegate whether the data (or upload) task should store the response in the cache.        /// </summary>        /// <param name="session">The session containing the data (or upload) task.</param>        /// <param name="dataTask">The data (or upload) task.</param>        /// <param name="willCacheResponse">The default caching behavior. This behavior is determined based on the current caching policy and the values of certain received headers, such as the Pragma and Cache-Control headers.</param>        /// <param name="completionHandler">A block that your handler must call, providing either the original proposed response, a modified version of that response, or NULL to prevent caching the response. If your delegate implements this method, it must call this completion handler; otherwise, your app leaks memory.</param>        [iOSVersion(7)]        [Export("URLSession")]        [Optional]        void URLSession(NSURLSession session, NSURLSessionDataTask dataTask, NSCachedURLResponse willCacheResponse, Action<NSCachedURLResponse> completionHandler);    }

    /// <summary>
    /// Constants indicating how a data or upload session should proceed after receiving the initial headers.
    /// </summary>
    public enum NSURLSessionResponseDisposition
    {
        /// <summary>
        /// Cancel the load. Equivalent to calling cancel on the task.
        /// </summary>
        [iOSVersion(7)]
        Cancel,

        /// <summary>
        /// Allow the load operation to continue.
        /// </summary>
        [iOSVersion(7)]
        Allow,

        /// <summary>
        /// Convert this request into a download task.
        /// </summary>
        [iOSVersion(7)]
        BecomeDownload,
    }}