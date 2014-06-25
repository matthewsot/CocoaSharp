using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPageViewControllerClassReferenceClassRef/index.html#//apple_ref/occ/cl/UIPageViewController    /// <summary>    /// A page view controller lets the user navigate between pages of content, where each page is managed by its own view controller object. Navigation can be controlled programmatically by your app or directly by the user using gestures. When navigating from page to page, the page view controller uses the transition that you specify to animate the change.    /// </summary>    [iOSVersion(5)]    public class UIPageViewController : UIViewController    {        /// <summary>        /// Initializes a newly created page view controller.        /// </summary>        /// <param name="transitionStyle">The style for transitions between pages.</param>        /// <param name="navigationOrientation">The orientation of the page-by-page navigation.</param>        /// <param name="options">A dictionary of options. For keys, see Options Keys.</param>        /// <returns>The initialized page view controller.</returns>        [iOSVersion(5)]        public UIPageViewController(UIPageViewControllerTransitionStyle transitionStyle, UIPageViewControllerNavigationOrientation navigationOrientation, NSDictionary options) { }                /// <summary>        /// The object that provides view controllers.        /// </summary>        [iOSVersion(5)]        [Export("dataSource")]        public UIPageViewControllerDataSource DataSource { get; set; }                /// <summary>        /// The delegate object.        /// </summary>        [iOSVersion(5)]        [Export("delegate")]        public UIPageViewControllerDelegate Delegate { get; set; }                /// <summary>        /// Sets the view controllers to be displayed.        /// </summary>        /// <param name="viewControllers">The view controller or view controllers to be displayed.</param>        /// <param name="direction">The navigation direction.</param>        /// <param name="animated">A Boolean value that indicates whether the transition is to be animated.</param>        /// <param name="completion">A block to be called when the page-turn animation completes.   The block takes the following parameters:           finished              true if the animation finished; false if it was skipped.</param>        [iOSVersion(5)]        [Export("setViewControllers")]        public void SetViewControllers(AnyObject[] viewControllers, UIPageViewControllerNavigationDirection direction, bool animated, Action<bool> completion) { }                /// <summary>        /// The view controllers displayed by the page view controller. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("viewControllers")]        public AnyObject[] ViewControllers { get; private set; }                /// <summary>        /// An array of UIGestureRecognizer objects that are configured to handle user interaction. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("gestureRecognizers")]        public AnyObject[] GestureRecognizers { get; private set; }                /// <summary>        /// The direction along which navigation occurs. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("navigationOrientation")]        public UIPageViewControllerNavigationOrientation NavigationOrientation { get; private set; }                /// <summary>        /// The location of the spine. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("spineLocation")]        public UIPageViewControllerSpineLocation SpineLocation { get; private set; }                /// <summary>        /// The style used to transition between view controllers. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("transitionStyle")]        public UIPageViewControllerTransitionStyle TransitionStyle { get; private set; }                /// <summary>        /// A Boolean value that indicates whether content appears on the back of pages.        /// </summary>        [iOSVersion(5)]        [Export("doubleSided")]        public bool DoubleSided { get; set; }        /// <summary>        /// Keys for the options dictionary.        /// </summary>                /// <summary>        /// Location of the spine.        /// </summary>        [iOSVersion(5)]        public string UIPageViewControllerOptionSpineLocationKey { get; private set; }                /// <summary>        /// Space between pages, in points.        /// </summary>        [iOSVersion(6)]        public string UIPageViewControllerOptioninterPageSpacingKey { get; private set; }
    }

    /// <summary>
    /// Orientations for page-turn transitions.
    /// </summary>
    public enum UIPageViewControllerNavigationOrientation
    {
        /// <summary>
        /// Horizontal orientation, with pages turning left and right.
        /// </summary>
        [iOSVersion(5)]
        Horizontal,

        /// <summary>
        /// Vertical orientation, with pages turning up and down.
        /// </summary>
        [iOSVersion(5)]
        Vertical,
    }
    /// <summary>
    /// Directions for page-turn transitions.
    /// </summary>
    public enum UIPageViewControllerNavigationDirection
    {
        /// <summary>
        /// Navigation to the next page.
        /// </summary>
        [iOSVersion(5)]
        Forward,

        /// <summary>
        /// Navigation to the previous page.
        /// </summary>
        [iOSVersion(5)]
        Reverse,
    }
    /// <summary>
    /// Styles for the page-turn transition.
    /// </summary>
    public enum UIPageViewControllerTransitionStyle
    {
        /// <summary>
        /// Page curl transition style.
        /// </summary>
        [iOSVersion(5)]
        PageCurl,

        /// <summary>
        /// Scrolling transition style.
        /// </summary>
        [iOSVersion(6)]
        Scroll,
    }

    /// <summary>
    /// Locations for the spine.
    /// </summary>
    public enum UIPageViewControllerSpineLocation
    {
        /// <summary>
        /// No spine.
        /// </summary>
        [iOSVersion(5)]
        None,

        /// <summary>
        /// Spine at the left or top edge of the screen.
        /// </summary>
        [iOSVersion(5)]
        Min,

        /// <summary>
        /// Spine in the middle or the screen.
        /// </summary>
        [iOSVersion(5)]
        Mid,

        /// <summary>
        /// Spine at the right or bottom edge of the screen.
        /// </summary>
        [iOSVersion(5)]
        Max,
    }}