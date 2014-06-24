using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSCache_Class/index.html#//apple_ref/occ/cl/NSCache
    /// <summary>
    /// An NSCache object is a collection-like container, or cache, that stores key-value pairs, similar to the NSDictionary class. Developers often incorporate caches to temporarily store objects with transient data that are expensive to create. Reusing these objects can provide performance benefits, because their values do not have to be recalculated. However, the objects are not critical to the application and can be discarded if memory is tight. If discarded, their values will have to be recomputed again when needed.
    /// </summary>
    [iOSVersion(4)]
    public class NSCache : NSObject
    {
        /// <summary>
        /// Returns the name of the cache.
        /// </summary>
        /// <returns>The name of the cache.</returns>
        [iOSVersion(4)]
        [Export("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <param name="key">An object identifying the value.</param>
        /// <returns>The value associated with key, or nil if no value is associated with key.</returns>
        [iOSVersion(4)]
        [Export("objectForKey")]
        public AnyObject ObjectForKey(AnyObject key) { return null; }

        /// <summary>
        /// Sets the value of the specified key in the cache.
        /// </summary>
        /// <param name="obj">The object to be stored in the cache.</param>
        /// <param name="forKey">The key with which to associate the value.</param>
        [iOSVersion(4)]
        [Export("setObject")]
        public void SetObject(AnyObject obj, AnyObject forKey) { }

        /// <summary>
        /// Sets the value of the specified key in the cache, and associates the key-value pair with the specified cost.
        /// </summary>
        /// <param name="obj">The object to store in the cache.</param>
        /// <param name="forKey">The key with which to associate the value.</param>
        /// <param name="cost">The cost with which to associate the key-value pair.</param>
        [iOSVersion(4)]
        [Export("setObject")]
        public void SetObject(AnyObject obj, AnyObject forKey, int cost) { }

        /// <summary>
        /// Removes the value of the specified key in the cache.
        /// </summary>
        /// <param name="key">The key identifying the value to be removed.</param>
        [iOSVersion(4)]
        [Export("removeObjectForKey")]
        public void RemoveObjectForKey(AnyObject key) { }

        /// <summary>
        /// Empties the cache.
        /// </summary>
        [iOSVersion(4)]
        [Export("removeAllObjects")]
        public void RemoveAllObjects() { }

        /// <summary>
        /// Returns the maximum number of objects that the cache can currently hold.
        /// </summary>
        /// <returns>The maximum number of objects that the cache can currently hold.</returns>
        [iOSVersion(4)]
        [Export("countLimit")]
        public int CountLimit { get; set; }

        /// <summary>
        /// Returns the maximum total cost that the cache can have before it starts evicting objects.
        /// </summary>
        /// <returns>The current maximum cost that the cache can have before it starts evicting objects.</returns>
        [iOSVersion(4)]
        [Export("totalCostLimit")]
        public int TotalCostLimit { get; set; }

        /// <summary>
        /// Returns whether or not the cache will automatically evict discardable-content objects whose content has been discarded.
        /// </summary>
        /// <returns>true if the cache will evict the object after it is discarded; otherwise, false.</returns>
        [iOSVersion(4)]
        [Export("evictsObjectsWithDiscardedContent")]
        public bool EvictsObjectsWithDiscardedContent { get; set; }

        /// <summary>
        /// Returns the cache’s delegate.
        /// </summary>
        /// <returns>The application delegate object.</returns>
        [iOSVersion(4)]
        [Export("delegate")]
        public NSCacheDelegate Delegate { get; set; }
    }
}