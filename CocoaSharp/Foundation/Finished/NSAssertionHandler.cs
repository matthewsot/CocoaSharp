using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSAssertionHandler_Class/index.html#//apple_ref/occ/cl/NSAssertionHandler
    /// <summary>
    /// NSAssertionHandler objects are automatically created to handle false assertions. Assertion macros, such as NSAssert and NSCAssert, are used to evaluate a condition, and, if the condition evaluates to false, the macros pass a string to an NSAssertionHandler object describing the failure. Each thread has its own NSAssertionHandler object. When invoked, an assertion handler prints an error message that includes the method and class (or function) containing the assertion and raises an NSInternalInconsistencyException. 
    /// 
    /// This is extremely preliminary
    /// </summary>
    [iOSVersion(2)]
    public class NSAssertionHandler : NSObject
    {
        /// <summary>
        /// Returns the NSAssertionHandler object associated with the current thread.
        /// </summary>
        /// <returns>The NSAssertionHandler object associated with the current thread.</returns>
        [iOSVersion(2)]
        [Export("currentHandler")]
        public static NSAssertionHandler CurrentHandler() { return null; }
    }
}
