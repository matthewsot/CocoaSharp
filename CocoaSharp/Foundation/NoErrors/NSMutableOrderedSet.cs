using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    using NSComparator = Func<AnyObject, AnyObject, NSComparisonResult>;

    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSMutableOrderedSet_Class/index.html#//apple_ref/occ/cl/NSMutableOrderedSet
    /// <summary>
    /// NSMutableOrderedSet class declares the programmatic interface to a mutable, ordered collection of distinct objects.
    /// </summary>
    [iOSVersion(5)]
    public class NSMutableOrderedSet : NSOrderedSet
    {
        /// <summary>
        /// Returns an initialized mutable ordered set with a given initial capacity.
        /// </summary>
        /// <param name="capacity">The initial capacity of the new ordered set.</param>
        /// <returns>An initialized mutable ordered set with initial capacity to hold numItems members.</returns>
        [iOSVersion(5)]
        public NSMutableOrderedSet(int capacity) { }
        
        /// <summary>
        /// Initializes a newly allocated mutable ordered set.
        /// </summary>
        /// <returns>A mutable ordered set.</returns>
        [iOSVersion(7)]
        public NSMutableOrderedSet() { }
        
        /// <summary>
        /// Appends a given object to the mutable ordered set, if it is not already a member.
        /// </summary>
        /// <param name="object">The object to add to the set.</param>
        [iOSVersion(5)]
        [Export("addObject")]
        public void AddObject(AnyObject @object) { }
        
        /// <summary>
        /// Appends the given number of objects from a given C array.
        /// </summary>
        /// <param name="objects">A C array of objects.</param>
        /// <param name="count">The number of values from the objects C array to append to the mutable ordered set. This number will be the count of the new array—it must not be negative or greater than the number of elements in objects.</param>
        [iOSVersion(5)]
        [Export("addObjects")]
        public void AddObjects(CConstPointer<AnyObject> objects, int count) { }
        
        /// <summary>
        /// Appends to the mutable ordered set each object contained in a given array that is not already a member.
        /// </summary>
        /// <param name="array">An array of objects to add to the set.</param>
        [iOSVersion(5)]
        [Export("addObjectsFromArray")]
        public void AddObjectsFromArray(AnyObject[] array) { }
        
        /// <summary>
        /// Inserts the given object at the specified index of the mutable ordered set.
        /// </summary>
        /// <param name="object">The object to insert into to the set’s content. This value must not be nil.       Important     Important: Raises an NSInvalidArgumentException if object is nil.</param>
        /// <param name="atIndex">The index in the mutable ordered set at which to insert object. This value must not be greater than the count of elements in the array.       Important     Important: Raises an NSRangeException if idx is greater than the number of elements in the mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("insertObject")]
        public void InsertObject(AnyObject @object, int atIndex) { }

        //TODO: wasup with the two SetObjects?
        
        /// <summary>
        /// Inserts the given object at the specified index of the mutable ordered set.
        /// </summary>
        /// <param name="object">The object to insert into to the set’s content. This value must not be nil.       Important     Important: Raises an NSInvalidArgumentException if object is nil.</param>
        /// <param name="atIndexedSubscript">The index in the mutable ordered set at which to insert object. This value must not be greater than the count of elements in the array.       Important     Important: Raises an NSRangeException if idx is greater than the number of elements in the mutable ordered set.</param>
        [iOSVersion(6)]
        [Export("setObject")]
        public void SetObject(AnyObject @object, int atIndexedSubscript) { }

        /// <summary>
        /// Appends or replaces the object at the specified index.
        /// </summary>
        /// <param name="obj">The object to insert or append.</param>
        /// <param name="atIndex">The index. If the index is equal to the length of the collection, then it inserts the object at that index, otherwise it replaces the object at that index with the given object.</param>
        [iOSVersion(5)]
        [Export("setObject")]
        public void SetObjectiOS5(AnyObject obj, int atIndex) { }
        
        /// <summary>
        /// Inserts the objects in the array at the specified indexes.
        /// </summary>
        /// <param name="objects">An array of objects to insert into the mutable ordered set.</param>
        /// <param name="atIndexes">The indexes at which the objects in objects should be inserted. The count of locations in indexes must equal the count of objects.</param>
        [iOSVersion(5)]
        [Export("insertObjects")]
        public void InsertObjects(AnyObject[] objects, NSIndexSet atIndexes) { }
        
        /// <summary>
        /// Removes a given object from the mutable ordered set.
        /// </summary>
        /// <param name="object">The object to remove from the mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("removeObject")]
        public void RemoveObject(AnyObject @object) { }
        
        /// <summary>
        /// Removes a the object at the specified index from the mutable ordered set.
        /// </summary>
        /// <param name="idx">The index of the object to remove from the mutable ordered set. The value must not exceed the bounds of the set.       Important     Raises an NSRangeException if index is beyond the end of the mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("removeObjectAtIndex")]
        public void RemoveObjectAtIndex(int idx) { }
        
        /// <summary>
        /// Removes the objects at the specified indexes from the mutable ordered set.
        /// </summary>
        /// <param name="indexes">The indexes of the objects to remove from the mutable ordered set. The locations specified by indexes must lie within the bounds of the mutable ordered .</param>
        [iOSVersion(5)]
        [Export("removeObjectsAtIndexes")]
        public void RemoveObjectsAtIndexes(NSIndexSet indexes) { }
        
        /// <summary>
        /// Removes the objects in the array from the mutable ordered set.
        /// </summary>
        /// <param name="array">An array containing the objects to be removed from the receiving mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("removeObjectsInArray")]
        public void RemoveObjectsInArray(AnyObject[] array) { }
        
        /// <summary>
        /// Removes from the mutable ordered set each of the objects within a given range.
        /// </summary>
        /// <param name="range">The range of the objects to remove from the mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("removeObjectsInRange")]
        public void RemoveObjectsInRange(NSRange range) { }
        
        /// <summary>
        /// Removes all the objects from the mutable ordered set.
        /// </summary>
        [iOSVersion(5)]
        [Export("removeAllObjects")]
        public void RemoveAllObjects() { }
        
        /// <summary>
        /// Replaces the object at the specified index with the new object.
        /// </summary>
        /// <param name="idx">The index of the object to be replaced. This value must not exceed the bounds of the mutable ordered set.       Important     Raises an NSRangeException if index is beyond the end of the mutable ordered set.</param>
        /// <param name="withObject">The object with which to replace the object at the index in the ordered set specified by idx. This value must not be nil.       Important     Raises an NSInvalidArgumentException if object is nil.</param>
        [iOSVersion(5)]
        [Export("replaceObjectAtIndex")]
        public void ReplaceObjectAtIndex(int idx, AnyObject withObject) { }
        
        /// <summary>
        /// Replaces the objects at the specified indexes with the new objects.
        /// </summary>
        /// <param name="indexes">The indexes of the objects to be replaced.</param>
        /// <param name="withObjects">The objects with which to replace the objects in the receiving mutable ordered set at the indexes specified by indexes.   The count of locations in indexes must equal the count of objects.</param>
        [iOSVersion(5)]
        [Export("replaceObjectsAtIndexes")]
        public void ReplaceObjectsAtIndexes(NSIndexSet indexes, AnyObject[] withObjects) { }
        
        /// <summary>
        /// Replaces the objects in the receiving mutable ordered set at the range with the specified number of objects from a given C array.
        /// </summary>
        /// <param name="range">The range of the objects to replace.</param>
        /// <param name="withObjects">A C array of objects.</param>
        /// <param name="count">The number of values from the objects C array to insert in place of the objects in range. This number will be the count of the new array—it must not be negative or greater than the number of elements in objects.</param>
        [iOSVersion(5)]
        [Export("replaceObjectsInRange")]
        public void ReplaceObjectsInRange(NSRange range, CConstPointer<AnyObject> withObjects, int count) { }
        
        /// <summary>
        /// Moves the objects at the specified indexes to the new location.
        /// </summary>
        /// <param name="indexes">The indexes of the objects to move.</param>
        /// <param name="toIndex">The index in the mutable ordered set at which to insert the objects. The objects being moved are first removed from the set, then this index is used to find the location at which to insert the moved objects.</param>
        [iOSVersion(5)]
        [Export("moveObjectsAtIndexes")]
        public void MoveObjectsAtIndexes(NSIndexSet indexes, int toIndex) { }
        
        /// <summary>
        /// Exchanges the object at the specified index with the object at the other index.
        /// </summary>
        /// <param name="idx1">The index of the first object.       Important     Raises an NSRangeException if index is beyond the end of the mutable ordered set.</param>
        /// <param name="withObjectAtIndex">The index of the second object.       Important     Raises an NSRangeException if index is beyond the end of the mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("exchangeObjectAtIndex")]
        public void ExchangeObjectAtIndex(int idx1, int withObjectAtIndex) { }
        
        /// <summary>
        /// Evaluates a given predicate against the mutable ordered set’s content and leaves only objects that match.
        /// </summary>
        /// <param name="predicate">The predicate to evaluate against the set’s elements.</param>
        [iOSVersion(5)]
        [Export("filterUsingPredicate")]
        public void FilterUsingPredicate(NSPredicate predicate) { }
        
        /// <summary>
        /// Sorts the receiving ordered set using a given array of sort descriptors.
        /// </summary>
        /// <param name="sortDescriptors">An array containing the NSSortDescriptor objects to use to sort the receiving ordered set’s contents.</param>
        [iOSVersion(5)]
        [Export("sortUsingDescriptors")]
        public void SortUsingDescriptors(AnyObject[] sortDescriptors) { }
        
        /// <summary>
        /// Sorts the mutable ordered set using the comparison method specified by the comparator block.
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        [iOSVersion(5)]
        [Export("sortUsingComparator")]
        public void SortUsingComparator(NSComparator cmptr) { }
        
        /// <summary>
        /// Sorts the mutable ordered set using the specified options and the comparison method specified by a given comparator block.
        /// </summary>
        /// <param name="opts">A bitmask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="usingComparator">A comparator block.</param>
        [iOSVersion(5)]
        [Export("sortWithOptions")]
        public void SortWithOptions(NSSortOptions opts, NSComparator usingComparator) { }
        
        /// <summary>
        /// Sorts the specified range of the mutable ordered set using the specified options and the comparison method specified by a given comparator block.
        /// </summary>
        /// <param name="range">The range to sort.</param>
        /// <param name="options">A bitmask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="usingComparator">A comparator block.</param>
        [iOSVersion(5)]
        [Export("sortRange")]
        public void SortRange(NSRange range, NSSortOptions options, NSComparator usingComparator) { }
        
        /// <summary>
        /// Removes from the receiving ordered set each object that isn’t a member of another ordered set.
        /// </summary>
        /// <param name="other">The ordered set with which to perform the intersection.</param>
        [iOSVersion(5)]
        [Export("intersectOrderedSet")]
        public void intersectOrderedSet(NSOrderedSet other) { }
        
        /// <summary>
        /// Removes from the receiving ordered set each object that isn’t a member of another set.
        /// </summary>
        /// <param name="other">The set with which to perform the intersection.</param>
        [iOSVersion(5)]
        [Export("intersectSet")]
        public void intersectSet(NSSet other) { }
        
        /// <summary>
        /// Removes each object in another given ordered set from the receiving mutable ordered set, if present.
        /// </summary>
        /// <param name="other">The ordered set of objects to remove from the receiving set.</param>
        [iOSVersion(5)]
        [Export("minusOrderedSet")]
        public void MinusOrderedSet(NSOrderedSet other) { }
        
        /// <summary>
        /// Removes each object in another given set from the receiving mutable ordered set, if present.
        /// </summary>
        /// <param name="other">The set of objects to remove from the receiving set.</param>
        [iOSVersion(5)]
        [Export("minusSet")]
        public void MinusSet(NSSet other) { }
        
        /// <summary>
        /// Adds each object in another given ordered set to the receiving mutable ordered set, if not present.
        /// </summary>
        /// <param name="other">The set of objects to add to the receiving mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("unionOrderedSet")]
        public void UnionOrderedSet(NSOrderedSet other) { }
        
        /// <summary>
        /// Adds each object in another given set to the receiving mutable ordered set, if not present.
        /// </summary>
        /// <param name="other">The set of objects to add to the receiving mutable ordered set.</param>
        [iOSVersion(5)]
        [Export("unionSet")]
        public void UnionSet(NSSet other) { }
    }
}