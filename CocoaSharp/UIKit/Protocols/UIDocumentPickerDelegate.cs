using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDocumentPickerDelegate/index.html#//apple_ref/occ/intf/UIDocumentPickerDelegate	/// <summary>	/// The UIDocumentPickerDelegate protocol defines the methods you must implement to track	when the user selects a document or destination, or to track when the document picker is canceled.	/// </summary>	[iOSVersion(8)]	public interface UIDocumentPickerDelegate	{		/// <summary>		/// Tells the delegate that the user has selected a document or a destination. (required)		/// </summary>		/// <param name="controller">The document picker that called this method.</param>		/// <param name="didPickDocumentAtURL">The URL of the selected document or destination.</param>		[iOSVersion(8)]		[Export("documentPicker")]		void DocumentPicker(UIDocumentPickerViewController controller, NSURL didPickDocumentAtURL);				/// <summary>		/// Tells the delegate that the user canceled the document picker.		/// </summary>		/// <param name="controller">The document picker that called this method.</param>		[iOSVersion(8)]		[Export("documentPickerWasCancelled")]		[Optional]		void DocumentPickerWasCancelled(UIDocumentPickerViewController controller);	}}