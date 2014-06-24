using ObjectiveC;
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
    }