using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A constraint defines a relationship between two attributes of user interface objects that must be satisfied by the constraint-based layout system.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/AppKit/Reference/NSLayoutConstraint_Class/index.html#//apple_ref/occ/cl/NSLayoutConstraint"/>    [iOSVersion(6)]    public class NSLayoutConstraint : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Create constraints described by an ASCII art-like visual format string.        /// </summary>        /// <param name="format">The format specification for the constraints.</param>        /// <param name="options">Options describing the attribute and the direction of layout for all objects in the visual format string.</param>        /// <param name="metrics">A dictionary of constants that appear in the visual format string. The keys must be the string values used in the visual format string, and the values must be NSNumber objects.</param>        /// <param name="views">A dictionary of views that appear in the visual format string. The keys must be the string values used in the visual format string, and the values must be the view objects.</param>        [iOSVersion(6)]        [Export("constraintsWithVisualFormat")]        public static AnyObject[] ConstraintsWithVisualFormat(string format, NSLayoutFormatOptions options, Dictionary<NSObject, AnyObject> metrics, Dictionary<NSObject, AnyObject> views) { return default(AnyObject[]); }                /// <summary>        /// Create a constraint of the form &quot;view1.attr1 <relation> view2.attr2 * multiplier + constant&quot;.        /// </summary>        /// <param name="item">The view for the left-hand side of the constraint.</param>        /// <param name="attribute">The attribute of the view for the left-hand side of the constraint.</param>        /// <param name="relatedBy">The relationship between the left-hand side of the constraint and the right-hand side of the constraint.</param>        /// <param name="toItem">The view for the right-hand side of the constraint.</param>        /// <param name="attribute">The attribute of the view for the right-hand side of the constraint.</param>        /// <param name="multiplier">The constant multiplied with the attribute on the right-hand side of the constraint as part of getting the modified attribute.</param>        /// <param name="constant">The constant added to the multiplied attribute value on the right-hand side of the constraint to yield the final modified attribute.</param>        [iOSVersion(6)]        [Export("convenience init")]        [RenameParameter("leftAttribute", "attribute")]        [RenameParameter("rightAttribute", "attribute")]        public NSLayoutConstraint(AnyObject item, NSLayoutAttribute leftAttribute, NSLayoutRelation relatedBy, AnyObject toItem, NSLayoutAttribute rightAttribute, CGFloat multiplier, CGFloat constant) { }                /// <summary>        /// The priority of the constraint.        /// </summary>        [iOSVersion(6)]        [Export("priority")]        public UILayoutPriority Priority { get; set; }                /// <summary>        /// The first object participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("firstItem")]        public AnyObject FirstItem { get; private set; }                /// <summary>        /// The attribute of the first object participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("firstAttribute")]        public NSLayoutAttribute FirstAttribute { get; private set; }                /// <summary>        /// The relation between the two attributes in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("relation")]        public NSLayoutRelation Relation { get; private set; }                /// <summary>        /// The second object participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("secondItem")]        public AnyObject SecondItem { get; private set; }                /// <summary>        /// The attribute of the second object participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("secondAttribute")]        public NSLayoutAttribute SecondAttribute { get; private set; }                /// <summary>        /// The multiplier applied to the second attribute participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("multiplier")]        public CGFloat Multiplier { get; private set; }                /// <summary>        /// The constant added to the multiplied second attribute participating in the constraint.        /// </summary>        [iOSVersion(6)]        [Export("constant")]        public CGFloat Constant { get; set; }                /// <summary>        /// The name that identifies the constraint.        /// </summary>        [iOSVersion(7)]        [Export("identifier")]        public string Identifier { get; set; }                /// <summary>        /// Determines whether the constraint should be archived by its owning view.        /// </summary>        [iOSVersion(6)]        [Export("shouldBeArchived")]        public bool ShouldBeArchived { get; set; }    }    /// <summary>    /// Describes the relation between the first attribute and the modified second attribute in a constraint.    /// </summary>    [iOSVersion(6)]    public enum NSLayoutRelation    {        /// <summary>        /// The constraint requires that the first attribute be less than or equal to the modified second attribute.        /// </summary>        [iOSVersion(6)]        LessThanOrEqual,        /// <summary>        /// The constraint requires that the first attribute be exactly equal to the modified second attribute.        /// </summary>        [iOSVersion(6)]        Equal,        /// <summary>        /// The constraint requires that the first attribute by greater than or equal to the modified second attribute.        /// </summary>        [iOSVersion(6)]        GreaterThanOrEqual,    }    /// <summary>    /// Layout attributes are used to specify the part of the object’s visual representation that should be used to get the value for the constraint.    /// </summary>    [iOSVersion(6)]    public enum NSLayoutAttribute    {        /// <summary>        /// The left side of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Left,        /// <summary>        /// The right side of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Right,        /// <summary>        /// The top of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Top,        /// <summary>        /// The bottom of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Bottom,        /// <summary>        /// The leading edge of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Leading,        /// <summary>        /// The trailing edge of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Trailing,        /// <summary>        /// The width of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Width,        /// <summary>        /// The height of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        Height,        /// <summary>        /// The center along the x-axis of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        CenterX,        /// <summary>        /// The center along the y-axis of the object’s alignment rectangle.        /// </summary>        [iOSVersion(6)]        CenterY,        /// <summary>        /// The object’s baseline.        /// </summary>        [iOSVersion(6)]        Baseline,        /// <summary>        ///         /// </summary>        FirstBaseline,        /// <summary>        ///         /// </summary>        LeftMargin,        /// <summary>        ///         /// </summary>        RightMargin,        /// <summary>        ///         /// </summary>        TopMargin,        /// <summary>        ///         /// </summary>        BottomMargin,        /// <summary>        ///         /// </summary>        LeadingMargin,        /// <summary>        ///         /// </summary>        TrailingMargin,        /// <summary>        ///         /// </summary>        CenterXWithinMargins,        /// <summary>        ///         /// </summary>        CenterYWithinMargins,        /// <summary>        /// The requested attribute does not exist. This result would be returned if you asked a constraint with no second object for the attribute of its second object.        /// </summary>        [iOSVersion(6)]        NotAnAttribute,    }    /// <summary>    /// A bit mask that specifies both a part of an interface element to align and a direction for the alignment between two interface elements.    /// </summary>    [iOSVersion(6)]    public enum NSLayoutFormatOptions    {        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeLeft on each.        /// </summary>        [iOSVersion(6)]        AlignAllLeft,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeRight on each.        /// </summary>        [iOSVersion(6)]        AlignAllRight,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeTop on each.        /// </summary>        [iOSVersion(6)]        AlignAllTop,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeBottom on each.        /// </summary>        [iOSVersion(6)]        AlignAllBottom,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeLeading on each.        /// </summary>        [iOSVersion(6)]        AlignAllLeading,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeTrailing on each.        /// </summary>        [iOSVersion(6)]        AlignAllTrailing,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeCenterX on each.        /// </summary>        [iOSVersion(6)]        AlignAllCenterX,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeCenterY on each.        /// </summary>        [iOSVersion(6)]        AlignAllCenterY,        /// <summary>        /// Align all specified interface elements using NSLayoutAttributeBaseline on each.        /// </summary>        [iOSVersion(6)]        AlignAllBaseline,        /// <summary>        ///         /// </summary>        AlignAllLastBaseline,        /// <summary>        ///         /// </summary>        AlignAllFirstBaseline,        /// <summary>        /// Bit mask that can be combined with a NSLayoutFormatOptions variable to yield only the alignment portion of the format options.        /// </summary>        [iOSVersion(6)]        AlignmentMask,        /// <summary>        /// Arrange objects in order based on the normal text flow for the current user interface language. In English this results in the first object being placed farthest to the left, the next one to its right, and so on. In right to left languages this ordering is reversed.        /// </summary>        [iOSVersion(6)]        DirectionLeadingToTrailing,        /// <summary>        /// Arrange objects in order from left to right.        /// </summary>        [iOSVersion(6)]        DirectionLeftToRight,        /// <summary>        /// Arrange objects in order from right to left.        /// </summary>        [iOSVersion(6)]        DirectionRightToLeft,        /// <summary>        /// Bit mask that can be combined with a NSLayoutFormatOptions variable to yield only the direction portion of the format options.        /// </summary>        [iOSVersion(6)]        DirectionMask,    }    /// <summary>    /// The layout priority is used to indicate to the constraint-based layout system which constraints are more important, allowing the system to make appropriate tradeoffs when satisfying the constraints of the system as a whole.    /// </summary>    [iOSVersion(6)]    public struct UILayoutPriority    {        static public implicit operator UILayoutPriority(float value)        {            return default(UILayoutPriority);        }        static public implicit operator float(UILayoutPriority value)        {            return default(float);        }    }}