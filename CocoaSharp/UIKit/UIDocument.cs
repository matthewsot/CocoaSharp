using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIDocument class is an abstract base class for managing the data of documents.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocument_Class/index.html#//apple_ref/occ/cl/UIDocument"/>    [iOSVersion(5)]    public class UIDocument : NSObject//, AnyObject, NSFilePresenter, NSObjectProtocol    {        /// <summary>        /// Returns a document object initialized with its file-system location.        /// </summary>        /// <param name="fileURL">A file URL identifying the location in the application sandbox where document data is to be written. Passing in nil or an empty URL results in the throwing of an NSInvalidArgumentException.</param>        [iOSVersion(5)]        public UIDocument(NSURL fileURL) { }                /// <summary>        /// Asynchronously closes the document after saving any changes.        /// </summary>        /// <param name="completionHandler">A block with code to execute after the save-and-close operation concludes. The block returns no value and has one parameter:        ///       success        ///   true if any save operation succeeds, otherwise false.        ///   The block is invoked on the main queue.</param>        [iOSVersion(5)]        [Export("closeWithCompletionHandler")]        public void CloseWithCompletionHandler(Action<bool> completionHandler) {  }                /// <summary>        /// Override this method to return the document data to be saved.        /// </summary>        /// <param name="typeName">The file type of the document, a Uniform Type Identifier (UTI). This string typically derives from the fileType property. If you want to save the document under a different UTI, you can override the savingFileType method.</param>        /// <param name="error">If you cannot return document data, return by indirection an NSError object that encapsulates the reasons you can’t. Otherwise, ignore this parameter.</param>        [iOSVersion(5)]        [Export("contentsForType")]        public AnyObject ContentsForType(string typeName, NSErrorPointer error) { return default(AnyObject); }                /// <summary>        /// Saves document data to the specified location in the application sandbox.        /// </summary>        /// <param name="url">The file URL identifying the location in the application sandbox to write the document data to. Typically, this is the URL obtained from the fileURL property.</param>        /// <param name="forSaveOperation">A constant that indicates whether the document file is being written the first time or whether it is being overwritten. See Document Save Operation for details.</param>        /// <param name="completionHandler">A block with code that is executed when the save operation concludes. The block returns no value and has one parameter:        ///       success        ///   true if the save operation succeeds, otherwise false.        ///   This block is invoked on the calling queue.</param>        [iOSVersion(5)]        [Export("saveToURL")]        public void SaveToURL(NSURL url, UIDocumentSaveOperation forSaveOperation, Action<bool> completionHandler) {  }                /// <summary>        /// Ensures that document data is written safely to a specified location in the application sandbox.        /// </summary>        /// <param name="contents">The document data to write to disk. Typically, the data is encapsulated by an NSData object (if a flat file) or an NSFileWrapper object (if a file package).         ///   If the object encapsulating the document data is of some other type, you should override this method or writeContents:toURL:forSaveOperation:originalContentsURL:error: to perform the actual writing of the data.</param>        /// <param name="andAttributes">A dictionary of NSFileManager file attributes to assign to the document file. The default implementation obtains these file attributes by calling fileAttributesToWriteToURL:forSaveOperation:error:.</param>        /// <param name="safelyToURL">The file URL specifying the location of the document file in the application sandbox.</param>        /// <param name="forSaveOperation">A constant that indicates whether the document file is being written the first time or whether it is being overwritten. See Document Save Operation for details.</param>        /// <param name="error">If you override this method and cannot write the document data for any reason, return by indirection an NSError object that encapsulates the reasons why you can’t. Otherwise, ignore this parameter.</param>        [iOSVersion(5)]        [Export("writeContents")]        public bool WriteContents(AnyObject contents, Dictionary<NSObject, AnyObject> andAttributes, NSURL safelyToURL, UIDocumentSaveOperation forSaveOperation, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Writes the document data to disk at the sandbox location indicated by a file URL.        /// </summary>        /// <param name="contents">The document data to write to disk. Typically, the data is encapsulated by an NSData object (if a flat file) or an NSFileWrapper object (if a file package).         ///   If the object encapsulating the document data is of some other type, you should override this method or writeContents:andAttributes:safelyToURL:forSaveOperation:error: to perform the actual writing of the data.</param>        /// <param name="toURL">A file URL specifying the location of the document file in the application sandbox.</param>        /// <param name="forSaveOperation">A constant that indicates whether the document file is being written the first time or whether it is being overwritten. See Document Save Operation for details.</param>        /// <param name="originalContentsURL">A file URL specifying the previous location of the document file (if not nil).</param>        /// <param name="error">If you override this method and cannot write the document data for any reason, return by indirection an NSError object that encapsulates the reasons why you can’t. Otherwise, ignore this parameter.</param>        [iOSVersion(5)]        [Export("writeContents")]        public bool WriteContents(AnyObject contents, NSURL toURL, UIDocumentSaveOperation forSaveOperation, NSURL originalContentsURL, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Returns the file type to use for saving a document.        /// </summary>        [iOSVersion(5)]        [Export("savingFileType")]        public string SavingFileType() { return default(string); }                /// <summary>        /// Returns a dictionary of file attributes to associate with the document file when writing or updating it.        /// </summary>        /// <param name="url">A file URL locating the document in the application sandbox.</param>        /// <param name="forSaveOperation">A constant that indicates whether the document file is being written the first time or whether it is being overwritten. See Document Save Operation for details.</param>        /// <param name="error">If you override this method and cannot write the document data for any reason, return by indirection an NSError object that encapsulates the reasons why you can’t. Otherwise, ignore this parameter.</param>        [iOSVersion(5)]        [Export("fileAttributesToWriteToURL")]        public Dictionary<NSObject, AnyObject> FileAttributesToWriteToURL(NSURL url, UIDocumentSaveOperation forSaveOperation, NSErrorPointer error) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Returns a file extension to append to the file URL of the document file being written.        /// </summary>        /// <param name="typeName">A Uniform Type Identifier (UTI) that indicates the type of document (for example, PDF or HTML).</param>        /// <param name="saveOperation">A constant that indicates whether the document file is being written the first time or whether it is being overwritten. See Document Save Operation for details.</param>        [iOSVersion(5)]        [Export("fileNameExtensionForType")]        public string FileNameExtensionForType(string typeName, UIDocumentSaveOperation saveOperation) { return default(string); }                /// <summary>        /// Opens a document asynchronously.        /// </summary>        /// <param name="completionHandler">A block with code to execute after the open operation concludes. The block returns no value and has one parameter:        ///       success        ///   true if the open operation succeeds, otherwise false.        ///   The block is invoked on the main queue.</param>        [iOSVersion(5)]        [Export("openWithCompletionHandler")]        public void OpenWithCompletionHandler(Action<bool> completionHandler) {  }                /// <summary>        /// Override this method to load the document data into the app’s data model.        /// </summary>        /// <param name="contents">An object encapsulating the document data to load. This object is either an instance of the NSData class (for flat files) or the NSFileWrapper class (for file packages).</param>        /// <param name="ofType">The file type of the document, a Uniform Type Identifier (UTI) based on the file extension of fileURL. You can obtain the default value of the file type from the fileType property.</param>        /// <param name="error">If you cannot load the document data for any reason, return by indirection an NSError object that encapsulates the reasons you can’t. Otherwise, ignore this parameter.</param>        [iOSVersion(5)]        [Export("loadFromContents")]        public bool LoadFromContents(AnyObject contents, string ofType, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Reads the document data in a file at a specified location in the application sandbox.        /// </summary>        /// <param name="url">A file URL that identifies the location of the document file in the application sandbox. This file URL is typically the one returned by the fileURL property.</param>        /// <param name="error">If the document file cannot be read, returns by indirection an error object that encapsulates the reasons why the read operation failed.</param>        [iOSVersion(5)]        [Export("readFromURL")]        public bool ReadFromURL(NSURL url, NSErrorPointer error) { return default(bool); }                /// <summary>        /// Schedules a document-reading or document-writing operation on a concurrent background queue.        /// </summary>        /// <param name="block">A block that is invoked as the task to execute on the background queue. The block returns no value and takes no parameters.</param>        [iOSVersion(5)]        [Export("performAsynchronousFileAccessUsingBlock")]        public void PerformAsynchronousFileAccessUsingBlock(Action block) {  }                /// <summary>        /// Reverts a document to the most recent document data stored on-disk.        /// </summary>        /// <param name="url">A file URL locating the most recent version of the document file in the application’s sandbox.</param>        /// <param name="completionHandler">A block with code to execute after the reversion operation concludes. The block returns no value and has one parameter:        ///       success        ///   true if the reversion operation succeeds, otherwise false.        ///   The block is invoked on the main queue.</param>        [iOSVersion(5)]        [Export("revertToContentsOfURL")]        public void RevertToContentsOfURL(NSURL url, Action<bool> completionHandler) {  }                /// <summary>        /// Overridden to disable editing when it is unsafe to make changes to a document.        /// </summary>        [iOSVersion(5)]        [Export("disableEditing")]        public void DisableEditing() {  }                /// <summary>        /// Overridden to enable editing when it is safe again to make changes to a document.        /// </summary>        [iOSVersion(5)]        [Export("enableEditing")]        public void EnableEditing() {  }                /// <summary>        /// Returns whether the document has any unsaved changes.        /// </summary>        [iOSVersion(5)]        [Export("hasUnsavedChanges")]        public bool HasUnsavedChanges() { return default(bool); }                /// <summary>        /// Update the change counter by indicating the kind of change.        /// </summary>        /// <param name="change">A constant that indicates whether a change has been made, cleared, undone, or redone. See Document Save Kind for more information.</param>        [iOSVersion(5)]        [Export("updateChangeCount")]        public void UpdateChangeCount(UIDocumentChangeKind change) {  }                /// <summary>        /// Overridden to return a change token for a specific save operation.        /// </summary>        /// <param name="saveOperation">A constant that indicates whether the save operation is writing a new file or overwriting an existing one. See Document Save Operation for descriptions of these constants.</param>        [iOSVersion(5)]        [Export("changeCountTokenForSaveOperation")]        public AnyObject ChangeCountTokenForSaveOperation(UIDocumentSaveOperation saveOperation) { return default(AnyObject); }                /// <summary>        /// Overridden to update the change count with reference to a change-count token passed in by UIKit.        /// </summary>        /// <param name="changeCountToken">An object to use as a change-count token. UIDocument obtained this token earlier by calling changeCountTokenForSaveOperation:.</param>        /// <param name="forSaveOperation">A constant that indicates whether the save operation is writing a new file or overwriting an existing one. See Document Save Operation for descriptions of these constants.</param>        [iOSVersion(5)]        [Export("updateChangeCountWithToken")]        public void UpdateChangeCountWithToken(AnyObject changeCountToken, UIDocumentSaveOperation forSaveOperation) {  }                /// <summary>        /// Called by UIKit to initiate automatic saving of documents with unsaved changes.        /// </summary>        /// <param name="completionHandler">A block with code to execute after automatic saving concludes. The block returns no value and has one parameter:        ///       success        ///   true if the autosaving operation succeeds, otherwise false.        ///   The block is invoked on the calling queue.</param>        [iOSVersion(5)]        [Export("autosaveWithCompletionHandler")]        public void AutosaveWithCompletionHandler(Action<bool> completionHandler) {  }                /// <summary>        /// Restores the state needed to continue the given user activity.        /// </summary>        /// <param name="activity">The user activity to be continued.</param>        [iOSVersion(8)]        [Export("restoreUserActivityState")]        public void RestoreUserActivityState(NSUserActivity activity) {  }                /// <summary>        /// Updates the state of the given user activity.        /// </summary>        /// <param name="activity">The user activity to be updated.</param>        [iOSVersion(8)]        [Export("updateUserActivityState")]        public void UpdateUserActivityState(NSUserActivity activity) {  }                /// <summary>        /// Called or overridden to handle an error that occurs during an attempt to read, save, or revert a document.        /// </summary>        /// <param name="error">An object encapsulating information about an error encountered in an attempt to open, save, or revert a document. The error domain is NSCocoaErrorDomain. The error code is one of the enum constants declared in FoundationErrors.h.</param>        /// <param name="userInteractionPermitted">If false, no attempt is (or should be) made to present a modal view to the user. This value can be false in cases such as when a save operation fails while the application is being suspended. If this parameter is true, UIKit or your override may present error information to the user in a modal view and (optionally) allow the user to resolve the error.</param>        [iOSVersion(5)]        [Export("handleError")]        public void HandleError(NSError error, bool userInteractionPermitted) {  }                /// <summary>        /// Tells UIKit that you have finished handled the error.        /// </summary>        /// <param name="error">An error object encapsulating information about the error.</param>        /// <param name="recovered">true if you recovered from the error, otherwise false.</param>        [iOSVersion(5)]        [Export("finishedHandlingError")]        public void FinishedHandlingError(NSError error, bool recovered) {  }                /// <summary>        /// Sent when it is no longer safe to proceed without immediately handling the error.        /// </summary>        /// <param name="error">An error object encapsulating information about the error.</param>        [iOSVersion(5)]        [Export("userInteractionNoLongerPermittedForError")]        public void UserInteractionNoLongerPermittedForError(NSError error) {  }                /// <summary>        /// The file URL with which the document was initialized. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("fileURL")]        public NSURL FileURL { get; private set; }                /// <summary>        /// The localized name of the document. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("localizedName")]        public string LocalizedName { get; private set; }                /// <summary>        /// The file type of the document. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("fileType")]        public string FileType { get; private set; }                /// <summary>        /// The date and time the document file was last modified.        /// </summary>        [iOSVersion(5)]        [Export("fileModificationDate")]        public NSDate FileModificationDate { get; set; }                /// <summary>        /// Returns the current state of the document. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("documentState")]        public UIDocumentState DocumentState { get; private set; }                /// <summary>        /// The undo manager for the document.        /// </summary>        [iOSVersion(5)]        [Export("undoManager")]        public NSUndoManager UndoManager { get; set; }                /// <summary>        /// An object encapsulating a user activity supported by this document.        /// </summary>        [iOSVersion(8)]        [Export("userActivity")]        public NSUserActivity UserActivity { get; set; }    }    /// <summary>    /// Constants for specifying the kind of change to a document.    /// </summary>    [iOSVersion(5)]    public enum UIDocumentChangeKind    {        /// <summary>        /// A change has been made to the document.        /// </summary>        [iOSVersion(5)]        Done,        /// <summary>        /// A change to the document has been undone.        /// </summary>        [iOSVersion(5)]        Undone,        /// <summary>        /// An undone change to the document has been redone.        /// </summary>        [iOSVersion(5)]        Redone,        /// <summary>        /// The document is cleared of outstanding changes.        /// </summary>        [iOSVersion(5)]        Cleared,    }    /// <summary>    /// Constants for specifying the type of save operation.    /// </summary>    [iOSVersion(5)]    public enum UIDocumentSaveOperation    {        /// <summary>        /// The document is being saved for the first time.        /// </summary>        [iOSVersion(5)]        ForCreating,        /// <summary>        /// The document is being saved by overwriting the current version.        /// </summary>        [iOSVersion(5)]        ForOverwriting,    }    /// <summary>    /// The document state.    /// </summary>    [iOSVersion(5)]    public enum UIDocumentState    {        /// <summary>        /// The document is open, editing is enabled, and there are no conflicts or errors associated with it.        /// </summary>        [iOSVersion(5)]        Normal,        /// <summary>        /// There was an error in reading the document: the document has either not been successfully opened, or has been since closed. The document properties might not be valid.        /// </summary>        [iOSVersion(5)]        Closed,        /// <summary>        /// Conflicts exist for the document file located at fileURL. You can access these conflicting document versions by calling the otherVersionsOfItemAtURL: class method of the NSFileVersion class.  This method returns an array of NSFileVersion objects. You can then resolve the conflicting versions—for example, programmatically attempt to merge the versions or present the document versions to the user and request him or her to pick one.        /// </summary>        [iOSVersion(5)]        InConflict,        /// <summary>        /// There was an error in saving or reverting the document.        /// </summary>        [iOSVersion(5)]        SavingError,        /// <summary>        /// The document is busy and it is not currently safe for user edits. This state is set just before UIDocument calls the disableEditing method. It calls enableEditing when it becomes safe to edit again. UIDocument also sets this state when an error prevents the reverting of a document.        /// </summary>        [iOSVersion(5)]        EditingDisabled,    }    /// <summary>    /// When handling this notification, check the value of the documentState property to see what the new state is, and then proceed accordingly. There is no userInfo dictionary.    /// </summary>    [iOSVersion(5)]    public class UIDocumentStateChangedNotification : NSNotification    {        public UIDocumentStateChangedNotification() : base("", null) { }    }}