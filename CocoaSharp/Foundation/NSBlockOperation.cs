using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSBlockOperation_class/index.html#//apple_ref/occ/cl/NSBlockOperation
    /// <summary>
    /// The NSBlockOperation class is a concrete subclass of NSOperation that manages the concurrent execution of one or more blocks. You can use this object to execute several blocks at once without having to create separate operation objects for each. When executing more than one block, the operation itself is considered finished only when all blocks have finished executing.
    /// </summary>
    [iOSVersion(4)]
    public class NSBlockOperation : NSOperation
    {
        /// <summary>
        /// Creates and returns an NSBlockOperation object and adds the specified block to it.
        /// </summary>
        /// <param name="block">The block to add to the new block operation object’s list. The block should take no parameters and have no return value.</param>
        /// <returns>A new block operation object.</returns>
        [iOSVersion(4)]
        public NSBlockOperation(Action block) { }
        
        /// <summary>
        /// Adds the specified block to the receiver’s list of blocks to perform.
        /// </summary>
        /// <param name="block">The block to add to the receiver’s list. The block should take no parameters and have no return value.</param>
        [iOSVersion(4)]
        [Export("addExecutionBlock")]
        public void AddExecutionBlock(Action block) { }
        
        /// <summary>
        /// Returns an array containing the blocks associated with the receiver.
        /// </summary>
        /// <returns>An array of blocks. The blocks in this array are copies of the ones originally added using the addExecutionBlock: method.</returns>
        [iOSVersion(4)]
        [Export("executionBlocks")]
        public AnyObject[] ExecutionBlocks { get; private set; }
    }
}