using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSHTTPCookieStorage_Class/index.html#//apple_ref/occ/cl/NSHTTPCookieStorage    /// <summary>    /// NSHTTPCookieStorage implements a singleton object (shared instance) that manages storage of cookies. Each cookie is represented by an instance of the NSHTTPCookie class. As a rule, cookies are shared among all applications and are kept in sync across process boundaries. Session cookies (where the cookie object’s isSessionOnly method returns true) are local to a single process and are not shared.    /// </summary>    [iOSVersion(2)]    public class NSHTTPCookieStorage : NSObject    {        /// <summary>        /// Returns the shared cookie storage instance.        /// </summary>        /// <returns>The shared cookie storage instance.</returns>        [iOSVersion(2)]        [Export("sharedHTTPCookieStorage")]        public static NSHTTPCookieStorage SharedHTTPCookieStorage() { return null; }                /// <summary>        /// Returns the cookie storage’s cookie accept policy.        /// </summary>        /// <returns>The cookie storage’s cookie accept policy. The default cookie accept policy is NSHTTPCookieAcceptPolicyAlways.</returns>        [iOSVersion(2)]        [Export("cookieAcceptPolicy")]        public NSHTTPCookieAcceptPolicy CookieAcceptPolicy { get; set; }                /// <summary>        /// Deletes the specified cookie from the cookie storage.        /// </summary>        /// <param name="aCookie">The cookie to delete.</param>        [iOSVersion(2)]        [Export("deleteCookie")]        public void DeleteCookie(NSHTTPCookie aCookie) { }                /// <summary>        /// Stores a specified cookie in the cookie storage if the cookie accept policy permits.        /// </summary>        /// <param name="aCookie">The cookie to store.</param>        [iOSVersion(2)]        [Export("setCookie")]        public void SetCookie(NSHTTPCookie aCookie) { }                /// <summary>        /// Adds an array of cookies to the receiver if the receiver’s cookie acceptance policy permits.        /// </summary>        /// <param name="cookies">The cookies to add.</param>        /// <param name="forURL">The URL associated with the added cookies.</param>        /// <param name="mainDocumentURL">The URL of the main HTML document for the top-level frame, if known. Can be nil. This URL is used to determine if the cookie should be accepted if the cookie accept policy is NSHTTPCookieAcceptPolicyOnlyFromMainDocumentDomain.</param>        [iOSVersion(2)]        [Export("setCookies")]        public void SetCookies(AnyObject[] cookies, NSURL forURL, NSURL mainDocumentURL) { }                /// <summary>        /// Returns the cookie storage’s cookies.        /// </summary>        /// <returns>An array containing all of the cookie storage’s cookies.</returns>        [iOSVersion(2)]        [Export("cookies")]        public AnyObject[] Cookies { get; private set; }                /// <summary>        /// Returns all the cookie storage’s cookies that are sent to a specified URL.        /// </summary>        /// <param name="theURL">The URL to filter on.</param>        /// <returns>An array of cookies whose URL matches the provided URL.</returns>        [iOSVersion(2)]        [Export("cookiesForURL")]        public AnyObject[] CookiesForURL(NSURL theURL) { return null; }                /// <summary>        /// Returns all of the cookie storage’s cookies, sorted according to a given set of sort descriptors.        /// </summary>        /// <param name="sortOrder">The sort descriptors to use for sorting, as an array of NSSortDescriptor objects.</param>        /// <returns>The cookie storage’s cookies, sorted according to sortOrder, as an array of NSHTTPCookie objects.</returns>        [iOSVersion(5)]        [Export("sortedCookiesUsingDescriptors")]        public AnyObject[] SortedCookiesUsingDescriptors(AnyObject[] sortOrder) { return null; }

        //TODO: NSHTTPCookieStorage notifications    }

    /// <summary>
    /// NSHTTPCookieAcceptPolicy specifies the cookie acceptance policies implemented by the NSHTTPCookieStorage class.
    /// </summary>
    [iOSVersion(2)]
    public enum NSHTTPCookieAcceptPolicy
    {
        /// <summary>
        /// Accept all cookies. This is the default cookie accept policy.
        /// </summary>
        [iOSVersion(2)]
        Always,

        /// <summary>
        /// Reject all cookies.
        /// </summary>
        [iOSVersion(2)]
        Never,

        /// <summary>
        /// Accept cookies only from the main document domain.
        /// </summary>
        [iOSVersion(2)]
        OnlyFromMainDocumentDomain
    }}