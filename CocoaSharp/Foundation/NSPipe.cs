using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSPipe objects provide an object-oriented interface for accessing pipes. An NSPipe object represents both ends of a pipe and enables communication through the pipe. A pipe is a one-way communications channel between related processes; one process writes data, while the other process reads that data. The data that passes through the pipe is buffered; the size of the buffer is determined by the underlying operating system. NSPipe is an abstract class, the public interface of a class cluster.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPipe_Class/index.html#//apple_ref/occ/cl/NSPipe"/>    [iOSVersion(2)]    public class NSPipe : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// The receiver's read file handle. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("fileHandleForReading")]        public NSFileHandle FileHandleForReading { get; private set; }                /// <summary>        /// The receiver's write file handle. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("fileHandleForWriting")]        public NSFileHandle FileHandleForWriting { get; private set; }    }}