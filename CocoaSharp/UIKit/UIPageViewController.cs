using ObjectiveC;
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
    }