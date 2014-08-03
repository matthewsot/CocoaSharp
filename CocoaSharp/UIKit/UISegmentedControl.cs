using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UISegmentedControl object is a horizontal control made of multiple segments, each segment functioning as a discrete button. A segmented control affords a compact means to group together a number of controls.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISegmentedControl_Class/index.html#//apple_ref/occ/cl/UISegmentedControl"/>    [iOSVersion(2)]    public class UISegmentedControl : UIControl//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Initializes and returns a segmented control with segments having the given titles or images.        /// </summary>        /// <param name="items">An array of NSString objects (for segment titles) or UIImage objects (for segment images).</param>        [iOSVersion(2)]        public UISegmentedControl(AnyObject[] items) { }                /// <summary>        /// Sets the content of a segment to a given image.        /// </summary>        /// <param name="image">An image object to display in the segment. .</param>        /// <param name="forSegmentAtIndex">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("setImage")]        public void SetImage(UIImage image, int forSegmentAtIndex) {  }                /// <summary>        /// Returns the image for a specific segment        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("imageForSegmentAtIndex")]        public UIImage ImageForSegmentAtIndex(int segment) { return default(UIImage); }                /// <summary>        /// Sets the title of a segment.        /// </summary>        /// <param name="title">A string to display in the segment as its title.</param>        /// <param name="forSegmentAtIndex">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("setTitle")]        public void SetTitle(string title, int forSegmentAtIndex) {  }                /// <summary>        /// Returns the title of the specified segment.        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("titleForSegmentAtIndex")]        public string TitleForSegmentAtIndex(int segment) { return default(string); }                /// <summary>        /// Inserts a segment at a specified position in the receiver and gives it an image as content.        /// </summary>        /// <param name="image">An image object to use as the content of the segment.</param>        /// <param name="atIndex">An index number identifying a segment in the control.        ///     segment must be a number in the range 0 to the number of segments (numberOfSegments) inclusive; values exceeding this upper range are pinned to it.        ///   The new segment is inserted just before the designated one.</param>        /// <param name="animated">true if the insertion of the new segment should be animated, otherwise false.</param>        [iOSVersion(2)]        [Export("insertSegmentWithImage")]        public void InsertSegmentWithImage(UIImage image, int atIndex, bool animated) {  }                /// <summary>        /// Inserts a segment at a specific position in the receiver and gives it a title as content.        /// </summary>        /// <param name="title">A string to use as the segment’s title.</param>        /// <param name="atIndex">An index number identifying a segment in the control.        ///     segment must be a number in the range 0 to the number of segments (numberOfSegments) inclusive; values exceeding this upper range are pinned to it.        ///   The new segment is inserted just before the designated one.</param>        /// <param name="animated">true if the insertion of the new segment should be animated, otherwise false.</param>        [iOSVersion(2)]        [Export("insertSegmentWithTitle")]        public void InsertSegmentWithTitle(string title, int atIndex, bool animated) {  }                /// <summary>        /// Removes all segments of the receiver        /// </summary>        [iOSVersion(2)]        [Export("removeAllSegments")]        public void RemoveAllSegments() {  }                /// <summary>        /// Removes the specified segment from the receiver, optionally animating the transition.        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        /// <param name="animated">true if the removal of the new segment should be animated, otherwise false.</param>        [iOSVersion(2)]        [Export("removeSegmentAtIndex")]        public void RemoveSegmentAtIndex(int segment, bool animated) {  }                /// <summary>        /// Enables the specified segment.        /// </summary>        /// <param name="enabled">true to enable the specified segment or false to disable the segment. By default, segments are enabled.</param>        /// <param name="forSegmentAtIndex">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("setEnabled")]        public void SetEnabled(bool enabled, int forSegmentAtIndex) {  }                /// <summary>        /// Returns whether the indicated segment is enabled.        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("isEnabledForSegmentAtIndex")]        public bool IsEnabledForSegmentAtIndex(int segment) { return default(bool); }                /// <summary>        /// Adjusts the offset for drawing the content (image or text) of the specified segment.        /// </summary>        /// <param name="offset">The offset (specified as a CGSize type) from the origin of the segment at which to draw the segment’s content.  The default offset is (0,0).</param>        /// <param name="forSegmentAtIndex">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("setContentOffset")]        public void SetContentOffset(CGSize offset, int forSegmentAtIndex) {  }                /// <summary>        /// Returns the offset for drawing the content (image or text) of the specified segment.        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("contentOffsetForSegmentAtIndex")]        public CGSize ContentOffsetForSegmentAtIndex(int segment) { return default(CGSize); }                /// <summary>        /// Sets the width of the specified segment of the receiver.        /// </summary>        /// <param name="width">A float value specifying the width of the segment. The default value is {0.0}, which tells UISegmentedControl to automatically size the segment.</param>        /// <param name="forSegmentAtIndex">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("setWidth")]        public void SetWidth(CGFloat width, int forSegmentAtIndex) {  }                /// <summary>        /// Returns the width of the indicated segment of the receiver.        /// </summary>        /// <param name="segment">An index number identifying a segment in the control. It must be a number between 0 and the number of segments (numberOfSegments) minus 1; values exceeding this upper range are pinned to it.</param>        [iOSVersion(2)]        [Export("widthForSegmentAtIndex")]        public CGFloat WidthForSegmentAtIndex(int segment) { return default(CGFloat); }                /// <summary>        /// Returns the background image for a given state and bar metrics.        /// </summary>        /// <param name="state">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("backgroundImageForState")]        public UIImage BackgroundImageForState(UIControlState state, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the background image for a given state and bar metrics.        /// </summary>        /// <param name="backgroundImage">The background image to use for state and barMetrics.</param>        /// <param name="forState">A control state.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIControlState forState, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the positioning offset for a given segment and bar metrics.        /// </summary>        /// <param name="leftCenterRightOrAlone">An identifier for a segment.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("contentPositionAdjustmentForSegmentType")]        public UIOffset ContentPositionAdjustmentForSegmentType(UISegmentedControlSegment leftCenterRightOrAlone, UIBarMetrics barMetrics) { return default(UIOffset); }                /// <summary>        /// Returns the content positioning offset for a given segment and bar metrics.        /// </summary>        /// <param name="adjustment">The positioning offset for the segment identified by leftCenterRightOrAlone and barMetrics.</param>        /// <param name="forSegmentType">An identifier for a segment type.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setContentPositionAdjustment")]        public void SetContentPositionAdjustment(UIOffset adjustment, UISegmentedControlSegment forSegmentType, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the divider image used for a given combination of left and right segment states and bar metrics.        /// </summary>        /// <param name="leftState">The state of the left segment.</param>        /// <param name="rightSegmentState">The state of the right segment.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("dividerImageForLeftSegmentState")]        public UIImage DividerImageForLeftSegmentState(UIControlState leftState, UIControlState rightSegmentState, UIBarMetrics barMetrics) { return default(UIImage); }                /// <summary>        /// Sets the divider image used for a given combination of left and right segment states and bar metrics.        /// </summary>        /// <param name="dividerImage">The divider image to use.</param>        /// <param name="forLeftSegmentState">The state of the left segment.</param>        /// <param name="rightSegmentState">The state of the right segment.</param>        /// <param name="barMetrics">Bar metrics.</param>        [iOSVersion(5)]        [Export("setDividerImage")]        public void SetDividerImage(UIImage dividerImage, UIControlState forLeftSegmentState, UIControlState rightSegmentState, UIBarMetrics barMetrics) {  }                /// <summary>        /// Returns the text attributes of the title for a given control state.        /// </summary>        /// <param name="state">A control state.</param>        [iOSVersion(5)]        [Export("titleTextAttributesForState")]        public Dictionary<NSObject, AnyObject> TitleTextAttributesForState(UIControlState state) { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Sets the text attributes of the title for a given control state.        /// </summary>        /// <param name="attributes">The text attributes of the title for state.</param>        /// <param name="forState">A control state.</param>        [iOSVersion(5)]        [Export("setTitleTextAttributes")]        public void SetTitleTextAttributes(Dictionary<NSObject, AnyObject> attributes, UIControlState forState) {  }                /// <summary>        /// Returns the number of segments the receiver has. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("numberOfSegments")]        public int NumberOfSegments { get; private set; }                /// <summary>        /// The index number identifying the selected segment (that is, the last segment touched).        /// </summary>        [iOSVersion(2)]        [Export("selectedSegmentIndex")]        public int SelectedSegmentIndex { get; set; }                /// <summary>        /// A Boolean value that determines whether segments in the receiver show selected state.        /// </summary>        [iOSVersion(2)]        [Export("momentary")]        public bool Momentary { get; set; }                /// <summary>        /// Indicates whether the control attempts to adjust segment widths based on their content widths.        /// </summary>        [iOSVersion(5)]        [Export("apportionsSegmentWidthsByContent")]        public bool ApportionsSegmentWidthsByContent { get; set; }                /// <summary>        /// The tint color of the segmented control.        /// </summary>        [iOSVersion(2)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// A constant for indicating that no segment is selected.        /// </summary>        public int UISegmentedControlNoSegment { get; set; }    }    /// <summary>    /// Constants for specifying a segment in a control    /// </summary>    [iOSVersion(5)]    public enum UISegmentedControlSegment    {        /// <summary>        /// Specifies any segment.        /// </summary>        [iOSVersion(5)]        Any,        /// <summary>        /// The capped, leftmost segment.        /// Only applies when numSegments > 1.        /// </summary>        [iOSVersion(5)]        Left,        /// <summary>        /// Any segment between the left and rightmost segments.        /// Only applies when numSegments > 2.        /// </summary>        [iOSVersion(5)]        Center,        /// <summary>        /// The capped,rightmost segment. .        /// Only applies when numSegments > 1.        /// </summary>        [iOSVersion(5)]        Right,        /// <summary>        /// The standalone segment, capped on both ends.        /// Only applies when numSegments = 1.        /// </summary>        [iOSVersion(5)]        Alone,    }}