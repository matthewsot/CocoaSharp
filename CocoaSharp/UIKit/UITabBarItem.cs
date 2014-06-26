using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITabBarItem_Class/index.html#//apple_ref/occ/cl/UITabBarItem    /// <summary>    /// The UITabBarItem class implements an item on a UITabBar object. A tab bar operates strictly in radio mode, where one item is selected at a time—tapping a tab bar item toggles the view above the tab bar. You can also specify a badge value on the tab bar item for adding additional visual information—for example, the Messages app uses a badge on the item to show the number of new messages. This class also provides a number of system defaults for creating items.    /// </summary>    [iOSVersion(2)]    public class UITabBarItem : UIBarItem    {        /// <summary>        /// Creates and returns a new item containing the specified system item.        /// </summary>        /// <param name="tabBarSystemItem">The system item to use as the first item on the tab bar. One of the constants defined in UITabBarSystemItem.</param>        /// <param name="tag">The receiver’s tag, an integer that you can use to identify bar item objects in your application.</param>        /// <returns>A newly initialized item containing the specified system item. The item’s target is nil.</returns>        [iOSVersion(2)]        public UITabBarItem(UITabBarSystemItem tabBarSystemItem, int tag) { }                /// <summary>        /// Creates and returns a new item using the specified properties.        /// </summary>        /// <param name="title">The item’s title. If nil, a title is not displayed.</param>        /// <param name="image">The item’s image. If nil, an image is not displayed.</param>        /// <param name="tag">The receiver’s tag, an integer that you can use to identify bar item objects in your application.</param>        /// <returns>Newly initialized item with the specified properties.</returns>        [iOSVersion(2)]        public UITabBarItem(string title, UIImage image, int tag) { }                /// <summary>        /// Creates and returns a new item with the specified title, unselected image, and selected image.        /// </summary>        /// <param name="title">The item’s title. If nil, a title is not displayed.</param>        /// <param name="image">The item’s unselected image. If nil, an image is not displayed.</param>        /// <param name="selectedImage">The item’s selected image. If nil, uses the value of image.</param>        /// <returns>Newly initialized item with the specified title, unselected image, and selected image.</returns>        [iOSVersion(7)]        public UITabBarItem(string title, UIImage image, UIImage selectedImage) { }                /// <summary>        /// Text that is displayed in the upper-right corner of the item with a surrounding red oval.        /// </summary>        [iOSVersion(2)]        [Export("badgeValue")]        public string BadgeValue { get; set; }                /// <summary>        /// The image displayed when the tab bar item is selected.        /// </summary>        [iOSVersion(7)]        [Export("selectedImage")]        public UIImage SelectedImage { get; set; }                /// <summary>        /// Returns the offset to use to adjust the title position.        /// </summary>        /// <returns>The offset to use to adjust the title position.</returns>        [iOSVersion(5)]        [Export("titlePositionAdjustment")]        public UIOffset TitlePositionAdjustment() { return null; }                /// <summary>        /// Sets the offset to use to adjust the title position.        /// </summary>        /// <param name="adjustment">The offset to use to adjust the title position.</param>        [iOSVersion(5)]        [Export("setTitlePositionAdjustment")]        public void SetTitlePositionAdjustment(UIOffset adjustment) { }                /// <summary>        /// Returns the finished selected image.				 		  Deprecation Statement		  		 Use selectedImage with UIImageRenderingModeAlwaysOriginal instead.        /// </summary>        /// <returns>The finished selected image.</returns>        [Obsolete]        [iOSVersion(5)]        [Export("finishedSelectedImage")]        public UIImage FinishedSelectedImage() { return null; }                /// <summary>        /// Returns the finished unselected image.				 		  Deprecation Statement		  		 Use image with UIImageRenderingModeAlwaysOriginal instead.        /// </summary>        /// <returns>The finished unselected image.</returns>        [Obsolete]        [iOSVersion(5)]        [Export("finishedUnselectedImage")]        public UIImage FinishedUnselectedImage() { return null; }                /// <summary>        /// Sets the finished selected and unselected images.				 		  Deprecation Statement		  		 Use image and selectedImage with UIImageRenderingModeAlwaysOriginal instead.        /// </summary>        /// <param name="selectedImage">The finished selected image.</param>        /// <param name="withFinishedUnselectedImage">The finished unselected image.</param>        [Obsolete]        [iOSVersion(5)]        [Export("setFinishedSelectedImage")]        public void SetFinishedSelectedImage(UIImage selectedImage, UIImage withFinishedUnselectedImage) { }    }

    /// <summary>
    /// System items that can be used on a tab bar.
    /// </summary>
    public enum UITabBarSystemItem
    {
        /// <summary>
        /// The more system item.
        /// </summary>
        [iOSVersion(2)]
        More,

        /// <summary>
        /// The favorites system item.
        /// </summary>
        [iOSVersion(2)]
        Favorites,

        /// <summary>
        /// The featured system item.
        /// </summary>
        [iOSVersion(2)]
        Featured,

        /// <summary>
        /// The top rated system item.
        /// </summary>
        [iOSVersion(2)]
        TopRated,

        /// <summary>
        /// The recents system item.
        /// </summary>
        [iOSVersion(2)]
        Recents,

        /// <summary>
        /// The contacts system item.
        /// </summary>
        [iOSVersion(2)]
        Contacts,

        /// <summary>
        /// The history system item.
        /// </summary>
        [iOSVersion(2)]
        History,

        /// <summary>
        /// The bookmarks system item.
        /// </summary>
        [iOSVersion(2)]
        Bookmarks,

        /// <summary>
        /// The search system item.
        /// </summary>
        [iOSVersion(2)]
        Search,

        /// <summary>
        /// The downloads system item.
        /// </summary>
        [iOSVersion(2)]
        Downloads,

        /// <summary>
        /// The most recent system item.
        /// </summary>
        [iOSVersion(2)]
        MostRecent,

        /// <summary>
        /// The most viewed system item.
        /// </summary>
        [iOSVersion(2)]
        MostViewed,
    }}