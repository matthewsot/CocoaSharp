using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// You use the UIWebView class to embed web content in your application. To do so, you simply create a UIWebView object, attach it to a window, and send it a request to load web content. You can also use this class to move back and forward in the history of webpages, and you can even set some web content properties programmatically.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIWebView_Class/index.html#//apple_ref/occ/cl/UIWebView"/>    [iOSVersion(2)]    public class UIWebView : UIView//, AnyObject, NSCoding, NSObjectProtocol, Reflectable, UIAccessibilityIdentification, UIAppearance, UIAppearanceContainer, UICoordinateSpace, UIDynamicItem, UIScrollViewDelegate, UITraitEnvironment    {        /// <summary>        /// Sets the main page contents, MIME type, content encoding, and base URL.        /// </summary>        /// <param name="data">The content for the main page.</param>        /// <param name="MIMEType">The MIME type of the content.</param>        /// <param name="textEncodingName">The IANA encoding name as in utf-8 or utf-16.</param>        /// <param name="baseURL">The base URL for the content.</param>        [iOSVersion(2)]        [Export("loadData")]        public void LoadData(NSData data, string MIMEType, string textEncodingName, NSURL baseURL) {  }                /// <summary>        /// Sets the main page content and base URL.        /// </summary>        /// <param name="@string">The content for the main page.</param>        /// <param name="baseURL">The base URL for the content.</param>        [iOSVersion(2)]        [Export("loadHTMLString")]        public void LoadHTMLString(string @string, NSURL baseURL) {  }                /// <summary>        /// Connects to a given URL by initiating an asynchronous client request.        /// </summary>        /// <param name="request">A URL request identifying the location of the content to load.</param>        [iOSVersion(2)]        [Export("loadRequest")]        public void LoadRequest(NSURLRequest request) {  }                /// <summary>        /// Stops the loading of any web content managed by the receiver.        /// </summary>        [iOSVersion(2)]        [Export("stopLoading")]        public void StopLoading() {  }                /// <summary>        /// Reloads the current page.        /// </summary>        [iOSVersion(2)]        [Export("reload")]        public void Reload() {  }                /// <summary>        /// Loads the previous location in the back-forward list.        /// </summary>        [iOSVersion(2)]        [Export("goBack")]        public void GoBack() {  }                /// <summary>        /// Loads the next location in the back-forward list.        /// </summary>        [iOSVersion(2)]        [Export("goForward")]        public void GoForward() {  }                /// <summary>        /// Returns the result of running a script.        /// </summary>        /// <param name="script">The script to run.</param>        [iOSVersion(2)]        [Export("stringByEvaluatingJavaScriptFromString")]        public string StringByEvaluatingJavaScriptFromString(string script) { return default(string); }                /// <summary>        /// The receiver’s delegate.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public UIWebViewDelegate Delegate { get; set; }                /// <summary>        /// The URL request identifying the location of the content to load. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("request")]        public NSURLRequest Request { get; private set; }                /// <summary>        /// A Boolean value indicating whether the receiver is done loading content. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("loading")]        public bool Loading { get; private set; }                /// <summary>        /// A Boolean value indicating whether the receiver can move backward. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("canGoBack")]        public bool CanGoBack { get; private set; }                /// <summary>        /// A Boolean value indicating whether the receiver can move forward. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("canGoForward")]        public bool CanGoForward { get; private set; }                /// <summary>        /// A Boolean value determining whether the webpage scales to fit the view and the user can change the scale.        /// </summary>        [iOSVersion(2)]        [Export("scalesPageToFit")]        public bool ScalesPageToFit { get; set; }                /// <summary>        /// The scroll view associated with the web view. (read-only)        /// </summary>        [iOSVersion(5)]        [Export("scrollView")]        public UIScrollView ScrollView { get; private set; }                /// <summary>        /// A Boolean value indicating whether the web view suppresses content rendering until it is fully loaded into memory.        /// </summary>        [iOSVersion(6)]        [Export("suppressesIncrementalRendering")]        public bool SuppressesIncrementalRendering { get; set; }                /// <summary>        /// A Boolean value indicating whether web content can programmatically display the keyboard.        /// </summary>        [iOSVersion(6)]        [Export("keyboardDisplayRequiresUserAction")]        public bool KeyboardDisplayRequiresUserAction { get; set; }                /// <summary>        /// The types of data converted to clickable URLs in the web view’s content.        /// </summary>        [iOSVersion(3)]        [Export("dataDetectorTypes")]        public UIDataDetectorTypes DataDetectorTypes { get; set; }                /// <summary>        /// A Boolean value that determines whether HTML5 videos play inline or use the native full-screen controller.        /// </summary>        [iOSVersion(4)]        [Export("allowsInlineMediaPlayback")]        public bool AllowsInlineMediaPlayback { get; set; }                /// <summary>        /// A Boolean value that determines whether HTML5 videos can play automatically or require the user to start playing them.        /// </summary>        [iOSVersion(4)]        [Export("mediaPlaybackRequiresUserAction")]        public bool MediaPlaybackRequiresUserAction { get; set; }                /// <summary>        /// A Boolean value that determines whether Air Play is allowed from this view.        /// </summary>        [iOSVersion(5)]        [Export("mediaPlaybackAllowsAirPlay")]        public bool MediaPlaybackAllowsAirPlay { get; set; }                /// <summary>        /// The size of the gap, in points, between pages.        /// </summary>        [iOSVersion(7)]        [Export("gapBetweenPages")]        public CGFloat GapBetweenPages { get; set; }                /// <summary>        /// The number of pages produced by the layout of the web view. (read-only)        /// </summary>        [iOSVersion(7)]        [Export("pageCount")]        public int PageCount { get; private set; }                /// <summary>        /// The size of each page, in points, in the direction that the pages flow.        /// </summary>        [iOSVersion(7)]        [Export("pageLength")]        public CGFloat PageLength { get; set; }                /// <summary>        /// The manner in which column- or page-breaking occurs.        /// </summary>        [iOSVersion(7)]        [Export("paginationBreakingMode")]        public UIWebPaginationBreakingMode PaginationBreakingMode { get; set; }                /// <summary>        /// The layout of content in the web view.        /// </summary>        [iOSVersion(7)]        [Export("paginationMode")]        public UIWebPaginationMode PaginationMode { get; set; }    }    /// <summary>    /// Constant indicating the user’s action.    /// </summary>    [iOSVersion(2)]    public enum UIWebViewNavigationType    {        /// <summary>        /// User tapped a link.        /// </summary>        [iOSVersion(2)]        LinkClicked,        /// <summary>        /// User submitted a form.        /// </summary>        [iOSVersion(2)]        FormSubmitted,        /// <summary>        /// User tapped the back or forward button.        /// </summary>        [iOSVersion(2)]        BackForward,        /// <summary>        /// User tapped the reload button.        /// </summary>        [iOSVersion(2)]        Reload,        /// <summary>        /// User resubmitted a form.        /// </summary>        [iOSVersion(2)]        FormResubmitted,        /// <summary>        /// Some other action occurred.        /// </summary>        [iOSVersion(2)]        Other,    }    /// <summary>    /// The manner in which column- or page-breaking occurs.    /// </summary>    [iOSVersion(7)]    public enum UIWebPaginationBreakingMode    {        /// <summary>        /// Content respects CSS properties related to page-breaking.        /// </summary>        [iOSVersion(7)]        Page,        /// <summary>        /// Content respects CSS properties related to column-breaking.        /// </summary>        [iOSVersion(7)]        Column,    }    /// <summary>    /// The layout of content in the web view, which determines the direction that the pages flow.    /// </summary>    [iOSVersion(7)]    public enum UIWebPaginationMode    {        /// <summary>        /// Content appears as one long scrolling view with no distinct pages.        /// </summary>        [iOSVersion(7)]        Unpaginated,        /// <summary>        /// Content is broken up into pages that flow from left to right.        /// </summary>        [iOSVersion(7)]        LeftToRight,        /// <summary>        /// Content is broken up into pages that flow from top to bottom.        /// </summary>        [iOSVersion(7)]        TopToBottom,        /// <summary>        /// Content is broken up into pages that flow from bottom to top.        /// </summary>        [iOSVersion(7)]        BottomToTop,        /// <summary>        /// Content is broken up into pages that flow from right to left.        /// </summary>        [iOSVersion(7)]        RightToLeft,    }}