using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSUndoManager_Class/index.html#//apple_ref/occ/cl/NSUndoManager    /// <summary>    /// NSUndoManager is a general-purpose recorder of operations for undo and redo.    /// </summary>    [iOSVersion(3)]    public class NSUndoManager : NSObject    {        /// <summary>        /// Records a single undo operation for a given target, so that when an undo is performed it is sent a specified selector with a given object as the sole argument.        /// </summary>        /// <param name="target">The target of the undo operation.</param>        /// <param name="selector">The selector for the undo operation.</param>        /// <param name="object">The argument sent with the selector.</param>        [iOSVersion(3)]        [Export("registerUndoWithTarget")]        public void RegisterUndoWithTarget(AnyObject target, Selector selector, AnyObject @object) { }                /// <summary>        /// Prepares the receiver for invocation-based undo with the given target as the subject of the next undo operation and returns self.        /// </summary>        /// <param name="target">The target of the undo operation. The undo manager maintains a weak reference to the target.</param>        /// <returns>self.</returns>        [iOSVersion(3)]        [Export("prepareWithInvocationTarget")]        public AnyObject PrepareWithInvocationTarget(AnyObject target) { return null; }                /// <summary>        /// Returns a Boolean value that indicates whether the receiver has any actions to undo.        /// </summary>        /// <returns>true if the receiver has any actions to undo, otherwise false.</returns>        [iOSVersion(3)]        [Export("canUndo")]        public bool CanUndo { get; private set; }                /// <summary>        /// Returns a Boolean value that indicates whether the receiver has any actions to redo.        /// </summary>        /// <returns>true if the receiver has any actions to redo, otherwise false.</returns>        [iOSVersion(3)]        [Export("canRedo")]        public bool CanRedo { get; private set; }                /// <summary>        /// Closes the top-level undo group if necessary and invokes undoNestedGroup.        /// </summary>        [iOSVersion(3)]        [Export("undo")]        public void Undo() { }                /// <summary>        /// Performs the undo operations in the last undo group (whether top-level or nested), recording the operations on the redo stack as a single group.        /// </summary>        [iOSVersion(3)]        [Export("undoNestedGroup")]        public void UndoNestedGroup() { }                /// <summary>        /// Performs the operations in the last group on the redo stack, if there are any, recording them on the undo stack as a single group.        /// </summary>        [iOSVersion(3)]        [Export("redo")]        public void Redo() { }                /// <summary>        /// Sets or returns the maximum number of top-level undo groups the receiver holds.        /// </summary>        /// <param name="anint">The maximum number of undo groups. A limit of 0 indicates no limit, so that old undo groups are never dropped.</param>        [iOSVersion(3)]        [Export("levelsOfUndo")]        public int LevelsOfUndo { get; set; }                /// <summary>        /// Marks the beginning of an undo group.        /// </summary>        [iOSVersion(3)]        [Export("beginUndoGrouping")]        public void BeginUndoGrouping() { }                /// <summary>        /// Marks the end of an undo group.        /// </summary>        [iOSVersion(3)]        [Export("endUndoGrouping")]        public void EndUndoGrouping() { }                /// <summary>        /// Returns or sets a Boolean value that indicates whether the receiver automatically creates undo groups around each pass of the run loop.        /// </summary>        /// <returns>true if the receiver automatically creates undo groups around each pass of the run loop, otherwise false.</returns>        [iOSVersion(3)]        [Export("groupsByEvent")]        public bool GroupsByEvent { get; set; }                /// <summary>        /// Returns the number of nested undo groups (or redo groups, if Redo was invoked last) in the current event loop.        /// </summary>        /// <returns>An integer indicating the number of nested groups. If 0 is returned, there is no open undo or redo group.</returns>        [iOSVersion(3)]        [Export("groupingLevel")]        public int GroupingLevel { get; private set; }                /// <summary>        /// Disables the recording of undo operations, whether by registerUndoWithTarget:selector:object: or by invocation-based undo.        /// </summary>        [iOSVersion(3)]        [Export("disableUndoRegistration")]        public void DisableUndoRegistration() { }                /// <summary>        /// Enables the recording of undo operations.        /// </summary>        [iOSVersion(3)]        [Export("enableUndoRegistration")]        public void EnableUndoRegistration() { }                /// <summary>        /// Clears the undo and redo stacks and re-enables the receiver.        /// </summary>        [iOSVersion(3)]        [Export("removeAllActions")]        public void RemoveAllActions() { }                /// <summary>        /// Clears the undo and redo stacks of all operations involving the specified target as the recipient of the undo message.        /// </summary>        /// <param name="target">The recipient of the undo messages to be removed.</param>        [iOSVersion(3)]        [Export("removeAllActionsWithTarget")]        public void RemoveAllActionsWithTarget(AnyObject target) { }                /// <summary>        /// Sets the name of the action associated with the Undo or Redo command.        /// </summary>        /// <param name="actionName">The name of the action.</param>        [iOSVersion(3)]        [Export("setActionName")]        public void SetActionName(string actionName) { }                /// <summary>        /// Returns the name identifying the redo action.        /// </summary>        /// <returns>The redo action name. Returns an empty string (@&quot;&quot;) if no action name has been assigned or if there is nothing to redo.</returns>        [iOSVersion(3)]        [Export("redoActionName")]        public string RedoActionName { get; private set; }                /// <summary>        /// Returns the name identifying the undo action.        /// </summary>        /// <returns>The undo action name. Returns an empty string (@&quot;&quot;) if no action name has been assigned or if there is nothing to undo.</returns>        [iOSVersion(3)]        [Export("undoActionName")]        public string UndoActionName { get; private set; }                /// <summary>        /// Returns the complete title of the Redo menu command, for example, “Redo Paste.”        /// </summary>        /// <returns>The menu item title.</returns>        [iOSVersion(3)]        [Export("redoMenuItemTitle")]        public string RedoMenuItemTitle { get; private set; }                /// <summary>        /// Returns the complete title of the Undo menu command, for example, “Undo Paste.”        /// </summary>        /// <returns>The menu item title.</returns>        [iOSVersion(3)]        [Export("undoMenuItemTitle")]        public string UndoMenuItemTitle { get; private set; }                /// <summary>        /// Returns the complete, localized title of the Redo menu command for the action identified by the given name.        /// </summary>        /// <param name="actionName">The name of the undo action.</param>        /// <returns>The localized title of the redo menu item.</returns>        [iOSVersion(3)]        [Export("redoMenuTitleForUndoActionName")]        public string RedoMenuTitleForUndoActionName(string actionName) { return ""; }                /// <summary>        /// Returns the complete, localized title of the Undo menu command for the action identified by the given name.        /// </summary>        /// <param name="actionName">The name of the undo action.</param>        /// <returns>The localized title of the undo menu item.</returns>        [iOSVersion(3)]        [Export("undoMenuTitleForUndoActionName")]        public string UndoMenuTitleForUndoActionName(string actionName) { return ""; }                /// <summary>        /// Returns or sets the modes governing the types of input handled during a cycle of the run loop.        /// </summary>        /// <returns>An array of string constants specifying the current run-loop modes.</returns>        [iOSVersion(3)]        [Export("runLoopModes")]        public AnyObject[] RunLoopModes { get; set; }                /// <summary>        /// Sets whether the next undo or redo action is discardable.        /// </summary>        /// <param name="discardable">Specifies if the action is discardable. true if the next undo or redo action can be discarded; false otherwise.</param>        [iOSVersion(5)]        [Export("setActionIsDiscardable")]        public void SetActionIsDiscardable(bool discardable) { }                /// <summary>        /// Returns whether the next undo action is discardable.        /// </summary>        /// <returns>true if the action is discardable; false otherwise.</returns>        [iOSVersion(5)]        [Export("undoActionIsDiscardable")]        public bool UndoActionIsDiscardable { get; private set; }                /// <summary>        /// Returns whether the next redo action is discardable.        /// </summary>        /// <returns>true if the action is discardable; false otherwise.</returns>        [iOSVersion(5)]        [Export("redoActionIsDiscardable")]        public bool RedoActionIsDiscardable { get; private set; }                /// <summary>        /// NSUndoManager provides this constant as a convenience; you can use it to compare to values returned by some NSUndoManager methods.        /// </summary>        [Export("NSUndoCloseGroupingRunLoopOrdering")]        public int NSUndoCloseGroupingRunLoopOrdering { get; private set; }                //TODO: notifications    }

    /// <summary>
    /// Posted whenever an NSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerCheckpointNotification : NSNotification
    {
        public NSUndoManagerCheckpointNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted whenever an NSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerDidOpenUndoGroupNotification : NSNotification
    {
        public NSUndoManagerDidOpenUndoGroupNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted just after an NSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerDidRedoChangeNotification : NSNotification
    {
        public NSUndoManagerDidRedoChangeNotification() : base("", null) { }
    }


    /// <summary>
    /// Posted just after an undoundoNestedGroupNSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerDidUndoChangeNotification : NSNotification
    {
        public NSUndoManagerDidUndoChangeNotification() : base("", null) { }
    }


    /// <summary>
    /// Posted before an NSUndoManageruserInfoNSNumber
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerWillCloseUndoGroupNotification : NSNotification
    {
        public NSUndoManagerWillCloseUndoGroupNotification() : base("", null) { }
    }



    /// <summary>
    /// Posted after an NSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerDidCloseUndoGroupNotification : NSNotification
    {
        public NSUndoManagerDidCloseUndoGroupNotification() : base("", null) { }
    }

    /// <summary>
    /// Posted just before an NSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerWillRedoChangeNotification : NSNotification
    {
        public NSUndoManagerWillRedoChangeNotification() : base("", null) { }
    }
    

    /// <summary>
    /// Posted just before an undoundoNestedGroupNSUndoManageruserInfo
    /// </summary>
    [iOSVersion(3)]
    public class NSUndoManagerWillUndoChangeNotification : NSNotification
    {
        public NSUndoManagerWillUndoChangeNotification() : base("", null) { }
    }}