using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectiveC;

namespace Foundation
{
    public class NSMutableDictionary : NSDictionary
    {
        /// <summary>
        /// Initializes a newly allocated mutable dictionary, allocating enough memory to hold numItems entries.
        /// </summary>
        /// <param name="numItems">The initial capacity of the initialized dictionary.</param>
        /// <returns>An initialized mutable dictionary, which might be different than the original receiver.</returns>
        [iOSVersion(2)]
        public NSMutableDictionary(int capacity) { }

        /// <summary>
        /// Initializes a newly allocated mutable dictionary.
        /// </summary>
        /// <returns>A mutable dictionary.</returns>
        [iOSVersion(7)]
        public NSMutableDictionary() { }

        /// <summary>
        /// Creates a mutable dictionary which is optimized for dealing with a known set of keys.
        /// </summary>
        /// <param name="keyset">The keyset, created by the NSDictionary class method sharedKeySetForKeys:. If keyset is nil, an exception is thrown. If keyset is not an object returned by sharedKeySetForKeys:, an exception is thrown.</param>
        /// <returns>A new mutable dictionary optimized for a known set of keys.</returns>
        [iOSVersion(6)]
        public NSMutableDictionary(AnyObject sharedKeySet) { }

        /// <summary>
        /// Adds a given key-value pair to the dictionary.
        /// </summary>
        /// <param name="anObject">The value for aKey. A strong reference to the object is maintained by the dictionary. Raises an NSInvalidArgumentException if anObject is nil. If you need to represent a nil value in the dictionary, use NSNull.</param>
        /// <param name="aKey">The key for value. The key is copied (using copyWithZone:; keys must conform to the NSCopying protocol). Raises an NSInvalidArgumentException if aKey is nil. If aKey already exists in the dictionary anObject takes its place.</param>
        [iOSVersion(2)]
        [Export("setObject")]
        public void SetObject(AnyObject anObject, NSCopying forKey) { }

        /// <summary>
        /// This method is identical to setObject:forKey:. 
        /// Adds a given key-value pair to the dictionary.
        /// </summary>
        /// <param name="object">The value for aKey. A strong reference to the object is maintained by the dictionary. Raises an NSInvalidArgumentException if anObject is nil. If you need to represent a nil value in the dictionary, use NSNull.</param>
        /// <param name="aKey">The key for value. The key is copied (using copyWithZone:; keys must conform to the NSCopying protocol). Raises an NSInvalidArgumentException if aKey is nil. If aKey already exists in the dictionary anObject takes its place.</param>
        [iOSVersion(6)]
        [Export("setObject")]
        public void SetObjectForKeyedSubscript(AnyObject @object, NSCopying forKeyedSubscript) { }

        /// <summary>
        /// Adds a given key-value pair to the dictionary.
        /// </summary>
        /// <param name="value">The value for key.</param>
        /// <param name="key">The key for value. Note that when using key-value coding, the key must be a string (see Key-Value Coding Fundamentals).</param>
        [iOSVersion(2)]
        [Export("setValue")]
        public void SetValue(AnyObject value, string forKey) { }

        /// <summary>
        /// Adds to the receiving dictionary the entries from another dictionary.
        /// </summary>
        /// <param name="otherDictionary">The dictionary from which to add entries</param>
        [iOSVersion(2)]
        [Export("addEntriesFromDictionary")]
        public void AddEntriesFromDictionary(NSDictionary otherDictionary) { }

        /// <summary>
        /// Sets the contents of the receiving dictionary to entries in a given dictionary.
        /// </summary>
        /// <param name="otherDictionary">A dictionary containing the new entries.</param>
        [iOSVersion(2)]
        [Export("setDictionary")]
        public void SetDictionary(NSDictionary otherDictionary) { }

        /// <summary>
        /// Removes a given key and its associated value from the dictionary.
        /// </summary>
        /// <param name="aKey">The key to remove.</param>
        [iOSVersion(2)]
        [Export("removeObjectForKey")]
        public void RemoveObjectForKey(AnyObject aKey) { }

        /// <summary>
        /// Empties the dictionary of its entries.
        /// </summary>
        [iOSVersion(2)]
        [Export("removeAllObjects")]
        public void RemoveAllObjects() { }

        /// <summary>
        /// Removes from the dictionary entries specified by elements in a given array.
        /// </summary>
        /// <param name="keyArray">An array of objects specifying the keys to remove.</param>
        [iOSVersion(2)]
        [Export("removeObjectsForKeys")]
        public void RemoveObjectsForKeys(AnyObject[] keyArray) { }
    }
}
