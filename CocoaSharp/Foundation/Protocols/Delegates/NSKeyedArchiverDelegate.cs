using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSKeyedArchiverDelegate protocol defines the optional methods implemented by delegates of NSKeyedArchiver objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSKeyedArchiverDelegate_Protocol/index.html#//apple_ref/occ/intf/NSKeyedArchiverDelegate"/>    [iOSVersion(4)]    public interface NSKeyedArchiverDelegate//: NSObjectProtocol    {        /// <summary>        /// Informs the delegate that a given object has been encoded.        /// </summary>        /// <param name="archiver">The archiver that sent the message.</param>        /// <param name="didEncodeObject">The object that has been encoded. object may be nil.</param>        [iOSVersion(2)]        [Export("archiver")]        void Archiver(NSKeyedArchiver archiver, AnyObject didEncodeObject);                /// <summary>        /// Notifies the delegate that encoding has finished.        /// </summary>        /// <param name="archiver">The archiver that sent the message.</param>        [iOSVersion(2)]        [Export("archiverDidFinish")]        void ArchiverDidFinish(NSKeyedArchiver archiver);                /// <summary>        /// Informs the delegate that object is about to be encoded.        /// </summary>        /// <param name="archiver">The archiver that sent the message.</param>        /// <param name="willEncodeObject">The object that is about to be encoded. This value is never nil.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("archiver")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        AnyObject Archiver(NSKeyedArchiver archiver, AnyObject willEncodeObject, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Notifies the delegate that encoding is about to finish.        /// </summary>        /// <param name="archiver">The archiver that sent the message.</param>        [iOSVersion(2)]        [Export("archiverWillFinish")]        void ArchiverWillFinish(NSKeyedArchiver archiver);                /// <summary>        /// Informs the delegate that one given object is being substituted for another given object.        /// </summary>        /// <param name="archiver">The archiver that sent the message.</param>        /// <param name="willReplaceObject">The object being replaced in the archive.</param>        /// <param name="withObject">The object replacing object in the archive.</param>        [iOSVersion(2)]        [Export("archiver")]        void Archiver(NSKeyedArchiver archiver, AnyObject willReplaceObject, AnyObject withObject);    }}