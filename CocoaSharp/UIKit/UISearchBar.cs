using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISearchBar_Class/index.html#//apple_ref/occ/cl/UISearchBar    /// <summary>    /// The UISearchBar class implements a text field control for text-based searches. The control provides a text field for entering text, a search button, a bookmark button, and a cancel button. The UISearchBar object does not actually perform any searches. You use a delegate, an object conforming to the UISearchBarDelegate protocol, to implement the actions when text is entered and buttons are clicked.    /// </summary>    [iOSVersion(2)]    public class UISearchBar : UIView    {        /// <summary>        /// The string that is displayed when there is no other text in the text field.        /// </summary>        [iOSVersion(2)]        [Export("placeholder")]        public string Placeholder { get; set; }                /// <summary>        /// A single line of text displayed at the top of the search bar.        /// </summary>        [iOSVersion(2)]        [Export("prompt")]        public string Prompt { get; set; }                /// <summary>        /// The current or starting search text.        /// </summary>        [iOSVersion(2)]        [Export("text")]        public string Text { get; set; }                /// <summary>        /// A bar style that specifies the search bar’s appearance.        /// </summary>        [iOSVersion(2)]        [Export("barStyle")]        public UIBarStyle BarStyle { get; set; }                /// <summary>        /// The tint color to apply to the search bar background.        /// </summary>        [iOSVersion(7)]        [Export("barTintColor")]        public UIColor BarTintColor { get; set; }                /// <summary>        /// A search bar style that specifies the search bar’s appearance.        /// </summary>        [iOSVersion(7)]        [Export("searchBarStyle")]        public UISearchBarStyle SearchBarStyle { get; set; }                /// <summary>        /// The tint color to apply to key elements in the search bar.        /// </summary>        [iOSVersion(2)]        [Export("tintColor")]        public UIColor TintColor { get; set; }                /// <summary>        /// A Boolean value that indicates whether the search bar is translucent (true) or not (false).        /// </summary>        [iOSVersion(3)]        [Export("translucent")]        public bool Translucent { get; set; }                /// <summary>        /// A Boolean value indicating whether the bookmark button is displayed.        /// </summary>        [iOSVersion(2)]        [Export("showsBookmarkButton")]        public bool ShowsBookmarkButton { get; set; }                /// <summary>        /// A Boolean value indicating whether the cancel button is displayed.        /// </summary>        [iOSVersion(2)]        [Export("showsCancelButton")]        public bool ShowsCancelButton { get; set; }                /// <summary>        /// Sets the display state of the cancel button optionally with animation.        /// </summary>        /// <param name="showsCancelButton">true to display the cancel button, otherwise false.</param>        /// <param name="animated">true to use animation to change the display state of the cancel button, otherwise false.</param>        [iOSVersion(3)]        [Export("setShowsCancelButton")]        public void SetShowsCancelButton(bool showsCancelButton, bool animated) { }                /// <summary>        /// A Boolean value indicating whether the search results button is displayed.        /// </summary>        [iOSVersion(3.2)]        [Export("showsSearchResultsButton")]        public bool ShowsSearchResultsButton { get; set; }                /// <summary>        /// A Boolean value indicating whether the search results button is selected.        /// </summary>        [iOSVersion(3.2)]        [Export("searchResultsButtonSelected")]        public bool SearchResultsButtonSelected { get; set; }                /// <summary>        /// An array of strings indicating the titles of the scope buttons.        /// </summary>        [iOSVersion(3)]        [Export("scopeButtonTitles")]        public AnyObject[] ScopeButtonTitles { get; set; }                /// <summary>        /// The index of the selected scope button.        /// </summary>        [iOSVersion(3)]        [Export("selectedScopeButtonIndex")]        public int SelectedScopeButtonIndex { get; set; }                /// <summary>        /// Specifies whether the scope bar is displayed.        /// </summary>        [iOSVersion(3)]        [Export("showsScopeBar")]        public bool ShowsScopeBar { get; set; }                /// <summary>        /// The search bar’s delegate object.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public UISearchBarDelegate Delegate { get; set; }                /// <summary>        /// The background image for the search bar.        /// </summary>        [iOSVersion(5)]        [Export("backgroundImage")]        public UIImage BackgroundImage { get; set; }                /// <summary>        /// Returns the image used for the background in a given position and with given metrics.        /// </summary>        /// <param name="barPosition">A bar position constant.</param>        /// <param name="barMetrics">A bar metrics constant.</param>        /// <returns>The image used for the search bar background in the position specified by barPosition and with the metrics specified by barMetrics.</returns>        [iOSVersion(7)]        [Export("backgroundImageForBarPosition")]        public UIImage BackgroundImageForBarPosition(UIBarPosition barPosition, UIBarMetrics barMetrics) { return null; }                /// <summary>        /// Sets the image to use for the background in a given position and with given metrics.        /// </summary>        /// <param name="backgroundImage">The image to use for the search bar background in the position specified by barPosition and with the metrics specified by barMetrics.</param>        /// <param name="forBarPosition">A bar position constant.</param>        /// <param name="barMetrics">A bar metrics constant.</param>        [iOSVersion(7)]        [Export("setBackgroundImage")]        public void SetBackgroundImage(UIImage backgroundImage, UIBarPosition forBarPosition, UIBarMetrics barMetrics) { }                /// <summary>        /// Returns the image for a given search bar icon type and control state.        /// </summary>        /// <param name="icon">An icon identifier constant.</param>        /// <param name="state">A control state.   Valid states are UIControlStateNormal and UIControlStateDisabled.</param>        /// <returns>The image used for the search bar icon identified by icon in the state identified by state.</returns>        [iOSVersion(5)]        [Export("imageForSearchBarIcon")]        public UIImage ImageForSearchBarIcon(UISearchBarIcon icon, UIControlState state) { return null; }                /// <summary>        /// Sets the image for a given search bar icon type and control state.        /// </summary>        /// <param name="iconImage">The image to use for the search bar icon identified by icon in the state identified by state.</param>        /// <param name="forSearchBarIcon">An icon identifier constant.</param>        /// <param name="state">A control state.   Valid states are UIControlStateNormal and UIControlStateDisabled.</param>        [iOSVersion(5)]        [Export("setImage")]        public void SetImage(UIImage iconImage, UISearchBarIcon forSearchBarIcon, UIControlState state) { }                /// <summary>        /// Returns the position adjustment for a given icon.        /// </summary>        /// <param name="icon">An icon identifier constant.</param>        /// <returns>The position adjustment for the icon identified by icon.</returns>        [iOSVersion(5)]        [Export("positionAdjustmentForSearchBarIcon")]        public UIOffset PositionAdjustmentForSearchBarIcon(UISearchBarIcon icon) { return new UIOffset(); }                /// <summary>        /// Returns the position adjustment for a given icon.        /// </summary>        /// <param name="adjustment">The offset to use for the icon identified by icon.</param>        /// <param name="forSearchBarIcon">An icon identifier constant.</param>        [iOSVersion(5)]        [Export("setPositionAdjustment")]        public void SetPositionAdjustment(UIOffset adjustment, UISearchBarIcon forSearchBarIcon) { }                /// <summary>        /// A custom input accessory view for the keyboard of the search bar.        /// </summary>        [iOSVersion(6)]        [Export("inputAccessoryView")]        public UIView InputAccessoryView { get; set; }                /// <summary>        /// The background image for the scope bar.        /// </summary>        [iOSVersion(5)]        [Export("scopeBarBackgroundImage")]        public UIImage ScopeBarBackgroundImage { get; set; }                /// <summary>        /// Returns the background image for the scope bar button in a given state.        /// </summary>        /// <param name="state">A control state.</param>        /// <returns>The background image for the scope bar button in state.</returns>        [iOSVersion(5)]        [Export("scopeBarButtonBackgroundImageForState")]        public UIImage ScopeBarButtonBackgroundImageForState(UIControlState state) { return null; }                /// <summary>        /// Sets the background image for the scope bar button in a given state.        /// </summary>        /// <param name="backgroundImage">The background image for the scope bar button in state.</param>        /// <param name="forState">A control state.</param>        [iOSVersion(5)]        [Export("setScopeBarButtonBackgroundImage")]        public void SetScopeBarButtonBackgroundImage(UIImage backgroundImage, UIControlState forState) { }                /// <summary>        /// Returns the divider image to use for a given combination of left and right segment states.        /// </summary>        /// <param name="leftState">The state of the left segment for which to provide the divider image.   The state may be UIControlStateNormal or UIControlStateSelected.</param>        /// <param name="rightSegmentState">The state of the right segment for which to provide the divider image.   The state may be UIControlStateNormal or UIControlStateSelected.</param>        /// <returns>The divider image to use for the combination of leftState and rightState.</returns>        [iOSVersion(5)]        [Export("scopeBarButtonDividerImageForLeftSegmentState")]        public UIImage ScopeBarButtonDividerImageForLeftSegmentState(UIControlState leftState, UIControlState rightSegmentState) { return null; }                /// <summary>        /// Sets the divider image to use for a given combination of left and right segment states.        /// </summary>        /// <param name="dividerImage">The divider image to use for the combination of leftState and rightState.</param>        /// <param name="forLeftSegmentState">The state of the left segment for which to set the divider image.   The state may be UIControlStateNormal or UIControlStateSelected.</param>        /// <param name="rightSegmentState">The state of the right segment for which to set the divider image.   The state may be UIControlStateNormal or UIControlStateSelected.</param>        [iOSVersion(5)]        [Export("setScopeBarButtonDividerImage")]        public void SetScopeBarButtonDividerImage(UIImage dividerImage, UIControlState forLeftSegmentState, UIControlState rightSegmentState) { }                /// <summary>        /// Returns the text attributes for the search bar’s button’s title string for a given state.        /// </summary>        /// <param name="state">A control state.</param>        /// <returns>The text attributes for the search bar’ button’s title string for state.</returns>        [iOSVersion(5)]        [Export("scopeBarButtonTitleTextAttributesForState")]        public NSDictionary ScopeBarButtonTitleTextAttributesForState(UIControlState state) { return null; }                /// <summary>        /// Sets the text attributes for the search bar’ button’s title string for a given state.        /// </summary>        /// <param name="attributes">A dictionary containing key-value pairs specifying the text attributes to use for state.   You may specify the font, text color, text shadow color, and text shadow offset, using the keys found in NSString UIKit Additions Reference.</param>        /// <param name="forState">A control state.</param>        [iOSVersion(5)]        [Export("setScopeBarButtonTitleTextAttributes")]        public void SetScopeBarButtonTitleTextAttributes(NSDictionary attributes, UIControlState forState) { }                /// <summary>        /// Returns the search text field image for a given state.        /// </summary>        /// <param name="state">A control state.   Valid states are UIControlStateNormal and UIControlStateDisabled.</param>        /// <returns>The search text field image to use for state.</returns>        [iOSVersion(5)]        [Export("searchFieldBackgroundImageForState")]        public UIImage SearchFieldBackgroundImageForState(UIControlState state) { return null; }                /// <summary>        /// Sets the search text field image for a given state.        /// </summary>        /// <param name="backgroundImage">The search text field image image to use for state.</param>        /// <param name="forState">A control state.   Valid states are UIControlStateNormal and UIControlStateDisabled.</param>        [iOSVersion(5)]        [Export("setSearchFieldBackgroundImage")]        public void SetSearchFieldBackgroundImage(UIImage backgroundImage, UIControlState forState) { }                /// <summary>        /// The offset of the search text field background in the search bar.        /// </summary>        [iOSVersion(5)]        [Export("searchFieldBackgroundPositionAdjustment")]        public UIOffset SearchFieldBackgroundPositionAdjustment { get; set; }                /// <summary>        /// The offset of the text within the search text field background.        /// </summary>        [iOSVersion(5)]        [Export("searchTextPositionAdjustment")]        public UIOffset SearchTextPositionAdjustment { get; set; }
    }

    /// <summary>
    /// Constants to identify the icons used in the search bar.
    /// </summary>
    public enum UISearchBarIcon
    {
        /// <summary>
        /// Identifies the search icon.
        /// </summary>
        [iOSVersion(5)]
        Search,

        /// <summary>
        /// Identifies the clear action icon.
        /// </summary>
        [iOSVersion(5)]
        Clear,

        /// <summary>
        /// Identifies the bookmarks icon.
        /// </summary>
        [iOSVersion(5)]
        Bookmark,

        /// <summary>
        /// Identifies the results list icon.
        /// </summary>
        [iOSVersion(5)]
        ResultsList,
    }
    /// <summary>
    /// Specifies whether the search bar has a background.
    /// </summary>
    public enum UISearchBarStyle
    {
        /// <summary>
        /// The search bar has the default style.
        /// </summary>
        [iOSVersion(7)]
        Default,

        /// <summary>
        /// The search bar has a translucent background, and the search field is opaque.
        /// </summary>
        [iOSVersion(7)]
        Prominent,

        /// <summary>
        /// The search bar has no background, and the search field is translucent.
        /// </summary>
        [iOSVersion(7)]
        Minimal,
    }}