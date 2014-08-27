using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// Classes that adopt the UITextInput protocol (and conform with inherited protocols) interact with the text input system and thus acquire features such as autocorrection and multistage text input for their documents.  (Multistage text input is required when the language is ideographic and the keyboard is phonetic.)    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextInput_Protocol/index.html#//apple_ref/occ/intf/UITextInput"/>    [iOSVersion(3.2)]    public interface UITextInput//: NSObjectProtocol, UIKeyInput, UITextInputTraits    {        /// <summary>        /// Return the text in the specified range. (required)        /// </summary>        /// <param name="range">A range of text in a document.</param>        [iOSVersion(3.2)]        [Export("textInRange")]        string TextInRange(UITextRange range);                /// <summary>        /// Replace the text in a document that is in the specified range. (required)        /// </summary>        /// <param name="range">A range of text in a document.</param>        /// <param name="withText">A string to replace the text in range.</param>        [iOSVersion(3.2)]        [Export("replaceRange")]        void ReplaceRange(UITextRange range, string withText);                /// <summary>        /// Asks whether the text in the specified range should be replaced.        /// </summary>        /// <param name="range">A range of text in a document.</param>        /// <param name="replacementText">The proposed text to replace the text in range.</param>        [iOSVersion(6)]        [Export("shouldChangeTextInRange")]        bool ShouldChangeTextInRange(UITextRange range, string replacementText);                /// <summary>        /// Insert the provided text and marks it to indicate that it is part of an active input session. (required)        /// </summary>        /// <param name="markedText">The text to be marked.</param>        /// <param name="selectedRange">A range within markedText that indicates the current selection. This range is always relative to markedText.</param>        [iOSVersion(3.2)]        [Export("setMarkedText")]        void SetMarkedText(string markedText, NSRange selectedRange);                /// <summary>        /// Unmark the currently marked text. (required)        /// </summary>        [iOSVersion(3.2)]        [Export("unmarkText")]        void UnmarkText();                /// <summary>        /// Return the range between two text positions. (required)        /// </summary>        /// <param name="fromPosition">An object that represents a location in a document.</param>        /// <param name="toPosition">An object that represents another location in a document.</param>        [iOSVersion(3.2)]        [Export("textRangeFromPosition")]        UITextRange TextRangeFromPosition(UITextPosition fromPosition, UITextPosition toPosition);                /// <summary>        /// Returns the text position at a given offset from another text position. (required)        /// </summary>        /// <param name="position">A custom UITextPosition object that represents a location in a document.</param>        /// <param name="offset">A character offset from position. It can be a positive or negative value.</param>        [iOSVersion(3.2)]        [Export("positionFromPosition")]        UITextPosition PositionFromPosition(UITextPosition position, int offset);                /// <summary>        /// Returns the text position at a given offset in a specified direction from another text position. (required)        /// </summary>        /// <param name="position">A custom UITextPosition object that represents a location in a document.</param>        /// <param name="inDirection">A UITextLayoutDirection constant that represents the direction of the offset from position. Return nil if the computed text position is less than 0 or greater than the length of the backing string.</param>        /// <param name="offset">A character offset from position.</param>        [iOSVersion(3.2)]        [Export("positionFromPosition")]        UITextPosition PositionFromPosition(UITextPosition position, UITextLayoutDirection inDirection, int offset);                /// <summary>        /// Return how one text position compares to another text position. (required)        /// </summary>        /// <param name="position">A custom object that represents a location within a document.</param>        /// <param name="toPosition">A custom object that represents another location within a document.</param>        [iOSVersion(3.2)]        [Export("comparePosition")]        NSComparisonResult ComparePosition(UITextPosition position, UITextPosition toPosition);                /// <summary>        /// Return the number of visible characters between one text position and another text position. (required)        /// </summary>        /// <param name="fromPosition">A custom object that represents a location within a document.</param>        /// <param name="toPosition">A custom object that represents another location within document.</param>        [iOSVersion(3.2)]        [Export("offsetFromPosition")]        int OffsetFromPosition(UITextPosition fromPosition, UITextPosition toPosition);                /// <summary>        /// Return the text position that is at the farthest extent in a given layout direction within a range of text. (required)        /// </summary>        /// <param name="range">A text-range object that demarcates a range of text in a document.</param>        /// <param name="farthestInDirection">A constant that indicates a direction of layout (right, left, up, down).</param>        [iOSVersion(3.2)]        [Export("positionWithinRange")]        UITextPosition PositionWithinRange(UITextRange range, UITextLayoutDirection farthestInDirection);                /// <summary>        /// Return a text range from a given text position to its farthest extent in a certain direction of layout. (required)        /// </summary>        /// <param name="position">A text-position object that identifies a location in a document.</param>        /// <param name="inDirection">A constant that indicates a direction of layout (right, left, up, down).</param>        [iOSVersion(3.2)]        [Export("characterRangeByExtendingPosition")]        UITextRange CharacterRangeByExtendingPosition(UITextPosition position, UITextLayoutDirection inDirection);                /// <summary>        /// Return the base writing direction for a position in the text going in a certain direction. (required)        /// </summary>        /// <param name="position">An object that identifies a location in a document.</param>        /// <param name="inDirection">A constant that indicates a direction of storage (forward or backward).</param>        [iOSVersion(3.2)]        [Export("baseWritingDirectionForPosition")]        UITextWritingDirection BaseWritingDirectionForPosition(UITextPosition position, UITextStorageDirection inDirection);                /// <summary>        /// Set the base writing direction for a given range of text in a document. (required)        /// </summary>        /// <param name="writingDirection">A constant that represents a writing direction (for example, left-to-right or right-to-left)</param>        /// <param name="forRange">An object that represents a range of text in a document.</param>        [iOSVersion(3.2)]        [Export("setBaseWritingDirection")]        void SetBaseWritingDirection(UITextWritingDirection writingDirection, UITextRange forRange);                /// <summary>        /// Return the first rectangle that encloses a range of text in a document. (required)        /// </summary>        /// <param name="range">An object that represents a range of text in a document.</param>        [iOSVersion(3.2)]        [Export("firstRectForRange")]        CGRect FirstRectForRange(UITextRange range);                /// <summary>        /// Return a rectangle used to draw the caret at a given insertion point. (required)        /// </summary>        /// <param name="position">An object that identifies a location in a document.</param>        [iOSVersion(3.2)]        [Export("caretRectForPosition")]        CGRect CaretRectForPosition(UITextPosition position);                /// <summary>        /// Return the position in a document that is closest to a specified point. (required)        /// </summary>        /// <param name="point">A point in the view that is drawing a document’s text.</param>        [iOSVersion(3.2)]        [Export("closestPositionToPoint")]        UITextPosition ClosestPositionToPoint(CGPoint point);                /// <summary>        /// Returns an array of selection rects corresponding to the range of text. (required)        /// </summary>        /// <param name="range">An object representing a range in a document’s text.</param>        [iOSVersion(6)]        [Export("selectionRectsForRange")]        AnyObject[] SelectionRectsForRange(UITextRange range);                /// <summary>        /// Return the position in a document that is closest to a specified point in a given range. (required)        /// </summary>        /// <param name="point">A point in the view that is drawing a document’s text.</param>        /// <param name="withinRange">An object representing a range in a document’s text.</param>        [iOSVersion(3.2)]        [Export("closestPositionToPoint")]        UITextPosition ClosestPositionToPoint(CGPoint point, UITextRange withinRange);                /// <summary>        /// Return the character or range of characters that is at a given point in a document. (required)        /// </summary>        /// <param name="point">A point in the view that is drawing a document’s text.</param>        [iOSVersion(3.2)]        [Export("characterRangeAtPoint")]        UITextRange CharacterRangeAtPoint(CGPoint point);                /// <summary>        /// Called when there is a pending dictation result.        /// </summary>        [iOSVersion(5.1)]        [Export("dictationRecordingDidEnd")]        void DictationRecordingDidEnd();                /// <summary>        /// Called when dictation ended but recognition failed.        /// </summary>        [iOSVersion(5.1)]        [Export("dictationRecognitionFailed")]        void DictationRecognitionFailed();                /// <summary>        /// Called when there is more than one interpretation of a spoken phrase in a dictation result.        /// </summary>        /// <param name="dictationResult">An array of UIDictationPhrase objects.</param>        [iOSVersion(5.1)]        [Export("insertDictationResult")]        void InsertDictationResult(AnyObject[] dictationResult);                /// <summary>        /// Asks for the placeholder object to use while dictation results are being generated.        /// </summary>        [iOSVersion(6)]        [Export("insertDictationResultPlaceholder")]        AnyObject InsertDictationResultPlaceholder();                /// <summary>        /// Asks for the rectangle in which to display the dictation placeholder animation.        /// </summary>        /// <param name="placeholder">A placeholder object provided by your app and used to identify the location of the dictation results.</param>        [iOSVersion(6)]        [Export("frameForDictationResultPlaceholder")]        CGRect FrameForDictationResultPlaceholder(AnyObject placeholder);                /// <summary>        /// Tells the view that the specified placeholder object is no longer needed.        /// </summary>        /// <param name="placeholder">The placeholder object that is no longer needed.</param>        /// <param name="willInsertResult">The value of this parameter is true if the dictation value was generated successfully or false if an error occurred.</param>        [iOSVersion(6)]        [Export("removeDictationResultPlaceholder")]        void RemoveDictationResultPlaceholder(AnyObject placeholder, bool willInsertResult);                /// <summary>        /// Return a dictionary with properties that specify how text is to be style at a certain location in a document.        /// </summary>        /// <param name="position">An object that indicates a location in the text of a document.</param>        /// <param name="inDirection">The direction of the styling attributes in text storage.</param>        [iOSVersion(3.2)]        [Export("textStylingAtPosition")]        Dictionary<NSObject, AnyObject> TextStylingAtPosition(UITextPosition position, UITextStorageDirection inDirection);                /// <summary>        /// Return the position within a range of a document’s text that corresponds to the character offset from the start of that range.        /// </summary>        /// <param name="range">An object that specifies a range of text in a document.</param>        /// <param name="atCharacterOffset">A character offset from the start of range.</param>        [iOSVersion(3.2)]        [Export("positionWithinRange")]        UITextPosition PositionWithinRange(UITextRange range, int atCharacterOffset);                /// <summary>        /// Return the character offset of a position in a document’s text that falls within a given range.        /// </summary>        /// <param name="position">An object that identifies a location in a document’s text.</param>        /// <param name="withinRange">An object that specifies a range of text in a document.</param>        [iOSVersion(3.2)]        [Export("characterOffsetOfPosition")]        int CharacterOffsetOfPosition(UITextPosition position, UITextRange withinRange);                /// <summary>        /// The range of selected text in a document. (required)        /// </summary>        [iOSVersion(3.2)]        [Export("selectedTextRange")]        UITextRange SelectedTextRange { get; set; }                /// <summary>        /// The range of text that is currently marked in a document. (required) (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("markedTextRange")]        UITextRange MarkedTextRange { get; }                /// <summary>        /// A dictionary of attributes that describes how marked text should be drawn. (required)        /// </summary>        [iOSVersion(3.2)]        [Export("markedTextStyle")]        Dictionary<NSObject, AnyObject> MarkedTextStyle { get; set; }                /// <summary>        /// The desired location for the insertion point.        /// </summary>        [iOSVersion(3.2)]        [Export("selectionAffinity")]        UITextStorageDirection SelectionAffinity { get; set; }                /// <summary>        /// The text position for the beginning of a document. (required) (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("beginningOfDocument")]        UITextPosition BeginningOfDocument { get; }                /// <summary>        /// The text position for the end of a document. (required) (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("endOfDocument")]        UITextPosition EndOfDocument { get; }                /// <summary>        /// An input delegate that is notified when text changes or when the selection changes. (required)        /// </summary>        [iOSVersion(3.2)]        [Export("inputDelegate")]        UITextInputDelegate InputDelegate { get; set; }                /// <summary>        /// An input tokenizer that provides information about the granularity of text units. (required) (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("tokenizer")]        UITextInputTokenizer Tokenizer { get; }                /// <summary>        /// An affiliated view that provides a coordinate system for all geometric values in this protocol. (read-only)        /// </summary>        [iOSVersion(3.2)]        [Export("textInputView")]        UIView TextInputView { get; }    }    /// <summary>    /// The direction of text storage.    /// </summary>    [iOSVersion(3.2)]    public enum UITextStorageDirection    {        /// <summary>        /// Storage of the text in a forward direction.        /// </summary>        [iOSVersion(3.2)]        Forward,        /// <summary>        /// Storage of the text in a backward direction.        /// </summary>        [iOSVersion(3.2)]        Backward,    }    /// <summary>    /// The direction of text layout.    /// </summary>    [iOSVersion(3.2)]    public enum UITextLayoutDirection    {        /// <summary>        /// Layout of the text to the right.        /// </summary>        [iOSVersion(3.2)]        Right,        /// <summary>        /// Layout of the text to the left.        /// </summary>        [iOSVersion(3.2)]        Left,        /// <summary>        /// Layout of the text in an upward direction.        /// </summary>        [iOSVersion(3.2)]        Up,        /// <summary>        /// Layout of the text in a downward direction.        /// </summary>        [iOSVersion(3.2)]        Down,    }    /// <summary>    /// The writing direction of the text, based on language.    /// </summary>    [iOSVersion(3.2)]    public enum UITextWritingDirection    {        /// <summary>        /// The natural writing direction as defined by the Bidi algorithm.        /// </summary>        [iOSVersion(3.2)]        Natural,        /// <summary>        /// Writing that goes from left to right.        /// </summary>        [iOSVersion(3.2)]        LeftToRight,        /// <summary>        /// Writing that goes from right to left.        /// </summary>        [iOSVersion(3.2)]        RightToLeft,    }}