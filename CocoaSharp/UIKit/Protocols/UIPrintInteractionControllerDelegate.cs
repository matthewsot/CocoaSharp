using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrintinteractionControllerDelegate_Protocol/index.html#//apple_ref/occ/intf/UIPrintinteractionControllerDelegate	/// <summary>	/// The UIPrintinteractionControllerDelegate protocol is implemented by the delegate of the UIPrintinteractionController shared instance to perform a number of optional tasks.	/// </summary>	[iOSVersion(4.2)]	public interface UIPrintinteractionControllerDelegate	{		/// <summary>		/// Returns a parent view controller for managing the printing-options view.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		/// <returns>The view controller that is to be the parent of the print-interaction controller managing the printing-options view. Return nil for the standard presentation behavior.</returns>		[iOSVersion(4.2)]		[Export("printinteractionControllerParentViewController")]		[Optional]		UIViewController PrintinteractionControllerParentViewController(UIPrintinteractionController printinteractionController);				/// <summary>		/// Asks the delegate for an object encapsulating the paper size and printing area to use for the print job.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		/// <param name="choosePaper">An array of UIPrintPaper objects that represent combinations of paper sizes and imageable areas supported by the selected printer.</param>		/// <returns>A UIPrintPaper object representing both the paper size and imageable area (or printable rectangle) to use for the print job. If you return nil, a UIPrintPaper encapsulating the default paper size and printable rectangle is used.</returns>		[iOSVersion(4.2)]		[Export("printinteractionController")]		[Optional]		UIPrintPaper PrintinteractionController(UIPrintinteractionController printinteractionController, AnyObject[] choosePaper);				/// <summary>		/// Asks the delegate for a length to use when cutting the page.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		/// <param name="cutLengthForPaper">A UIPrintPaper that specifies the maximum physical and printable areas of the page.</param>		/// <returns>The physiucal length of the page in points.</returns>		[iOSVersion(7)]		[Export("printinteractionController")]		[Optional]		CGFloat PrintinteractionController(UIPrintinteractionController printinteractionController, UIPrintPaper cutLengthForPaper);				/// <summary>		/// Tells the delegate that the printing-options user interface is about to be displayed.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerWillPresentPrinterOptions")]		[Optional]		void PrintinteractionControllerWillPresentPrinterOptions(UIPrintinteractionController printinteractionController);				/// <summary>		/// Tells the delegate that the printing-options user interface has just been presented.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerDidPresentPrinterOptions")]		[Optional]		void PrintinteractionControllerDidPresentPrinterOptions(UIPrintinteractionController printinteractionController);				/// <summary>		/// Tells the delegate that the printing-options user interface will be dismissed.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerWillDismissPrinterOptions")]		[Optional]		void PrintinteractionControllerWillDismissPrinterOptions(UIPrintinteractionController printinteractionController);				/// <summary>		/// Tells the delegate that the printer user interface is being dismissed.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerDidDismissPrinterOptions")]		[Optional]		void PrintinteractionControllerDidDismissPrinterOptions(UIPrintinteractionController printinteractionController);				/// <summary>		/// Tells the delegate that the print job is about to start.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerWillStartJob")]		[Optional]		void PrintinteractionControllerWillStartJob(UIPrintinteractionController printinteractionController);				/// <summary>		/// Tells the delegate that the print job has ended.		/// </summary>		/// <param name="printinteractionController">The shared instance of UIPrintinteractionController that is managing the print job.</param>		[iOSVersion(4.2)]		[Export("printinteractionControllerDidFinishJob")]		[Optional]		void PrintinteractionControllerDidFinishJob(UIPrintinteractionController printinteractionController);	}}