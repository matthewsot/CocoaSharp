using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCompoundPredicate_Class/index.html#//apple_ref/occ/cl/NSCompoundPredicate	/// <summary>	/// NSCompoundPredicate is a subclass of NSPredicate used to represent logical “gate” operations (AND/OR/NOT) and comparison operations.	/// </summary>	[iOSVersion(3)]	public class NSCompoundPredicate : NSPredicate	{		/// <summary>		/// Returns a new predicate formed by AND-ing the predicates in a given array.		/// </summary>		/// <param name="subpredicates">An array of NSPredicate objects.</param>		/// <returns>A new predicate formed by AND-ing the predicates specified by subpredicates.</returns>		[iOSVersion(3)]		[Export("andPredicateWithSubpredicates")]		public static NSCompoundPredicate AndPredicateWithSubpredicates(AnyObject[] subpredicates) { return null; }				/// <summary>		/// Returns a new predicate formed by NOT-ing a given predicate.		/// </summary>		/// <param name="predicate">A predicate.</param>		/// <returns>A new predicate formed by NOT-ing the predicate specified by predicate.</returns>		[iOSVersion(3)]		[Export("notPredicateWithSubpredicate")]		public static NSCompoundPredicate NotPredicateWithSubpredicate(NSPredicate predicate) { return null; }				/// <summary>		/// Returns a new predicate formed by OR-ing the predicates in a given array.		/// </summary>		/// <param name="subpredicates">An array of NSPredicate objects.</param>		/// <returns>A new predicate formed by OR-ing the predicates specified by subpredicates.</returns>		[iOSVersion(3)]		[Export("orPredicateWithSubpredicates")]		public static NSCompoundPredicate OrPredicateWithSubpredicates(AnyObject[] subpredicates) { return null; }				/// <summary>		/// Returns the receiver initialized to a given type using predicates from a given array.		/// </summary>		/// <param name="type">The type of the new predicate.</param>		/// <param name="subpredicates">An array of NSPredicate objects.</param>		/// <returns>The receiver initialized with its type set to type and subpredicates array to subpredicates.</returns>		[iOSVersion(3)]		public NSCompoundPredicate(NSCompoundPredicateType type, AnyObject[] subpredicates) { }				/// <summary>		/// Returns the predicate type for the receiver.		/// </summary>		/// <returns>The predicate type for the receiver.</returns>		[iOSVersion(3)]		[Export("compoundPredicateType")]		public NSCompoundPredicateType CompoundPredicateType { get; private set; }				/// <summary>		/// Returns the array of the receiver’s subpredicates.		/// </summary>		/// <returns>The array of the receiver’s subpredicates.</returns>		[iOSVersion(3)]		[Export("subpredicates")]		public AnyObject[] Subpredicates { get; private set; }		        //TODO: check NSCompoundPredicateType		/// <summary>		/// These constants describe the possible types of NSCompoundPredicate.		/// </summary>		[iOSVersion(3)]
        public enum NSCompoundPredicateType
        {
            /// <summary>
            /// A logical NOT predicate.
            /// </summary>
            [iOSVersion(3)]
            NotPredicateType,

            /// <summary>
            /// A logical AND predicate.
            /// </summary>
            [iOSVersion(3)]
            AndPredicateType,

            /// <summary>
            /// A logical OR predicate.
            /// </summary>
            [iOSVersion(3)]            OrPredicateType        }	}}