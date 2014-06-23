using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    /// <summary>    /// Components in a bit-field to specify the behavior of elements in an NSHashTable object.    /// </summary>    //[iOSVersion(6)]    using NSHashTableOptions = Int32;        //From NSPointerFunctions.cs    /// <summary>    /// Defines the memory and personality options for an NSPointerFunctions object.    /// </summary>    //[iOSVersion(6)]    using NSPointerFunctionsOptions = Int32;    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSHashTable_class/index.html#//apple_ref/occ/cl/NSHashTable    /// <summary>    /// NSHashTable is modeled after NSSet but provides different options, in particular to support weak relationships.    /// </summary>    [iOSVersion(6)]    public class NSHashTable : NSObject    {        /// <summary>        /// Returns a hash table initialized with the given attributes.        /// </summary>        /// <param name="options">A bit field that specifies the options for the elements in the hash table. For possible values, see “Hash Table Options”.</param>        /// <param name="capacity">The initial number of elements the hash table can hold.</param>        /// <returns>A hash table initialized with options specified by options and initial capacity of capacity.</returns>        [iOSVersion(6)]        public NSHashTable(NSPointerFunctionsOptions options, int capacity) { }                /// <summary>        /// Returns a hash table initialized with the given functions and capacity.        /// </summary>        /// <param name="pointerFunctions">The pointer functions for the new hash table.</param>        /// <param name="capacity">The initial capacity of the hash table.</param>        /// <returns>A hash table initialized with the given functions and capacity.</returns>        [iOSVersion(6)]        public NSHashTable(NSPointerFunctions pointerFunctions, int capacity) { }                /// <summary>        /// Returns a new hash table for storing weak references to its contents.        /// </summary>        /// <returns>A new has table that uses the options NSHashTableZeroingWeakMemory and NSPointerFunctionsObjectPersonality and has an initial capacity of 0.</returns>        [iOSVersion(6)]        [Export("weakObjectsHashTable")]        public static NSHashTable WeakObjectsHashTable() { return null; }                /// <summary>        /// Returns a hash table with given pointer functions options.        /// </summary>        /// <param name="options">A bit field that specifies the options for the elements in the hash table. For possible values, see “Hash Table Options”.</param>        /// <returns>A hash table with given pointer functions options.</returns>        [iOSVersion(6)]
        public NSHashTable(NSPointerFunctionsOptions options) { }                /// <summary>        /// Returns an array that contains the hash table’s members.        /// </summary>        /// <returns>An array that contains the hash table’s members.</returns>        [iOSVersion(6)]        [Export("allObjects")]        public AnyObject[] AllObjects { get; private set; }                /// <summary>        /// Returns one of the objects in the hash table.        /// </summary>        /// <returns>One of the objects in the hash table, or nil if the hash table contains no objects.</returns>        [iOSVersion(6)]        [Export("anyObject")]        public AnyObject AnyObject { get; private set; }                /// <summary>        /// Returns a Boolean value that indicates whether the hash table contains a given object.        /// </summary>        /// <param name="anObject">The object to test for membership in the hash table.</param>        /// <returns>true if the hash table contains anObject, otherwise false.</returns>        [iOSVersion(6)]        [Export("containsObject")]        public bool ContainsObject(AnyObject anObject) { return false; }                /// <summary>        /// Returns the number of elements in the hash table.        /// </summary>        /// <returns>The number of elements in the hash table.</returns>        [iOSVersion(6)]        [Export("count")]        public int Count { get; private set; }                /// <summary>        /// Determines whether the hash table contains a given object, and returns that object if it is present        /// </summary>        /// <param name="object">The object to test for membership in the hash table.</param>        /// <returns>If object is a member of the hash table, returns object, otherwise returns nil.</returns>        [iOSVersion(6)]        [Export("member")]        public AnyObject Member(AnyObject @object) { return null; }                /// <summary>        /// Returns an enumerator object that lets you access each object in the hash table.        /// </summary>        /// <returns>An enumerator object that lets you access each object in the hash table.</returns>        [iOSVersion(6)]        [Export("objectEnumerator")]        public NSEnumerator ObjectEnumerator() { return null; }                /// <summary>        /// Returns a set that contains the hash table’s members.        /// </summary>        /// <returns>A set that contains the hash table’s members.</returns>        [iOSVersion(6)]        [Export("setRepresentation")]        public NSSet SetRepresentation { get; private set; }                /// <summary>        /// Adds a given object to the hash table.        /// </summary>        /// <param name="object">The object to add to the hash table.</param>        [iOSVersion(6)]        [Export("addObject")]        public void AddObject(AnyObject @object) { }                /// <summary>        /// Removes all objects from the hash table.        /// </summary>        [iOSVersion(6)]        [Export("removeAllObjects")]        public void RemoveAllObjects() { }                /// <summary>        /// Removes a given object from the hash table.        /// </summary>        /// <param name="object">The object to remove from the hash table.</param>        [iOSVersion(6)]        [Export("removeObject")]        public void RemoveObject(AnyObject @object) { }                /// <summary>        /// Returns a Boolean value that indicates whether a given hash table intersects with the receiving hash table.        /// </summary>        /// <param name="other">The hash table with which to compare the receiving hash table.</param>        /// <returns>true if other intersects with the receiving hash table, otherwise false.</returns>        [iOSVersion(6)]        [Export("intersectsHashTable")]        public bool intersectsHashTable(NSHashTable other) { return false; }                /// <summary>        /// Removes from the receiving hash table each element that isn’t a member of another given hash table.        /// </summary>        /// <param name="other">The hash table with which to perform the intersection.</param>        [iOSVersion(6)]        [Export("intersectHashTable")]        public void intersectHashTable(NSHashTable other) { }                /// <summary>        /// Returns a Boolean value that indicates whether a given hash table is equal to the receiving hash table.        /// </summary>        /// <param name="other">The hash table with which to compare the receiving hash table.</param>        /// <returns>true if the contents of other are equal to the contents of the receiving hash table, otherwise false.</returns>        [iOSVersion(6)]        [Export("isEqualToHashTable")]        public bool IsEqualToHashTable(NSHashTable other) { return false; }                /// <summary>        /// Returns a Boolean value that indicates whether every element in the receiving hash table is also present in another given hash table.        /// </summary>        /// <param name="other">The hash table with which to compare the receiving hash table.</param>        /// <returns>true if every element in the receiving hash table is also present in other, otherwise false.</returns>        [iOSVersion(6)]        [Export("isSubsetOfHashTable")]        public bool IsSubsetOfHashTable(NSHashTable other) { return false; }                /// <summary>        /// Removes each element in another given hash table from the receiving hash table, if present.        /// </summary>        /// <param name="other">The hash table of elements to remove from the receiving hash table.</param>        [iOSVersion(6)]        [Export("minusHashTable")]        public void MinusHashTable(NSHashTable other) { }                /// <summary>        /// Adds each element in another given hash table to the receiving hash table, if not present.        /// </summary>        /// <param name="other">The hash table of elements to add to the receiving hash table.</param>        [iOSVersion(6)]        [Export("unionHashTable")]        public void UnionHashTable(NSHashTable other) { }                /// <summary>        /// Returns the pointer functions for the hash table.        /// </summary>        /// <returns>The pointer functions for the hash table.</returns>        [iOSVersion(6)]        [Export("pointerFunctions")]        public NSPointerFunctions PointerFunctions { get; private set; }    }}