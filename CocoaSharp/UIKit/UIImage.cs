using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIImage_Class/index.html#//apple_ref/occ/cl/UIImage    /// <summary>    /// A UIImage object is a high-level way to display image data. You can create images from files, from Quartz image objects, or from raw image data you receive. The UIImage class also offers several options for drawing images to the current graphics context using different blend modes and opacity values.    /// </summary>    [iOSVersion(2)]    public class UIImage : NSObject    {        /// <summary>        /// Returns an image in the bundle that is compatible with the trait collection.        /// </summary>        /// <param name="named">The name of the image.</param>        /// <param name="inBundle">The bundle the image file or asset catalog is located in, pass nil to use the main bundle.</param>        /// <param name="compatibleWithTraitCollection">Traits that describe the desired image to retrieve, pass nil to use traits that describe the main screen.</param>        /// <returns>An image that exactly or best matches the desired traits with the given name, or nil if no suitable image was found.</returns>        [iOSVersion(8)]        public UIImage Init(string named, NSBundle inBundle, UITraitCollection compatibleWithTraitCollection) { }                /// <summary>        /// Returns the image object associated with the specified filename.        /// </summary>        /// <param name="named">The name of the file. If this is the first time the image is being loaded, the method looks for an image with the specified name in the application’s main bundle.</param>        /// <returns>The image object for the specified file, or nil if the method could not find the specified image.</returns>        [iOSVersion(2)]        public UIImage Init(string named) { }                /// <summary>        /// Returns a new version of the image that uses the specified alignment insets.        /// </summary>        /// <param name="alignmentInsets">The alignment metadata to apply to the new image.</param>        /// <returns>A new image object.</returns>        [iOSVersion(6)]        [Export("imageWithAlignmentRectInsets")]        public UIImage ImageWithAlignmentRectInsets(UIEdgeInsets alignmentInsets) { return null; }                /// <summary>        /// Creates and returns an animated image.        /// </summary>        /// <param name="name">The full or partial path to the file (sans suffix).</param>        /// <param name="duration">The duration of the animation.</param>        /// <returns>A new image object.</returns>        [iOSVersion(5)]        [Export("animatedImageNamed")]        public static UIImage AnimatedImageNamed(string name, NSTimeinterval duration) { return null; }                /// <summary>        /// Creates and returns an animated image from an existing set of images.        /// </summary>        /// <param name="images">An array of UIImage objects.</param>        /// <param name="duration">The duration of the animation.</param>        /// <returns>A new image object.</returns>        [iOSVersion(5)]        [Export("animatedImageWithImages")]        public static UIImage AnimatedImageWithImages(AnyObject[] images, NSTimeinterval duration) { return null; }                /// <summary>        /// Creates and returns an animated image with end caps.        /// </summary>        /// <param name="name">The full or partial path to the file (sans suffix).</param>        /// <param name="capInsets">The values to use for the cap insets.</param>        /// <param name="duration">The duration of the animation.</param>        /// <returns>A new image object.</returns>        [iOSVersion(5)]        [Export("animatedResizableImageNamed")]        public static UIImage AnimatedResizableImageNamed(string name, UIEdgeInsets capInsets, NSTimeinterval duration) { return null; }                /// <summary>        /// Creates and returns a new image object with the specified cap values.				 		  Deprecation Statement		  		 Deprecated. Use the resizableImageWithCapInsets: instead, specifying cap insets such that the interior is a 1x1 area.        /// </summary>        /// <param name="leftCapWidth">The value to use for the left cap width. Specify 0 if you want the entire image to be horizontally stretchable. For a discussion of how a non-zero value affects the image, see the leftCapWidth property.</param>        /// <param name="topCapHeight">The value to use for the top cap width. Specify 0 if you want the entire image to be vertically stretchable. For a discussion of how a non-zero value affects the image, see the topCapHeight property.</param>        /// <returns>A new image object with the specified cap values.</returns>        [Obsolete]        [iOSVersion(2)]        [Export("stretchableImageWithLeftCapWidth")]        public UIImage StretchableImageWithLeftCapWidth(int leftCapWidth, int topCapHeight) { return null; }                /// <summary>        /// Creates and returns a new image object with the specified cap insets.        /// </summary>        /// <param name="capInsets">The values to use for the cap insets.</param>        /// <returns>A new image object with the specified cap insets.</returns>        [iOSVersion(5)]        [Export("resizableImageWithCapInsets")]        public UIImage ResizableImageWithCapInsets(UIEdgeInsets capInsets) { return null; }                /// <summary>        /// Creates and returns an animated image with end caps and a specific resizing mode.        /// </summary>        /// <param name="name">The full or partial path to the file (sans suffix).</param>        /// <param name="capInsets">The values to use for the cap insets.</param>        /// <param name="resizingMode">The mode with which the interior of the image is resized.</param>        /// <param name="duration">The duration of the animation.</param>        /// <returns>A new animated image object with the specified cap insets and resizing mode.</returns>        [iOSVersion(6)]        [Export("animatedResizableImageNamed")]        public static UIImage AnimatedResizableImageNamed(string name, UIEdgeInsets capInsets, UIImageResizingMode resizingMode, NSTimeinterval duration) { return null; }                /// <summary>        /// Creates and returns a new image object with the specified cap insets and options.        /// </summary>        /// <param name="capInsets">The values to use for the cap insets.</param>        /// <param name="resizingMode">The mode with which the interior of the image is resized.</param>        /// <returns>A new image object with the specified cap insets and resizing mode.</returns>        [iOSVersion(6)]        [Export("resizableImageWithCapInsets")]        public UIImage ResizableImageWithCapInsets(UIEdgeInsets capInsets, UIImageResizingMode resizingMode) { return null; }                /// <summary>        /// Creates and returns a new image object with the specified rendering mode.        /// </summary>        /// <param name="renderingMode">The rendering mode to use for the new image.</param>        /// <returns>A new image object with the specified rendering mode.</returns>        [iOSVersion(7)]        [Export("imageWithRenderingMode")]        public UIImage ImageWithRenderingMode(UIImageRenderingMode renderingMode) { return null; }                /// <summary>        /// Initializes and returns the image object with the contents of the specified file.        /// </summary>        /// <param name="contentsOfFile">The path to the file. This path should include the filename extension that identifies the type of the image data.</param>        /// <returns>An initialized UIImage object, or nil if the method could not find the file or initialize the image from its contents.</returns>        [iOSVersion(2)]        public UIImage(string contentsOfFile) { }                /// <summary>        /// Initializes and returns the image object with the specified data.        /// </summary>        /// <param name="data">The data object containing the image data.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(2)]        public UIImage(NSData data) { }                /// <summary>        /// Initializes and returns the image object with the specified data and scale factor.        /// </summary>        /// <param name="data">The data object containing the image data.</param>        /// <param name="scale">The scale factor to assume when interpreting the image data. Applying a scale factor of 1.0 results in an image whose size matches the pixel-based dimensions of the image. Applying a different scale factor changes the size of the image as reported by the size property.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(6)]        public UIImage(NSData data, CGFloat scale) { }                /// <summary>        /// Initializes and returns the image object with the specified Quartz image reference.        /// </summary>        /// <param name="CGImage">A Quartz image reference.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(2)]        public UIImage(CGImage CGImage) { }                /// <summary>        /// Initializes and returns an image object with the specified scale and orientation factors        /// </summary>        /// <param name="CGImage">The Quartz image object.</param>        /// <param name="scale">The scale factor to assume when interpreting the image data. Applying a scale factor of 1.0 results in an image whose size matches the pixel-based dimensions of the image. Applying a different scale factor changes the size of the image as reported by the size property.</param>        /// <param name="orientation">The orientation of the image data. You can use this parameter to specify any rotation factors applied to the image.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(4)]        public UIImage(CGImage CGImage, CGFloat scale, UIImageOrientation orientation) { }                /// <summary>        /// Initializes and returns an image object with the specified Core Image object.        /// </summary>        /// <param name="CIImage">The Core Image object.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(5)]        public UIImage(CIImage CIImage) { }                /// <summary>        /// Initializes and returns an image object with the specified Core Image object and properties.        /// </summary>        /// <param name="CIImage">The Core Image object.</param>        /// <param name="scale">The scale factor to assume when interpreting the image data. Applying a scale factor of 1.0 results in an image whose size matches the pixel-based dimensions of the image. Applying a different scale factor changes the size of the image as reported by the size property.</param>        /// <param name="orientation">The orientation of the image data. You can use this parameter to specify any rotation factors applied to the image.</param>        /// <returns>An initialized UIImage object, or nil if the method could not initialize the image from the specified data.</returns>        [iOSVersion(6)]        public UIImage(CIImage CIImage, CGFloat scale, UIImageOrientation orientation) { }                /// <summary>        /// The orientation of the receiver’s image. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("imageOrientation")]        public UIImageOrientation ImageOrientation { get; private set; }                /// <summary>        /// The dimensions of the image, taking orientation into account. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("size")]        public CGSize Size { get; private set; }                /// <summary>        /// The scale factor of the image. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("scale")]        public CGFloat Scale { get; private set; }                /// <summary>        /// The resizing mode of the image. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("resizingMode")]        public UIImageResizingMode ResizingMode { get; private set; }                /// <summary>        /// The underlying Quartz image data. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("CGImage")]        public CGImage CGImage { get; private set; }                /// <summary>        /// The underlying Core Image data. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("CIImage")]        public CIImage CIImage { get; private set; }                /// <summary>        /// For an animated image, this property holds the complete array of UIImage objects that make up the animation. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("images")]        public AnyObject[] Images { get; private set; }                /// <summary>        /// Returns the time interval used to display an animated image. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("duration")]        public NSTimeinterval Duration { get; private set; }                /// <summary>        /// The end-cap insets. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("capInsets")]        public UIEdgeInsets CapInsets { get; private set; }                /// <summary>        /// The horizontal end-cap size. (read-only)
        /// Deprecation Statement: Use the capInsets property instead.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("leftCapWidth")]        public int LeftCapWidth { get; private set; }                /// <summary>        /// The vertical end-cap size. (read-only)
        /// Deprecation Statement: Use the capInsets property instead.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("topCapHeight")]        public int TopCapHeight { get; private set; }                /// <summary>        /// The alignment metadata used to position the image during layout. (read-only)        /// </summary>        [iOSVersion(6)]        [Export("alignmentRectInsets")]        public UIEdgeInsets AlignmentRectInsets { get; private set; }                /// <summary>        /// Returns a reference to the image asset the image is associated with. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("imageAsset")]        public UIImageAsset ImageAsset { get; private set; }                /// <summary>        /// Returns the trait collection that describes the image. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("traitCollection")]        public UITraitCollection TraitCollection { get; private set; }                /// <summary>        /// Determines how an image is rendered. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("renderingMode")]        public UIImageRenderingMode RenderingMode { get; private set; }                /// <summary>        /// Draws the image at the specified point in the current context.        /// </summary>        /// <param name="point">The point at which to draw the top-left corner of the image.</param>        [iOSVersion(2)]        [Export("drawAtPoint")]        public void DrawAtPoint(CGPoint point) { }                /// <summary>        /// Draws the entire image at the specified point using the custom compositing options.        /// </summary>        /// <param name="point">The point at which to draw the top-left corner of the image.</param>        /// <param name="blendMode">The blend mode to use when compositing the image.</param>        /// <param name="alpha">The desired opacity of the image, specified as a value between 0.0 and 1.0. A value of 0.0 renders the image totally transparent while 1.0 renders it fully opaque. Values larger than 1.0 are interpreted as 1.0.</param>        [iOSVersion(2)]        [Export("drawAtPoint")]        public void DrawAtPoint(CGPoint point, CGBlendMode blendMode, CGFloat alpha) { }                /// <summary>        /// Draws the entire image in the specified rectangle, scaling it as needed to fit.        /// </summary>        /// <param name="rect">The rectangle (in the coordinate system of the graphics context) in which to draw the image.</param>        [iOSVersion(2)]        [Export("drawInRect")]        public void DrawInRect(CGRect rect) { }                /// <summary>        /// Draws the entire image in the specified rectangle and using the specified compositing options.        /// </summary>        /// <param name="rect">The rectangle (in the coordinate system of the graphics context) in which to draw the image.</param>        /// <param name="blendMode">The blend mode to use when compositing the image.</param>        /// <param name="alpha">The desired opacity of the image, specified as a value between 0.0 and 1.0. A value of 0.0 renders the image totally transparent while 1.0 renders it fully opaque. Values larger than 1.0 are interpreted as 1.0.</param>        [iOSVersion(2)]        [Export("drawInRect")]        public void DrawInRect(CGRect rect, CGBlendMode blendMode, CGFloat alpha) { }                /// <summary>        /// Draws a tiled Quartz pattern using the receiver’s contents as the tile pattern.        /// </summary>        /// <param name="rect">The rectangle (in the coordinate system of the graphics context) in which to draw the image.</param>        [iOSVersion(2)]        [Export("drawAsPatternInRect")]        public void DrawAsPatternInRect(CGRect rect) { }
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
    }}