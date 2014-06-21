using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    using NSComparator = Func<AnyObject, AnyObject, NSComparisonResult>;

    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDictionary_Class/index.html#//apple_ref/occ/cl/NSDictionary
    /// <summary>
    /// The NSDictionary class declares the programmatic interface to objects that manage immutable associations of keys and values. Use this class or its subclass NSMutableDictionary when you need a convenient and efficient way to retrieve data associated with an arbitrary key. NSDictionary creates static dictionaries, and NSMutableDictionary creates dynamic dictionaries. (For convenience, the term dictionary refers to any instance of one of these classes without specifying its exact class membership.)
    /// </summary>
    [iOSVersion(2)]
    public class NSDictionary : NSObject
    {
        /// <summary>
        /// Creates and returns a dictionary containing a given key and value.
        /// </summary>
        /// <param name="object">The value corresponding to aKey.   If this value is nil, an NSInvalidArgumentException is raised.</param>
        /// <param name="forKey">The key for anObject.   If this value is nil, an NSInvalidArgumentException is raised.</param>
        /// <returns>A new dictionary containing a single object, anObject, for a single key, aKey.</returns>
        [iOSVersion(2)]
        public NSDictionary(AnyObject @object, NSCopying forKey) { }

        /// <summary>
        /// Initializes a newly allocated dictionary using the keys and values found in a file at a given path.
        /// </summary>
        /// <param name="contentsOfFile">A full or relative pathname. The file identified by path must contain a string representation of a property list whose root object is a dictionary.</param>
        /// <returns>An initialized dictionary—which might be different than the original receiver—that contains the dictionary at path, or nil if there is a file error or if the contents of the file are an invalid representation of a dictionary.</returns>
        [iOSVersion(2)]
        public NSDictionary(string contentsOfFile) { }

        /// <summary>
        /// Initializes a newly allocated dictionary using the keys and values found at a given URL.
        /// </summary>
        /// <param name="contentsOfURL">An URL that identifies a resource containing a string representation of a property list whose root object is a dictionary.</param>
        /// <returns>An initialized dictionary—which might be different than the original receiver—that contains the dictionary at aURL, or nil if there is an error or if the contents of the resource are an invalid representation of a dictionary.</returns>
        [iOSVersion(2)]
        public NSDictionary(NSURL contentsOfURL) { }

        /// <summary>
        /// Initializes a newly allocated dictionary by placing in it the keys and values contained in another given dictionary.
        /// </summary>
        /// <param name="dictionary">A dictionary containing the keys and values with which to initialize the new dictionary.</param>
        /// <returns>An initialized dictionary—which might be different than the original receiver—containing the keys and values found in otherDictionary.</returns>
        [iOSVersion(2)]
        public NSDictionary(NSDictionary dictionary) { }

        /// <summary>
        /// Initializes a newly allocated dictionary using the objects contained in another given dictionary.
        /// </summary>
        /// <param name="dictionary">A dictionary containing the keys and values with which to initialize the new dictionary.</param>
        /// <param name="copyItems">If true, each object in otherDictionary receives a copyWithZone: message to create a copy of the object—objects must conform to the NSCopying protocol. In a managed memory environment, this is instead of the retain message the object would otherwise receive. The object copy is then added to the returned dictionary.   If false, then in a managed memory environment each object in otherDictionary simply receives a retain message when it is added to the returned dictionary.</param>
        /// <returns>An initialized object—which might be different than the original receiver—containing the keys and values found in otherDictionary.</returns>
        [iOSVersion(2)]
        public NSDictionary(NSDictionary dictionary, bool copyItems) { }

        /// <summary>
        /// Initializes a newly allocated dictionary with entries constructed from the contents of the objects and keys arrays.
        /// </summary>
        /// <param name="objects">An array containing the values for the new dictionary.</param>
        /// <param name="forKeys">An array containing the keys for the new dictionary. Each key is copied (using copyWithZone:; keys must conform to the NSCopying protocol), and the copy is added to the new dictionary.</param>
        [iOSVersion(2)]
        public NSDictionary(AnyObject[] objects, AnyObject[] forKeys) { }

        /// <summary>
        /// Initializes a newly allocated dictionary with count entries.
        /// </summary>
        /// <param name="objects">A C array of values for the new dictionary.</param>
        /// <param name="forKeys">A C array of keys for the new dictionary. Each key is copied (using copyWithZone:; keys must conform to the NSCopying protocol), and the copy is added to the new dictionary.</param>
        /// <param name="count">The number of elements to use from the keys and objects arrays. count must not exceed the number of elements in objects or keys.</param>
        [iOSVersion(2)]
        public NSDictionary(CConstPointer<AnyObject> objects, CConstPointer<NSCopying> forKeys, int count) { }

        /// <summary>
        /// Initializes a newly allocated dictionary.
        /// </summary>
        /// <returns>A dictionary.</returns>
        [iOSVersion(7)]
        public NSDictionary() { }

        /// <summary>
        /// Creates a shared key set object for the specified keys.
        /// </summary>
        /// <param name="keys">The array of keys. If the parameter is nil, an exception is thrown. If the array of keys is empty, an empty key set is returned.</param>
        /// <returns>A shared key set object.</returns>
        [iOSVersion(6)]
        [Export("sharedKeySetForKeys")]
        public static AnyObject SharedKeySetForKeys(AnyObject[] keys) { return null; }

        /// <summary>
        /// Returns the number of entries in the dictionary.
        /// </summary>
        /// <returns>The number of entries in the dictionary.</returns>
        [iOSVersion(2)]
        [Export("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Returns a Boolean value that indicates whether the contents of the receiving dictionary are equal to the contents of another given dictionary.
        /// </summary>
        /// <param name="otherDictionary">The dictionary with which to compare the receiving dictionary.</param>
        /// <returns>true if the contents of otherDictionary are equal to the contents of the receiving dictionary, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isEqualToDictionary")]
        public bool IsEqualToDictionary(NSDictionary otherDictionary) { return false; }

        /// <summary>
        /// Returns a new array containing the dictionary’s keys.
        /// </summary>
        /// <returns>A new array containing the dictionary’s keys, or an empty array if the dictionary has no entries.</returns>
        [iOSVersion(2)]
        [Export("allKeys")]
        public AnyObject[] AllKeys { get; private set; }

        /// <summary>
        /// Returns a new array containing the keys corresponding to all occurrences of a given object in the dictionary.
        /// </summary>
        /// <param name="anObject">The value to look for in the dictionary.</param>
        /// <returns>A new array containing the keys corresponding to all occurrences of anObject in the dictionary. If no object matching anObject is found, returns an empty array.</returns>
        [iOSVersion(2)]
        [Export("allKeysForObject")]
        public AnyObject[] AllKeysForObject(AnyObject anObject) { return null; }

        /// <summary>
        /// Returns a new array containing the dictionary’s values.
        /// </summary>
        /// <returns>A new array containing the dictionary’s values, or an empty array if the dictionary has no entries.</returns>
        [iOSVersion(2)]
        [Export("allValues")]
        public AnyObject[] AllValues { get; private set; }

        /// <summary>
        /// Returns by reference C arrays of the keys and values in the dictionary.
        /// </summary>
        /// <param name="objects">Upon return, contains a C array of the values in the dictionary.</param>
        /// <param name="andKeys">Upon return, contains a C array of the keys in the dictionary.</param>
        [iOSVersion(2)]
        [Export("getObjects")]
        public void GetObjects(AutoreleasingUnsafePointer<AnyObject> objects, AutoreleasingUnsafePointer<AnyObject> andKeys) { }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <param name="aKey">The key for which to return the corresponding value.</param>
        /// <returns>The value associated with aKey, or nil if no value is associated with aKey.</returns>
        [iOSVersion(2)]
        [Export("objectForKey")]
        public AnyObject ObjectForKey(AnyObject aKey) { return null; }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <param name="key">The key for which to return the corresponding value.</param>
        /// <returns>The value associated with aKey, or nil if no value is associated with aKey.</returns>
        [iOSVersion(6)]
        [Export("objectForKeyedSubscript")]
        public AnyObject ObjectForKeyedSubscript(NSCopying key) { return null; }

        /// <summary>
        /// Returns the set of objects from the dictionary that corresponds to the specified keys as an NSArray.
        /// </summary>
        /// <param name="keys">An NSArray containing the keys for which to return corresponding values.</param>
        /// <param name="notFoundMarker">The marker object to place in the corresponding element of the returned array if an object isn’t found in the dictionary to correspond to a given key.</param>
        [iOSVersion(2)]
        [Export("objectsForKeys")]
        public AnyObject[] ObjectsForKeys(AnyObject[] keys, AnyObject notFoundMarker) { return null; }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <param name="key">The key for which to return the corresponding value. Note that when using key-value coding, the key must be a string (see Key-Value Coding Fundamentals).</param>
        /// <returns>The value associated with key.</returns>
        [iOSVersion(2)]
        [Export("valueForKey")]
        public AnyObject ValueForKey(string key) { return null; }

        /// <summary>
        /// Returns an enumerator object that lets you access each key in the dictionary.
        /// </summary>
        /// <returns>An enumerator object that lets you access each key in the dictionary.</returns>
        [iOSVersion(2)]
        [Export("keyEnumerator")]
        public NSEnumerator KeyEnumerator() { return null; }

        /// <summary>
        /// Returns an enumerator object that lets you access each value in the dictionary.
        /// </summary>
        /// <returns>An enumerator object that lets you access each value in the dictionary.</returns>
        [iOSVersion(2)]
        [Export("objectEnumerator")]
        public NSEnumerator ObjectEnumerator() { return null; }

        /// <summary>
        /// Applies a given block object to the entries of the dictionary.
        /// </summary>
        /// <param name="block">A block object to operate on entries in the dictionary.</param>
        [iOSVersion(4)]
        [Export("enumerateKeysAndObjectsUsingBlock")]
        public void EnumerateKeysAndObjectsUsingBlock(Action<AnyObject, AnyObject, CMutablePointer<ObjCBool>> block) { }

        /// <summary>
        /// Applies a given block object to the entries of the dictionary.
        /// </summary>
        /// <param name="opts">Enumeration options.</param>
        /// <param name="usingBlock">A block object to operate on entries in the dictionary.</param>
        [iOSVersion(4)]
        [Export("enumerateKeysAndObjectsWithOptions")]
        public void EnumerateKeysAndObjectsWithOptions(NSEnumerationOptions opts, Action<AnyObject, AnyObject, CMutablePointer<ObjCBool>> usingBlock) { }

        /// <summary>
        /// Returns an array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values.
        /// </summary>
        /// <param name="comparator">A selector that specifies the method to use to compare the values in the dictionary.   The comparator method should return NSOrderedAscending if the dictionary value is smaller than the argument, NSOrderedDescending if the dictionary value is larger than the argument, and NSOrderedSame if they are equal.</param>
        /// <returns>An array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values.</returns>
        [iOSVersion(2)]
        [Export("keysSortedByValueUsingSelector")]
        public AnyObject[] KeysSortedByValueUsingSelector(Selector comparator) { return null; }

        /// <summary>
        /// Returns an array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values using a given comparator block.
        /// </summary>
        /// <param name="cmptr">A comparator block.</param>
        /// <returns>An array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values using cmptr.</returns>
        [iOSVersion(4)]
        [Export("keysSortedByValueUsingComparator")]
        public AnyObject[] KeysSortedByValueUsingComparator(NSComparator cmptr) { return null; }

        /// <summary>
        /// Returns an array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values using a given comparator block and a specified set of options.
        /// </summary>
        /// <param name="opts">A bitmask of sort options.</param>
        /// <param name="usingComparator">A comparator block.</param>
        /// <returns>An array of the dictionary’s keys, in the order they would be in if the dictionary were sorted by its values using cmptr with the options given in opts.</returns>
        [iOSVersion(4)]
        [Export("keysSortedByValueWithOptions")]
        public AnyObject[] KeysSortedByValueWithOptions(NSSortOptions opts, NSComparator usingComparator) { return null; }

        /// <summary>
        /// Returns the set of keys whose corresponding value satisfies a constraint described by a block object.
        /// </summary>
        /// <param name="predicate">A block object that specifies constraints for values in the dictionary.</param>
        /// <returns>The set of keys whose corresponding value satisfies predicate.</returns>
        [iOSVersion(4)]
        [Export("keysOfEntriesPassingTest")]
        public NSSet KeysOfEntriesPassingTest(Func<AnyObject, AnyObject, CMutablePointer<ObjCBool>, bool> predicate) { return null; }

        /// <summary>
        /// Returns the set of keys whose corresponding value satisfies a constraint described by a block object.
        /// </summary>
        /// <param name="opts">A bit mask of enumeration options.</param>
        /// <param name="passingTest">A block object that specifies constraints for values in the dictionary.</param>
        /// <returns>The set of keys whose corresponding value satisfies predicate.</returns>
        [iOSVersion(4)]
        [Export("keysOfEntriesWithOptions")]
        public NSSet KeysOfEntriesWithOptions(NSEnumerationOptions opts, Func<AnyObject, AnyObject, CMutablePointer<ObjCBool>, bool> passingTest) { return null; }

        /// <summary>
        /// Writes a property list representation of the contents of the dictionary to a given path.
        /// </summary>
        /// <param name="path">The path at which to write the file.   If path contains a tilde (~) character, you must expand it with stringByExpandingTildeInPath before invoking this method.</param>
        /// <param name="atomically">A flag that specifies whether the file should be written atomically.   If flag is true, the dictionary is written to an auxiliary file, and then the auxiliary file is renamed to path. If flag is false, the dictionary is written directly to path. The true option guarantees that path, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <returns>true if the file is written successfully, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically) { return false; }

        /// <summary>
        /// Writes a property list representation of the contents of the dictionary to a given URL.
        /// </summary>
        /// <param name="aURL">The URL to which to write the dictionary.</param>
        /// <param name="atomically">A flag that specifies whether the output should be written atomically.   If flag is true, the dictionary is written to an auxiliary location, and then the auxiliary location is renamed to aURL. If flag is false, the dictionary is written directly to aURL. The true option guarantees that aURL, if it exists at all, won’t be corrupted even if the system should crash during writing. flag is ignored if aURL is of a type that cannot be written atomically.</param>
        /// <returns>true if the location is written successfully, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL aURL, bool atomically) { return false; }

        /// <summary>
        /// Returns the value for the NSFileCreationDate key.
        /// </summary>
        /// <returns>The value for the NSFileCreationDate key, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileCreationDate")]
        public NSDate FileCreationDate() { return null; }

        /// <summary>
        /// Returns the value for the NSFileExtensionHidden key.
        /// </summary>
        /// <returns>The value for the NSFileExtensionHidden key, or false if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileExtensionHidden")]
        public bool FileExtensionHidden() { return false; }

        /// <summary>
        /// Returns the value for the NSFileGroupOwnerAccountID key.
        /// </summary>
        /// <returns>The value for the NSFileGroupOwnerAccountID key, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileGroupOwnerAccountID")]
        public NSNumber FileGroupOwnerAccountID() { return null; }

        /// <summary>
        /// Returns the value for the NSFileGroupOwnerAccountName key.
        /// </summary>
        /// <returns>The value for the key NSFileGroupOwnerAccountName, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileGroupOwnerAccountName")]
        public string FileGroupOwnerAccountName() { return ""; }

        /// <summary>
        /// Returns the value for the NSFileHFSCreatorCode key.
        /// </summary>
        /// <returns>The value for the NSFileHFSCreatorCode key, or 0 if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileHFSCreatorCode")]
        public OSType FileHFSCreatorCode() { return null; }

        /// <summary>
        /// Returns the value for the NSFileHFSTypeCode key.
        /// </summary>
        /// <returns>The value for the NSFileHFSTypeCode key, or 0 if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileHFSTypeCode")]
        public OSType FileHFSTypeCode() { return null; }

        /// <summary>
        /// Returns the value for the NSFileAppendOnly key.
        /// </summary>
        /// <returns>The value for the NSFileAppendOnly key, or false if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileIsAppendOnly")]
        public bool FileIsAppendOnly() { return false; }

        /// <summary>
        /// Returns the value for the NSFileImmutable key.
        /// </summary>
        /// <returns>The value for the NSFileImmutable key, or false if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileIsImmutable")]
        public bool FileIsImmutable() { return false; }

        /// <summary>
        /// Returns the value for the key NSFileModificationDate.
        /// </summary>
        /// <returns>The value for the key NSFileModificationDate, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileModificationDate")]
        public NSDate FileModificationDate() { return null; }

        /// <summary>
        /// Returns the value for the NSFileOwnerAccountID key.
        /// </summary>
        /// <returns>The value for the NSFileOwnerAccountID key, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileOwnerAccountID")]
        public NSNumber FileOwnerAccountID() { return null; }

        /// <summary>
        /// Returns the value for the key NSFileOwnerAccountName.
        /// </summary>
        /// <returns>The value for the key NSFileOwnerAccountName, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileOwnerAccountName")]
        public string FileOwnerAccountName() { return ""; }

        /// <summary>
        /// Returns the value for the key NSFilePosixPermissions.
        /// </summary>
        /// <returns>The value, as an unsigned long, for the key NSFilePosixPermissions, or 0 if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("filePosixPermissions")]
        public int FilePosixPermissions() { return 0; }

        /// <summary>
        /// Returns the value for the key NSFileSize.
        /// </summary>
        /// <returns>The value, as an unsigned long long, for the key NSFileSize, or 0 if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileSize")]
        public CUnsignedLongLong FileSize() { return null; }

        /// <summary>
        /// Returns the value for the key NSFileSystemFileNumber.
        /// </summary>
        /// <returns>The value, as an unsigned long, for the key NSFileSystemFileNumber, or 0 if the dictionary doesn’t have an entry for the key</returns>
        [iOSVersion(2)]
        [Export("fileSystemFileNumber")]
        public int FileSystemFileNumber() { return 0; }

        /// <summary>
        /// Returns the value for the key NSFileSystemNumber.
        /// </summary>
        /// <returns>The value, as an unsigned long, for the key NSFileSystemNumber, or 0 if the dictionary doesn’t have an entry for the key</returns>
        [iOSVersion(2)]
        [Export("fileSystemNumber")]
        public int FileSystemNumber() { return 0; }

        /// <summary>
        /// Returns the value for the key NSFileType.
        /// </summary>
        /// <returns>The value for the key NSFileType, or nil if the dictionary doesn’t have an entry for the key.</returns>
        [iOSVersion(2)]
        [Export("fileType")]
        public string FileType() { return ""; }

        /// <summary>
        /// Returns a string that represents the contents of the dictionary, formatted as a property list.
        /// </summary>
        /// <returns>A string that represents the contents of the dictionary, formatted as a property list.</returns>
        [iOSVersion(2)]
        [Export("description")]
        public new string Description { get; private set; }

        /// <summary>
        /// Returns a string that represents the contents of the dictionary, formatted in .strings file format.
        /// </summary>
        /// <returns>A string that represents the contents of the dictionary, formatted in .strings file format.</returns>
        [iOSVersion(2)]
        [Export("descriptionInStringsFileFormat")]
        public string DescriptionInStringsFileFormat { get; private set; }

        /// <summary>
        /// Returns a string object that represents the contents of the dictionary, formatted as a property list.
        /// </summary>
        /// <param name="locale">An object that specifies options used for formatting each of the dictionary’s keys and values; pass nil if you don’t want them formatted.   On iOS and OS X v10.5 and later, either an instance of NSDictionary or an NSLocale object may be used for locale. On OS X v10.4 and earlier it must be an instance of NSDictionary.</param>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale) { return ""; }

        /// <summary>
        /// Returns a string object that represents the contents of the dictionary, formatted as a property list.
        /// </summary>
        /// <param name="locale">An object that specifies options used for formatting each of the dictionary’s keys and values; pass nil if you don’t want them formatted.   On iOS and OS X v10.5 and later, either an instance of NSDictionary or an NSLocale object may be used for locale. On OS X v10.4 and earlier it must be an instance of NSDictionary.</param>
        /// <param name="indent">Specifies a level of indentation, to make the output more readable: the indentation is (4 spaces) * level.</param>
        /// <returns>A string object that represents the contents of the dictionary, formatted as a property list.</returns>
        [iOSVersion(2)]
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale, int indent) { return ""; }
    }
}
