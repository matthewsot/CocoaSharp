using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UIPrintInteractionControllerDelegate protocol is implemented by the delegate of the UIPrintInteractionController shared instance to perform a number of optional tasks.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrintInteractionControllerDelegate_Protocol/index.html#//apple_ref/occ/intf/UIPrintInteractionControllerDelegate"/>    [iOSVersion(4.2)]    public interface UIPrintInteractionControllerDelegate//: NSObjectProtocol    {        /// <summary>        /// Returns a parent view controller for managing the printing-options view.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerParentViewController")]        //[Optional]        //UIViewController PrintInteractionControllerParentViewController(UIPrintInteractionController printInteractionController);                /// <summary>        /// Asks the delegate for an object encapsulating the paper size and printing area to use for the print job.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        /// <param name="choosePaper">An array of UIPrintPaper objects that represent combinations of paper sizes and imageable areas supported by the selected printer.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionController")]        //[Optional]        //UIPrintPaper PrintInteractionController(UIPrintInteractionController printInteractionController, AnyObject[] choosePaper);                /// <summary>        /// Asks the delegate for a length to use when cutting the page.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        /// <param name="cutLengthForPaper">A UIPrintPaper that specifies the maximum physical and printable areas of the page.</param>        //[iOSVersion(7)]        //[Export("printInteractionController")]        //[Optional]        //CGFloat PrintInteractionController(UIPrintInteractionController printInteractionController, UIPrintPaper cutLengthForPaper);                /// <summary>        /// Tells the delegate that the printing-options user interface is about to be displayed.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerWillPresentPrinterOptions")]        //[Optional]        //void PrintInteractionControllerWillPresentPrinterOptions(UIPrintInteractionController printInteractionController);                /// <summary>        /// Tells the delegate that the printing-options user interface has just been presented.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerDidPresentPrinterOptions")]        //[Optional]        //void PrintInteractionControllerDidPresentPrinterOptions(UIPrintInteractionController printInteractionController);                /// <summary>        /// Tells the delegate that the printing-options user interface will be dismissed.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerWillDismissPrinterOptions")]        //[Optional]        //void PrintInteractionControllerWillDismissPrinterOptions(UIPrintInteractionController printInteractionController);                /// <summary>        /// Tells the delegate that the printer user interface is being dismissed.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerDidDismissPrinterOptions")]        //[Optional]        //void PrintInteractionControllerDidDismissPrinterOptions(UIPrintInteractionController printInteractionController);                /// <summary>        /// Tells the delegate that the print job is about to start.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerWillStartJob")]        //[Optional]        //void PrintInteractionControllerWillStartJob(UIPrintInteractionController printInteractionController);                /// <summary>        /// Tells the delegate that the print job has ended.        /// </summary>        /// <param name="printInteractionController">The shared instance of UIPrintInteractionController that is managing the print job.</param>        //[iOSVersion(4.2)]        //[Export("printInteractionControllerDidFinishJob")]        //[Optional]        //void PrintInteractionControllerDidFinishJob(UIPrintInteractionController printInteractionController);    }}