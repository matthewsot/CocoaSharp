using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //NOTE: the whole Move/Copy prefixes are messed up, make sure to copy the [Export] too

    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSFileManagerDelegate_Protocol/index.html#//apple_ref/occ/intf/NSFileManagerDelegate
    /// <summary>
    /// The NSFileManagerDelegate protocol defines optional methods for managing operations involving the copying, moving, linking, or removal of files and directories. When you use an NSFileManager object to initiate a copy, move, link, or remove operation, the file manager asks its delegate whether the operation should begin at all and whether it should proceed when an error occurs.
    /// </summary>
    [iOSVersion(5)]
    public interface NSFileManagerDelegate
    {
        /// <summary>
        /// Asks the delegate if the file manager should move the specified item to the new URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to move the file or directory.</param>
        /// <param name="shouldMoveItemAtURL">The URL of the file or directory that the file manager wants to move.</param>
        /// <param name="toURL">The URL specifying the new location for the file or directory.</param>
        /// <returns>true if the item should be moved or false if it should not be moved. If you do not implement this method, the file manager assumes a response of true.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool MoveFileManager(NSFileManager fileManager, NSURL shouldMoveItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if the file manager should move the specified item to the new path.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to move the file or directory.</param>
        /// <param name="shouldMoveItemAtPath">The path to the file or directory that the file manager wants to move.</param>
        /// <param name="toPath">The new path for the file or directory.</param>
        /// <returns>true if the operation should proceed, otherwise false. If you do not implement this method, the file manager assumes a response of true.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool MoveFileManager(NSFileManager fileManager, string shouldMoveItemAtPath, string toPath);
        
        /// <summary>
        /// Asks the delegate if the move operation should continue after an error occurs while moving the item at the specified URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to move the item.</param>
        /// <param name="shouldProceedAfterError">The error that occurred while trying to move the item in srcURL.</param>
        /// <param name="movingItemAtURL">The URL of the file or directory that the file manager tried to move.</param>
        /// <param name="toURL">The URL of the intended destination for the item in srcURL.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool MoveFileManager(NSFileManager fileManager, NSError shouldProceedAfterError, NSURL movingItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if the move operation should continue after an error occurs while moving the item at the specified path.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to move the item.</param>
        /// <param name="shouldProceedAfterError">The error that occurred while trying to move the item in srcPath.</param>
        /// <param name="movingItemAtPath">The path of the file or directory that the file manager tried to move.</param>
        /// <param name="toPath">The path of the intended destination for the item in srcPath.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool MoveFileManager(NSFileManager fileManager, NSError shouldProceedAfterError, string movingItemAtPath, string toPath);
        
        /// <summary>
        /// Asks the delegate if the file manager should copy the specified item to the new URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to copy the file or directory.</param>
        /// <param name="shouldCopyItemAtURL">The URL of the file or directory that the file manager wants to copy.</param>
        /// <param name="toURL">The URL specifying the location for the copied file or directory.</param>
        /// <returns>true if the item should be copied or false if the file manager should stop copying items associated with the current operation. If you do not implement this method, the file manager assumes a response of true.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool CopyFileManager(NSFileManager fileManager, NSURL shouldCopyItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if the file manager should copy the specified item to the new path.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to copy the file or directory.</param>
        /// <param name="shouldCopyItemAtPath">The path to the file or directory that the file manager wants to copy.</param>
        /// <param name="toPath">The new path for the copied file or directory.</param>
        /// <returns>true if the item should be copied or false if the file manager should stop copying items associated with the current operation. If you do not implement this method, the file manager assumes a response of true.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool CopyFileManager(NSFileManager fileManager, string shouldCopyItemAtPath, string toPath);
        
        /// <summary>
        /// Asks the delegate if the move operation should continue after an error occurs while copying the item at the specified URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to copy the item.</param>
        /// <param name="shouldProceedAfterError">The error that occurred during the attempt to copy.</param>
        /// <param name="copyingItemAtURL">The URL or a file or directory that fileManager is attempting to copy.</param>
        /// <param name="toURL">The URL or a file or directory to which fileManager is attempting to copy.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool CopyFileManager(NSFileManager fileManager, NSError shouldProceedAfterError, NSURL copyingItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if the move operation should continue after an error occurs while copying the item at the specified path.
        /// </summary>
        /// <param name="fileManager">The NSFileManager object that sent this message.</param>
        /// <param name="shouldProceedAfterError">The error that occurred during the attempt to copy.</param>
        /// <param name="copyingItemAtPath">The path or a file or directory that fileManager is attempting to copy.</param>
        /// <param name="toPath">The path or a file or directory to which fileManager is attempting to copy.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool CopyFileManager(NSFileManager fileManager, NSError shouldProceedAfterError, string copyingItemAtPath, string toPath);
        
        /// <summary>
        /// Asks the delegate whether the item at the specified URL should be deleted.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to remove the file or directory.</param>
        /// <param name="shouldRemoveItemAtURL">The URL indicating the file or directory that the file manager is attempting to delete.</param>
        /// <returns>true if the specified item should be removed or false if it should not be removed.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSURL shouldRemoveItemAtURL);
        
        /// <summary>
        /// Asks the delegate whether the item at the specified path should be deleted.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to remove the file or directory.</param>
        /// <param name="shouldRemoveItemAtPath">The path to the file or directory that the file manager is attempting to delete.</param>
        /// <returns>true if the specified item should be deleted or false if it should not be deleted.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, string shouldRemoveItemAtPath);
        
        /// <summary>
        /// Asks the delegate if the operation should continue after an error occurs while removing the item at the specified URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to remove the item.</param>
        /// <param name="shouldProceedAfterError">The error that occurred while attempting to remove the item at URL.</param>
        /// <param name="removingItemAtURL">The URL for the file or directory that the file manager tried to delete.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSError shouldProceedAfterError, NSURL removingItemAtURL);
        
        /// <summary>
        /// Asks the delegate if the operation should continue after an error occurs while removing the item at the specified path.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to remove the item.</param>
        /// <param name="shouldProceedAfterError">The error that occurred during the attempt to copy.</param>
        /// <param name="removingItemAtPath">The path for the file or directory that the file manager tried to delete.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSError shouldProceedAfterError, string removingItemAtPath);
        
        /// <summary>
        /// Asks the delegate if a hard link should be created between the items at the two URLs.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to create the link.</param>
        /// <param name="shouldLinkItemAtURL">The URL identifying the new hard link to be created.</param>
        /// <param name="toURL">The URL identifying the destination of the link.</param>
        /// <returns>true if the link should be created or false if it should not be created.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSURL shouldLinkItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if a hard link should be created between the items at the two paths.
        /// </summary>
        /// <param name="fileManager">The file manager object that is attempting to create the link.</param>
        /// <param name="shouldLinkItemAtPath">The path or a file or directory that fileManager is about to attempt to link.</param>
        /// <param name="toPath">The path or a file or directory to which fileManager is about to attempt to link.</param>
        /// <returns>true if the operation should proceed, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, string shouldLinkItemAtPath, string toPath);
        
        /// <summary>
        /// Asks the delegate if the operation should continue after an error occurs while linking to the item at the specified URL.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to create the link.</param>
        /// <param name="shouldProceedAfterError">The error that occurred during the link attempt.</param>
        /// <param name="linkingItemAtURL">The URL of the attempted link location.</param>
        /// <param name="toURL">The URL of the file or directory that was the destination of the hard link.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(4)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSError shouldProceedAfterError, NSURL linkingItemAtURL, NSURL toURL);
        
        /// <summary>
        /// Asks the delegate if the operation should continue after an error occurs while linking to the item at the specified path.
        /// </summary>
        /// <param name="fileManager">The file manager object that attempted to create the link.</param>
        /// <param name="shouldProceedAfterError">The error that occurred during the link attempt.</param>
        /// <param name="linkingItemAtPath">The path to the attempted link location.</param>
        /// <param name="toPath">The path to the file or directory that was the destination of the hard link.</param>
        /// <returns>true if the operation should proceed or false if it should be aborted. If you do not implement this method, the file manager assumes a response of false.</returns>
        [iOSVersion(2)]
        [Export("fileManager")]
        [Optional]
        bool FileManager(NSFileManager fileManager, NSError shouldProceedAfterError, string linkingItemAtPath, string toPath);
    }
}