using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewUpdateItem_class/index.html#//apple_ref/occ/cl/UICollectionViewUpdateItem    /// <summary>    /// The UICollectionViewUpdateItem class describes a single change to make to an item in a collection view. You do not create instances of this class directly. When updating its content, the collection view object creates them and passes them to the layout object’s prepareForCollectionViewUpdates: method, which can use them to prepare the layout object for the upcoming changes.    /// </summary>    [iOSVersion(6)]    public class UICollectionViewUpdateItem : NSObject    {        /// <summary>        /// The index path of the item before the update. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("indexPathBeforeUpdate")]        public NSIndexPath IndexPathBeforeUpdate { get; private set; }                /// <summary>        /// The index path of the item after the update. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("indexPathAfterUpdate")]        public NSIndexPath IndexPathAfterUpdate { get; private set; }                /// <summary>        /// The action being performed on the item. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("updateAction")]        public UICollectionUpdateAction UpdateAction { get; private set; }    }

    /// <summary>
    /// Constants indicating the type of action being performed on an item.
    /// </summary>
    public enum UICollectionUpdateAction
    {
        /// <summary>
        /// Insert the item into the collection view.
        /// </summary>
        [iOSVersion(6)]
        Insert,

        /// <summary>
        /// Remove the item from the collection view.
        /// </summary>
        [iOSVersion(6)]
        Delete,

        /// <summary>
        /// Reload the item, which consists of deleting and then inserting the item.
        /// </summary>
        [iOSVersion(6)]
        Reload,

        /// <summary>
        /// Move the item from its current location to a new location.
        /// </summary>
        [iOSVersion(6)]
        Move,

        /// <summary>
        /// Take no action on the item.
        /// </summary>
        [iOSVersion(6)]
        None,
    }}