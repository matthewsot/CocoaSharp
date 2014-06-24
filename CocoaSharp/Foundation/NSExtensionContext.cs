using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
	//https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSExtensionContext_Class/index.html#//apple_ref/occ/cl/NSExtensionContext
	/// <summary>
	/// An NSExtensionContext object represents the context in which an app extension is invoked. When the currently running app (known as the host app) sends a request to an extension, it defines the context in which the extension runs. For many app extensions, the most important thing to know is the data the user wants to work with, which is contained in the inputItems property.
	/// </summary>
	[iOSVersion(8)]
	public class NSExtensionContext : NSObject
	{
		/// <summary>
		/// Signals the host to cancel the app extension request, with the supplied error.
		/// </summary>
		/// <param name="error">The error object to return. It must be non-nil.</param>
		[iOSVersion(8)]
		[Export("cancelRequestWithError")]
		public void CancelRequestWithError(NSError error) { }
		
		/// <summary>
		/// Signals the host to complete the app extension request with the supplied result items.
		/// </summary>
		/// <param name="items">An array of NSExtensionItem objects to return.</param>
		/// <param name="completionHandler">A block to be called when the request completes.   The block takes the following parameter:           expired              A Boolean value that indicates whether the system is terminating a previous invocation of completionHandler earlier than expected. This parameter is true if the system is terminating a completionHandler that was previously invoked as a nonexpiration handler.</param>
		[iOSVersion(8)]
		[Export("completeRequestReturningItems")]
		public void CompleteRequestReturningItems(AnyObject[] items, Action<bool> completionHandler) { }
		
		/// <summary>
		/// Asks the system open a URL on behalf of the currently running app extension.
		/// </summary>
		/// <param name="URL">The URL to open.</param>
		/// <param name="completionHandler">A block to be called when the URL has opened.   The block takes the following parameter:           success              A Boolean value that indicates whether the open was successful.</param>
		[iOSVersion(8)]
		[Export("openURL")]
		public void OpenURL(NSURL URL, Action<bool> completionHandler) { }
		
		/// <summary>
		/// The list of input NSExtensionItem objects associated with the context. (read-only)
		/// </summary>
		[iOSVersion(8)]
		[Export("inputItems")]
		public AnyObject[] InputItems { get; private set; }
		
		/// <summary>
		/// This key is used in the userInfo dictionary of the NSError object returned by cancelRequestWithError:.
		/// </summary>
		[Export("NSExtensionItemsAndErrorsKey")]
		public string NSExtensionItemsAndErrorsKey { get; private set; }
	}
}