using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITextInputStringTokenizer_Class/index.html#//apple_ref/occ/cl/UITextInputStringTokenizer	/// <summary>	/// The UITextInputStringTokenizer class is a base implementation of the UITextInputTokenizer protocol provided by the UIKit framework.	/// </summary>	[iOSVersion(3.2)]	public class UITextInputStringTokenizer : NSObject	{		/// <summary>		/// Returns an object initialized with the document object that directly communicates with the text input system.		/// </summary>		/// <param name="textInput">The document object in the application that adopts the UITextInput protocol for the purposes of communicating with the text input system.</param>		/// <returns>An instance of a subclass of UITextInputStringTokenizer, or nil if the object couldn’t be created.</returns>		[iOSVersion(3.2)]		public UITextInputStringTokenizer(UIResponder textInput) { }	}}