using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSCondition_class/index.html#//apple_ref/occ/cl/NSCondition
    /// <summary>
    /// The NSCondition class implements a condition variable whose semantics follow those used for POSIX-style conditions. A condition object acts as both a lock and a checkpoint in a given thread. The lock protects your code while it tests the condition and performs the task triggered by the condition. The checkpoint behavior requires that the condition be true before the thread proceeds with its task. While the condition is not true, the thread blocks. It remains blocked until another thread signals the condition object.
    /// </summary>
    [iOSVersion(2)]
    public class NSCondition : NSObject
    {
        /// <summary>
        /// Blocks the current thread until the condition is signaled.
        /// </summary>
        [iOSVersion(2)]
        [Export("wait")]
        public void Wait() { }

        /// <summary>
        /// Blocks the current thread until the condition is signaled or the specified time limit is reached.
        /// </summary>
        /// <param name="limit">The time at which to wake up the thread if the condition has not been signaled.</param>
        /// <returns>true if the condition was signaled; otherwise, false if the time limit was reached.</returns>
        [iOSVersion(2)]
        [Export("waitUntilDate")]
        public bool WaitUntilDate(NSDate limit) { return false; }

        /// <summary>
        /// Signals the condition, waking up one thread waiting on it.
        /// </summary>
        [iOSVersion(2)]
        [Export("signal")]
        public void Signal() { }

        /// <summary>
        /// Signals the condition, waking up all threads waiting on it.
        /// </summary>
        [iOSVersion(2)]
        [Export("broadcast")]
        public void Broadcast() { }

        /// <summary>
        /// Assigns or returns a name to the receiver.
        /// </summary>
        /// <param name="newName">The new name for the receiver. This method makes a copy of the specified string.</param>
        /// <returns>The name of the receiver.</returns>
        [iOSVersion(2)]
        [Export("name")]
        public string Name { get; set; }
    }
}