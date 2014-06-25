using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIMenuItem_Class/index.html#//apple_ref/occ/cl/UIMenuItem	/// <summary>	/// An instance of the UIMenuItem class represents a custom item in the editing menu managed by the UIMenuController object.	/// </summary>	[iOSVersion(3.2)]	public class UIMenuItem : NSObject	{		/// <summary>		/// Creates and returns a menu-item object initialized with the given title and action.		/// </summary>		/// <param name="title">The title of the menu item.</param>		/// <param name="action">A selector identifying the method of the responder object to invoke for handling the command represented by the menu item.</param>		/// <returns>An initialized UIMenuItem object, or nil if there was a problem creating the object.</returns>		[iOSVersion(3.2)]		public UIMenuItem(string title, Selector action) { }				/// <summary>		/// The title of the menu item.		/// </summary>		[iOSVersion(3.2)]		[Export("title")]		public string Title { get; set; }				/// <summary>		/// A selector identifying the method of the responder object to invoke for handling of the menu command.		/// </summary>		[iOSVersion(3.2)]		[Export("action")]		public Selector Action { get; set; }	}}