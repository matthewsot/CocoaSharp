using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSKeyValueObserving_Protocol/index.html#//apple_ref/doc/uid/TP40003781    /// <summary>    /// The NSKeyValueObserving (KVO) informal protocol defines a mechanism that allows objects to be notified of changes to the specified properties of other objects.    /// </summary>    [iOSVersion(2)]    public interface NSKeyValueObserving    {        /// <summary>        /// This message is sent to the receiver when the value at the specified key path relative to the given object has changed.        /// </summary>        /// <param name="keyPath">The key path, relative to object, to the value that has changed.</param>        /// <param name="ofObject">The source object of the key path keyPath.</param>        /// <param name="change">A dictionary that describes the changes that have been made to the value of the property at the key path keyPath relative to object. Entries are described in Change Dictionary Keys.</param>        /// <param name="context">The value that was provided when the receiver was registered to receive key-value observation notifications.</param>        [iOSVersion(2)]        [Export("observeValueForKeyPath")]        void ObserveValueForKeyPath(string keyPath, AnyObject ofObject, NSDictionary change, CMutableVoidPointer context);                /// <summary>        /// Registers anObserver to receive KVO notifications for the specified key-path relative to the receiver.        /// </summary>        /// <param name="anObserver">The object to register for KVO notifications. The observer must implement the key-value observing method observeValueForKeyPath:ofObject:change:context:.</param>        /// <param name="forKeyPath">The key path, relative to the receiver, of the property to observe. This value must not be nil.</param>        /// <param name="options">A combination of the NSKeyValueObservingOptions values that specifies what is included in observation notifications. For possible values, see NSKeyValueObservingOptions.</param>        /// <param name="context">Arbitrary data that is passed to anObserver in observeValueForKeyPath:ofObject:change:context:.</param>        [iOSVersion(2)]        [Export("addObserver")]        void AddObserver(NSObject anObserver, string forKeyPath, NSKeyValueObservingOptions options, CMutableVoidPointer context);                /// <summary>        /// Stops a given object from receiving change notifications for the property specified by a given key-path relative to the receiver.        /// </summary>        /// <param name="anObserver">The object to remove as an observer.</param>        /// <param name="forKeyPath">A key-path, relative to the receiver, for which anObserver is registered to receive KVO change notifications.</param>        [iOSVersion(2)]        [Export("removeObserver")]        void RemoveObserver(NSObject anObserver, string forKeyPath);                /// <summary>        /// Stops a given object from receiving change notifications for the property specified by a given key-path relative to the receiver and a context.        /// </summary>        /// <param name="observer">The object to remove as an observer.</param>        /// <param name="forKeyPath">A key-path, relative to the receiver, for which anObserver is registered to receive KVO change notifications.</param>        /// <param name="context">Arbitrary data that more specifically identifies the observer to be removed.</param>        [iOSVersion(5)]        [Export("removeObserver")]        void RemoveObserver(NSObject observer, string forKeyPath, CMutableVoidPointer context);                /// <summary>        /// Invoked to inform the receiver that the value of a given property is about to change.        /// </summary>        /// <param name="key">The name of the property that will change.</param>        [iOSVersion(2)]        [Export("willChangeValueForKey")]        void WillChangeValueForKey(string key);                /// <summary>        /// Invoked to inform the receiver that the value of a given property has changed.        /// </summary>        /// <param name="key">The name of the property that changed.</param>        [iOSVersion(2)]        [Export("didChangeValueForKey")]        void DidChangeValueForKey(string key);                /// <summary>        /// Invoked to inform the receiver that the specified change is about to be executed at given indexes for a specified ordered to-many relationship.        /// </summary>        /// <param name="change">The type of change that is about to be made.</param>        /// <param name="valuesAtIndexes">The indexes of the to-many relationship that will be affected by the change.</param>        /// <param name="forKey">The name of a property that is an ordered to-many relationship.</param>        [iOSVersion(2)]        [Export("willChange")]        void WillChange(NSKeyValueChange change, NSIndexSet valuesAtIndexes, string forKey);                /// <summary>        /// Invoked to inform the receiver that the specified change has occurred on the indexes for a specified ordered to-many relationship.        /// </summary>        /// <param name="change">The type of change that was made.</param>        /// <param name="valuesAtIndexes">The indexes of the to-many relationship that were affected by the change.</param>        /// <param name="forKey">The name of a property that is an ordered to-many relationship.</param>        [iOSVersion(2)]        [Export("didChange")]        void DidChange(NSKeyValueChange change, NSIndexSet valuesAtIndexes, string forKey);                /// <summary>        /// Invoked to inform the receiver that the specified change is about to be made to a specified unordered to-many relationship.        /// </summary>        /// <param name="key">The name of a property that is an unordered to-many relationship</param>        /// <param name="withSetMutation">The type of change that will be made.</param>        /// <param name="usingObjects">The objects that are involved in the change (see NSKeyValueSetMutationKind).</param>        [iOSVersion(2)]        [Export("willChangeValueForKey")]        void WillChangeValueForKey(string key, NSKeyValueSetMutationKind withSetMutation, NSSet usingObjects);                /// <summary>        /// Invoked to inform the receiver that the specified change was made to a specified unordered to-many relationship.        /// </summary>        /// <param name="key">The name of a property that is an unordered to-many relationship</param>        /// <param name="withSetMutation">The type of change that was made.</param>        /// <param name="usingObjects">The objects that were involved in the change (see NSKeyValueSetMutationKind).</param>        [iOSVersion(2)]        [Export("didChangeValueForKey")]        void DidChangeValueForKey(string key, NSKeyValueSetMutationKind withSetMutation, NSSet usingObjects);                /// <summary>        /// Returns a Boolean value that indicates whether the receiver supports automatic key-value observation for the given key.        /// </summary>        /// <returns>true if the key-value observing machinery should automatically invoke willChangeValueForKey:/didChangeValueForKey: and willChange:valuesAtIndexes:forKey:/didChange:valuesAtIndexes:forKey: whenever instances of the class receive key-value coding messages for the key, or mutating key-value-coding-compliant methods for the key are invoked; otherwise false.</returns>        //[iOSVersion(2)]        //[Export("automaticallyNotifiesObserversForKey")]        //static bool AutomaticallyNotifiesObserversForKey(string key);                /// <summary>        /// Returns a set of key paths for properties whose values affect the value of the specified key.        /// </summary>        /// <param name="key">The key whose value is affected by the key paths.</param>        /// <returns></returns>        //[iOSVersion(2)]        //[Export("keyPathsForValuesAffectingValueForKey")]        //static NSSet KeyPathsForValuesAffectingValueForKey(string key);                /// <summary>        /// Sets the observation info for the receiver.        /// </summary>        /// <param name="observationInfo">The observation info for the receiver.</param>        [iOSVersion(2)]        [Export("observationInfo")]        COpaquePointer ObservationInfo { get; set; }        /// <summary>        /// These constants are used as keys in the change dictionary passed to observeValueForKeyPath:ofObject:change:context:.        /// </summary>                /// <summary>        /// An NSNumber object that contains a value corresponding to one of the NSKeyValueChange enums, indicating what sort of change has occurred.        /// </summary>        [iOSVersion(2)]        string NSKeyValueChangeKindKey { get; }                /// <summary>        /// If the value of the NSKeyValueChangeKindKey entry is NSKeyValueChangeSetting, and NSKeyValueObservingOptionNew was specified when the observer was registered, the value of this key is the new value for the attribute.        /// </summary>        [iOSVersion(2)]        string NSKeyValueChangeNewKey { get; }                /// <summary>        /// If the value of the NSKeyValueChangeKindKey entry is NSKeyValueChangeSetting, and NSKeyValueObservingOptionOld was specified when the observer was registered, the value of this key is the value before the attribute was changed.        /// </summary>        [iOSVersion(2)]        string NSKeyValueChangeOldKey { get; }                /// <summary>        /// If the value of the NSKeyValueChangeKindKey entry is NSKeyValueChangeInsertion, NSKeyValueChangeRemoval, or NSKeyValueChangeReplacement, the value of this key is an NSIndexSet object that contains the indexes of the inserted, removed, or replaced objects.        /// </summary>        [iOSVersion(2)]        string NSKeyValueChangeIndexesKey { get; }                /// <summary>        /// If the option NSKeyValueObservingOptionPrior was specified when the observer was registered this notification is sent prior to a change.        /// </summary>        [iOSVersion(2)]        string NSKeyValueChangeNotificationIsPriorKey { get; }
    }

    /// <summary>
    /// These constants are returned as the value for a NSKeyValueChangeKindKey key in the change dictionary passed to observeValueForKeyPath:ofObject:change:context: indicating the type of change made:
    /// </summary>
    public enum NSKeyValueChange
    {
        /// <summary>
        /// Indicates that the value of the observed key path was set to a new value. This change can occur when observing an attribute of an object, as well as properties that specify to-one and to-many relationships.
        /// </summary>
        [iOSVersion(2)]
        Setting,

        /// <summary>
        /// Indicates that an object has been inserted into the to-many relationship that is being observed.
        /// </summary>
        [iOSVersion(2)]
        Insertion,

        /// <summary>
        /// Indicates that an object has been removed from the to-many relationship that is being observed.
        /// </summary>
        [iOSVersion(2)]
        Removal,

        /// <summary>
        /// Indicates that an object has been replaced in the to-many relationship that is being observed.
        /// </summary>
        [iOSVersion(2)]
        Replacement,
    }
    /// <summary>
    /// These constants are passed to addObserver:forKeyPath:options:context: and determine the values that are returned as part of the change dictionary passed to an observeValueForKeyPath:ofObject:change:context:. You can pass 0 if you require no change dictionary values.
    /// </summary>
    public enum NSKeyValueObservingOptions
    {
        /// <summary>
        /// Indicates that the change dictionary should provide the new attribute value, if applicable.
        /// </summary>
        [iOSVersion(2)]
        New,

        /// <summary>
        /// Indicates that the change dictionary should contain the old attribute value, if applicable.
        /// </summary>
        [iOSVersion(2)]
        Old,

        /// <summary>
        /// If specified, a notification should be sent to the observer immediately, before the observer registration method even returns.
        /// </summary>
        [iOSVersion(2)]
        Initial,

        /// <summary>
        /// Whether separate notifications should be sent to the observer before and after each change, instead of a single notification after the change.
        /// </summary>
        [iOSVersion(2)]
        Prior,
    }

    /// <summary>
    /// These constants are specified as the parameter to the methods willChangeValueForKey:withSetMutation:usingObjects: and didChangeValueForKey:withSetMutation:usingObjects:. Their semantics correspond exactly to the NSMutableSet class methods unionSet:, minusSet:, intersectSet:, and setSet: method, respectively.
    /// </summary>
    public enum NSKeyValueSetMutationKind
    {
        /// <summary>
        /// Indicates that objects in the specified set are being added to the receiver.
        /// </summary>
        [iOSVersion(2)]
        UnionSetMutation,

        /// <summary>
        /// Indicates that the objects in the specified set are being removed from the receiver.
        /// </summary>
        [iOSVersion(2)]
        MinusSetMutation,

        /// <summary>
        /// Indicates that the objects not in the specified set are being removed from the receiver.
        /// </summary>
        [iOSVersion(2)]
        intersectSetMutation,

        /// <summary>
        /// Indicates that set of objects are replacing the existing objects in the receiver.
        /// </summary>
        [iOSVersion(2)]
        SetSetMutation,
    }}