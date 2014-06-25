using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPageControl_Class/index.html#//apple_ref/occ/cl/UIPageControl	/// <summary>	/// You use the UIPageControl class to create and manage page controls. A page control displays a horizontal series of dots, each of which corresponds to a page in the application’s document (or other data-model entity). The currently viewed page is indicated by a white dot.	/// </summary>	[iOSVersion(2)]	public class UIPageControl : UIControl	{		/// <summary>		/// The current page, shown by the receiver as a white dot.		/// </summary>		[iOSVersion(2)]		[Export("currentPage")]		public int CurrentPage { get; set; }				/// <summary>		/// The number of pages the receiver shows (as dots).		/// </summary>		[iOSVersion(2)]		[Export("numberOfPages")]		public int NumberOfPages { get; set; }				/// <summary>		/// A Boolean value that controls whether the page control is hidden when there is only one page.		/// </summary>		[iOSVersion(2)]		[Export("hidesForSinglePage")]		public bool HidesForSinglePage { get; set; }				/// <summary>		/// The tint color to be used for the page indicator.		/// </summary>		[iOSVersion(6)]		[Export("pageIndicatorTintColor")]		public UIColor PageIndicatorTintColor { get; set; }				/// <summary>		/// The tint color to be used for the current page indicator.		/// </summary>		[iOSVersion(6)]		[Export("currentPageIndicatorTintColor")]		public UIColor CurrentPageIndicatorTintColor { get; set; }				/// <summary>		/// A Boolean value that controls when the current page is displayed.		/// </summary>		[iOSVersion(2)]		[Export("defersCurrentPageDisplay")]		public bool DefersCurrentPageDisplay { get; set; }				/// <summary>		/// Updates the page indicator to the current page.		/// </summary>		[iOSVersion(2)]		[Export("updateCurrentPageDisplay")]		public void UpdateCurrentPageDisplay() { }				/// <summary>		/// Returns the size the receiver’s bounds should be to accommodate the given number of pages.		/// </summary>		/// <param name="pageCount">The number of pages to fit in the receiver’s bounds.</param>		/// <returns>The minimum size required to display dots for the page count.</returns>		[iOSVersion(2)]		[Export("sizeForNumberOfPages")]		public CGSize SizeForNumberOfPages(int pageCount) { return new CGSize(); }	}}