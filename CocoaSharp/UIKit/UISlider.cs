using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UISlider_Class/index.html#//apple_ref/occ/cl/UISlider	/// <summary>	/// A UISlider object is a visual control used to select a single value from a continuous range of values. Sliders are always displayed as horizontal bars. An indicator, or thumb, notes the current value of the slider and can be moved by the user to change the setting.	/// </summary>	[iOSVersion(2)]	public class UISlider : UIControl	{		/// <summary>		/// Contains the receiver’s current value.		/// </summary>		[iOSVersion(2)]		[Export("value")]		public CFloat Value { get; set; }				/// <summary>		/// Sets the receiver’s current value, allowing you to animate the change visually.		/// </summary>		/// <param name="value">The new value to assign to the value property</param>		/// <param name="animated">Specify true to animate the change in value when the receiver is redrawn; otherwise, specify false to draw the receiver with the new value only. Animations are performed asynchronously and do not block the calling thread.</param>		[iOSVersion(2)]		[Export("setValue")]		public void SetValue(CFloat value, bool animated) { }				/// <summary>		/// Contains the minimum value of the receiver.		/// </summary>		[iOSVersion(2)]		[Export("minimumValue")]		public CFloat MinimumValue { get; set; }				/// <summary>		/// Contains the maximum value of the receiver.		/// </summary>		[iOSVersion(2)]		[Export("maximumValue")]		public CFloat MaximumValue { get; set; }				/// <summary>		/// Contains a Boolean value indicating whether changes in the sliders value generate continuous update events.		/// </summary>		[iOSVersion(2)]		[Export("continuous")]		public bool Continuous { get; set; }				/// <summary>		/// Contains the image that is drawn on the side of the slider representing the minimum value.		/// </summary>		[iOSVersion(2)]		[Export("minimumValueImage")]		public UIImage MinimumValueImage { get; set; }				/// <summary>		/// Contains the image that is drawn on the side of the slider representing the maximum value.		/// </summary>		[iOSVersion(2)]		[Export("maximumValueImage")]		public UIImage MaximumValueImage { get; set; }				/// <summary>		/// The color used to tint the standard minimum track images.		/// </summary>		[iOSVersion(5)]		[Export("minimumTrackTintColor")]		public UIColor MinimumTrackTintColor { get; set; }				/// <summary>		/// Contains the minimum track image currently being used to render the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("currentMinimumTrackImage")]		public UIImage CurrentMinimumTrackImage { get; private set; }				/// <summary>		/// Returns the minimum track image associated with the specified control state.		/// </summary>		/// <param name="state">The control state whose minimum track image you want. You should specify only one control state value for this parameter.</param>		/// <returns>The minimum track image associated with the specified state, or nil if no image has been set. This method might also return nil if you specify multiple control states in the state parameter. For a description of track images, see Customizing the Slider’s Appearance.</returns>		[iOSVersion(2)]		[Export("minimumTrackImageForState")]		public UIImage MinimumTrackImageForState(UIControlState state) { return null; }				/// <summary>		/// Assigns a minimum track image to the specified control states.		/// </summary>		/// <param name="image">The minimum track image to associate with the specified states.</param>		/// <param name="forState">The control state with which to associate the image.</param>		[iOSVersion(2)]		[Export("setMinimumTrackImage")]		public void SetMinimumTrackImage(UIImage image, UIControlState forState) { }				/// <summary>		/// The color used to tint the standard maximum track images.		/// </summary>		[iOSVersion(5)]		[Export("maximumTrackTintColor")]		public UIColor MaximumTrackTintColor { get; set; }				/// <summary>		/// Contains the maximum track image currently being used to render the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("currentMaximumTrackImage")]		public UIImage CurrentMaximumTrackImage { get; private set; }				/// <summary>		/// Returns the maximum track image associated with the specified control state.		/// </summary>		/// <param name="state">The control state whose maximum track image you want. You should specify only one control state value for this parameter.</param>		/// <returns>The maximum track image associated with the specified state, or nil if an appropriate image could not be retrieved. This method might return nil if you specify multiple control states in the state parameter. For a description of track images, see Customizing the Slider’s Appearance.</returns>		[iOSVersion(2)]		[Export("maximumTrackImageForState")]		public UIImage MaximumTrackImageForState(UIControlState state) { return null; }				/// <summary>		/// Assigns a maximum track image to the specified control states.		/// </summary>		/// <param name="image">The maximum track image to associate with the specified states.</param>		/// <param name="forState">The control state with which to associate the image.</param>		[iOSVersion(2)]		[Export("setMaximumTrackImage")]		public void SetMaximumTrackImage(UIImage image, UIControlState forState) { }				/// <summary>		/// The color used to tint the standard thumb images.		/// </summary>		[iOSVersion(5)]		[Export("thumbTintColor")]		public UIColor ThumbTintColor { get; set; }				/// <summary>		/// Contains the thumb image currently being used to render the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("currentThumbImage")]		public UIImage CurrentThumbImage { get; private set; }				/// <summary>		/// Returns the thumb image associated with the specified control state.		/// </summary>		/// <param name="state">The control state whose thumb image you want. You should specify only one control state value for this parameter.</param>		/// <returns>The thumb image associated with the specified state, or nil if an appropriate image could not be retrieved. This method might return nil if you specify multiple control states in the state parameter. For a description of track and thumb images, see Customizing the Slider’s Appearance.</returns>		[iOSVersion(2)]		[Export("thumbImageForState")]		public UIImage ThumbImageForState(UIControlState state) { return null; }				/// <summary>		/// Assigns a thumb image to the specified control states.		/// </summary>		/// <param name="image">The thumb image to associate with the specified states.</param>		/// <param name="forState">The control state with which to associate the image.</param>		[iOSVersion(2)]		[Export("setThumbImage")]		public void SetThumbImage(UIImage image, UIControlState forState) { }				/// <summary>		/// Returns the drawing rectangle for the maximum value image.		/// </summary>		/// <param name="bounds">The bounding rectangle of the receiver.</param>		/// <returns>The computed drawing rectangle for the image.</returns>		[iOSVersion(2)]		[Export("maximumValueImageRectForBounds")]		public CGRect MaximumValueImageRectForBounds(CGRect bounds) { return null; }				/// <summary>		/// Returns the drawing rectangle for the minimum value image.		/// </summary>		/// <param name="bounds">The bounding rectangle of the receiver.</param>		/// <returns>The computed drawing rectangle for the image.</returns>		[iOSVersion(2)]		[Export("minimumValueImageRectForBounds")]		public CGRect MinimumValueImageRectForBounds(CGRect bounds) { return null; }				/// <summary>		/// Returns the drawing rectangle for the slider’s track.		/// </summary>		/// <param name="bounds">The bounding rectangle of the receiver.</param>		/// <returns>The computed drawing rectangle for the track. This rectangle corresponds to the entire length of the track between the minimum and maximum value images.</returns>		[iOSVersion(2)]		[Export("trackRectForBounds")]		public CGRect TrackRectForBounds(CGRect bounds) { return null; }				/// <summary>		/// Returns the drawing rectangle for the slider’s thumb image.		/// </summary>		/// <param name="bounds">The bounding rectangle of the receiver.</param>		/// <param name="trackRect">The drawing rectangle for the receiver’s track, as returned by the trackRectForBounds: method.</param>		/// <param name="value">The current value of the slider.</param>		/// <returns>The computed drawing rectangle for the thumb image.</returns>		[iOSVersion(2)]		[Export("thumbRectForBounds")]		public CGRect ThumbRectForBounds(CGRect bounds, CGRect trackRect, CFloat value) { return null; }	}}