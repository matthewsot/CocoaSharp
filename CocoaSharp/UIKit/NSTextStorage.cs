using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// NSTextStorage is a semiconcrete subclass of NSMutableAttributedString that manages a set of client NSLayoutManager objects, notifying them of any changes to its characters or attributes so that they can relay and redisplay the text as needed. NSTextStorage defines the fundamental storage mechanism of the Text Kit’s extended text-handling system.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSTextStorage_Class_TextKit/index.html#//apple_ref/occ/cl/NSTextStorage"/>    [iOSVersion(7)]    public class NSTextStorage : NSMutableAttributedString//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol, NSSecureCoding    {        /// <summary>        /// Notifies and records a recent change.        /// </summary>        /// <param name="editedMask">The edit action performed.</param>        /// <param name="range">The range in the original string (before the edit).</param>        /// <param name="changeInLength">The length delta for the editing changes.</param>        [iOSVersion(7)]        [Export("edited")]        public void Edited(NSTextStorageEditActions editedMask, NSRange range, int changeInLength) {  }                /// <summary>        /// Ensures that attributes are fixed in the given range.        /// </summary>        /// <param name="range">The range of characters whose attributes might be examined.</param>        [iOSVersion(7)]        [Export("ensureAttributesAreFixedInRange")]        public void EnsureAttributesAreFixedInRange(NSRange range) {  }                /// <summary>        /// Invalidates attributes in the specified range.        /// </summary>        /// <param name="range">The range of characters whose attributes should be invalidated.</param>        [iOSVersion(7)]        [Export("invalidateAttributesInRange")]        public void InvalidateAttributesInRange(NSRange range) {  }                /// <summary>        /// Triggers post-editing operations.        /// </summary>        [iOSVersion(7)]        [Export("processEditing")]        public void ProcessEditing() {  }                /// <summary>        /// Adds a layout manager to the receiver.        /// </summary>        /// <param name="aLayoutManager">The layout manager added to the receiver.</param>        [iOSVersion(7)]        [Export("addLayoutManager")]        public void AddLayoutManager(NSLayoutManager aLayoutManager) {  }                /// <summary>        /// Removes a layout manager from the receiver’s set of layout managers.        /// </summary>        /// <param name="aLayoutManager">The layout manager to remove.</param>        [iOSVersion(7)]        [Export("removeLayoutManager")]        public void RemoveLayoutManager(NSLayoutManager aLayoutManager) {  }                /// <summary>        /// The text storage delegate.        /// </summary>        [iOSVersion(7)]        [Export("delegate")]        public NSTextStorageDelegate Delegate { get; set; }                /// <summary>        /// The kinds of edits pending for the receiver.        /// </summary>        [iOSVersion(7)]        [Export("editedMask")]        public NSTextStorageEditActions EditedMask { get; set; }                /// <summary>        /// The length delta for the pending changes.        /// </summary>        [iOSVersion(7)]        [Export("changeInLength")]        public int ChangeInLength { get; set; }                /// <summary>        /// The range of the receiver to which pending changes have been made, whether of characters or of attributes.        /// </summary>        [iOSVersion(7)]        [Export("editedRange")]        public NSRange EditedRange { get; set; }                /// <summary>        /// Indicates whether the receiver fixes attributes lazily. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("fixesAttributesLazily")]        public bool FixesAttributesLazily { get; private set; }                /// <summary>        /// The receiver’s layout managers. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("layoutManagers")]        public AnyObject[] LayoutManagers { get; private set; }    }    /// <summary>    /// These constants are used in edited:range:changeInLength:.    /// </summary>    [iOSVersion(7)]    public enum NSTextStorageEditActions    {        /// <summary>        /// Attributes were added, removed, or changed.        /// </summary>        [iOSVersion(7)]        EditedAttributes,        /// <summary>        /// Characters were added, removed, or replaced.        /// </summary>        [iOSVersion(7)]        EditedCharacters,    }    /// <summary>    /// Observers other than the delegate shouldn’t make further changes to the text storage. The notification object is the text storage object that processed the edits. This notification does not contain a userInfo dictionary.    /// </summary>    [iOSVersion(7)]    public class NSTextStorageDidProcessEditingNotification : NSNotification    {        public NSTextStorageDidProcessEditingNotification() : base("", null) { }    }    /// <summary>    /// Observers other than the delegate shouldn’t make further changes to the text storage. The notification object is the text storage object that is about to process the edits. This notification does not contain a userInfo dictionary.    /// </summary>    [iOSVersion(7)]    public class NSTextStorageWillProcessEditingNotification : NSNotification    {        public NSTextStorageWillProcessEditingNotification() : base("", null) { }    }}