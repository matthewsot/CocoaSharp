﻿using ObjectiveC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    using NSComparator = Func<AnyObject, AnyObject, NSComparisonResult>;

    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableArray_Class/index.html#//apple_ref/occ/cl/NSMutableArray
    /// <summary>
    /// The NSMutableArray class declares the programmatic interface to objects that manage a modifiable array of objects. This class adds insertion and deletion operations to the basic array-handling behavior inherited from NSArray.
    /// </summary>
    public class NSMutableArray : NSArray
    {
        /// <summary>
        /// Returns an array, initialized with enough memory to initially hold a given number of objects.
        /// </summary>
        /// <param name="numItems">The initial capacity of the new array.</param>
        /// <returns>An array initialized with enough memory to hold numItems objects. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSMutableArray(int capacity) { }

        /// <summary>
        /// Initializes a newly allocated array.
        /// </summary>
        /// <returns>An array.</returns>
        [iOSVersion(7)]
        public NSMutableArray() { }

        /// <summary>
        /// Inserts a given object at the end of the array.
        /// </summary>
        /// <param name="anObject">The object to add to the end of the array's content. This value must not be nil.       Important     Raises an NSInvalidArgumentException if anObject is nil.</param>
        [iOSVersion(2)]
        [Export("addObject")]
        public void AddObject(AnyObject anObject) { }

        /// <summary>
        /// Adds the objects contained in another given array to the end of the receiving array’s content.
        /// </summary>
        /// <param name="otherArray">An array of objects to add to the end of the receiving array’s content.</param>
        [iOSVersion(2)]
        [Export("addObjectsFromArray")]
        public void AddObjectsFromArray(AnyObject[] otherArray) { }

        /// <summary>
        /// Inserts a given object into the array's contents at a given index.
        /// </summary>
        /// <param name="anObject">The object to add to the array's content. This value must not be nil.       Important     Raises an NSInvalidArgumentException if anObject is nil.</param>
        /// <param name="index">The index in the array at which to insert anObject. This value must not be greater than the count of elements in the array.       Important     Raises an NSRangeException if index is greater than the number of elements in the array.</param>
        [iOSVersion(2)]
        [Export("insertObject")]
        public void InsertObject(AnyObject anObject, int atIndex) { }

        /// <summary>
        /// Inserts the objects in the provided array into the receiving array at the specified indexes.
        /// </summary>
        /// <param name="objects">An array of objects to insert into the receiving array.</param>
        /// <param name="indexes">The indexes at which the objects in objects should be inserted. The count of locations in indexes must equal the count of objects. For more details, see the Discussion.</param>
        [iOSVersion(2)]
        [Export("insertObjects")]
        public void InsertObjects(AnyObject[] objects, NSIndexSet atIndexes) { }

        /// <summary>
        /// Empties the array of all its elements.
        /// </summary>
        [iOSVersion(2)]
        [Export("removeAllObjects")]
        public void RemoveAllObjects() { }

        /// <summary>
        /// Removes the object with the highest-valued index in the array
        /// </summary>
        [iOSVersion(2)]
        [Export("removeLastObject")]
        public void RemoveLastObject() { }

        /// <summary>
        /// Removes all occurrences in the array of a given object.
        /// </summary>
        /// <param name="anObject">The object to remove from the array.</param>
        [iOSVersion(2)]
        [Export("removeObject")]
        public void RemoveObject(AnyObject anObject) { }

        /// <summary>
        /// Removes all occurrences within a specified range in the array of a given object.
        /// </summary>
        /// <param name="anObject">The object to remove from the array's content.</param>
        /// <param name="aRange">The range from which to remove anObject.       Important     Raises an NSRangeException if aRange exceeds the bounds of the array.</param>
        [iOSVersion(2)]
        [Export("removeObject")]
        public void RemoveObject(AnyObject anObject, NSRange inRange) { }

        /// <summary>
        /// Removes the object at index .
        /// </summary>
        /// <param name="index">The index from which to remove the object in the array. The value must not exceed the bounds of the array.       Important     Raises an NSRangeException if index is beyond the end of the array.</param>
        [iOSVersion(2)]
        [Export("removeObjectAtIndex")]
        public void RemoveObjectAtIndex(int index) { }

        /// <summary>
        /// Removes the objects at the specified indexes from the array.
        /// </summary>
        /// <param name="indexes">The indexes of the objects to remove from the array. The locations specified by indexes must lie within the bounds of the array.</param>
        [iOSVersion(2)]
        [Export("removeObjectsAtIndexes")]
        public void RemoveObjectsAtIndexes(NSIndexSet indexes) { }

        /// <summary>
        /// Removes all occurrences of a given object in the array.
        /// </summary>
        /// <param name="anObject">The object to remove from the array.</param>
        [iOSVersion(2)]
        [Export("removeObjectIdenticalTo")]
        public void RemoveObjectIdenticalTo(AnyObject anObject) { }

        /// <summary>
        /// Removes all occurrences of anObject within the specified range in the array.
        /// </summary>
        /// <param name="anObject">The object to remove from the array within aRange.</param>
        /// <param name="aRange">The range in the array from which to remove anObject.       Important     Raises an NSRangeException if aRange exceeds the bounds of the array.</param>
        [iOSVersion(2)]
        [Export("removeObjectIdenticalTo")]
        public void RemoveObjectIdenticalTo(AnyObject anObject, NSRange inRange) { }

        /// <summary>
        /// Removes the specified number of objects from the array, beginning at the specified index.
        /// Deprecation Statement: Use removeObjectsAtIndexes: instead.
        /// </summary>
        /// <param name="indices">A C array of the indices of the objects to remove from the receiving array.</param>
        /// <param name="count">The number of objects to remove from the receiving array.</param>
        [iOSVersion(2)]
        [Obsolete]
        [Export("removeObjectsFromIndices")]
        public void RemoveObjectsFromIndices(CMutablePointer<int> indices, int numIndices) { }

        /// <summary>
        /// Removes from the receiving array the objects in another given array.
        /// </summary>
        /// <param name="otherArray">An array containing the objects to be removed from the receiving array.</param>
        [iOSVersion(2)]
        [Export("removeObjectsInArray")]
        public void RemoveObjectsInArray(AnyObject[] otherArray) { }

        /// <summary>
        /// Removes from the array each of the objects within a given range.
        /// </summary>
        /// <param name="aRange">The range of the objects to remove from the array.</param>
        [iOSVersion(2)]
        [Export("removeObjectsInRange")]
        public void RemoveObjectsInRange(NSRange aRange) { }

        /// <summary>
        /// Replaces the object at index with anObject.
        /// </summary>
        /// <param name="index">The index of the object to be replaced. This value must not exceed the bounds of the array.       Important     Raises an NSRangeException if index is beyond the end of the array.</param>
        /// <param name="anObject">The object with which to replace the object at index index in the array. This value must not be nil.       Important     Raises an NSInvalidArgumentException if anObject is nil.</param>
        [iOSVersion(2)]
        [Export("replaceObjectAtIndex")]
        public void ReplaceObjectAtIndex(int index, AnyObject withObject) { }

        /// <summary>
        /// Replaces the object at the index with the new object, possibly adding the object.
        /// </summary>
        /// <param name="anObject">The object with which to replace the object at index index in the array. This value must not be nil.       Important     Raises an NSInvalidArgumentException if anObject is nil.</param>
        /// <param name="index">The index of the object to be replaced. This value must not exceed the bounds of the array.       Important     Raises an NSRangeException if index is beyond the end of the array.</param>
        [iOSVersion(6)]
        [Export("setObject")]
        public void SetObject(AnyObject anObject, int atIndexedSubscript) { }

        /// <summary>
        /// Replaces the objects in the receiving array at specified locations specified with the objects from a given array.
        /// </summary>
        /// <param name="indexes">The indexes of the objects to be replaced.</param>
        /// <param name="objects">The objects with which to replace the objects in the receiving array at the indexes specified by indexes. The count of locations in indexes must equal the count of objects.</param>
        [iOSVersion(2)]
        [Export("replaceObjectsAtIndexes")]
        public void ReplaceObjectsAtIndexes(NSIndexSet indexes, AnyObject[] withObjects) { }

        /// <summary>
        /// Replaces the objects in the receiving array specified by one given range with the objects in another array specified by another range.
        /// </summary>
        /// <param name="aRange">The range of objects to replace in (or remove from) the receiving array.</param>
        /// <param name="otherArray">The array of objects from which to select replacements for the objects in aRange.</param>
        /// <param name="otherRange">The range of objects to select from otherArray as replacements for the objects in aRange.</param>
        [iOSVersion(2)]
        [Export("replaceObjectsInRange")]
        public void ReplaceObjectsInRange(NSRange aRange, AnyObject[] withObjectsFromArray, NSRange range) { }

        /// <summary>
        /// Replaces the objects in the receiving array specified by a given range with all of the objects from a given array.
        /// </summary>
        /// <param name="aRange">The range of objects to replace in (or remove from) the receiving array.</param>
        /// <param name="otherArray">The array of objects from which to select replacements for the objects in aRange.</param>
        [iOSVersion(2)]
        [Export("replaceObjectsInRange")]
        public void ReplaceObjectsInRange(NSRange aRange, AnyObject[] withObjectsFromArray) { }

        /// <summary>
        /// Sets the receiving array’s elements to those in another given array.
        /// </summary>
        /// <param name="otherArray">The array of objects with which to replace the receiving array's content.</param>
        [iOSVersion(2)]
        [Export("setArray")]
        public void SetArray(AnyObject[] otherArray) { }

        /// <summary>
        /// Evaluates a given predicate against the array’s content and leaves only objects that match
        /// </summary>
        /// <param name="predicate">The predicate to evaluate against the array's elements.</param>
        [iOSVersion(3)]
        [Export("filterUsingPredicate")]
        public void FilterUsingPredicate(NSPredicate predicate) { }

        /// <summary>
        /// Exchanges the objects in the array at given indices.
        /// </summary>
        /// <param name="idx1">The index of the object with which to replace the object at index idx2.</param>
        /// <param name="idx2">The index of the object with which to replace the object at index idx1.</param>
        [iOSVersion(2)]
        [Export("exchangeObjectAtIndex")]
        public void ExchangeObjectAtIndex(int idx1, int withObjectAtIndex) { }

        /// <summary>
        /// Sorts the receiving array using a given array of sort descriptors.
        /// </summary>
        /// <param name="sortDescriptors">An array containing the NSSortDescriptor objects to use to sort the receiving array's contents.</param>
        [iOSVersion(2)]
        [Export("sortUsingDescriptors")]
        public void SortUsingDescriptors(AnyObject[] sortDescriptors) { }

        /// <summary>
        /// Sorts the array using the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        [iOSVersion(4)]
        [Export("sortUsingComparator")]
        public void SortUsingComparator(NSComparator cmptr) { }

        /// <summary>
        /// Sorts the array using the specified options and the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="cmptr">A comparator block.</param>
        [iOSVersion(4)]
        [Export("sortWithOptions")]
        public void SortWithOptions(NSSortOptions opts, NSComparator usingComparator) { }

        /// <summary>
        /// Sorts the array’s elements in ascending order, as determined by the comparison method specified by a given selector.
        /// </summary>
        /// <param name="comparator">A selector that specifies the comparison method to use to compare elements in the array.   The comparator message is sent to each object in the array and has as its single argument another object in the array. The comparator method should return NSOrderedAscending if the array is smaller than the argument, NSOrderedDescending if the array is larger than the argument, and NSOrderedSame if they are equal.</param>
        [iOSVersion(2)]
        [Export("sortUsingSelector")]
        public void SortUsingSelector(Selector comparator) { }
    }
}
