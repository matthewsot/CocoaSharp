using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIWebViewDelegate protocol defines methods that a delegate of a UIWebView object can optionally implement to intervene when web content is loaded.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIWebViewDelegate_Protocol/index.html#//apple_ref/occ/intf/UIWebViewDelegate"/>    [iOSVersion(2)]    public interface UIWebViewDelegate//: NSObjectProtocol    {        /// <summary>        /// Sent before a web view begins loading a frame.        /// </summary>        /// <param name="webView">The web view that is about to load a new frame.</param>        /// <param name="shouldStartLoadWithRequest">The content location.</param>        /// <param name="navigationType">The type of user action that started the load request.</param>        [iOSVersion(2)]        [Export("webView")]        bool WebView(UIWebView webView, NSURLRequest shouldStartLoadWithRequest, UIWebViewNavigationType navigationType);                /// <summary>        /// Sent after a web view starts loading a frame.        /// </summary>        /// <param name="webView">The web view that has begun loading a new frame.</param>        [iOSVersion(2)]        [Export("webViewDidStartLoad")]        void WebViewDidStartLoad(UIWebView webView);                /// <summary>        /// Sent after a web view finishes loading a frame.        /// </summary>        /// <param name="webView">The web view has finished loading.</param>        [iOSVersion(2)]        [Export("webViewDidFinishLoad")]        void WebViewDidFinishLoad(UIWebView webView);                /// <summary>        /// Sent if a web view failed to load a frame.        /// </summary>        /// <param name="webView">The web view that failed to load a frame.</param>        /// <param name="didFailLoadWithError">The error that occurred during loading.</param>        [iOSVersion(2)]        [Export("webView")]        void WebView(UIWebView webView, NSError didFailLoadWithError);    }}