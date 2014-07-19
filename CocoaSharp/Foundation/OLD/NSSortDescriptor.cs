using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSSortDescriptor_Class/index.html#//apple_ref/occ/cl/NSSortDescriptor
    /// <summary>
    /// An instance of NSSortDescriptor describes a basis for ordering objects by specifying the property to use to compare the objects, the method to use to compare the properties, and whether the comparison should be ascending or descending. Instances of NSSortDescriptor are immutable.
    /// </summary>
    [iOSVersion(2)]
    public class NSSortDescriptor : NSObject
    {
        /// <summary>
        /// Returns an NSSortDescriptor object initialized with a given property key path and sort order, and with the default comparison selector.
        /// </summary>
        /// <param name="key">The property key to use when performing a comparison. In the comparison, the property is accessed using key-value coding (see Key-Value Coding Programming Guide).</param>
        /// <param name="ascending">true if the receiver specifies sorting in ascending order, otherwise false.</param>
        /// <returns>An NSSortDescriptor object initialized with the property key path specified by keyPath, sort order specified by ascending, and the default comparison selector (compare:).</returns>
        [iOSVersion(2)]
        public NSSortDescriptor(string key, bool ascending) { }
        
        /// <summary>
        /// Returns an NSSortDescriptor object initialized with a given property key path, sort order, and comparison selector.
        /// </summary>
        /// <param name="key">The property key to use when performing a comparison. In the comparison, the property is accessed using key-value coding (see Key-Value Coding Programming Guide).</param>
        /// <param name="ascending">true if the receiver specifies sorting in ascending order, otherwise false.</param>
        /// <param name="selector">The method to use when comparing the properties of objects, for example caseInsensitiveCompare: or localizedCompare:. The selector must specify a method implemented by the value of the property identified by keyPath. The selector used for the comparison is passed a single parameter, the object to compare against self, and must return the appropriate NSComparisonResult constant. The selector must have the same method signature as:                Swift         func localizedCompare(aString: String) -&gt; NSComparisonResult { }                   Objective-C         - (NSComparisonResult)localizedCompare:(NSString *)aString</param>
        /// <returns>An NSSortDescriptor object initialized with the property key path specified by keyPath, sort order specified by ascending, and the selector specified by selector.</returns>
        [iOSVersion(2)]
        public NSSortDescriptor(string key, bool ascending, Selector selector) { }
        
        /// <summary>
        /// Returns an NSSortDescriptor object initialized to do with the given ordering and comparator block.
        /// </summary>
        /// <param name="key">The property key to use when performing a comparison. In the comparison, the property is accessed using key-value coding (see Key-Value Coding Programming Guide).</param>
        /// <param name="ascending">true if the receiver specifies sorting in ascending order, otherwise false.</param>
        /// <param name="comparator">A comparator block.</param>
        /// <returns>An NSSortDescriptor initialized with the specified key, ordering and comparator.</returns>
        [iOSVersion(4)]
        public NSSortDescriptor(string key, bool ascending, NSComparator comparator) { }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver specifies sorting in ascending order.
        /// </summary>
        /// <returns>true if the receiver specifies sorting in ascending order, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("ascending")]
        public bool Ascending { get; private set; }
        
        /// <summary>
        /// Returns the receiver’s property key path.
        /// </summary>
        /// <returns>The receiver’s property key path.</returns>
        [iOSVersion(2)]
        [Export("key")]
        public string Key { get; private set; }
        
        /// <summary>
        /// Returns the selector the receiver specifies to use when comparing objects.
        /// </summary>
        /// <returns>The selector the receiver specifies to use when comparing objects.</returns>
        [iOSVersion(2)]
        [Export("selector")]
        public Selector Selector { get; private set; }
        
        /// <summary>
        /// Returns an NSComparisonResult value that indicates the ordering of two given objects.
        /// </summary>
        /// <param name="object1">The object to compare with object2. This object must have a property accessible using the key-path specified by key.   This value must not be nil. If the value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <param name="toObject">The object to compare with object1. This object must have a property accessible using the key-path specified by key.   This value must not be nil. If the value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>NSOrderedAscending if object1 is less than object2, NSOrderedDescending if object1 is greater than object2, or NSOrderedSame if object1 is equal to object2.</returns>
        [iOSVersion(2)]
        [Export("compareObject")]
        public NSComparisonResult CompareObject(AnyObject object1, AnyObject toObject) { return NSComparisonResult.OrderedSame; }
        
        /// <summary>
        /// Returns a copy of the receiver with the sort order reversed.
        /// </summary>
        /// <returns>A copy of the receiver with the sort order reversed</returns>
        [iOSVersion(2)]
        [Export("reversedSortDescriptor")]
        public AnyObject ReversedSortDescriptor { get; private set; }
        
        /// <summary>
        /// Force a sort descriptor that was securely decoded to allow evaluation.
        /// </summary>
        [iOSVersion(7)]
        [Export("allowEvaluation")]
        public void AllowEvaluation() { }
        
        /// <summary>
        /// Creates and returns an NSComparator for the sort descriptor.
        /// </summary>
        /// <returns>An NSComparator object representing the sort descriptor.</returns>
        [iOSVersion(4)]
        [Export("comparator")]
        public NSComparator Comparator { get; private set; }
    }
}