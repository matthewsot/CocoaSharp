using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIVisualEffectView/index.html#//apple_ref/occ/cl/UIVisualEffectView	/// <summary>	/// The UIVisualEffectView provides a simple abstraction over complex visual effects. Depending on the desired effect, the results may affect content layered behind the view or content added to the view’s contentView.	/// </summary>	[iOSVersion(8)]	public class UIVisualEffectView : UIView	{		/// <summary>		/// A UIView object that can have UIVisualEffectView added to it. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("contentView")]		public UIView ContentView { get; private set; }				/// <summary>		/// The visual effect provided by the view. (read-only)		/// </summary>		[iOSVersion(8)]		[Export("effect")]		public UIVisualEffect Effect { get; private set; }				/// <summary>		/// Creates a new visual effect view with the designated visual effect.		/// </summary>		/// <param name="effect">The visual effect to provided to the view.</param>		/// <returns>The new view containing the designated visual effect.</returns>		[iOSVersion(8)]		public UIVisualEffectView(UIVisualEffect effect) { }	}}