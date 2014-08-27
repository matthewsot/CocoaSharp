using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSURLConnectionDownloadDelegate protocol describes methods that should be implemented by the delegate of instances of NSURLConnection created using Newsstand Kit’s downloadWithDelegate: method. The methods in this protocol provide progress information about the download of a URL asset and, when downloading concludes, provide a file URL where the downloaded file can be accessed.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSURLConnectionDownloadDelegate_Protocol/index.html#//apple_ref/occ/intf/NSURLConnectionDownloadDelegate"/>    [iOSVersion(5)]    public interface NSURLConnectionDownloadDelegate//: NSObjectProtocol, NSURLConnectionDelegate    {        /// <summary>        /// Sent to the delegate to deliver progress information for a download of a URL asset to a destination file.        /// </summary>        /// <param name="connection">The URL connection object downloading the asset.</param>        /// <param name="didWriteData">The number of bytes written since the last call of this method.</param>        /// <param name="totalBytesWritten">The total number of bytes of the downloading asset that have been written to the file.</param>        /// <param name="expectedTotalBytes">The total number of bytes of the URL asset once it is completely downloaded and written to a file. This parameter can be zero if the total number of bytes is not known.</param>        [iOSVersion(5)]        [Export("connection")]        void Connection(NSURLConnection connection, Int64 didWriteData, Int64 totalBytesWritten, Int64 expectedTotalBytes);                /// <summary>        /// Sent to the delegate when an URL connection resumes downloading a URL asset that was earlier suspended.        /// </summary>        /// <param name="connection">The URL connection object downloading the asset.</param>        /// <param name="totalBytesWritten">The total number of bytes of the downloading asset that have been written to the destination file.</param>        /// <param name="expectedTotalBytes">The total number of bytes of the URL asset once it is completely downloaded and written to a file.</param>        [iOSVersion(5)]        [Export("connectionDidResumeDownloading")]        void ConnectionDidResumeDownloading(NSURLConnection connection, Int64 totalBytesWritten, Int64 expectedTotalBytes);                /// <summary>        /// Sent to the delegate when the URL connection has successfully downloaded the URL asset to a destination file.        /// </summary>        /// <param name="connection">The URL connection object that downloaded the asset.</param>        /// <param name="destinationURL">A file URL specifying a destination in the file system. For iOS applications, this is a location in the application sandbox.</param>        [iOSVersion(5)]        [Export("connectionDidFinishDownloading")]        void ConnectionDidFinishDownloading(NSURLConnection connection, NSURL destinationURL);    }}