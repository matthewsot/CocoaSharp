using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Defines the types of checking that are available. These values can be combined using the C-bitwise OR operator. The system supports its own internal types, and the user can extend those types by subclassing NSTextCheckingResult and adding their own custom types.
    /// </summary>
    //[iOSVersion(4)]
    using NSTextCheckingTypes = UInt32;

    //https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSDataDetector_Class/index.html#//apple_ref/occ/cl/NSDataDetector
    /// <summary>
    /// The NSDataDetector class is a specialized subclass of the NSRegularExpression class designed to match data detectors.
    /// </summary>
    [iOSVersion(4)]
    public class NSDataDetector : NSRegularExpression
    {
        /// <summary>
        /// Creates and returns a new data detector instance.
        /// </summary>
        /// <param name="checkingTypes">The checking types. The supported checking types are a subset of the types specified in NSTextCheckingType. Those constants can be combined using the C-bitwise OR operator.</param>
        /// <param name="error">An out parameter that if an error occurs during initialization contains the encountered error.</param>
        /// <returns>Returns the newly initialized data detector. If an error was encountered returns nil, and error contains the error.</returns>
        [iOSVersion(4)]
        [Export("dataDetectorWithTypes")]
        public static NSDataDetector DataDetectorWithTypes(NSTextCheckingTypes checkingTypes, NSErrorPointer error) { return null; }

        /// <summary>
        /// Initializes and returns a data detector instance.
        /// </summary>
        /// <param name="types">The checking types. The supported checking types are a subset of the types NSTextCheckingType. Those constants can be combined using the C-bitwise OR operator.</param>
        /// <param name="error">An out parameter that if an error occurs during initialization contains the encountered error.</param>
        /// <returns>Returns the newly initialized data detector. If an error was encountered returns nil, and error contains the error.</returns>
        [iOSVersion(4)]
        public NSDataDetector(NSTextCheckingTypes types, NSErrorPointer error) : base("", NSRegularExpressionOptions.CaseInsensitive, null) { }

        /// <summary>
        /// Returns the checking types for this data detector. (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("checkingTypes")]
        public NSTextCheckingTypes CheckingTypes { get; private set; }
    }
}