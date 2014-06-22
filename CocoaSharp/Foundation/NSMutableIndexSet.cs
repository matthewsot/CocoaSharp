﻿using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableIndexSet_Class/index.html#//apple_ref/occ/cl/NSMutableIndexSet
    /// <summary>
    /// The NSMutableIndexSet class represents a mutable collection of unique unsigned integers, known as indexes because of the way they are used. This collection is referred to as a mutable index set. The set of valid indexes are 0 .. NSNotFound - 1; trying to use indexes outside this range is an error.
    /// </summary>
    [iOSVersion(2)]
    class NSMutableIndexSet : NSIndexSet
    {
        /// <summary>
        /// Adds an index to the receiver.
        /// </summary>
        /// <param name="index">Index to add. Must be in the range 0 .. NSNotFound - 1.</param>
        [iOSVersion(2)]
        [Export("addIndex")]
        public void AddIndex(int index) { }

        /// <summary>
        /// Adds the indexes in an index set to the receiver.
        /// </summary>
        /// <param name="indexSet">Index set to add.</param>
        [iOSVersion(2)]
        [Export("addIndexes")]
        public void AddIndexes(NSIndexSet indexSet) { }

        /// <summary>
        /// Adds the indexes in an index range to the receiver.
        /// </summary>
        /// <param name="indexRange">Index range to add. Must be in the range 0 .. NSNotFound - 1.</param>
        [iOSVersion(2)]
        [Export("addIndexesInRange")]
        public void AddIndexesInRange(NSRange indexRange) { }

        /// <summary>
        /// Removes an index from the receiver.
        /// </summary>
        /// <param name="index">Index to remove.</param>
        [iOSVersion(2)]
        [Export("removeIndex")]
        public void RemoveIndex(int index) { }

        /// <summary>
        /// Removes the indexes in an index set from the receiver.
        /// </summary>
        /// <param name="indexSet">Index set to remove.</param>
        [iOSVersion(2)]
        [Export("removeIndexes")]
        public void RemoveIndexes(NSIndexSet indexSet) { }

        /// <summary>
        /// Removes the receiver’s indexes.
        /// </summary>
        [iOSVersion(2)]
        [Export("removeAllIndexes")]
        public void RemoveAllIndexes() { }

        /// <summary>
        /// Removes the indexes in an index range from the receiver.
        /// </summary>
        /// <param name="indexRange">Index range to remove.</param>
        [iOSVersion(2)]
        [Export("removeIndexesInRange")]
        public void RemoveIndexesInRange(NSRange indexRange) { }

        /// <summary>
        /// Shifts a group of indexes to the left or the right within the receiver.
        /// </summary>
        /// <param name="startIndex">Head of the group of indexes to shift.</param>
        /// <param name="by">Amount and direction of the shift. Positive integers shift the indexes to the right. Negative integers shift the indexes to the left.</param>
        [iOSVersion(2)]
        [Export("shiftIndexesStartingAtIndex")]
        public void ShiftIndexesStartingAtIndex(int startIndex, int by) { }
    }
}