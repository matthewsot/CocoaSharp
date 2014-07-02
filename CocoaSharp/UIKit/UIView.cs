using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIView_Class/index.html#//apple_ref/occ/cl/UIView    /// <summary>    /// The UIView class defines a rectangular area on the screen and the interfaces for managing the content in that area. At runtime, a view object handles the rendering of any content in its area and also handles any interactions with that content. The UIView class itself provides basic behavior for filling its rectangular area with a background color. More sophisticated content can be presented by subclassing UIView and implementing the necessary drawing and event-handling code yourself. The UIKit framework also includes a set of standard subclasses that range from simple buttons to complex tables and can be used as-is. For example, a UILabel object draws a text string and a UIImageView object draws an image.    /// </summary>    [iOSVersion(2)]    public class UIView : UIResponder    {        /// <summary>        /// Initializes and returns a newly allocated view object with the specified frame rectangle.        /// </summary>        /// <param name="frame">The frame rectangle for the view, measured in points. The origin of the frame is relative to the superview in which you plan to add it. This method uses the frame rectangle to set the center and bounds properties accordingly.</param>        /// <returns>An initialized view object or nil if the object couldn't be created.</returns>        [iOSVersion(2)]        public UIView(CGRect frame) { }                /// <summary>        /// The view’s background color.        /// </summary>        [iOSVersion(2)]        [Export("backgroundColor")]        public UIColor BackgroundColor { get; set; }                /// <summary>        /// A Boolean value that determines whether the view is hidden.        /// </summary>        [iOSVersion(2)]        [Export("hidden")]        public bool Hidden { get; set; }                /// <summary>        /// The view’s alpha value.        /// </summary>        [iOSVersion(2)]        [Export("alpha")]        public CGFloat Alpha { get; set; }                /// <summary>        /// A Boolean value that determines whether the view is opaque.        /// </summary>        [iOSVersion(2)]        [Export("opaque")]        public bool Opaque { get; set; }                /// <summary>        /// The first nondefault tint color value in the view’s hierarchy, ascending from and starting with the view itself.        /// </summary>        [iOSVersion(7)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// The first non-default tint adjustment mode value in the view’s hierarchy, ascending from and starting with the view itself.        /// </summary>        [iOSVersion(7)]        [Export("tintAdjustmentMode")]        public UIViewTintAdjustmentMode TintAdjustmentMode { get; set; }                /// <summary>        /// A Boolean value that determines whether subviews are confined to the bounds of the view.        /// </summary>        [iOSVersion(2)]        [Export("clipsToBounds")]        public bool ClipsToBounds { get; set; }                /// <summary>        /// A Boolean value that determines whether the view’s bounds should be automatically cleared before drawing.        /// </summary>        [iOSVersion(2)]        [Export("clearsContextBeforeDrawing")]        public bool ClearsContextBeforeDrawing { get; set; }                /// <summary>        /// An optional view whose alpha channel is used to mask a view’s content.        /// </summary>        [iOSVersion(8)]        [Export("maskView")]        public UIView MaskView { get; set; }                /// <summary>        /// Returns the class used to create the layer for instances of this class.        /// </summary>        /// <returns>The class used to create the view’s Core Animation layer.</returns>        [iOSVersion(2)]        [Export("layerClass")]        public static AnyClass LayerClass() { return null; }                /// <summary>        /// The view’s Core Animation layer used for rendering. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("layer")]        public CALayer Layer { get; private set; }                /// <summary>        /// A Boolean value that determines whether user events are ignored and removed from the event queue.        /// </summary>        [iOSVersion(2)]        [Export("userinteractionEnabled")]        public bool UserinteractionEnabled { get; set; }                /// <summary>        /// A Boolean value that indicates whether the receiver handles multi-touch events.        /// </summary>        [iOSVersion(2)]        [Export("multipleTouchEnabled")]        public bool MultipleTouchEnabled { get; set; }                /// <summary>        /// A Boolean value that indicates whether the receiver handles touch events exclusively.        /// </summary>        [iOSVersion(2)]        [Export("exclusiveTouch")]        public bool ExclusiveTouch { get; set; }                /// <summary>        /// The frame rectangle, which describes the view’s location and size in its superview’s coordinate system.        /// </summary>        [iOSVersion(2)]        [Export("frame")]        public CGRect Frame { get; set; }                /// <summary>        /// The receiver’s superview, or nil if it has none. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("superview")]        public UIView Superview { get; private set; }                /// <summary>        /// The receiver’s immediate subviews. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("subviews")]        public AnyObject[] Subviews { get; private set; }                /// <summary>        /// The receiver’s window object, or nil if it has none. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("window")]        public UIWindow Window { get; private set; }                /// <summary>        /// Adds a view to the end of the receiver’s list of subviews.        /// </summary>        /// <param name="view">The view to be added. After being added, this view appears on top of any other subviews.</param>        [iOSVersion(2)]        [Export("addSubview")]        public void AddSubview(UIView view) { }                /// <summary>        /// Moves the specified subview so that it appears on top of its siblings.        /// </summary>        /// <param name="view">The subview to move to the front.</param>        [iOSVersion(2)]        [Export("bringSubviewToFront")]        public void BringSubviewToFront(UIView view) { }                /// <summary>        /// Moves the specified subview so that it appears behind its siblings.        /// </summary>        /// <param name="view">The subview to move to the back.</param>        [iOSVersion(2)]        [Export("sendSubviewToBack")]        public void SendSubviewToBack(UIView view) { }                /// <summary>        /// Unlinks the view from its superview and its window, and removes it from the responder chain.        /// </summary>        [iOSVersion(2)]        [Export("removeFromSuperview")]        public void RemoveFromSuperview() { }                /// <summary>        /// Inserts a subview at the specified index.        /// </summary>        /// <param name="view">The view to insert. This value cannot be nil.</param>        /// <param name="atIndex">The index in the array of the subviews property at which to insert the view. Subview indices start at 0 and cannot be greater than the number of subviews.</param>        [iOSVersion(2)]        [Export("insertSubview")]        public void InsertSubview(UIView view, int atIndex) { }                /// <summary>        /// Inserts a view above another view in the view hierarchy.        /// </summary>        /// <param name="view">The view to insert. It’s removed from its superview if it’s not a sibling of siblingSubview.</param>        /// <param name="aboveSubview">The sibling view that will be behind the inserted view.</param>        [iOSVersion(2)]        [Export("insertSubview")]        public void InsertAboveSubview(UIView view, UIView aboveSubview) { }                /// <summary>        /// Inserts a view below another view in the view hierarchy.        /// </summary>        /// <param name="view">The view to insert below another view. It’s removed from its superview if it’s not a sibling of siblingSubview.</param>        /// <param name="belowSubview">The sibling view that will be above the inserted view.</param>        [iOSVersion(2)]        [Export("insertSubview")]        public void InsertBelowSubview(UIView view, UIView belowSubview) { }                /// <summary>        /// Exchanges the subviews at the specified indices.        /// </summary>        /// <param name="index1">The index of the first subview in the receiver.</param>        /// <param name="withSubviewAtIndex">The index of the second subview in the receiver.</param>        [iOSVersion(2)]        [Export("exchangeSubviewAtIndex")]        public void ExchangeSubviewAtIndex(int index1, int withSubviewAtIndex) { }                /// <summary>        /// Returns a Boolean value indicating whether the receiver is a subview of a given view or identical to that view.        /// </summary>        /// <param name="view">The view to test against the receiver’s view hierarchy.</param>        /// <returns>true if the receiver is an immediate or distant subview of view or if view is the receiver itself; otherwise false.</returns>        [iOSVersion(2)]        [Export("isDescendantOfView")]        public bool IsDescendantOfView(UIView view) { return false; }                /// <summary>        /// An integer bit mask that determines how the receiver resizes itself when its superview’s bounds change.        /// </summary>        [iOSVersion(2)]        [Export("autoresizingMask")]        public UIViewAutoresizing AutoresizingMask { get; set; }                /// <summary>        /// A Boolean value that determines whether the receiver automatically resizes its subviews when its bounds change.        /// </summary>        [iOSVersion(2)]        [Export("autoresizesSubviews")]        public bool AutoresizesSubviews { get; set; }                /// <summary>        /// A flag used to determine how a view lays out its content when its bounds change.        /// </summary>        [iOSVersion(2)]        [Export("contentMode")]        public UIViewContentMode ContentMode { get; set; }                /// <summary>        /// The rectangle that defines the stretchable and nonstretchable regions of a view.        /// </summary>        [iOSVersion(3)]        [Export("contentStretch")]        public CGRect ContentStretch { get; set; }                /// <summary>        /// Asks the view to calculate and return the size that best fits its subviews.        /// </summary>        /// <param name="size">The current size of the receiver.</param>        /// <returns>A new size that fits the receiver’s subviews.</returns>        [iOSVersion(2)]        [Export("sizeThatFits")]        public CGSize SizeThatFits(CGSize size) { return new CGSize(); }                /// <summary>        /// Resizes and moves the receiver view so it just encloses its subviews.        /// </summary>        [iOSVersion(2)]        [Export("sizeToFit")]        public void SizeToFit() { }                /// <summary>        /// Lays out subviews.        /// </summary>        [iOSVersion(2)]        [Export("layoutSubviews")]        public void LayoutSubviews() { }                /// <summary>        /// Invalidates the current layout of the receiver and triggers a layout update during the next update cycle.        /// </summary>        [iOSVersion(2)]        [Export("setNeedsLayout")]        public void SetNeedsLayout() { }                /// <summary>        /// Lays out the subviews immediately.        /// </summary>        [iOSVersion(2)]        [Export("layoutIfNeeded")]        public void LayoutIfNeeded() { }                /// <summary>        /// Returns whether the receiver depends on the constraint-based layout system.        /// </summary>        /// <returns>true if the view must be in a window using constraint-based layout to function properly, false otherwise.</returns>        [iOSVersion(6)]        [Export("requiresConstraintBasedLayout")]        public static bool RequiresConstraintBasedLayout() { return false; }                /// <summary>        /// Returns a Boolean value that indicates whether the view’s autoresizing mask is translated into constraints for the constraint-based layout system.        /// </summary>        /// <returns>true if the view’s autoresizing mask is translated into constraints for the constraint-based layout system, false otherwise.</returns>        [iOSVersion(6)]        [Export("translatesAutoresizingMaskintoConstraints")]        public bool TranslatesAutoresizingMaskintoConstraints() { return false; }                /// <summary>        /// Sets whether the view’s autoresizing mask should be translated into constraints for the constraint-based layout system.        /// </summary>        /// <param name="flag">true if the view’s autoresizing mask should be translated into constraints for the constraint-based layout system, false otherwise.</param>        [iOSVersion(6)]        [Export("setTranslatesAutoresizingMaskintoConstraints")]        public void SetTranslatesAutoresizingMaskintoConstraints(bool flag) { }                /// <summary>        /// Returns the constraints held by the view.        /// </summary>        /// <returns>The constraints held by the view.</returns>        [iOSVersion(6)]        [Export("constraints")]        public AnyObject[] Constraints() { return null; }                /// <summary>        /// Adds a constraint on the layout of the receiving view or its subviews.        /// </summary>        /// <param name="constraint">The constraint to be added to the view. The constraint may only reference the view itself or its subviews.</param>        [iOSVersion(6)]        [Export("addConstraint")]        public void AddConstraint(NSLayoutConstraint constraint) { }                /// <summary>        /// Adds multiple constraints on the layout of the receiving view or its subviews.        /// </summary>        /// <param name="constraints">An array of constraints to be added to the view. All constraints may only reference the view itself or its subviews.</param>        [iOSVersion(6)]        [Export("addConstraints")]        public void AddConstraints(AnyObject[] constraints) { }                /// <summary>        /// Removes the specified constraint from the view.        /// </summary>        /// <param name="constraint">The constraint to remove. Removing a constraint not held by the view has no effect.</param>        [iOSVersion(6)]        [Export("removeConstraint")]        public void RemoveConstraint(NSLayoutConstraint constraint) { }                /// <summary>        /// Removes the specified constraints from the view.        /// </summary>        /// <param name="constraints">The constraints to remove.</param>        [iOSVersion(6)]        [Export("removeConstraints")]        public void RemoveConstraints(AnyObject[] constraints) { }                /// <summary>        /// Returns the size of the view that satisfies the constraints it holds.        /// </summary>        /// <param name="targetSize">Indicates whether you want the smallest or largest possible size that meets the constraints. See Fitting Size for accepted values.</param>        /// <returns>The size of the view that satisfies the constraints it holds.</returns>        [iOSVersion(6)]        [Export("systemLayoutSizeFittingSize")]        public CGSize SystemLayoutSizeFittingSize(CGSize targetSize) { return new CGSize(); }                /// <summary>        /// Returns the size of the view that satisfies the constraints it holds.        /// </summary>        /// <param name="targetSize">Indicates whether you want the smallest or largest possible size that meets the constraints. See Fitting Size for accepted values.</param>        /// <param name="withHorizontalFittingPriority">The horizontal constraint priority.</param>        /// <param name="verticalFittingPriority">The vertical constraint priority.</param>        /// <returns>The size of the view that satisfies the constraints it holds.</returns>        [iOSVersion(8)]        [Export("systemLayoutSizeFittingSize")]        public CGSize SystemLayoutSizeFittingSize(CGSize targetSize, UILayoutPriority withHorizontalFittingPriority, UILayoutPriority verticalFittingPriority) { return new CGSize(); }                /// <summary>        /// Returns the natural size for the receiving view, considering only properties of the view itself.        /// </summary>        /// <returns>A size indicating the natural size for the receiving view based on its intrinsic properties.</returns>        [iOSVersion(6)]        [Export("intrinsicContentSize")]        public CGSize intrinsicContentSize() { return new CGSize(); }                /// <summary>        /// Invalidates the view’s intrinsic content size.        /// </summary>        [iOSVersion(6)]        [Export("invalidateintrinsicContentSize")]        public void InvalidateintrinsicContentSize() { }                /// <summary>        /// Returns the priority with which a view resists being made smaller than its intrinsic size.        /// </summary>        /// <param name="axis">The axis of the view that might be reduced.</param>        /// <returns>The priority with which the view should resist being compressed from its intrinsic size on the specified axis.</returns>        [iOSVersion(6)]        [Export("contentCompressionResistancePriorityForAxis")]        public UILayoutPriority ContentCompressionResistancePriorityForAxis(UILayoutConstraintAxis axis) { return null; }                /// <summary>        /// Sets the priority with which a view resists being made smaller than its intrinsic size.        /// </summary>        /// <param name="priority">The new priority.</param>        /// <param name="forAxis">The axis for which the compression resistance priority should be set.</param>        [iOSVersion(6)]        [Export("setContentCompressionResistancePriority")]        public void SetContentCompressionResistancePriority(UILayoutPriority priority, UILayoutConstraintAxis forAxis) { }                /// <summary>        /// Returns the priority with which a view resists being made larger than its intrinsic size.        /// </summary>        /// <param name="axis">The axis of the view that might be enlarged.</param>        /// <returns>The priority with which the view should resist being enlarged from its intrinsic size on the specified axis.</returns>        [iOSVersion(6)]        [Export("contentHuggingPriorityForAxis")]        public UILayoutPriority ContentHuggingPriorityForAxis(UILayoutConstraintAxis axis) { return null; }                /// <summary>        /// Sets the priority with which a view resists being made larger than its intrinsic size.        /// </summary>        /// <param name="priority">The new priority.</param>        /// <param name="forAxis">The axis for which the content hugging priority should be set.</param>        [iOSVersion(6)]        [Export("setContentHuggingPriority")]        public void SetContentHuggingPriority(UILayoutPriority priority, UILayoutConstraintAxis forAxis) { }                /// <summary>        /// Returns the view’s alignment rectangle for a given frame.        /// </summary>        /// <param name="frame">The frame whose corresponding alignment rectangle is desired.</param>        /// <returns>The alignment rectangle for the specified frame.</returns>        [iOSVersion(6)]        [Export("alignmentRectForFrame")]        public CGRect AlignmentRectForFrame(CGRect frame) { return new CGRect(); }                /// <summary>        /// Returns the view’s frame for a given alignment rectangle.        /// </summary>        /// <param name="alignmentRect">The alignment rectangle whose corresponding frame is desired.</param>        /// <returns>The frame for the specified alignment rectangle</returns>        [iOSVersion(6)]        [Export("frameForAlignmentRect")]        public CGRect FrameForAlignmentRect(CGRect alignmentRect) { return new CGRect(); }                /// <summary>        /// Returns the insets from the view’s frame that define its alignment rectangle.        /// </summary>        /// <returns>The insets from the view’s frame that define its alignment rectangle.</returns>        [iOSVersion(6)]        [Export("alignmentRectInsets")]        public UIEdgeInsets AlignmentRectInsets() { return new UIEdgeInsets(); }                /// <summary>        /// Returns a view used to satisfy baseline constraints.        /// </summary>        /// <returns>The view the constraint system should use to satisfy baseline constraints</returns>        [iOSVersion(6)]        [Export("viewForBaselineLayout")]        public UIView ViewForBaselineLayout() { return null; }                /// <summary>        /// Returns whether the view’s constraints need updating.        /// </summary>        /// <returns>true if the view’s constraints need updating, false otherwise.</returns>        [iOSVersion(6)]        [Export("needsUpdateConstraints")]        public bool NeedsUpdateConstraints() { return false; }                /// <summary>        /// Controls whether the view’s constraints need updating.        /// </summary>        [iOSVersion(6)]        [Export("setNeedsUpdateConstraints")]        public void SetNeedsUpdateConstraints() { }                /// <summary>        /// Updates constraints for the view.        /// </summary>        [iOSVersion(6)]        [Export("updateConstraints")]        public void UpdateConstraints() { }                /// <summary>        /// Updates the constraints for the receiving view and its subviews.        /// </summary>        [iOSVersion(6)]        [Export("updateConstraintsIfNeeded")]        public void UpdateConstraintsIfNeeded() { }                /// <summary>        /// Returns the constraints impacting the layout of the view for a given axis.        /// </summary>        /// <param name="axis">The axis for which the constraints should be found.</param>        /// <returns>The constraints impacting the layout of the view for the specified axis.</returns>        [iOSVersion(6)]        [Export("constraintsAffectingLayoutForAxis")]        public AnyObject[] ConstraintsAffectingLayoutForAxis(UILayoutConstraintAxis axis) { return null; }                /// <summary>        /// Returns whether the constraints impacting the layout of the view incompletely specify the location of the view.        /// </summary>        /// <returns>true if the view’s location is incompletely specified, false otherwise.</returns>        [iOSVersion(6)]        [Export("hasAmbiguousLayout")]        public bool HasAmbiguousLayout() { return false; }                /// <summary>        /// Randomly changes the frame of a view with an ambiguous layout between the different valid values.        /// </summary>        [iOSVersion(6)]        [Export("exerciseAmbiguityInLayout")]        public void ExerciseAmbiguityInLayout() { }                /// <summary>        /// Draws the receiver’s image within the passed-in rectangle.        /// </summary>        /// <param name="rect">The portion of the view’s bounds that needs to be updated. The first time your view is drawn, this rectangle is typically the entire visible bounds of your view. However, during subsequent drawing operations, the rectangle may specify only part of your view.</param>        [iOSVersion(2)]        [Export("drawRect")]        public void DrawRect(CGRect rect) { }                /// <summary>        /// Marks the receiver’s entire bounds rectangle as needing to be redrawn.        /// </summary>        [iOSVersion(2)]        [Export("setNeedsDisplay")]        public void SetNeedsDisplay() { }                /// <summary>        /// Marks the specified rectangle of the receiver as needing to be redrawn.        /// </summary>        /// <param name="invalidRect">The rectangular region of the receiver to mark as invalid; it should be specified in the coordinate system of the receiver.</param>        [iOSVersion(2)]        [Export("setNeedsDisplayInRect")]        public void SetNeedsDisplayInRect(CGRect invalidRect) { }                /// <summary>        /// The scale factor applied to the view.        /// </summary>        [iOSVersion(4)]        [Export("contentScaleFactor")]        public CGFloat ContentScaleFactor { get; set; }                /// <summary>        /// Called by the system when the tintColor property changes.        /// </summary>        [iOSVersion(7)]        [Export("tintColorDidChange")]        public void TintColorDidChange() { }                /// <summary>        /// Returns a print formatter for the receiving view.        /// </summary>        /// <returns>A UIViewPrintFormatter object or nil if the object could not be created. If it is successfully created, the returned object is automatically associated with this view.</returns>        [iOSVersion(4.2)]        [Export("viewPrintFormatter")]        public UIViewPrintFormatter ViewPrintFormatter() { return null; }                /// <summary>        /// Implemented to draw the view’s content for printing.        /// </summary>        /// <param name="area">A rectangle that defines the area for drawing printable content.</param>        /// <param name="forViewPrintFormatter">An instance of UIViewPrintFormatter obtained by calling the viewPrintFormatter method.</param>        [iOSVersion(4.2)]        [Export("drawRect")]        public void DrawRect(CGRect area, UIViewPrintFormatter forViewPrintFormatter) { }                /// <summary>        /// Attaches a gesture recognizer to the view.        /// </summary>        /// <param name="gestureRecognizer">An object whose class descends from the UIGestureRecognizer class. This parameter must not be nil.</param>        [iOSVersion(3.2)]        [Export("addGestureRecognizer")]        public void AddGestureRecognizer(UIGestureRecognizer gestureRecognizer) { }                /// <summary>        /// Detaches a gesture recognizer from the receiving view.        /// </summary>        /// <param name="gestureRecognizer">An object whose class descends from the UIGestureRecognizer class.</param>        [iOSVersion(3.2)]        [Export("removeGestureRecognizer")]        public void RemoveGestureRecognizer(UIGestureRecognizer gestureRecognizer) { }                /// <summary>        /// The gesture-recognizer objects currently attached to the view.        /// </summary>        [iOSVersion(3.2)]        [Export("gestureRecognizers")]        public AnyObject[] GestureRecognizers { get; set; }                /// <summary>        /// Asks the view if the gesture recognizer should be allowed to continue tracking touch events.        /// </summary>        /// <param name="gestureRecognizer">The gesture recognizer that is attempting to transition out of the UIGestureRecognizerStatePossible state.</param>        /// <returns>true if the gesture recognizer should continue tracking touch events and use them to trigger a gesture or false if it should transition to the UIGestureRecognizerStateFailed state.</returns>        [iOSVersion(6)]        [Export("gestureRecognizerShouldBegin")]        public bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer) { return false; }                /// <summary>        /// Animate changes to one or more views using the specified duration, delay, options, and completion handler.        /// </summary>        /// <param name="duration">The total duration of the animations, measured in seconds. If you specify a negative value or 0, the changes are made without animating them.</param>        /// <param name="delay">The amount of time (measured in seconds) to wait before beginning the animations. Specify a value of 0 to begin the animations immediately.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see UIViewAnimationOptions.</param>        /// <param name="animations">A block object containing the changes to commit to the views. This is where you programmatically change any animatable properties of the views in your view hierarchy. This block takes no parameters and has no return value. This parameter must not be NULL.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations actually finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. This parameter may be NULL.</param>        [iOSVersion(4)]        [Export("animateWithDuration")]        public static void AnimateWithDuration(NSTimeinterval duration, NSTimeinterval delay, UIViewAnimationOptions options, Action animations, Action<bool> completion) { }                /// <summary>        /// Animate changes to one or more views using the specified duration and completion handler.        /// </summary>        /// <param name="duration">The total duration of the animations, measured in seconds. If you specify a negative value or 0, the changes are made without animating them.</param>        /// <param name="animations">A block object containing the changes to commit to the views. This is where you programmatically change any animatable properties of the views in your view hierarchy. This block takes no parameters and has no return value. This parameter must not be NULL.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations actually finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. This parameter may be NULL.</param>        [iOSVersion(4)]        [Export("animateWithDuration")]        public static void AnimateWithDuration(NSTimeinterval duration, Action animations, Action<bool> completion) { }                /// <summary>        /// Animate changes to one or more views using the specified duration.        /// </summary>        /// <param name="duration">The total duration of the animations, measured in seconds. If you specify a negative value or 0, the changes are made without animating them.</param>        /// <param name="animations">A block object containing the changes to commit to the views. This is where you programmatically change any animatable properties of the views in your view hierarchy. This block takes no parameters and has no return value. This parameter must not be NULL.</param>        [iOSVersion(4)]        [Export("animateWithDuration")]        public static void AnimateWithDuration(NSTimeinterval duration, Action animations) { }                /// <summary>        /// Creates a transition animation for the specified container view.        /// </summary>        /// <param name="view">The container view that performs the transition.</param>        /// <param name="duration">The duration of the transition animation, measured in seconds. If you specify a negative value or 0, the transition is made without animations.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see UIViewAnimationOptions.</param>        /// <param name="animations">A block object that contains the changes you want to make to the specified view. This block takes no parameters and has no return value. This parameter must not be NULL.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations actually finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. This parameter may be NULL.</param>        [iOSVersion(4)]        [Export("transitionWithView")]        public static void TransitionWithView(UIView view, NSTimeinterval duration, UIViewAnimationOptions options, Action animations, Action<bool> completion) { }                /// <summary>        /// Creates a transition animation between the specified views using the given parameters.        /// </summary>        /// <param name="fromView">The starting view for the transition. By default, this view is removed from its superview as part of the transition.</param>        /// <param name="toView">The ending view for the transition. By default, this view is added to the superview of fromView as part of the transition.</param>        /// <param name="duration">The duration of the transition animation, measured in seconds. If you specify a negative value or 0, the transition is made without animations.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see UIViewAnimationOptions.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations actually finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. This parameter may be NULL.</param>        [iOSVersion(4)]        [Export("transitionFromView")]        public static void TransitionFromView(UIView fromView, UIView toView, NSTimeinterval duration, UIViewAnimationOptions options, Action<bool> completion) { }                /// <summary>        /// Creates an animation block object that can be used to set up keyframe-based animations for the current view.        /// </summary>        /// <param name="duration">The duration of the overall animation, measured in seconds. If you specify a negative value or 0, changes are made immediately and without animations.</param>        /// <param name="delay">Specifies the time (in seconds) to wait before starting the animation.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see “UIViewKeyframeAnimationOptions”.</param>        /// <param name="animations">A block object containing the changes to commit to the views. Typically, you call the addKeyframeWithRelativeStartTime:relativeDuration:animations: method one or more times from inside this block. You may also change view values directly if you want those changes to animate over the full duration. This block takes no parameters and has no return value. Do not use a nil value for this parameter.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. You can use a nil value for this parameter.</param>        [iOSVersion(7)]        [Export("animateKeyframesWithDuration")]        public static void AnimateKeyframesWithDuration(NSTimeinterval duration, NSTimeinterval delay, UIViewKeyframeAnimationOptions options, Action animations, Action<bool> completion) { }                /// <summary>        /// Specifies the timing and animation values for a single frame of a keyframe animation.        /// </summary>        /// <param name="frameStartTime">The time at which to start the specified animations. This value must be in the range 0 to 1, where 0 represents the start of the overall animation and 1 represents the end of the overall animation. For example, for an animation that is two seconds in duration, specifying a start time of 0.5 causes the animations to begin executing one second after the start of the overall animation.</param>        /// <param name="relativeDuration">The length of time over which to animate to the specified value. This value must be in the range 0 to 1 and indicates the amount of time relative to the overall animation length. If you specify a value of 0, any properties you set in the animations block update immediately at the specified start time. If you specify a nonzero value, the properties animate over that amount of time. For example, for an animation that is two seconds in duration, specifying a duration of 0.5 results in an animation duration of one second.</param>        /// <param name="animations">A block object containing the animations you want to perform. This is where you programmatically change any animatable properties of the views in your view hierarchy. This block takes no parameters and has no return value. This parameter must not be nil.</param>        [iOSVersion(7)]        [Export("addKeyframeWithRelativeStartTime")]        public static void AddKeyframeWithRelativeStartTime(CDouble frameStartTime, CDouble relativeDuration, Action animations) { }                /// <summary>        /// Performs a specified system-provided animation on one or more views, along with optional parallel animations that you define.        /// </summary>        /// <param name="animation">The system animation to perform; a constant from the UISystemAnimation enum.</param>        /// <param name="onViews">The views to perform the animations on.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see UIViewAnimationOptions.</param>        /// <param name="animations">Additional animations you specify to run alongside the system animation, with the same timing and duration that the system animation defines or inherits.   In your additional animations, do not modify properties of the view on which the system animation is being performed.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. The single Boolean argument indicates whether or not the animations finished before the completion handler was called. If the animation duration is 0, this block is performed at the beginning of the next run-loop cycle. You can use a nil value for this parameter.</param>        [iOSVersion(7)]        [Export("performSystemAnimation")]        public static void PerformSystemAnimation(UISystemAnimation animation, AnyObject[] onViews, UIViewAnimationOptions options, Action animations, Action<bool> completion) { }                /// <summary>        /// Performs a view animation using a timing curve corresponding to the motion of a physical spring.        /// </summary>        /// <param name="duration">The total duration of the animations, measured in seconds. If you specify a negative value or 0, the changes are made without animating them.</param>        /// <param name="delay">The amount of time (measured in seconds) to wait before beginning the animations. Specify a value of 0 to begin the animations immediately.</param>        /// <param name="usingSpringWithDamping">The damping ratio for the spring animation as it approaches its quiescent state.   To smoothly decelerate the animation without oscillation, use a value of 1. Employ a damping ratio closer to zero to increase oscillation.</param>        /// <param name="initialSpringVelocity">The initial spring velocity. For smooth start to the animation, match this value to the view’s velocity as it was prior to attachment.   A value of 1 corresponds to the total animation distance traversed in one second. For example, if the total animation distance is 200 points and you want the start of the animation to match a view velocity of 100 pt/s, use a value of 0.5.</param>        /// <param name="options">A mask of options indicating how you want to perform the animations. For a list of valid constants, see UIViewAnimationOptions.</param>        /// <param name="animations">A block object containing the changes to commit to the views. This is where you programmatically change any animatable properties of the views in your view hierarchy. This block takes no parameters and has no return value. This parameter must not be NULL.</param>        /// <param name="completion">A block object to be executed when the animation sequence ends. This block has no return value and takes a single Boolean argument that indicates whether or not the animations actually finished before the completion handler was called. If the duration of the animation is 0, this block is performed at the beginning of the next run loop cycle. This parameter may be NULL.</param>        [iOSVersion(7)]        [Export("animateWithDuration")]        public static void AnimateWithDuration(NSTimeinterval duration, NSTimeinterval delay, CGFloat usingSpringWithDamping, CGFloat initialSpringVelocity, UIViewAnimationOptions options, Action animations, Action<bool> completion) { }                /// <summary>        /// Disables a view transition animation.        /// </summary>        /// <param name="actionsWithoutAnimation">The view transition code that you want to perform without animation.</param>        [iOSVersion(7)]        [Export("performWithoutAnimation")]        public static void PerformWithoutAnimation(Action actionsWithoutAnimation) { }                /// <summary>        /// Marks the beginning of a begin/commit animation block.        /// </summary>        /// <param name="animationID">An application-supplied identifier for the animations.</param>        /// <param name="context">Custom data that you want to associate with this set of animations. information that is passed to the animation delegate messages—the selectors set using the setAnimationWillStartSelector: and setAnimationDidStopSelector: methods.</param>        [iOSVersion(2)]        [Export("beginAnimations")]        public static void BeginAnimations(string animationID, CMutableVoidPointer context) { }                /// <summary>        /// Marks the end of a begin/commit animation block and schedules the animations for execution.        /// </summary>        [iOSVersion(2)]        [Export("commitAnimations")]        public static void CommitAnimations() { }                /// <summary>        /// Sets the start time for the current animation block.        /// </summary>        /// <param name="startTime">The time to begin the animations.</param>        [iOSVersion(2)]        [Export("setAnimationStartDate")]        public static void SetAnimationStartDate(NSDate startTime) { }                /// <summary>        /// Sets whether animations are enabled.        /// </summary>        /// <param name="enabled">Specify true to enable animations or false to disable them.</param>        [iOSVersion(2)]        [Export("setAnimationsEnabled")]        public static void SetAnimationsEnabled(bool enabled) { }                /// <summary>        /// Sets the delegate for any animation messages.        /// </summary>        /// <param name="delegate">An object that defines the methods registered using the setAnimationWillStartSelector: and setAnimationDidStopSelector: methods. The view maintains a strong reference to this object for the duration of the animation.</param>        [iOSVersion(2)]        [Export("setAnimationDelegate")]        public static void SetAnimationDelegate(AnyObject @delegate) { }                /// <summary>        /// Sets the message to send to the animation delegate when the animation starts.        /// </summary>        /// <param name="selector">The message to send to the animation delegate before animations start. The default value is NULL. This selector should be of the form: - (void)animationDidStart:(NSString *)animationID context:(void *)context. Your method must take the following arguments:    animationID   An NSString containing an optional application-supplied identifier. This is the identifier string that is passed to the beginAnimations:context: method. This argument can be nil.   context   An optional application-supplied context. This is the context data passed to the beginAnimations:context: method. This argument can be nil.</param>        [iOSVersion(2)]        [Export("setAnimationWillStartSelector")]        public static void SetAnimationWillStartSelector(Selector selector) { }                /// <summary>        /// Sets the message to send to the animation delegate when animation stops.        /// </summary>        /// <param name="selector">The message sent to the animation delegate after animations end. The default value is NULL. The selector should be of the form: - (void)animationDidStop:(NSString *)animationID finished:(NSNumber *)finished context:(void *)context. Your method must take the following arguments:    animationID   An NSString containing an optional application-supplied identifier. This is the identifier that is passed to the beginAnimations:context: method. This argument can be nil.   finished   An NSNumber object containing a Boolean value. The value is true if the animation ran to completion before it stopped or false if it did not.   context   An optional application-supplied context. This is the context data passed to the beginAnimations:context: method. This argument can be nil.</param>        [iOSVersion(2)]        [Export("setAnimationDidStopSelector")]        public static void SetAnimationDidStopSelector(Selector selector) { }                /// <summary>        /// Sets the duration (measured in seconds) of the animations in an animation block.        /// </summary>        /// <param name="duration">The period over which the animation occurs, measured in seconds.</param>        [iOSVersion(2)]        [Export("setAnimationDuration")]        public static void SetAnimationDuration(NSTimeinterval duration) { }                /// <summary>        /// Sets the amount of time (in seconds) to wait before animating property changes within an animation block.        /// </summary>        [iOSVersion(2)]        [Export("setAnimationDelay")]        public static void SetAnimationDelay(NSTimeinterval delay) { }                /// <summary>        /// Sets the curve to use when animating property changes within an animation block.        /// </summary>        [iOSVersion(2)]        [Export("setAnimationCurve")]        public static void SetAnimationCurve(UIViewAnimationCurve curve) { }                /// <summary>        /// Sets the number of times animations within an animation block repeat.        /// </summary>        /// <param name="repeatCount">The number of times animations repeat. This value can be a fraction. If you specify the value 0, the animation is performed once without repeating.</param>        [iOSVersion(2)]        [Export("setAnimationRepeatCount")]        public static void SetAnimationRepeatCount(CFloat repeatCount) { }                /// <summary>        /// Sets whether the animations within an animation block automatically reverse themselves.        /// </summary>        /// <param name="repeatAutoreverses">Specify true to enable autoreversing or false to disable it.</param>        [iOSVersion(2)]        [Export("setAnimationRepeatAutoreverses")]        public static void SetAnimationRepeatAutoreverses(bool repeatAutoreverses) { }                /// <summary>        /// Sets whether the animation should begin playing from the current state.        /// </summary>        /// <param name="fromCurrentState">Specify true if animations should begin from their currently visible state; otherwise, false.</param>        [iOSVersion(2)]        [Export("setAnimationBeginsFromCurrentState")]        public static void SetAnimationBeginsFromCurrentState(bool fromCurrentState) { }                /// <summary>        /// Sets a transition to apply to a view during an animation block.        /// </summary>        /// <param name="transition">A transition to apply to view. Possible values are described in UIViewAnimationTransition.</param>        /// <param name="forView">The view to apply the transition to.</param>        /// <param name="cache">If true, the before and after images of view are rendered once and used to create the frames in the animation. Caching can improve performance but if you set this parameter to true, you must not update the view or its subviews during the transition. Updating the view and its subviews may interfere with the caching behaviors and cause the view contents to be rendered incorrectly (or in the wrong location) during the animation. You must wait until the transition ends to update the view.   If false, the view and its contents must be updated for each frame of the transition animation, which may noticeably affect the frame rate.</param>        [Export("setAnimationTransition")]        public static void SetAnimationTransition(UIViewAnimationTransition transition, UIView forView, bool cache) { }                /// <summary>        /// Returns a Boolean value indicating whether animations are enabled.        /// </summary>        /// <returns>true if animations are enabled; otherwise, false.</returns>        [iOSVersion(2)]        [Export("areAnimationsEnabled")]        public static bool AreAnimationsEnabled() { return false; }                /// <summary>        /// Begins applying a motion effect to the view.        /// </summary>        /// <param name="effect">The motion effect.</param>        [iOSVersion(7)]        [Export("addMotionEffect")]        public void AddMotionEffect(UIMotionEffect effect) { }                /// <summary>        /// The array of motion effects for the view.        /// </summary>        [iOSVersion(7)]        [Export("motionEffects")]        public AnyObject[] MotionEffects { get; set; }                /// <summary>        /// Stops applying a motion effect to the view.        /// </summary>        /// <param name="effect">The motion effect.</param>        [iOSVersion(7)]        [Export("removeMotionEffect")]        public void RemoveMotionEffect(UIMotionEffect effect) { }                /// <summary>        /// The identifier that determines whether the view supports state restoration.        /// </summary>        [iOSVersion(6)]        [Export("restorationIdentifier")]        public string RestorationIdentifier { get; set; }                /// <summary>        /// Encodes state-related information for the view.        /// </summary>        /// <param name="coder">The coder object to use to encode the state of the view.</param>        [iOSVersion(6)]        [Export("encodeRestorableStateWithCoder")]        public void EncodeRestorableStateWithCoder(NSCoder coder) { }                /// <summary>        /// Decodes and restores state-related information for the view.        /// </summary>        /// <param name="coder">The coder object to use to decode the state of the view.</param>        [iOSVersion(6)]        [Export("decodeRestorableStateWithCoder")]        public void DecodeRestorableStateWithCoder(NSCoder coder) { }                /// <summary>        /// Returns a snapshot view based on the contents of the current view.        /// </summary>        /// <param name="afterUpdates">A Boolean value that specifies whether the snapshot should be taken after recent changes have been incorporated. Pass the value false to capture the screen in its current state, which might not include recent changes.</param>        /// <returns>A new view object based on a snapshot of the current view’s rendered contents.</returns>        [iOSVersion(7)]        [Export("snapshotViewAfterScreenUpdates")]        public UIView SnapshotViewAfterScreenUpdates(bool afterUpdates) { return null; }                /// <summary>        /// Returns a snapshot view based on the specified contents of the current view, with stretchable insets.        /// </summary>        /// <param name="rect">The portion of the view that you want to capture. The rectangle must be in the bounds coordinate space of the current view.</param>        /// <param name="afterScreenUpdates">A Boolean value that specifies whether the snapshot should be taken after recent changes have been incorporated. Pass the value false if you want to capture the screen in its current state, which might not include recent changes.</param>        /// <param name="withCapInsets">The edge insets that define the stretchable portion of the returned view’s content. You can specify UIEdgeInsetsZero if you do not want the contents of the returned view to have a stretchable area.</param>        /// <returns>A new view object containing a snapshot of the current view’s rendered contents.</returns>        [iOSVersion(7)]        [Export("resizableSnapshotViewFromRect")]        public UIView ResizableSnapshotViewFromRect(CGRect rect, bool afterScreenUpdates, UIEdgeInsets withCapInsets) { return null; }                /// <summary>        /// Renders a snapshot of the complete view hierarchy as visible onscreen into the current context.        /// </summary>        /// <param name="rect">A rectangle specified in the local coordinate system (bounds) of the view.</param>        /// <param name="afterScreenUpdates">A Boolean value that indicates whether the snapshot should be rendered after recent changes have been incorporated. Specify the value false if you want to render a snapshot in the view hierarchy’s current state, which might not include recent changes.</param>        /// <returns>Returns true if the snapshot is complete, or false if the snapshot is missing image data for any view in the hierarchy.</returns>        [iOSVersion(7)]        [Export("drawViewHierarchyInRect")]        public bool DrawViewHierarchyInRect(CGRect rect, bool afterScreenUpdates) { return false; }                /// <summary>        /// An integer that you can use to identify view objects in your application.        /// </summary>        [iOSVersion(2)]        [Export("tag")]        public int Tag { get; set; }                /// <summary>        /// Returns the view whose tag matches the specified value.        /// </summary>        /// <param name="tag">The tag value to search for.</param>        /// <returns>The view in the receiver’s hierarchy whose tag property matches the value in the tag parameter.</returns>        [iOSVersion(2)]        [Export("viewWithTag")]        public UIView ViewWithTag(int tag) { return null; }                /// <summary>        /// Converts a point from the receiver’s coordinate system to that of the specified view.        /// </summary>        /// <param name="point">A point specified in the local coordinate system (bounds) of the receiver.</param>        /// <param name="toView">The view into whose coordinate system point is to be converted. If view is nil, this method instead converts to window base coordinates. Otherwise, both view and the receiver must belong to the same UIWindow object.</param>        /// <returns>The point converted to the coordinate system of view.</returns>        [iOSVersion(2)]        [Export("convertPoint")]
        public CGPoint ConvertPoint(CGPoint point, UIView toView) { return new CGPoint(); }                /// <summary>        /// Converts a point from the coordinate system of a given view to that of the receiver.        /// </summary>        /// <param name="point">A point specified in the local coordinate system (bounds) of view.</param>        /// <param name="fromView">The view with point in its coordinate system. If view is nil, this method instead converts from window base coordinates. Otherwise, both view and the receiver must belong to the same UIWindow object.</param>        /// <returns>The point converted to the local coordinate system (bounds) of the receiver.</returns>        [iOSVersion(2)]        [Export("convertPoint")]
        public CGPoint ConvertPoint(CGPoint point, UIView fromView) { return new CGPoint(); }                /// <summary>        /// Converts a rectangle from the receiver’s coordinate system to that of another view.        /// </summary>        /// <param name="rect">A rectangle specified in the local coordinate system (bounds) of the receiver.</param>        /// <param name="toView">The view that is the target of the conversion operation. If view is nil, this method instead converts to window base coordinates. Otherwise, both view and the receiver must belong to the same UIWindow object.</param>        /// <returns>The converted rectangle.</returns>        [iOSVersion(2)]        [Export("convertRect")]
        public CGRect ConvertRect(CGRect rect, UIView toView) { return new CGRect(); }                /// <summary>        /// Converts a rectangle from the coordinate system of another view to that of the receiver.        /// </summary>        /// <param name="rect">A rectangle specified in the local coordinate system (bounds) of view.</param>        /// <param name="fromView">The view with rect in its coordinate system. If view is nil, this method instead converts from window base coordinates. Otherwise, both view and the receiver must belong to the same UIWindow object.</param>        /// <returns>The converted rectangle.</returns>        [iOSVersion(2)]        [Export("convertRect")]
        public CGRect ConvertRect(CGRect rect, UIView fromView) { return new CGRect(); }                /// <summary>        /// Returns the farthest descendant of the receiver in the view hierarchy (including itself) that contains a specified point.        /// </summary>        /// <param name="point">A point specified in the receiver’s local coordinate system (bounds).</param>        /// <param name="withEvent">The event that warranted a call to this method. If you are calling this method from outside your event-handling code, you may specify nil.</param>        /// <returns>The view object that is the farthest descendent the current view and contains point. Returns nil if the point lies completely outside the receiver’s view hierarchy.</returns>        [iOSVersion(2)]        [Export("hitTest")]        public UIView HitTest(CGPoint point, UIEvent withEvent) { return null; }                /// <summary>        /// Returns a Boolean value indicating whether the receiver contains the specified point.        /// </summary>        /// <param name="point">A point that is in the receiver’s local coordinate system (bounds).</param>        /// <param name="withEvent">The event that warranted a call to this method. If you are calling this method from outside your event-handling code, you may specify nil.</param>        /// <returns>true if point is inside the receiver’s bounds; otherwise, false.</returns>        [iOSVersion(2)]        [Export("pointInside")]        public bool PointInside(CGPoint point, UIEvent withEvent) { return false; }                /// <summary>        /// Causes the view (or one of its embedded text fields) to resign the first responder status.        /// </summary>        /// <param name="force">Specify true to force the first responder to resign, regardless of whether it wants to do so.</param>        /// <returns>true if the view resigned the first responder status or false if it did not.</returns>        [iOSVersion(2)]        [Export("endEditing")]        public bool EndEditing(bool force) { return false; }                /// <summary>        /// Tells the view that a subview was added.        /// </summary>        /// <param name="subview">The view that was added as a subview.</param>        [iOSVersion(2)]        [Export("didAddSubview")]        public void DidAddSubview(UIView subview) { }                /// <summary>        /// Tells the view that a subview is about to be removed.        /// </summary>        /// <param name="subview">The subview that will be removed.</param>        [iOSVersion(2)]        [Export("willRemoveSubview")]        public void WillRemoveSubview(UIView subview) { }                /// <summary>        /// Tells the view that its superview is about to change to the specified superview.        /// </summary>        /// <param name="newSuperview">A view object that will be the new superview of the receiver. This object may be nil.</param>        [iOSVersion(2)]        [Export("willMoveToSuperview")]        public void WillMoveToSuperview(UIView newSuperview) { }                /// <summary>        /// Tells the view that its superview changed.        /// </summary>        [iOSVersion(2)]        [Export("didMoveToSuperview")]        public void DidMoveToSuperview() { }                /// <summary>        /// Tells the view that its window object is about to change.        /// </summary>        /// <param name="newWindow">The window object that will be at the root of the receiver's new view hierarchy. This parameter may be nil.</param>        [iOSVersion(2)]        [Export("willMoveToWindow")]        public void WillMoveToWindow(UIWindow newWindow) { }                /// <summary>        /// Tells the view that its window object changed.        /// </summary>        [iOSVersion(2)]        [Export("didMoveToWindow")]        public void DidMoveToWindow() { }        /// <summary>        /// View fitting options used in the systemLayoutSizeFittingSize: method.        /// </summary>                /// <summary>        /// The option to use the smallest possible size.        /// </summary>        [iOSVersion(6)]        public CGSize UILayoutFittingCompressedSize { get; private set; }                /// <summary>        /// The option to use the largest possible size.        /// </summary>        [iOSVersion(6)]        public CGSize UILayoutFittingExpandedSize { get; private set; }                /// <summary>        /// The option to indicate that a view has no intrinsic metric for a given numeric property.        /// </summary>        [Export("UIViewNointrinsicMetric")]        public CGFloat UIViewNointrinsicMetric { get; private set; }
    }

    /// <summary>
    /// Options for animating views using block objects.
    /// </summary>
    public enum UIViewAnimationOptions
    {
        /// <summary>
        /// Lay out subviews at commit time so that they are animated along with their parent.
        /// </summary>
        [iOSVersion(4)]
        LayoutSubviews,

        /// <summary>
        /// Allow the user to interact with views while they are being animated.
        /// </summary>
        [iOSVersion(4)]
        AllowUserinteraction,

        /// <summary>
        /// Start the animation from the current setting associated with an already in-flight animation. If this key is not present, any in-flight animations are allowed to finish before the new animation is started. If another animation is not in flight, this key has no effect.
        /// </summary>
        [iOSVersion(4)]
        BeginFromCurrentState,

        /// <summary>
        /// Repeat the animation indefinitely.
        /// </summary>
        [iOSVersion(4)]
        Repeat,

        /// <summary>
        /// Run the animation backwards and forwards. Must be combined with the UIViewAnimationOptionRepeat option.
        /// </summary>
        [iOSVersion(4)]
        Autoreverse,

        /// <summary>
        /// Force the animation to use the original duration value specified when the animation was submitted. If this key is not present, the animation inherits the remaining duration of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedDuration,

        /// <summary>
        /// Force the animation to use the original curve value specified when the animation was submitted. If this key is not present, the animation inherits the curve of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedCurve,

        /// <summary>
        /// Animate the views by changing the property values dynamically and redrawing the view. If this key is not present, the views are animated using a snapshot image.
        /// </summary>
        [iOSVersion(4)]
        AllowAnimatedContent,

        /// <summary>
        /// When present, this key causes views to be hidden or shown (instead of removed or added) when performing a view transition. Both views must already be present in the parent view’s hierarchy when using this key. If this key is not present, the to-view in a transition is added to, and the from-view is removed from, the parent view’s list of subviews.
        /// </summary>
        [iOSVersion(4)]
        ShowHideTransitionViews,

        /// <summary>
        /// The option to not inherit the animation type or any options.
        /// </summary>
        [iOSVersion(4)]
        OverrideInheritedOptions,

        /// <summary>
        /// An ease-in ease-out curve causes the animation to begin slowly, accelerate through the middle of its duration, and then slow again before completing.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseInOut,

        /// <summary>
        /// An ease-in curve causes the animation to begin slowly, and then speed up as it progresses.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseIn,

        /// <summary>
        /// An ease-out curve causes the animation to begin quickly, and then slow as it completes.
        /// </summary>
        [iOSVersion(4)]
        CurveEaseOut,

        /// <summary>
        /// A linear animation curve causes an animation to occur evenly over its duration.
        /// </summary>
        [iOSVersion(4)]
        CurveLinear,

        /// <summary>
        /// No transition is specified.
        /// </summary>
        [iOSVersion(4)]
        TransitionNone,

        /// <summary>
        /// A transition that flips a view around its vertical axis from left to right. The left side of the view moves toward the front and right side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromLeft,

        /// <summary>
        /// A transition that flips a view around its vertical axis from right to left. The right side of the view moves toward the front and left side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromRight,

        /// <summary>
        /// A transition that curls a view up from the bottom.
        /// </summary>
        [iOSVersion(4)]
        TransitionCurlUp,

        /// <summary>
        /// A transition that curls a view down from the top.
        /// </summary>
        [iOSVersion(4)]
        TransitionCurlDown,

        /// <summary>
        /// A transition that dissolves from one view to the next.
        /// </summary>
        [iOSVersion(4)]
        TransitionCrossDissolve,

        /// <summary>
        /// A transition that flips a view around its horizontal axis from top to bottom. The top side of the view moves toward the front and the bottom side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromTop,

        /// <summary>
        /// A transition that flips a view around its horizontal axis from bottom to top. The bottom side of the view moves toward the front and the top side toward the back.
        /// </summary>
        [iOSVersion(4)]
        TransitionFlipFromBottom,
    }

    /// <summary>
    /// Specifies the supported animation curves.
    /// </summary>
    public enum UIViewAnimationCurve
    {
        /// <summary>
        /// An ease-in ease-out curve causes the animation to begin slowly, accelerate through the middle of its duration, and then slow again before completing. This is the default curve for most animations.
        /// </summary>
        [iOSVersion(2)]
        EaseInOut,

        /// <summary>
        /// An ease-in curve causes the animation to begin slowly, and then speed up as it progresses.
        /// </summary>
        [iOSVersion(2)]
        EaseIn,

        /// <summary>
        /// An ease-out curve causes the animation to begin quickly, and then slow down as it completes.
        /// </summary>
        [iOSVersion(2)]
        EaseOut,

        /// <summary>
        /// A linear animation curve causes an animation to occur evenly over its duration.
        /// </summary>
        [iOSVersion(2)]
        Linear,
    }
    /// <summary>
    /// Options to specify how a view adjusts its content when its size changes.
    /// </summary>
    public enum UIViewContentMode
    {
        /// <summary>
        /// The option to scale the content to fit the size of itself by changing the aspect ratio of the content if necessary.
        /// </summary>
        [iOSVersion(2)]
        ScaleToFill,

        /// <summary>
        /// The option to scale the content to fit the size of the view by maintaining the aspect ratio. Any remaining area of the view’s bounds is transparent.
        /// </summary>
        [iOSVersion(2)]
        ScaleAspectFit,

        /// <summary>
        /// The option to scale the content to fill the size of the view. Some portion of the content may be clipped to fill the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        ScaleAspectFill,

        /// <summary>
        /// The option to redisplay the view when the bounds change by invoking the setNeedsDisplay method.
        /// </summary>
        [iOSVersion(2)]
        Redraw,

        /// <summary>
        /// The option to center the content in the view’s bounds, keeping the proportions the same.
        /// </summary>
        [iOSVersion(2)]
        Center,

        /// <summary>
        /// The option to center the content aligned at the top in the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        Top,

        /// <summary>
        /// The option to center the content aligned at the bottom in the view’s bounds.
        /// </summary>
        [iOSVersion(2)]
        Bottom,

        /// <summary>
        /// The option to align the content on the left of the view.
        /// </summary>
        [iOSVersion(2)]
        Left,

        /// <summary>
        /// The option to align the content on the right of the view.
        /// </summary>
        [iOSVersion(2)]
        Right,

        /// <summary>
        /// The option to align the content in the top-left corner of the view.
        /// </summary>
        [iOSVersion(2)]
        TopLeft,

        /// <summary>
        /// The option to align the content in the top-right corner of the view.
        /// </summary>
        [iOSVersion(2)]
        TopRight,

        /// <summary>
        /// The option to align the content in the bottom-left corner of the view.
        /// </summary>
        [iOSVersion(2)]
        BottomLeft,

        /// <summary>
        /// The option to align the content in the bottom-right corner of the view.
        /// </summary>
        [iOSVersion(2)]
        BottomRight,
    }

    /// <summary>
    /// The tint adjustment mode for the view.
    /// </summary>
    public enum UIViewTintAdjustmentMode
    {
        /// <summary>
        /// The tint adjustment mode of the view is the same as its superview's tint adjustment mode (or UIViewTintAdjustmentModeNormal if the view has no superview).
        /// </summary>
        [iOSVersion(7)]
        Automatic,

        /// <summary>
        /// The view's tintColor property returns the completely unmodified tint color of the view.
        /// </summary>
        [iOSVersion(7)]
        Normal,

        /// <summary>
        /// The view's tintColor property returns a desaturated, dimmed version of the view's original tint color.
        /// </summary>
        [iOSVersion(7)]
        Dimmed,
    }

    /// <summary>
    /// Option to remove the views from the hierarchy when animation is complete.
    /// </summary>
    public enum UISystemAnimation
    {
        /// <summary>
        /// Option to remove views from the view hierarchy when animation is complete.
        /// </summary>
        [iOSVersion(7)]
        Delete,
    }
    /// <summary>
    /// Options for automatic view resizing.
    /// </summary>
    public enum UIViewAutoresizing
    {
        /// <summary>
        /// The option for indicating that the view does not resize.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the left margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleLeftMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view’s width.
        /// </summary>
        [iOSVersion(2)]
        FlexibleWidth,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the right margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleRightMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the top margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleTopMargin,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view's height.
        /// </summary>
        [iOSVersion(2)]
        FlexibleHeight,

        /// <summary>
        /// Resizing performed by expanding or shrinking a view in the direction of the bottom margin.
        /// </summary>
        [iOSVersion(2)]
        FlexibleBottomMargin,
    }
    /// <summary>
    /// Animation transition options for use in an animation block object.
    /// </summary>
    public enum UIViewAnimationTransition
    {
        /// <summary>
        /// The option for indicating that no transition is specified.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// A transition that flips a view around a vertical axis from left to right. The left side of the view moves towards the front and right side towards the back.
        /// </summary>
        [iOSVersion(2)]
        FlipFromLeft,

        /// <summary>
        /// A transition that flips a view around a vertical axis from right to left. The right side of the view moves towards the front and left side towards the back.
        /// </summary>
        [iOSVersion(2)]
        FlipFromRight,

        /// <summary>
        /// A transition that curls a view up from the bottom.
        /// </summary>
        [iOSVersion(2)]
        CurlUp,

        /// <summary>
        /// A transition that curls a view down from the top.
        /// </summary>
        [iOSVersion(2)]
        CurlDown,
    }
    /// <summary>
    /// Key frame animation options used with the animateKeyframesWithDuration:delay:options:animations:completion: method.
    /// </summary>
    public enum UIViewKeyframeAnimationOptions
    {
        /// <summary>
        /// The option to lay out subviews at commit time so that they are animated along with their parent.
        /// </summary>
        [iOSVersion(7)]
        LayoutSubviews,

        /// <summary>
        /// The option that allows the user to interact with views while they are being animated.
        /// </summary>
        [iOSVersion(7)]
        AllowUserinteraction,

        /// <summary>
        /// The option to start an animation from the current setting associated with an already in-flight animation. If this option is not present, any in-flight animations are allowed to finish before the new animation is started. If another animation is not in flight, this option has no effect.
        /// </summary>
        [iOSVersion(7)]
        BeginFromCurrentState,

        /// <summary>
        /// The option to repeat an animation indefinitely.
        /// </summary>
        [iOSVersion(7)]
        Repeat,

        /// <summary>
        /// The option to run an animation backwards and forwards. Must be combined with the UIViewKeyframeAnimationOptionRepeat option.
        /// </summary>
        [iOSVersion(7)]
        Autoreverse,

        /// <summary>
        /// The option to force an animation to use the original duration value specified when the animation was submitted. If this option is not present, the animation inherits the remaining duration of the in-flight animation, if any.
        /// </summary>
        [iOSVersion(7)]
        OverrideInheritedDuration,

        /// <summary>
        /// The option to not inherit the animation type or any options.
        /// </summary>
        [iOSVersion(7)]
        OverrideInheritedOptions,

        /// <summary>
        /// The option to use a simple linear calculation when interpolating between keyframe values.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeLinear,

        /// <summary>
        /// The option to not interpolate between keyframe values, but rather to jump directly to each new keyframe value.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeDiscrete,

        /// <summary>
        /// The option to compute intermediate keyframe values using a simple pacing algorithm. This option results in an evenly paced animation.
        /// </summary>
        [iOSVersion(7)]
        CalculationModePaced,

        /// <summary>
        /// The option to compute intermediate frames using a default Catmull-Rom spline that passes through the keyframe values. You cannot adjust the parameters of this algorithm.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeCubic,

        /// <summary>
        /// The option to compute intermediate frames using the cubic scheme while ignoring the timing properties of the animation. Instead, timing parameters are calculated implicitly to give the animation a constant velocity.
        /// </summary>
        [iOSVersion(7)]
        CalculationModeCubicPaced,
    }

    /// <summary>
    /// Keys that specify a horizontal or vertical layout constraint between objects.
    /// </summary>
    public enum UILayoutConstraintAxis
    {
        /// <summary>
        /// The constraint applied when laying out the horizontal relationship between objects.
        /// </summary>
        [iOSVersion(6)]
        Horizontal,

        /// <summary>
        /// The constraint applied when laying out the vertical relationship between objects.
        /// </summary>
        [iOSVersion(6)]
        Vertical,
    }}