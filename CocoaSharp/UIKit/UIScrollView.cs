using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIScrollView class provides support for displaying content that is larger than the size of the application’s window. It enables users to scroll within that content by making swiping gestures, and to zoom in and back from portions of the content by making pinching gestures.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIScrollView_Class/index.html#//apple_ref/occ/cl/UIScrollView"/>    [iOSVersion(2)]    public class UIScrollView : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UITraitEnvironment    {        /// <summary>        /// Sets the offset from the content view’s origin that corresponds to the receiver’s origin.        /// </summary>        /// <param name="contentOffset">A point (expressed in points) that is offset from the content view’s origin.</param>        /// <param name="animated">true to animate the transition at a constant velocity to the new offset, false to make the transition immediate.</param>        [iOSVersion(2)]        [Export("setContentOffset")]        public void SetContentOffset(CGPoint contentOffset, bool animated) {  }                /// <summary>        /// Scrolls a specific area of the content so that it is visible in the receiver.        /// </summary>        /// <param name="rect">A rectangle defining an area of the content view. The rectangle should be in the coordinate space of the scroll view.</param>        /// <param name="animated">true if the scrolling should be animated, false if it should be immediate.</param>        [iOSVersion(2)]        [Export("scrollRectToVisible")]        public void ScrollRectToVisible(CGRect rect, bool animated) {  }                /// <summary>        /// Overridden by subclasses to customize the default behavior when a finger touches down in displayed content.        /// </summary>        /// <param name="touches">A set of UITouch instances that represent the touches for the starting phase of the event represented by event.</param>        /// <param name="withEvent">An object representing the event to which the touch objects in touches belong.</param>        /// <param name="inContentView">The subview in the content where the touch-down gesture occurred.</param>        [iOSVersion(2)]        [Export("touchesShouldBegin")]        public bool TouchesShouldBegin(NSSet touches, UIEvent withEvent, UIView inContentView) { return default(bool); }                /// <summary>        /// Returns whether to cancel touches related to the content subview and start dragging.        /// </summary>        /// <param name="view">The view object in the content that is being touched.</param>        [iOSVersion(2)]        [Export("touchesShouldCancelInContentView")]        public bool TouchesShouldCancelInContentView(UIView view) { return default(bool); }                /// <summary>        /// Displays the scroll indicators momentarily.        /// </summary>        [iOSVersion(2)]        [Export("flashScrollIndicators")]        public void FlashScrollIndicators() {  }                /// <summary>        /// Zooms to a specific area of the content so that it is visible in the receiver.        /// </summary>        /// <param name="rect">A rectangle defining an area of the content view. The rectangle should be in the coordinate space of the view returned by viewForZoomingInScrollView:.</param>        /// <param name="animated">true if the scrolling should be animated, false if it should be immediate.</param>        [iOSVersion(3)]        [Export("zoomToRect")]        public void ZoomToRect(CGRect rect, bool animated) {  }                /// <summary>        /// A floating-point value that specifies the current zoom scale.        /// </summary>        /// <param name="scale">The new value to scale the content to.</param>        /// <param name="animated">true to animate the transition to the new scale, false to make the transition immediate.</param>        [iOSVersion(3)]        [Export("setZoomScale")]        public void SetZoomScale(CGFloat scale, bool animated) {  }                /// <summary>        /// The point at which the origin of the content view is offset from the origin of the scroll view.        /// </summary>        [iOSVersion(2)]        [Export("contentOffset")]        public CGPoint ContentOffset { get; set; }                /// <summary>        /// The size of the content view.        /// </summary>        [iOSVersion(2)]        [Export("contentSize")]        public CGSize ContentSize { get; set; }                /// <summary>        /// The distance that the content view is inset from the enclosing scroll view.        /// </summary>        [iOSVersion(2)]        [Export("contentInset")]        public UIEdgeInsets ContentInset { get; set; }                /// <summary>        /// A Boolean value that determines whether scrolling is enabled.        /// </summary>        [iOSVersion(2)]        [Export("scrollEnabled")]        public bool ScrollEnabled { get; set; }                /// <summary>        /// A Boolean value that determines whether scrolling is disabled in a particular direction.        /// </summary>        [iOSVersion(2)]        [Export("directionalLockEnabled")]        public bool DirectionalLockEnabled { get; set; }                /// <summary>        /// A Boolean value that controls whether the scroll-to-top gesture is enabled.        /// </summary>        [iOSVersion(2)]        [Export("scrollsToTop")]        public bool ScrollsToTop { get; set; }                /// <summary>        /// A Boolean value that determines whether paging is enabled for the scroll view.        /// </summary>        [iOSVersion(2)]        [Export("pagingEnabled")]        public bool PagingEnabled { get; set; }                /// <summary>        /// A Boolean value that controls whether the scroll view bounces past the edge of content and back again.        /// </summary>        [iOSVersion(2)]        [Export("bounces")]        public bool Bounces { get; set; }                /// <summary>        /// A Boolean value that determines whether bouncing always occurs when vertical scrolling reaches the end of the content.        /// </summary>        [iOSVersion(2)]        [Export("alwaysBounceVertical")]        public bool AlwaysBounceVertical { get; set; }                /// <summary>        /// A Boolean value that determines whether bouncing always occurs when horizontal scrolling reaches the end of the content view.        /// </summary>        [iOSVersion(2)]        [Export("alwaysBounceHorizontal")]        public bool AlwaysBounceHorizontal { get; set; }                /// <summary>        /// A Boolean value that controls whether touches in the content view always lead to tracking.        /// </summary>        [iOSVersion(2)]        [Export("canCancelContentTouches")]        public bool CanCancelContentTouches { get; set; }                /// <summary>        /// A Boolean value that determines whether the scroll view delays the handling of touch-down gestures.        /// </summary>        [iOSVersion(2)]        [Export("delaysContentTouches")]        public bool DelaysContentTouches { get; set; }                /// <summary>        /// A floating-point value that determines the rate of deceleration after the user lifts their finger.        /// </summary>        [iOSVersion(3)]        [Export("decelerationRate")]        public CGFloat DecelerationRate { get; set; }                /// <summary>        /// A Boolean value that indicates whether the user has begun scrolling the content. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("dragging")]        public bool Dragging { get; private set; }                /// <summary>        /// Returns whether the user has touched the content to initiate scrolling. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("tracking")]        public bool Tracking { get; private set; }                /// <summary>        /// Returns whether the content is moving in the scroll view after the user lifted their finger. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("decelerating")]        public bool Decelerating { get; private set; }                /// <summary>        /// The style of the scroll indicators.        /// </summary>        [iOSVersion(2)]        [Export("indicatorStyle")]        public UIScrollViewIndicatorStyle IndicatorStyle { get; set; }                /// <summary>        /// The distance the scroll indicators are inset from the edge of the scroll view.        /// </summary>        [iOSVersion(2)]        [Export("scrollIndicatorInsets")]        public UIEdgeInsets ScrollIndicatorInsets { get; set; }                /// <summary>        /// A Boolean value that controls whether the horizontal scroll indicator is visible.        /// </summary>        [iOSVersion(2)]        [Export("showsHorizontalScrollIndicator")]        public bool ShowsHorizontalScrollIndicator { get; set; }                /// <summary>        /// A Boolean value that controls whether the vertical scroll indicator is visible.        /// </summary>        [iOSVersion(2)]        [Export("showsVerticalScrollIndicator")]        public bool ShowsVerticalScrollIndicator { get; set; }                /// <summary>        /// The underlying gesture recognizer for pan gestures. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("panGestureRecognizer")]        public UIPanGestureRecognizer PanGestureRecognizer { get; private set; }                /// <summary>        /// The underlying gesture recognizer for pinch gestures. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("pinchGestureRecognizer")]        public UIPinchGestureRecognizer PinchGestureRecognizer { get; private set; }                /// <summary>        /// A floating-point value that specifies the current scale factor applied to the scroll view's content.        /// </summary>        [iOSVersion(3)]        [Export("zoomScale")]        public CGFloat ZoomScale { get; set; }                /// <summary>        /// A floating-point value that specifies the maximum scale factor that can be applied to the scroll view's content.        /// </summary>        [iOSVersion(2)]        [Export("maximumZoomScale")]        public CGFloat MaximumZoomScale { get; set; }                /// <summary>        /// A floating-point value that specifies the minimum scale factor that can be applied to the scroll view's content.        /// </summary>        [iOSVersion(2)]        [Export("minimumZoomScale")]        public CGFloat MinimumZoomScale { get; set; }                /// <summary>        /// A Boolean value that indicates that zooming has exceeded the scaling limits specified for the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("zoomBouncing")]        public bool ZoomBouncing { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the content view is currently zooming in or out. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("zooming")]        public bool Zooming { get; private set; }                /// <summary>        /// A Boolean value that determines whether the scroll view animates the content scaling when the scaling exceeds the maximum or minimum limits.        /// </summary>        [iOSVersion(2)]        [Export("bouncesZoom")]        public bool BouncesZoom { get; set; }                /// <summary>        /// The delegate of the scroll-view object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public UIScrollViewDelegate Delegate { get; set; }                /// <summary>        /// The manner in which the keyboard is dismissed when a drag begins in the scroll view.        /// </summary>        [iOSVersion(7)]        [Export("keyboardDismissMode")]        public UIScrollViewKeyboardDismissMode KeyboardDismissMode { get; set; }    }    /// <summary>    /// The style of the scroll indicators. You use these constants to set the value of the indicatorStyle style.    /// </summary>    [iOSVersion(2)]    public enum UIScrollViewIndicatorStyle    {        /// <summary>        /// The default style of scroll indicator, which is black with a white border. This style is good against any content background.        /// </summary>        [iOSVersion(2)]        Default,        /// <summary>        /// A style of indicator which is black and smaller than the default style. This style is good against a white content background.        /// </summary>        [iOSVersion(2)]        Black,        /// <summary>        /// A style of indicator is white and smaller than the default style. This style is good against a black content background.        /// </summary>        [iOSVersion(2)]        White,    }    /// <summary>    /// The manner in which the keyboard is dismissed when a drag begins in the scroll view.    /// </summary>    [iOSVersion(7)]    public enum UIScrollViewKeyboardDismissMode    {        /// <summary>        /// The keyboard does not get dismissed with a drag.        /// </summary>        [iOSVersion(7)]        None,        /// <summary>        /// The keyboard is dismissed when a drag begins.        /// </summary>        [iOSVersion(7)]        OnDrag,        /// <summary>        /// The keyboard follows the dragging touch offscreen, and can be pulled upward again to cancel the dismiss.        /// </summary>        [iOSVersion(7)]        Interactive,    }}