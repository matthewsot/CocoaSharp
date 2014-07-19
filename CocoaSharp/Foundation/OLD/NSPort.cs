using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPort_Class/index.html#//apple_ref/occ/cl/NSPort
    /// <summary>
    /// NSPort is an abstract class that represents a communication channel. Communication occurs between NSPort objects, which typically reside in different threads or tasks. The distributed objects system uses NSPort objects to send NSPortMessage objects back and forth. You should implement interapplication communication using distributed objects whenever possible and use NSPort objects only when necessary.
    /// </summary>
    [iOSVersion(2)]
    public class NSPort : NSObject
    {
        /// <summary>
        /// Marks the receiver as invalid and posts an NSPortDidBecomeInvalidNotification to the default notification center.
        /// </summary>
        [iOSVersion(2)]
        [Export("invalidate")]
        public void Invalidate() { }
        
        /// <summary>
        /// Sets the receiver’s delegate to a given object.
        /// </summary>
        /// <param name="anObject">The delegate for the receiver.</param>
        [iOSVersion(2)]
        [Export("setDelegate")]
        public void SetDelegate(NSPortDelegate anObject) { }
        
        /// <summary>
        /// Returns the receiver’s delegate.
        /// </summary>
        /// <returns>The receiver’s delegate.</returns>
        [iOSVersion(2)]
        [Export("delegate")]
        public NSPortDelegate Delegate() { return null; }
        
        /// <summary>
        /// This method is provided for subclasses that have custom types of NSPort.
        /// </summary>
        /// <param name="limitDate">The last instant that a message may be sent.</param>
        /// <param name="components">The message components.</param>
        /// <param name="from">The receive port.</param>
        /// <param name="reserved">The number of bytes reserved for the header.</param>
        [iOSVersion(2)]
        [Export("sendBeforeDate")]
        public bool SendBeforeDate(NSDate limitDate, NSMutableArray components, NSPort from, int reserved) { return false; }
        
        /// <summary>
        /// This method is provided for subclasses that have custom types of NSPort.
        /// </summary>
        /// <param name="limitDate">The last instant that a message may be sent.</param>
        /// <param name="msgid">The message ID.</param>
        /// <param name="components">The message components.</param>
        /// <param name="from">The receive port.</param>
        /// <param name="reserved">The number of bytes reserved for the header.</param>
        [iOSVersion(2)]
        [Export("sendBeforeDate")]
        public bool SendBeforeDate(NSDate limitDate, int msgid, NSMutableArray components, NSPort from, int reserved) { return false; }
        
        /// <summary>
        /// Returns the number of bytes of space reserved by the receiver for sending data.
        /// </summary>
        /// <returns>The number of bytes reserved by the receiver for sending data. The default length is 0.</returns>
        [iOSVersion(2)]
        [Export("reservedSpaceLength")]
        public int ReservedSpaceLength { get; private set; }
        
        /// <summary>
        /// This method should be implemented by a subclass to stop monitoring of a port when removed from a give run loop in a given input mode.
        /// </summary>
        /// <param name="runLoop">The run loop from which to remove the receiver.</param>
        /// <param name="forMode">The run loop mode from which to remove the receiver</param>
        [iOSVersion(2)]
        [Export("removeFromRunLoop")]
        public void RemoveFromRunLoop(NSRunLoop runLoop, string forMode) { }
        
        /// <summary>
        /// This method should be implemented by a subclass to set up monitoring of a port when added to a given run loop in a given input mode.
        /// </summary>
        /// <param name="runLoop">The run loop to which to add the receiver.</param>
        /// <param name="forMode">The run loop mode to which to add the receiver</param>
        [iOSVersion(2)]
        [Export("scheduleInRunLoop")]
        public void ScheduleInRunLoop(NSRunLoop runLoop, string forMode) { }
    }

    /// <summary>
    /// An NSSocketPort object cannot detect when its connection to a remote port is lost, even if the remote port is on the same machine. Therefore, it cannot invalidate itself and post this notification. Instead, you must detect the timeout error when the next message is sent.
    /// The NSPort object posting this notification is no longer useful, so all receivers should unregister themselves for any notifications involving the NSPort. A method receiving this notification should check to see which port became invalid before attempting to do anything. In particular, observers that receive all NSPortDidBecomeInvalidNotification messages should be aware that communication with the window server is handled through an NSPort. If this port becomes invalid, drawing operations will cause a fatal error.
    /// </summary>
    [iOSVersion(2)]
    public class NSPortDidBecomeInvalidNotification : NSNotification
    {
        public NSPortDidBecomeInvalidNotification() : base("", null) { }
    }
}