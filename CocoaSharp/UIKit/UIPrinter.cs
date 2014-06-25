using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrinter_class/index.html#//apple_ref/occ/cl/UIPrinter    /// <summary>    /// A UIPrinter object contains the attributes of a printer on the network. You use a printer object to obtain information about a printer so that you can display that information in your app’s interface. You do not use printer objects to communicate with the printer directly.    /// </summary>    [iOSVersion(8)]    public class UIPrinter : NSObject    {        /// <summary>        /// Creates and returns a printer with the specified location.        /// </summary>        /// <param name="URL">A URL that identifies the location of the printer on your network.</param>        /// <returns>A printer object representing the specified printer or nil if there was a problem initializing the object.</returns>        [iOSVersion(8)]        public UIPrinter(NSURL URL) { }                /// <summary>        /// The full address of the printer. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("URL")]        public NSURL URL { get; private set; }                /// <summary>        /// The human-readable printer name. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("displayName")]        public string DisplayName { get; private set; }                /// <summary>        /// The human-readable text describing the location of the printer. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("displayLocation")]        public string DisplayLocation { get; private set; }                /// <summary>        /// A string containing the manufacturer’s name and the model name of the printer. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("makeAndModel")]        public string MakeAndModel { get; private set; }                /// <summary>        /// The capabilities of the printer. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("supportedJobTypes")]        public UIPrinterJobTypes SupportedJobTypes { get; private set; }                /// <summary>        /// A Boolean value indicating whether the printer supports color printing. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("supportsColor")]        public bool SupportsColor { get; private set; }                /// <summary>        /// A Boolean value indicating whether the printer supports printing on both sides of a piece of paper. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("supportsDuplex")]        public bool SupportsDuplex { get; private set; }                /// <summary>        /// Connects to the printer and gathers information about its capabilities.        /// </summary>        /// <param name="completionHandler">The block to execute with the results. This block has no return value and takes the following parameter:           available              true if the printer was available and its information was retrieved or false if the printer could not be found or was unavailable.</param>        [iOSVersion(8)]        [Export("contactPrinter")]        public void ContactPrinter(Action<bool> completionHandler) { }    }

    /// <summary>
    /// Bit mask flags indicating the types of jobs that the printer supports.
    /// </summary>
    public enum UIPrinterJobTypes
    {
        /// <summary>
        /// The printer support is unknown.
        /// </summary>
        [iOSVersion(8)]
        Unknown,

        /// <summary>
        /// The printer supports standard document printing.
        /// </summary>
        [iOSVersion(8)]
        Document,

        /// <summary>
        /// The printer supports printing on envelopes.
        /// </summary>
        [iOSVersion(8)]
        Envelope,

        /// <summary>
        /// The printer supports printing on cut labels.
        /// </summary>
        [iOSVersion(8)]
        Label,

        /// <summary>
        /// The printer supports printing with photographic print quality.
        /// </summary>
        [iOSVersion(8)]
        Photo,

        /// <summary>
        /// The printer supports printing receipts on a continuous roll of paper.
        /// </summary>
        [iOSVersion(8)]
        Receipt,

        /// <summary>
        /// The printer supports printing documents or photos on a continuous roll of paper.
        /// </summary>
        [iOSVersion(8)]
        Roll,

        /// <summary>
        /// The printer supports printing larger than the ISO A3 size.
        /// </summary>
        [iOSVersion(8)]
        LargeFormat,

        /// <summary>
        /// The printer supports printing on postcards.
        /// </summary>
        [iOSVersion(8)]
        Postcard,
    }}