using System;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSArray_Class/index.html#//apple_ref/occ/cl/NSArray
    /// <summary>
    /// NSArray and its subclass NSMutableArray manage ordered collections of objects called arrays. NSArray creates static arrays, and NSMutableArray creates dynamic arrays. You can use arrays when you need an ordered collection of objects.
    /// </summary>
    [iOSVersion(2)]
    public class NSArray : NSObject
    {
        /// <summary>
        /// Initializes a newly allocated array.
        /// </summary>
        /// <returns>An array.</returns>
        [iOSVersion(2)]
        public NSArray() { }

        /// <summary>
        /// Creates and returns an array containing a given object.
        /// </summary>
        /// <param name="object">An object.</param>
        /// <returns>An array containing the single element anObject.</returns>
        [iOSVersion(2)]
        public NSArray(AnyObject @object) { }

        /// <summary>
        /// Initializes a newly allocated array by placing in it the objects contained in a given array.
        /// </summary>
        /// <param name="array">An array.</param>
        /// <returns>An array initialized to contain the objects in anArray. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSArray(AnyObject[] array) { }

        /// <summary>
        /// Initializes a newly allocated array using anArray as the source of data objects for the array.
        /// </summary>
        /// <param name="array">An array containing the objects with which to initialize the new array.</param>
        /// <param name="copyItems">If true, each object in array receives a copyWithZone: message to create a copy of the object—objects must conform to the NSCopying protocol. In a managed memory environment, this is instead of the retain message the object would otherwise receive. The object copy is then added to the returned array.   If false, then in a managed memory environment each object in array simply receives a retain message when it is added to the returned array.</param>
        /// <returns>An array initialized to contain the objects—or if flag is true, copies of the objects—in array. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSArray(AnyObject[] array, bool copyItems) { }

        /// <summary>
        /// Initializes a newly allocated array with the contents of the file specified by a given path.
        /// </summary>
        /// <param name="contentsOfFile">The path to a file containing a representation of an array produced by the writeToFile:atomically: method.</param>
        /// <returns>An array initialized to contain the contents of the file specified by aPath or nil if the file can’t be opened or the contents of the file can’t be parsed into an array. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSArray(string contentsOfFile) { }

        /// <summary>
        /// Initializes a newly allocated array with the contents of the location specified by a given URL.
        /// </summary>
        /// <param name="contentsOfURL">The location of a file containing a string representation of an array produced by the writeToURL:atomically: method.</param>
        /// <returns>An array initialized to contain the contents specified by aURL. Returns nil if the location can’t be opened or if the contents of the location can’t be parsed into an array. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSArray(NSURL contentsOfURL) { }

        /// <summary>
        /// Initializes a newly allocated array to include a given number of objects from a given C array.
        /// </summary>
        /// <param name="objects">A C array of objects.</param>
        /// <param name="count">The number of values from the objects C array to include in the new array. This number will be the count of the new array—it must not be negative or greater than the number of elements in objects.</param>
        /// <returns>A newly allocated array including the first count objects from objects. The returned object might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSArray(CConstPointer<AnyObject> objects, int count) { }

        /// <summary>
        /// Returns a Boolean value that indicates whether a given object is present in the array.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <returns>true if anObject is present in the array, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("containsObject")]
        public bool ContainsObject(AnyObject anObject) { return false; }

        /// <summary>
        /// Returns the number of objects currently in the array.
        /// </summary>
        /// <returns>The number of objects currently in the array.</returns>
        [iOSVersion(2)]
        [Export("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Copies all the objects contained in the array to aBuffer.
        /// Deprecation Statement: Use getObjects:range: instead.
        /// </summary>
        /// <param name="aBuffer">A C array of objects of size at least the count of the array.</param>
        [iOSVersion(2)]
        [Obsolete]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> aBuffer) { }

        /// <summary>
        /// Copies the objects contained in the array that fall within the specified range to aBuffer.
        /// </summary>
        /// <param name="aBuffer">A C array of objects of size at least the length of the range specified by aRange.</param>
        /// <param name="range">A range within the bounds of the array.   If the location plus the length of the range is greater than the count of the array, this method raises an NSRangeException.</param>
        [iOSVersion(2)]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> aBuffer, NSRange range) { }

        /// <summary>
        /// Returns the first object in the array.
        /// </summary>
        /// <returns>The first object in the array. If the array is empty, returns nil.</returns>
        [iOSVersion(4)]
        [Export("firstObject")]
        public AnyObject FirstObject { get; private set; }

        /// <summary>
        /// Returns the last object in the array.
        /// </summary>
        /// <returns>The last object in the array. If the array is empty, returns nil.</returns>
        [iOSVersion(2)]
        [Export("lastObject")]
        public AnyObject LastObject { get; private set; }

        /// <summary>
        /// Returns the object located at the specified index.
        /// </summary>
        /// <param name="index">An index within the bounds of the array.</param>
        /// <returns>The object located at index.</returns>
        [iOSVersion(2)]
        [Export("objectAtIndex")]
        public AnyObject ObjectAtIndex(int index) { return null; }

        /// <summary>
        /// Returns the object at the specified index.
        /// </summary>
        /// <param name="idx">An index within the bounds of the array.</param>
        /// <returns>The object located at index.</returns>
        [iOSVersion(6)]
        [Export("objectAtIndexedSubscript")]
        public AnyObject ObjectAtIndexedSubscript(int idx) { return null; }

        /// <summary>
        /// Returns an array containing the objects in the array at the indexes specified by a given index set.
        /// </summary>
        /// <returns>An array containing the objects in the array at the indexes specified by indexes.</returns>
        [iOSVersion(2)]
        [Export("objectsAtIndexes")]
        public AnyObject[] ObjectsAtIndexes(NSIndexSet indexes) { return null; }

        /// <summary>
        /// Returns an enumerator object that lets you access each object in the array.
        /// </summary>
        /// <returns>An enumerator object that lets you access each object in the array, in order, from the element at the lowest index upwards.</returns>
        [iOSVersion(2)]
        [Export("objectEnumerator")]
        public NSEnumerator ObjectEnumerator() { return null; }

        /// <summary>
        /// Returns an enumerator object that lets you access each object in the array, in reverse order.
        /// </summary>
        /// <returns>An enumerator object that lets you access each object in the array, in order, from the element at the highest index down to the element at index 0.</returns>
        [iOSVersion(2)]
        [Export("reverseObjectEnumerator")]
        public NSEnumerator ReverseObjectEnumerator() { return null; }

        /// <summary>
        /// Returns the lowest index whose corresponding array value is equal to a given object.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <returns>The lowest index whose corresponding array value is equal to anObject. If none of the objects in the array is equal to anObject, returns NSNotFound.</returns>
        [iOSVersion(2)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject anObject) { return 0; }

        /// <summary>
        /// Returns the lowest index within a specified range whose corresponding array value is equal to a given object .
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="inRange">The range of indexes in the array within which to search for anObject.</param>
        /// <returns>The lowest index within range whose corresponding array value is equal to anObject. If none of the objects within range is equal to anObject, returns NSNotFound.</returns>
        [iOSVersion(2)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject anObject, NSRange inRange) { return 0; }

        /// <summary>
        /// Returns the lowest index whose corresponding array value is identical to a given object.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <returns>The lowest index whose corresponding array value is identical to anObject. If none of the objects in the array is identical to anObject, returns NSNotFound.</returns>
        [iOSVersion(2)]
        [Export("indexOfObjectIdenticalTo")]
        public int IndexOfObjectIdenticalTo(AnyObject anObject) { return 0; }

        /// <summary>
        /// Returns the lowest index within a specified range whose corresponding array value is equal to a given object .
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <param name="inRange">The range of indexes in the array within which to search for anObject.</param>
        /// <returns>The lowest index within range whose corresponding array value is identical to anObject. If none of the objects within range is identical to anObject, returns NSNotFound.</returns>
        [iOSVersion(2)]
        [Export("indexOfObjectIdenticalTo")]
        public int IndexOfObjectIdenticalTo(AnyObject anObject, NSRange inRange) { return 0; }

        /// <summary>
        /// Returns the index of the first object in the array that passes a test in a given Block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test. Returning true will stop further processing of the array.</param>
        /// <returns>The lowest index whose corresponding value in the array passes the test specified by predicate. If no objects in the array pass the test, returns NSNotFound.</returns>
        [iOSVersion(4)]
        [Export("indexOfObjectPassingTest")]
        public int IndexOfObjectPassingTest(Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> predicate) { return 0; }

        /// <summary>
        /// Returns the index of an object in the array that passes a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The index whose corresponding value in the array passes the test specified by predicate and opts. If the opts bit mask specifies reverse order, then the last item that matches is returned. Otherwise, the index of the first matching object is returned. If no objects in the array pass the test, returns NSNotFound.</returns>
        [iOSVersion(4)]
        [Export("indexOfObjectWithOptions")]
        public int IndexOfObjectWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return 0; }

        /// <summary>
        /// Returns the index, from a given set of indexes, of the first object in the array that passes a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The lowest index whose corresponding value in the array passes the test specified by predicate. If no objects in the array pass the test, returns NSNotFound.</returns>
        [iOSVersion(4)]
        [Export("indexOfObjectAtIndexes")]
        public int IndexOfObjectAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return 0; }

        /// <summary>
        /// Returns the indexes of objects in the array that pass a test in a given Block.
        /// </summary>
        /// <param name="predicate">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The indexes whose corresponding values in the array pass the test specified by predicate. If no objects in the array pass the test, returns an empty index set.</returns>
        [iOSVersion(4)]
        [Export("indexesOfObjectsPassingTest")]
        public NSIndexSet IndexesOfObjectsPassingTest(Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> predicate) { return null; }

        /// <summary>
        /// Returns the indexes of objects in the array that pass a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The indexes whose corresponding values in the array pass the test specified by predicate. If no objects in the array pass the test, returns an empty index set.</returns>
        [iOSVersion(4)]
        [Export("indexesOfObjectsWithOptions")]
        public NSIndexSet IndexesOfObjectsWithOptions(NSEnumerationOptions opts, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return null; }

        /// <summary>
        /// Returns the indexes, from a given set of indexes, of objects in the array that pass a test in a given Block for a given set of enumeration options.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="passingTest">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.        The Block returns a Boolean value that indicates whether obj passed the test.</param>
        /// <returns>The indexes whose corresponding values in the array pass the test specified by predicate. If no objects in the array pass the test, returns an empty index set.</returns>
        [iOSVersion(4)]
        [Export("indexesOfObjectsAtIndexes")]
        public NSIndexSet IndexesOfObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Func<AnyObject, int, CMutablePointer<ObjCBool>, bool> passingTest) { return null; }

        /// <summary>
        /// Returns the index, within a specified range, of an object compared with elements in the array using a given NSComparator block.
        /// </summary>
        /// <param name="obj">An object for which to search in the array.   If this value is nil, throws an NSInvalidArgumentException.</param>
        /// <param name="inSortedRange">The range within the array to search for obj.   If r exceeds the bounds of the array (if the location plus length of the range is greater than the count of the array), throws an NSRangeException.</param>
        /// <param name="options">Options for the search. For possible values, see NSBinarySearchingOptions.   If you specify both NSBinarySearchingFirstEqual and NSBinarySearchingLastEqual, throws an NSInvalidArgumentException.</param>
        /// <param name="usingComparator">A comparator block used to compare the object obj with elements in the array.   If this value is NULL, throws an NSInvalidArgumentException.</param>
        /// <returns>If the NSBinarySearchingInsertionIndex option is not specified:</returns>
        [iOSVersion(4)]
        [Export("indexOfObject")]
        public int IndexOfObject(AnyObject obj, NSRange inSortedRange, NSBinarySearchingOptions options, NSComparator usingComparator) { return 0; }

        /// <summary>
        /// Sends to each object in the array the message identified by a given selector, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the message to send to the objects in the array. The method must not take any arguments, and must not have the side effect of modifying the receiving array.</param>
        [iOSVersion(2)]
        [Export("makeObjectsPerformSelector")]
        public void MakeObjectsPerformSelector(Selector aSelector) { }

        /// <summary>
        /// Sends the aSelector message to each object in the array, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the message to send to the objects in the array. The method must take a single argument of type id, and must not have the side effect of modifying the receiving array.</param>
        /// <param name="withObject">The object to send as the argument to each invocation of the aSelector method.</param>
        [iOSVersion(2)]
        [Export("makeObjectsPerformSelector")]
        public void MakeObjectsPerformSelector(Selector aSelector, AnyObject withObject) { }

        /// <summary>
        /// Executes a given block using each object in the array, starting with the first object and continuing through the array to the last object.
        /// </summary>
        /// <param name="block">The block to apply to elements in the array. The block takes three arguments:
        /// obj: The element in the array.
        /// idx: The index of the element in the array.
        /// stop: A reference to a Boolean value.
        /// The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsUsingBlock")]
        public void EnumerateObjectsUsingBlock(Action<AnyObject, int, CMutablePointer<ObjCBool>> block) { }

        /// <summary>
        /// Executes a given block using each object in the array.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the array. The block takes three arguments:  
        /// obj: The element in the array. 
        /// idx: The index of the element in the array.
        /// stop: A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsWithOptions")]
        public void EnumerateObjectsWithOptions(NSEnumerationOptions opts, Action<AnyObject, int, CMutablePointer<ObjCBool>> usingBlock) { }

        /// <summary>
        /// Executes a given block using the objects in the array at the specified indexes.
        /// </summary>
        /// <param name="indexSet">The indexes of the objects over which to enumerate.</param>
        /// <param name="options">A bit mask that specifies the options for the enumeration (whether it should be performed concurrently and whether it should be performed in reverse order).</param>
        /// <param name="usingBlock">The block to apply to elements in the array.   The block takes three arguments:           obj              The element in the array.                idx              The index of the element in the array.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(4)]
        [Export("enumerateObjectsAtIndexes")]
        public void EnumerateObjectsAtIndexes(NSIndexSet indexSet, NSEnumerationOptions options, Action<AnyObject, int, CMutablePointer<ObjCBool>> usingBlock) { }

        /// <summary>
        /// Returns the first object contained in the receiving array that’s equal to an object in another given array.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <returns>Returns the first object contained in the receiving array that’s equal to an object in otherArray. If no such object is found, returns nil.</returns>
        [iOSVersion(2)]
        [Export("firstObjectCommonWithArray")]
        public AnyObject FirstObjectCommonWithArray(AnyObject[] otherArray) { return null; }

        /// <summary>
        /// Compares the receiving array to another array.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <returns>true if the contents of otherArray are equal to the contents of the receiving array, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isEqualToArray")]
        public bool IsEqualToArray(AnyObject[] otherArray) { return false; }

        /// <summary>
        /// Returns a new array that is a copy of the receiving array with a given object added to the end.
        /// </summary>
        /// <param name="anObject">An object.</param>
        /// <returns>A new array that is a copy of the receiving array with anObject added to the end.</returns>
        [iOSVersion(2)]
        [Export("arrayByAddingObject")]
        public AnyObject[] ArrayByAddingObject(AnyObject anObject) { return null; }

        /// <summary>
        /// Returns a new array that is a copy of the receiving array with the objects contained in another array added to the end.
        /// </summary>
        /// <param name="otherArray">An array.</param>
        /// <returns>A new array that is a copy of the receiving array with the objects contained in otherArray added to the end.</returns>
        [iOSVersion(2)]
        [Export("arrayByAddingObjectsFromArray")]
        public AnyObject[] ArrayByAddingObjectsFromArray(AnyObject[] otherArray) { return null; }

        /// <summary>
        /// Evaluates a given predicate against each object in the receiving array and returns a new array containing the objects for which the predicate returns true.
        /// </summary>
        /// <param name="predicate">The predicate against which to evaluate the receiving array’s elements.</param>
        /// <returns>A new array containing the objects in the receiving array for which predicate returns true.</returns>
        [iOSVersion(3)]
        [Export("filteredArrayUsingPredicate")]
        public AnyObject[] FilteredArrayUsingPredicate(NSPredicate predicate) { return null; }

        /// <summary>
        /// Returns a new array containing the receiving array’s elements that fall within the limits specified by a given range.
        /// </summary>
        /// <param name="range">A range within the receiving array’s range of elements.</param>
        /// <returns>A new array containing the receiving array’s elements that fall within the limits specified by range.</returns>
        [iOSVersion(2)]
        [Export("subarrayWithRange")]
        public AnyObject[] SubarrayWithRange(NSRange range) { return null; }

        /// <summary>
        /// Analyzes the array and returns a “hint” that speeds the sorting of the array when the hint is supplied to sortedArrayUsingFunction:context:hint:.
        /// </summary>
        [iOSVersion(2)]
        [Export("sortedArrayHint")]
        public NSData SortedArrayHint { get; private set; }

        /// <summary>
        /// Returns a copy of the receiving array sorted as specified by a given array of sort descriptors.
        /// </summary>
        /// <param name="sortDescriptors">An array of NSSortDescriptor objects.</param>
        /// <returns>A copy of the receiving array sorted as specified by sortDescriptors.</returns>
        [iOSVersion(2)]
        [Export("sortedArrayUsingDescriptors")]
        public AnyObject[] SortedArrayUsingDescriptors(AnyObject[] sortDescriptors) { return null; }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given selector.
        /// </summary>
        /// <param name="comparator">A selector that identifies the method to use to compare two elements at a time. The method should return NSOrderedAscending if the receiving array is smaller than the argument, NSOrderedDescending if the receiving array is larger than the argument, and NSOrderedSame if they are equal.</param>
        /// <returns>An array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by the selector comparator.</returns>
        [iOSVersion(2)]
        [Export("sortedArrayUsingSelector")]
        public AnyObject[] SortedArrayUsingSelector(Selector comparator) { return null; }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        /// <returns>An array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified cmptr.</returns>
        [iOSVersion(4)]
        [Export("sortedArrayUsingComparator")]
        public AnyObject[] SortedArrayUsingComparator(NSComparator cmptr) { return null; }

        /// <summary>
        /// Returns an array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified by a given NSComparator Block.
        /// </summary>
        /// <param name="opts">A bit mask that specifies the options for the sort (whether it should be performed concurrently and whether it should be performed stably).</param>
        /// <param name="usingComparator">A comparator block.</param>
        /// <returns>An array that lists the receiving array’s elements in ascending order, as determined by the comparison method specified cmptr.</returns>
        [iOSVersion(4)]
        [Export("sortedArrayWithOptions")]
        public AnyObject[] SortedArrayWithOptions(NSSortOptions opts, NSComparator usingComparator) { return null; }

        /// <summary>
        /// Constructs and returns an NSString object that is the result of interposing a given separator between the elements of the array.
        /// </summary>
        /// <param name="separator">The string to interpose between the elements of the array.</param>
        /// <returns>An NSString object that is the result of interposing separator between the elements of the array. If the array has no elements, returns an NSString object representing an empty string.</returns>
        [iOSVersion(2)]
        [Export("componentsJoinedByString")]
        public string ComponentsJoinedByString(string separator) { return ""; }

        /// <summary>
        /// Returns a string that represents the contents of the array, formatted as a property list.
        /// </summary>
        /// <returns>A string that represents the contents of the array, formatted as a property list.</returns>
        [iOSVersion(2)]
        [Export("description")]
        public new string Description { get; private set; }

        /// <summary>
        /// Returns a string that represents the contents of the array, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <returns>A string that represents the contents of the array, formatted as a property list.</returns>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale) { return ""; }

        /// <summary>
        /// Returns a string that represents the contents of the array, formatted as a property list.
        /// </summary>
        /// <param name="locale">An NSLocale object or an NSDictionary object that specifies options used for formatting each of the array’s elements (where recognized). Specify nil if you don’t want the elements formatted.</param>
        /// <param name="indent">A level of indent, to make the output more readable: set level to 0 to use four spaces to indent, or 1 to indent the output with a tab character.</param>
        /// <returns>A string that represents the contents of the array, formatted as a property list.</returns>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale, int indent) { return ""; }

        /// <summary>
        /// Writes the contents of the array to a file at a given path.
        /// </summary>
        /// <param name="path">The path at which to write the contents of the array.   If path contains a tilde (~) character, you must expand it with stringByExpandingTildeInPath before invoking this method.</param>
        /// <param name="atomically">If true, the array is written to an auxiliary file, and then the auxiliary file is renamed to path. If false, the array is written directly to path. The true option guarantees that path, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <returns>true if the file is written successfully, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically) { return false; }

        /// <summary>
        /// Writes the contents of the array to the location specified by a given URL.
        /// </summary>
        /// <param name="aURL">The location at which to write the array.</param>
        /// <param name="atomically">If true, the array is written to an auxiliary location, and then the auxiliary location is renamed to aURL. If false, the array is written directly to aURL. The true option guarantees that aURL, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <returns>true if the location is written successfully, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL aURL, bool atomically) { return false; }

        /// <summary>
        /// Returns an array containing all the pathname elements in the receiving array that have filename extensions from a given array.
        /// </summary>
        /// <param name="filterTypes">An array of NSString objects containing filename extensions. The extensions should not include the dot (“.”) character.</param>
        /// <returns>An array containing all the pathname elements in the receiving array that have filename extensions from the filterTypes array.</returns>
        [iOSVersion(2)]
        [Export("pathsMatchingExtensions")]
        public AnyObject[] PathsMatchingExtensions(AnyObject[] filterTypes) { return null; }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to register for KVO notifications. The observer must implement the key-value observing method observeValueForKeyPath:ofObject:change:context:.</param>
        /// <param name="forKeyPath">The key path, relative to the array, of the property to observe. This value must not be nil.</param>
        /// <param name="options">A combination of NSKeyValueObservingOptions values that specifies what is included in observation notifications.</param>
        /// <param name="context">Arbitrary data that is passed to observer in observeValueForKeyPath:ofObject:change:context:.</param>
        [iOSVersion(2)]
        [Export("addObserver")]
        public void AddObserver(NSObject observer, string forKeyPath, NSKeyValueObservingOptions options, CMutableVoidPointer context) { }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the array, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        [iOSVersion(2)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath) { }

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="forKeyPath">A key-path, relative to the set, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="context">The context passed to the notifications.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, string forKeyPath, CMutableVoidPointer context) { }

        //TODO: double check what this is. esp. with the extra param

        /// <summary>
        /// Raises an exception.
        /// </summary>
        /// <param name="observer">The object to remove as an observer.</param>
        /// <param name="fromObjectsAtIndexes">A key-path, relative to the array, for which observer is registered to receive KVO change notifications. This value must not be nil.</param>
        /// <param name="forKeyPath">The context passed to the notifications.</param>
        [iOSVersion(5)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject observer, NSIndexSet fromObjectsAtIndexes, string forKeyPath, CMutableVoidPointer context) { }

        /// <summary>
        /// Registers an observer to receive key value observer notifications for the specified key-path relative to the objects at the indexes.
        /// </summary>
        /// <param name="anObserver">The observer.</param>
        /// <param name="toObjectsAtIndexes">The index set.</param>
        /// <param name="forKeyPath">The key path, relative to the array, to be observed.</param>
        /// <param name="options">The options to be included in the notification.</param>
        /// <param name="context">The context passed to the notifications.</param>
        [iOSVersion(2)]
        [Export("addObserver")]
        public void AddObserver(NSObject anObserver, NSIndexSet toObjectsAtIndexes, string forKeyPath, NSKeyValueObservingOptions options, CMutableVoidPointer context) { }

        /// <summary>
        /// Removes anObserver from all key value observer notifications associated with the specified keyPath relative to the array’s objects at indexes.
        /// </summary>
        /// <param name="anObserver">The observer.</param>
        /// <param name="fromObjectsAtIndexes">The index set.</param>
        /// <param name="forKeyPath">The key path, relative to the array, to be observed.</param>
        [iOSVersion(2)]
        [Export("removeObserver")]
        public void RemoveObserver(NSObject anObserver, NSIndexSet fromObjectsAtIndexes, string forKeyPath) { }

        /// <summary>
        /// Invokes setValue:forKey: on each of the array's items using the specified value and key.
        /// </summary>
        /// <param name="value">The object value.</param>
        /// <param name="forKey">The key to store the value.</param>
        [iOSVersion(2)]
        [Export("setValue")]
        public void SetValue(AnyObject value, string forKey) { }

        /// <summary>
        /// Returns an array containing the results of invoking valueForKey: using key on each of the array's objects.
        /// </summary>
        /// <param name="key">The key to retrieve.</param>
        /// <returns>The value of the retrieved key.</returns>
        [iOSVersion(2)]
        [Export("valueForKey")]
        public AnyObject ValueForKey(string key) { return null; }
    }

    /// <summary>
    /// Options for searches and insertions using indexOfObject:inSortedRange:options:usingComparator:.
    /// </summary>
    public enum NSBinarySearchingOptions
    {
        FirstEqual,
        LastEqual,
        InsertionIndex
    }
}
