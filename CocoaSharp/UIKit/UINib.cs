using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// Instances of the UINib class serve as object wrappers, or containers, for Interface Builder nib files. An UINib object caches the contents of a nib file in memory, ready for unarchiving and instantiation. When your application needs to instantiate the contents of the nib file it can do so without having to load the data from the nib file first, improving performance. The UINib object can automatically release this cached nib data to free up memory for your application under low-memory conditions, reloading that data the next time your application instantiates the nib. Your application should use UINib objects whenever it needs to repeatedly instantiate the same nib data. For example, if your table view uses a nib file to instantiate table view cells, caching the nib in a UINib object can provide a significant performance improvement.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UINib_Ref/index.html#//apple_ref/occ/cl/UINib"/>    [iOSVersion(4)]    public class UINib : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns an UINib object initialized to the nib file in the specified bundle.        /// </summary>        /// <param name="nibName">The name of the nib file, without any leading path information.</param>        /// <param name="bundle">The bundle in which to search for the nib file. If you specify nil, this method looks for the nib file in the main bundle.</param>        [iOSVersion(4)]        public UINib(string nibName, NSBundle bundle) { }                /// <summary>        /// Creates an UINib object from nib data stored in memory.        /// </summary>        /// <param name="data">A block of memory that contains nib data.</param>        /// <param name="bundle">The bundle in which to search for resources referenced by the nib. If you specify nil, this method looks for the nib file in the main bundle.</param>        [iOSVersion(4)]        public UINib(NSData data, NSBundle bundle) { }                /// <summary>        /// Unarchives and instantiates the in-memory contents of the receiver’s nib file, creating a distinct object tree and set of top level objects.        /// </summary>        /// <param name="ownerOrNil">The object to use as the owner of the nib file. If the nib file has an owner, you must specify a valid object for this parameter.</param>        /// <param name="options">A dictionary containing the options to use when opening the nib file. For a list of available keys for this dictionary, see NSBundle UIKit Additions Reference.</param>        [iOSVersion(4)]        [Export("instantiateWithOwner")]        public AnyObject[] InstantiateWithOwner(AnyObject ownerOrNil, Dictionary<NSObject, AnyObject> options) { return default(AnyObject[]); }    }}