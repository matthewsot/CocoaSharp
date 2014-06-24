using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSKeyValueCoding_Protocol/index.html#//apple_ref/doc/uid/TP40003780
    /// <summary>
    /// The NSKeyValueCoding informal protocol defines a mechanism by which you can access the properties of an object indirectly by name (or key), rather than directly through invocation of an accessor method or as instance variables. Thus, all of an object’s properties can be accessed in a consistent manner.
    /// </summary>
    [iOSVersion(2)]
    public interface NSKeyValueCoding
    {
        /// <summary>
        /// Returns the value for the property identified by a given key.
        /// </summary>
        /// <param name="key">The name of one of the receiver's properties.</param>
        /// <returns>The value for the property identified by key.</returns>
        [iOSVersion(2)]
        [Export("valueForKey")]
        AnyObject ValueForKey(string key);

        /// <summary>
        /// Returns the value for the derived property identified by a given key path.
        /// </summary>
        /// <param name="keyPath">A key path of the form relationship.property (with one or more relationships); for example “department.name” or “department.manager.lastName”.</param>
        /// <returns>The value for the derived property identified by keyPath.</returns>
        [iOSVersion(2)]
        [Export("valueForKeyPath")]
        AnyObject ValueForKeyPath(string keyPath);

        /// <summary>
        /// Returns a dictionary containing the property values identified by each of the keys in a given array.
        /// </summary>
        /// <param name="keys">An array containing NSString objects that identify properties of the receiver.</param>
        /// <returns>A dictionary containing as keys the property names in keys, with corresponding values being the corresponding property values.</returns>
        [iOSVersion(2)]
        [Export("dictionaryWithValuesForKeys")]
        NSDictionary DictionaryWithValuesForKeys(AnyObject[] keys);

        /// <summary>
        /// Invoked by valueForKey: when it finds no property corresponding to a given key.
        /// </summary>
        /// <param name="key">A string that is not equal to the name of any of the receiver's properties.</param>
        [iOSVersion(2)]
        [Export("valueForUndefinedKey")]
        AnyObject ValueForUndefinedKey(string key);

        /// <summary>
        /// Returns a mutable array proxy that provides read-write access to an ordered to-many relationship specified by a given key.
        /// </summary>
        /// <param name="key">The name of an ordered to-many relationship.</param>
        /// <returns>A mutable array proxy that provides read-write access to the ordered to-many relationship specified by key.</returns>
        [iOSVersion(2)]
        [Export("mutableArrayValueForKey")]
        NSMutableArray MutableArrayValueForKey(string key);

        /// <summary>
        /// Returns a mutable array that provides read-write access to the ordered to-many relationship specified by a given key path.
        /// </summary>
        /// <param name="keyPath">A key path, relative to the receiver, to an ordered to-many relationship.</param>
        /// <returns>A mutable array that provides read-write access to the ordered to-many relationship specified by keyPath.</returns>
        [iOSVersion(2)]
        [Export("mutableArrayValueForKeyPath")]
        NSMutableArray MutableArrayValueForKeyPath(string keyPath);

        /// <summary>
        /// Returns a mutable set proxy that provides read-write access to the unordered to-many relationship specified by a given key.
        /// </summary>
        /// <param name="key">The name of an unordered to-many relationship.</param>
        /// <returns>A mutable set that provides read-write access to the unordered to-many relationship specified by key.</returns>
        [iOSVersion(2)]
        [Export("mutableSetValueForKey")]
        NSMutableSet MutableSetValueForKey(string key);

        /// <summary>
        /// Returns a mutable set that provides read-write access to the unordered to-many relationship specified by a given key path.
        /// </summary>
        /// <param name="keyPath">A key path, relative to the receiver, to an unordered to-many relationship.</param>
        /// <returns>A mutable set that provides read-write access to the unordered to-many relationship specified by keyPath.</returns>
        [iOSVersion(2)]
        [Export("mutableSetValueForKeyPath")]
        NSMutableSet MutableSetValueForKeyPath(string keyPath);

        /// <summary>
        /// Returns a mutable ordered set that provides read-write access to the uniquing ordered to-many relationship specified by a given key.
        /// </summary>
        /// <param name="key">The name of a uniquing ordered to-many relationship.</param>
        /// <returns>A mutable ordered set that provides read-write access to the uniquing to-many relationship specified by key.</returns>
        [iOSVersion(5)]
        [Export("mutableOrderedSetValueForKey")]
        NSMutableOrderedSet MutableOrderedSetValueForKey(string key);

        /// <summary>
        /// Returns a mutable ordered set that provides read-write access to the uniquing ordered to-many relationship specified by a given key path.
        /// </summary>
        /// <param name="keyPath">A key path, relative to the receiver, to a uniquing ordered to-many relationship represented by a set.</param>
        /// <returns>A mutable ordered set that provides read-write access to the uniquing to-many relationship specified by keyPath.</returns>
        [iOSVersion(5)]
        [Export("mutableOrderedSetValueForKeyPath")]
        NSMutableOrderedSet MutableOrderedSetValueForKeyPath(string keyPath);

        /// <summary>
        /// Sets the value for the property identified by a given key path to a given value.
        /// </summary>
        /// <param name="value">The value for the property identified by keyPath.</param>
        /// <param name="forKeyPath">A key path of the form relationship.property (with one or more relationships): for example “department.name” or “department.manager.lastName.”</param>
        [iOSVersion(2)]
        [Export("setValue")]
        void SetValueForKeyPath(AnyObject value, string forKeyPath);

        /// <summary>
        /// Sets properties of the receiver with values from a given dictionary, using its keys to identify the properties.
        /// </summary>
        /// <param name="keyedValues">A dictionary whose keys identify properties in the receiver. The values of the properties in the receiver are set to the corresponding values in the dictionary.</param>
        [iOSVersion(2)]
        [Export("setValuesForKeysWithDictionary")]
        void SetValuesForKeysWithDictionary(NSDictionary keyedValues);

        /// <summary>
        /// Invoked by setValue:forKey: when it’s given a nil value for a scalar value (such as an int or float).
        /// </summary>
        /// <param name="key">The name of one of the receiver's properties.</param>
        [iOSVersion(2)]
        [Export("setNilValueForKey")]
        void SetNilValueForKey(string key);

        /// <summary>
        /// Sets the property of the receiver specified by a given key to a given value.
        /// </summary>
        /// <param name="value">The value for the property identified by key.</param>
        /// <param name="forKey">The name of one of the receiver's properties.</param>
        [iOSVersion(2)]
        [Export("setValue")]
        void SetValueForKey(AnyObject value, string forKey);

        /// <summary>
        /// Invoked by setValue:forKey: when it finds no property for a given key.
        /// </summary>
        /// <param name="value">The value for the key identified by key.</param>
        /// <param name="forUndefinedKey">A string that is not equal to the name of any of the receiver's properties.</param>
        [iOSVersion(2)]
        [Export("setValue")]
        void SetValueForUndefinedKey(AnyObject value, string forUndefinedKey);

        /// <summary>
        /// Returns a Boolean value that indicates whether the key-value coding methods should access the corresponding instance variable directly on finding no accessor method for a property.
        /// </summary>
        /// <returns>true if the key-value coding methods should access the corresponding instance variable directly on finding no accessor method for a property, otherwise false.</returns>
        //[iOSVersion(2)]
        //[Export("accessInstanceVariablesDirectly")]
        //static bool AccessInstanceVariablesDirectly();

        /// <summary>
        /// Returns a Boolean value that indicates whether the value specified by a given pointer is valid for the property identified by a given key.
        /// </summary>
        /// <param name="ioValue">A pointer to a new value for the property identified by key. This method may modify or replace the value in order to make it valid.</param>
        /// <param name="forKey">The name of one of the receiver's properties. The key must specify an attribute or a to-one relationship.</param>
        /// <param name="error">If validation is necessary and ioValue is not transformed into a valid value, upon return contains an NSError object that describes the reason that ioValue is not a valid value.</param>
        /// <returns>YES if *ioValue is a valid value for the property identified by key, or if the method is able to modify the value to *ioValue to make it valid; otherwise false.</returns>
        [iOSVersion(2)]
        [Export("validateValue")]
        bool ValidateValueForKey(AutoreleasingUnsafePointer<AnyObject> ioValue, string forKey, NSErrorPointer error);

        /// <summary>
        /// Returns a Boolean value that indicates whether the value specified by a given pointer is valid for a given key path relative to the receiver.
        /// </summary>
        /// <param name="ioValue">A pointer to a new value for the property identified by keyPath. This method may modify or replace the value in order to make it valid.</param>
        /// <param name="forKeyPath">The name of one of the receiver's properties. The key path must specify an attribute or a to-one relationship. The key path has the form relationship.property (with one or more relationships); for example “department.name” or “department.manager.lastName”.</param>
        /// <param name="error">If validation is necessary and ioValue is not transformed into a valid value, upon return contains an NSError object that describes the reason that ioValue is not a valid value.</param>
        [iOSVersion(2)]
        [Export("validateValue")]
        bool ValidateValueForKeyPath(AutoreleasingUnsafePointer<AnyObject> ioValue, string forKeyPath, NSErrorPointer error);

        /// <summary>
        /// This constant defines the name of an exception raised when a key value coding operation fails.
        /// </summary>
        [Export("NSUndefinedKeyException")]
        string NSUndefinedKeyException { get; }

        /// <summary>
        /// These constants define the available array operators. See Set and Array Operators for more information.
        /// </summary>

        /// <summary>
        /// The @avg array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSAverageKeyValueOperator { get; }

        /// <summary>
        /// The @count array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSCountKeyValueOperator { get; }

        /// <summary>
        /// The @distinctUnionOfArrays array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSDistinctUnionOfArraysKeyValueOperator { get; }

        /// <summary>
        /// The @distinctUnionOfObjects array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSDistinctUnionOfObjectsKeyValueOperator { get; }

        /// <summary>
        /// The @distinctUnionOfSets array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSDistinctUnionOfSetsKeyValueOperator { get; }

        /// <summary>
        /// The @max array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSMaximumKeyValueOperator { get; }

        /// <summary>
        /// The @min array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSMinimumKeyValueOperator { get; }

        /// <summary>
        /// The @sum array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSSumKeyValueOperator { get; }

        /// <summary>
        /// The @unionOfArrays array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSUnionOfArraysKeyValueOperator { get; }

        /// <summary>
        /// The @unionOfObjects array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSUnionOfObjectsKeyValueOperator { get; }

        /// <summary>
        /// The @unionOfSets array operator.
        /// </summary>
        [iOSVersion(2)]
        string NSUnionOfSetsKeyValueOperator { get; }
    }
}