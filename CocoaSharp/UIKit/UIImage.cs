using CoreGraphics;
using ObjectiveC;
    }

    /// <summary>
    /// Specifies the possible orientations of an image.
    /// </summary>
    public enum UIImageOrientation
    {
        /// <summary>
        /// The default orientation of images. The image is drawn right-side up, as shown here.
        /// </summary>
        [iOSVersion(2)]
        Up,

        /// <summary>
        /// The image is rotated 180 degrees, as shown here.
        /// </summary>
        [iOSVersion(2)]
        Down,

        /// <summary>
        /// The image is rotated 90 degrees clockwise, as shown here.
        /// </summary>
        [iOSVersion(2)]
        Left,

        /// <summary>
        /// The image is rotated 90 degrees counterclockwise, as shown here.
        /// </summary>
        [iOSVersion(2)]
        Right,

        /// <summary>
        /// The image is drawn as a mirror version of an image drawn with the UIImageOrientationUp value. In other words, the image is flipped along its horizontal axis, as shown here.
        /// </summary>
        [iOSVersion(2)]
        UpMirrored,

        /// <summary>
        /// The image is drawn as a mirror version of an image drawn with the UIImageOrientationDown value. This is the equivalent to flipping an image in the “up” orientation along its horizontal axis and then rotating the image 180 degrees, as shown here.
        /// </summary>
        [iOSVersion(2)]
        DownMirrored,

        /// <summary>
        /// The image is drawn as a mirror version of an image drawn with the UIImageOrientationLeft value. This is the equivalent to flipping an image in the “up” orientation along its horizontal axis and then rotating the image 90 degrees counterclockwise, as shown here.
        /// </summary>
        [iOSVersion(2)]
        LeftMirrored,

        /// <summary>
        /// The image is drawn as a mirror version of an image drawn with the UIImageOrientationRight value. This is the equivalent to flipping an image in the “up” orientation along its horizontal axis and then rotating the image 90 degrees clockwise, as shown here.
        /// </summary>
        [iOSVersion(2)]
        RightMirrored,
    }
    /// <summary>
    /// Specifies the possible resizing modes for an image.
    /// </summary>
    public enum UIImageResizingMode
    {
        /// <summary>
        /// The image is tiled when it is resized. In other words, the interior region of the original image will be repeated to fill in the interior region of the newly resized image.
        /// </summary>
        [iOSVersion(6)]
        Tile,

        /// <summary>
        /// The image is stretched when it is resized. In other words, the interior region of the original image will be scaled to fill in the interior region of the newly resized imaged.
        /// </summary>
        [iOSVersion(6)]
        Stretch,
    }
    /// <summary>
    /// Specifies the possible rendering modes for an image.
    /// </summary>
    public enum UIImageRenderingMode
    {
        /// <summary>
        /// Use the default rendering mode for the context where the image is used.
        /// </summary>
        [iOSVersion(7)]
        Automatic,

        /// <summary>
        /// Always draw the original image, without treating it as a template.
        /// </summary>
        [iOSVersion(7)]
        AlwaysOriginal,

        /// <summary>
        /// Always draw the image as a template image, ignoring its color information.
        /// </summary>
        [iOSVersion(7)]
        AlwaysTemplate,
    }