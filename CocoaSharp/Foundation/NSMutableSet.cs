using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSMutableSet class declares the programmatic interface to a mutable, unordered collection of distinct objects.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableSet_Class/index.html#//apple_ref/occ/cl/NSMutableSet"/>	[iOSVersion(2)]	public class NSMutableSet : NSSet//, AnyObject, NSCoding, NSCopying, NSFastEnumeration, NSMutableCopying, NSObjectProtocol, NSSecureCoding, Reflectable, Sequence	{		/// <summary>		/// Returns an initialized mutable set with a given initial capacity.		/// </summary>		/// <param name="capacity">The initial capacity of the set.</param>		[iOSVersion(2)]		public NSMutableSet(int capacity) { }				/// <summary>		/// Initializes a newly allocated set.		/// </summary>		[iOSVersion(7)]		public NSMutableSet() { }				/// <summary>		/// Adds a given object to the set, if it is not already a member.		/// </summary>		/// <param name="@object">The object to add to the set.</param>		[iOSVersion(2)]		[Export("addObject")]		public void AddObject(AnyObject @object) {  }				/// <summary>		/// Evaluates a given predicate against the set’s content and removes from the set those objects for which the predicate returns false.		/// </summary>		/// <param name="predicate">A predicate.</param>		[iOSVersion(3)]		[Export("filterUsingPredicate")]		public void FilterUsingPredicate(NSPredicate predicate) {  }				/// <summary>		/// Removes a given object from the set.		/// </summary>		/// <param name="@object">The object to remove from the set.</param>		[iOSVersion(2)]		[Export("removeObject")]		public void RemoveObject(AnyObject @object) {  }				/// <summary>		/// Empties the set of all of its members.		/// </summary>		[iOSVersion(2)]		[Export("removeAllObjects")]		public void RemoveAllObjects() {  }				/// <summary>		/// Adds to the set each object contained in a given array that is not already a member.		/// </summary>		/// <param name="array">An array of objects to add to the set.</param>		[iOSVersion(2)]		[Export("addObjectsFromArray")]		public void AddObjectsFromArray(AnyObject[] array) {  }				/// <summary>		/// Adds each object in another given set to the receiving set, if not present.		/// </summary>		/// <param name="otherSet">The set of objects to add to the receiving set.</param>		[iOSVersion(2)]		[Export("unionSet")]		public void UnionSet(NSSet otherSet) {  }				/// <summary>		/// Removes each object in another given set from the receiving set, if present.		/// </summary>		/// <param name="otherSet">The set of objects to remove from the receiving set.</param>		[iOSVersion(2)]		[Export("minusSet")]		public void MinusSet(NSSet otherSet) {  }				/// <summary>		/// Removes from the receiving set each object that isn’t a member of another given set.		/// </summary>		/// <param name="otherSet">The set with which to perform the intersection.</param>		[iOSVersion(2)]		[Export("intersectSet")]		public void IntersectSet(NSSet otherSet) {  }				/// <summary>		/// Empties the receiving set, then adds each object contained in another given set.		/// </summary>		/// <param name="otherSet">The set whose members replace the receiving set's content.</param>		[iOSVersion(2)]		[Export("setSet")]		public void SetSet(NSSet otherSet) {  }	}}