using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIControl_Class/index.html#//apple_ref/occ/cl/UIControl	/// <summary>	/// UIControl is the base class for control objects such as buttons and sliders that convey user intent to the application. You cannot use the UIControl class directly to instantiate controls. It instead defines the common interface and behavioral structure for all its subclasses.	/// </summary>	[iOSVersion(2)]	public class UIControl : UIView	{		/// <summary>		/// In response to a given event, forwards an action message to the application object for dispatching to a target.		/// </summary>		/// <param name="action">A selector identifying an action message. It cannot be NULL.</param>		/// <param name="to">The target object—that is, the object to which the action message is sent. If this is nil, the receiver traverses the responder chain and sends the action message to the first object willing to respond to it.</param>		/// <param name="forEvent">An object representing the event (typically in a UIControl object) that originated the action message. The event can be nil if the action is invoked directly instead of being caused by an event. For example, a value-changed message might be sent for programmatic reasons rather than as a result of the user touching the control.</param>		[iOSVersion(2)]		[Export("sendAction")]		public void SendAction(Selector action, AnyObject to, UIEvent forEvent) { }				/// <summary>		/// Sends action messages for the given control events.		/// </summary>		/// <param name="controlEvents">A bitmask whose set flags specify the control events for which action messages are sent. See Control Events for bitmask constants.</param>		[iOSVersion(2)]		[Export("sendActionsForControlEvents")]		public void SendActionsForControlEvents(UIControlEvents controlEvents) { }				/// <summary>		/// Adds a target and action for a particular event (or events) to an internal dispatch table.		/// </summary>		/// <param name="target">The target object—that is, the object to which the action message is sent. If this is nil, the responder chain is searched for an object willing to respond to the action message.</param>		/// <param name="action">A selector identifying an action message. It cannot be NULL.</param>		/// <param name="forControlEvents">A bitmask specifying the control events for which the action message is sent. See Control Events for bitmask constants.</param>		[iOSVersion(2)]		[Export("addTarget")]		public void AddTarget(AnyObject target, Selector action, UIControlEvents forControlEvents) { }				/// <summary>		/// Removes a target and action for a particular event (or events) from an internal dispatch table.		/// </summary>		/// <param name="target">The target object—that is, the object to which the action message is sent. Pass nil to remove all targets paired with action and the specified control events.</param>		/// <param name="action">A selector identifying an action message. Pass NULL to remove all action messages paired with target.</param>		/// <param name="forControlEvents">A bitmask specifying the control events associated with target and action. See Control Events for bitmask constants.</param>		[iOSVersion(2)]		[Export("removeTarget")]		public void RemoveTarget(AnyObject target, Selector action, UIControlEvents forControlEvents) { }				/// <summary>		/// Returns the actions that are associated with a target and a particular control event.		/// </summary>		/// <param name="target">The target object—that is, the object to which an action message is sent.   You must pass an explicit match for the target. Do not pass a value of nil.</param>		/// <param name="forControlEvent">A single constant of type UIControlEvents that specifies a particular user action on the control; for a list of these constants, see Control Events.</param>		/// <returns>An array of selector names as NSString objects or nil if there are no action selectors associated with the control event.</returns>		[iOSVersion(2)]		[Export("actionsForTarget")]		public AnyObject[] ActionsForTarget(AnyObject target, UIControlEvents forControlEvent) { return null; }				/// <summary>		/// Returns all target objects associated with the receiver.		/// </summary>		/// <returns>A set of all targets—that is, the objects to which action messages are sent—for the receiver. The set may include NSNull to indicate at least one nil target (meaning, the responder chain is searched for a target).</returns>		[iOSVersion(2)]		[Export("allTargets")]		public NSSet AllTargets() { return null; }				/// <summary>		/// Returns all control events associated with the receiver.		/// </summary>		/// <returns>One or more UIControlEvents constants that specify the current control events associated with the receiver; for a list of these constants, see Control Eventslist of all events that have at least one action.</returns>		[iOSVersion(2)]		[Export("allControlEvents")]		public UIControlEvents AllControlEvents() { return UIControlEvents.AllEditingEvents; }				/// <summary>		/// A bitmask value that indicates the state of the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("state")]		public UIControlState State { get; private set; }				/// <summary>		/// A Boolean value that determines whether the receiver is enabled.		/// </summary>		[iOSVersion(2)]		[Export("enabled")]		public bool Enabled { get; set; }				/// <summary>		/// A Boolean value that determines the receiver’s selected state.		/// </summary>		[iOSVersion(2)]		[Export("selected")]		public bool Selected { get; set; }				/// <summary>		/// A Boolean value that determines whether the receiver is highlighted.		/// </summary>		[iOSVersion(2)]		[Export("highlighted")]		public bool Highlighted { get; set; }				/// <summary>		/// The vertical alignment of content (text or image) within the receiver.		/// </summary>		[iOSVersion(2)]		[Export("contentVerticalAlignment")]		public UIControlContentVerticalAlignment ContentVerticalAlignment { get; set; }				/// <summary>		/// The horizontal alignment of content (text or image) within the receiver.		/// </summary>		[iOSVersion(2)]		[Export("contentHorizontalAlignment")]		public UIControlContentHorizontalAlignment ContentHorizontalAlignment { get; set; }				/// <summary>		/// Sent to the control when a touch related to the given event enters the control’s bounds.		/// </summary>		/// <param name="touch">A UITouch object that represents a touch on the receiving control during tracking.</param>		/// <param name="withEvent">An event object encapsulating the information specific to the user event.</param>		/// <returns>true if the receiver is set to respond continuously or set to respond when a touch is dragged; otherwise false.</returns>		[iOSVersion(2)]		[Export("beginTrackingWithTouch")]		public bool BeginTrackingWithTouch(UITouch touch, UIEvent withEvent) { return false; }				/// <summary>		/// Sent continuously to the control as it tracks a touch related to the given event within the control’s bounds.		/// </summary>		/// <param name="touch">A UITouch object that represents a touch on the receiving control during tracking.</param>		/// <param name="withEvent">An event object encapsulating the information specific to the user event</param>		/// <returns>true if touch tracking should continue; otherwise false.</returns>		[iOSVersion(2)]		[Export("continueTrackingWithTouch")]		public bool ContinueTrackingWithTouch(UITouch touch, UIEvent withEvent) { return false; }				/// <summary>		/// Sent to the control when the last touch for the given event completely ends, telling it to stop tracking.		/// </summary>		/// <param name="touches">A UITouch object that represents a touch on the receiving control during tracking.</param>		/// <param name="withEvent">An event object encapsulating the information specific to the user event.</param>		[iOSVersion(2)]		[Export("endTrackingWithTouch")]		public void EndTrackingWithTouch(UITouch touches, UIEvent withEvent) { }				/// <summary>		/// Tells the control to cancel tracking related to the given event.		/// </summary>		/// <param name="event">An event object encapsulating the information specific to the user event. This parameter might be nil, indicating that the cancelation was caused by something other than an event, such as the view being removed from the window.</param>		[iOSVersion(2)]		[Export("cancelTrackingWithEvent")]		public void CancelTrackingWithEvent(UIEvent @event) { }				/// <summary>		/// A Boolean value that indicates whether the receiver is currently tracking touches related to an event. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("tracking")]		public bool Tracking { get; private set; }				/// <summary>		/// A Boolean value that indicates whether a touch is inside the bounds of the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("touchInside")]		public bool TouchInside { get; private set; }								WHAT								WHAT	}	/// <summary>	/// Kinds of events possible for control objects.	/// </summary>	public enum UIControlEvents	{		/// <summary>		/// A touch-down event in the control.		/// </summary>		[iOSVersion(2)]		TouchDown,					/// <summary>		/// A repeated touch-down event in the control; for this event the value of the UITouch tapCount method is greater than one.		/// </summary>		[iOSVersion(2)]		TouchDownRepeat,					/// <summary>		/// An event where a finger is dragged inside the bounds of the control.		/// </summary>		[iOSVersion(2)]		TouchDragInside,					/// <summary>		/// An event where a finger is dragged just outside the bounds of the control.		/// </summary>		[iOSVersion(2)]		TouchDragOutside,					/// <summary>		/// An event where a finger is dragged into the bounds of the control.		/// </summary>		[iOSVersion(2)]		TouchDragEnter,					/// <summary>		/// An event where a finger is dragged from within a control to outside its bounds.		/// </summary>		[iOSVersion(2)]		TouchDragExit,					/// <summary>		/// A touch-up event in the control where the finger is inside the bounds of the control.		/// </summary>		[iOSVersion(2)]		TouchUpInside,					/// <summary>		/// A touch-up event in the control where the finger is outside the bounds of the control.		/// </summary>		[iOSVersion(2)]		TouchUpOutside,					/// <summary>		/// A system event canceling the current touches for the control.		/// </summary>		[iOSVersion(2)]		TouchCancel,					/// <summary>		/// A touch dragging or otherwise manipulating a control, causing it to emit a series of different values.		/// </summary>		[iOSVersion(2)]		ValueChanged,					/// <summary>		/// A touch initiating an editing session in a UITextField object by entering its bounds.		/// </summary>		[iOSVersion(2)]		EditingDidBegin,					/// <summary>		/// A touch making an editing change in a UITextField objet.		/// </summary>		[iOSVersion(2)]		EditingChanged,					/// <summary>		/// A touch ending an editing session in a UITextField object by leaving its bounds.		/// </summary>		[iOSVersion(2)]		EditingDidEnd,					/// <summary>		/// A touch ending an editing session in a UITextField object.		/// </summary>		[iOSVersion(2)]		EditingDidEndOnExit,					/// <summary>		/// All touch events.		/// </summary>		[iOSVersion(2)]		AllTouchEvents,					/// <summary>		/// All editing touches for UITextField objects.		/// </summary>		[iOSVersion(2)]		AllEditingEvents,					/// <summary>		/// A range of control-event values available for application use.		/// </summary>		[iOSVersion(2)]		ApplicationReserved,					/// <summary>		/// A range of control-event values reserved for internal framework use.		/// </summary>		[iOSVersion(2)]		SystemReserved,					/// <summary>		/// All events, including system events.		/// </summary>		[iOSVersion(2)]		AllEvents,	}	/// <summary>	/// The vertical alignment of content (text and images) within a control.	/// </summary>	public enum UIControlContentVerticalAlignment	{		/// <summary>		/// Aligns the content vertically in the center of the control.		/// </summary>		[iOSVersion(2)]		Center,					/// <summary>		/// Aligns the content vertically at the top in the control (the default).		/// </summary>		[iOSVersion(2)]		Top,					/// <summary>		/// Aligns the content vertically at the bottom in the control		/// </summary>		[iOSVersion(2)]		Bottom,					/// <summary>		/// Aligns the content vertically to fill the content rectangle; images may be stretched.		/// </summary>		[iOSVersion(2)]		Fill,	}	/// <summary>	/// The horizontal alignment of content (text and images) within a control.	/// </summary>	public enum UIControlContentHorizontalAlignment	{		/// <summary>		/// Aligns the content horizontally in the center of the control.		/// </summary>		[iOSVersion(2)]		Center,					/// <summary>		/// Aligns the content horizontally from the left of the control (the default).		/// </summary>		[iOSVersion(2)]		Left,					/// <summary>		/// Aligns the content horizontally from the right of the control		/// </summary>		[iOSVersion(2)]		Right,					/// <summary>		/// Aligns the content horizontally to fill the content rectangles; text may wrap and images may be stretched.		/// </summary>		[iOSVersion(2)]		Fill,	}	/// <summary>	/// The state of a control; a control can have more than one state at a time. States are recognized differently depending on the control. For example, a UIButton instance may be configured (using the setImage:forState: method) to display one image when it is in its normal state and a different image when it is highlighted.	/// </summary>	public enum UIControlState	{		/// <summary>		/// The normal, or default state of a control—that is, enabled but neither selected nor highlighted.		/// </summary>		[iOSVersion(2)]		Normal,					/// <summary>		/// Highlighted state of a control. A control enters this state when a touch enters and exits during tracking and when there is a touch up event. You can retrieve and set this value through the highlighted property.		/// </summary>		[iOSVersion(2)]		Highlighted,					/// <summary>		/// Disabled state of a control. This state indicates that the control is currently disabled. You can retrieve and set this value through the enabled property.		/// </summary>		[iOSVersion(2)]		Disabled,					/// <summary>		/// Selected state of a control. For many controls, this state has no effect on behavior or appearance. But other subclasses (for example, the UISegmentedControl class) may have different appearance depending on their selected state. You can retrieve and set this value through the selected property.		/// </summary>		[iOSVersion(2)]		Selected,					/// <summary>		/// Additional control-state flags available for application use.		/// </summary>		[iOSVersion(2)]		Application,					/// <summary>		/// Control-state flags reserved for internal framework use.		/// </summary>		[iOSVersion(2)]		Reserved,	}}