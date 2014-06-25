using CoreGraphics;
using ObjectiveC;
    }

    /// <summary>
    /// Specifies the style of a item.
    /// </summary>
    public enum UIBarButtonItemStyle
    {
        /// <summary>
        /// Glows when tapped. The default item style.
        /// </summary>
        [iOSVersion(2)]
        Plain,

        /// <summary>
        /// A simple button style with a border.
        /// </summary>
        [iOSVersion(8)]
        Bordered,

        /// <summary>
        /// The style for a done button—for example, a button that completes some task and returns to the previous view.
        /// </summary>
        [iOSVersion(2)]
        Done,
    }

    /// <summary>
    /// Defines system-supplied images for bar button items.
    /// </summary>
    public enum UIBarButtonSystemItem
    {
        /// <summary>
        /// The system Done button. Localized.
        /// </summary>
        [iOSVersion(2)]
        Done,

        /// <summary>
        /// The system Cancel button. Localized.
        /// </summary>
        [iOSVersion(2)]
        Cancel,

        /// <summary>
        /// The system Edit button. Localized.
        /// </summary>
        [iOSVersion(2)]
        Edit,

        /// <summary>
        /// The system Save button. Localized.
        /// </summary>
        [iOSVersion(2)]
        Save,

        /// <summary>
        /// The system plus button containing an icon of a plus sign.
        /// </summary>
        [iOSVersion(2)]
        Add,

        /// <summary>
        /// Blank space to add between other items. The space is distributed equally between the other items. Other item properties are ignored when this value is set.
        /// </summary>
        [iOSVersion(2)]
        FlexibleSpace,

        /// <summary>
        /// Blank space to add between other items. Only the width property is used when this value is set.
        /// </summary>
        [iOSVersion(2)]
        FixedSpace,

        /// <summary>
        /// The system compose button.
        /// </summary>
        [iOSVersion(2)]
        Compose,

        /// <summary>
        /// The system reply button.
        /// </summary>
        [iOSVersion(2)]
        Reply,

        /// <summary>
        /// The system action button.
        /// </summary>
        [iOSVersion(2)]
        Action,

        /// <summary>
        /// The system organize button.
        /// </summary>
        [iOSVersion(2)]
        Organize,

        /// <summary>
        /// The system bookmarks button.
        /// </summary>
        [iOSVersion(2)]
        Bookmarks,

        /// <summary>
        /// The system search button.
        /// </summary>
        [iOSVersion(2)]
        Search,

        /// <summary>
        /// The system refresh button.
        /// </summary>
        [iOSVersion(2)]
        Refresh,

        /// <summary>
        /// The system stop button.
        /// </summary>
        [iOSVersion(2)]
        Stop,

        /// <summary>
        /// The system camera button.
        /// </summary>
        [iOSVersion(2)]
        Camera,

        /// <summary>
        /// The system trash button.
        /// </summary>
        [iOSVersion(2)]
        Trash,

        /// <summary>
        /// The system play button.
        /// </summary>
        [iOSVersion(2)]
        Play,

        /// <summary>
        /// The system pause button.
        /// </summary>
        [iOSVersion(2)]
        Pause,

        /// <summary>
        /// The system rewind button.
        /// </summary>
        [iOSVersion(2)]
        Rewind,

        /// <summary>
        /// The system fast forward button.
        /// </summary>
        [iOSVersion(2)]
        FastForward,

        /// <summary>
        /// The system undo button.
        /// </summary>
        [iOSVersion(3)]
        Undo,

        /// <summary>
        /// The system redo button.
        /// </summary>
        [iOSVersion(3)]
        Redo,

        /// <summary>
        /// The system page curl button.
        /// </summary>
        [iOSVersion(4)]
        PageCurl,
    }