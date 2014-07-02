using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{	//https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDevice_Class/index.html#//apple_ref/occ/cl/UIDevice	/// <summary>	/// The UIDevice class provides a singleton instance representing the current device. From this instance you can obtain information about the device such as assigned name, device model, and operating-system name and version.	/// </summary>	[iOSVersion(2)]	public class UIDevice : NSObject	{		/// <summary>		/// Returns an object representing the current device.		/// </summary>		/// <returns>A singleton object that represents the current device.</returns>		[iOSVersion(2)]		[Export("currentDevice")]		public static UIDevice CurrentDevice() { return null; }				/// <summary>		/// A Boolean value indicating whether multitasking is supported on the current device. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("multitaskingSupported")]		public bool MultitaskingSupported { get; private set; }				/// <summary>		/// The name identifying the device. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("name")]		public string Name { get; private set; }				/// <summary>		/// The name of the operating system running on the device represented by the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("systemName")]		public string SystemName { get; private set; }				/// <summary>		/// The current version of the operating system. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("systemVersion")]		public string SystemVersion { get; private set; }				/// <summary>		/// The model of the device. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("model")]		public string Model { get; private set; }				/// <summary>		/// The model of the device as a localized string. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localizedModel")]		public string LocalizedModel { get; private set; }				/// <summary>		/// The style of interface to use on the current device. (read-only)		/// </summary>		[iOSVersion(3.2)]		[Export("userinterfaceIdiom")]		public UIUserinterfaceIdiom UserinterfaceIdiom { get; private set; }				/// <summary>		/// An alphanumeric string that uniquely identifies a device to the app’s vendor. (read-only)		/// </summary>		[iOSVersion(6)]		[Export("identifierForVendor")]		public NSUUID IdentifierForVendor { get; private set; }				/// <summary>		/// Returns the physical orientation of the device. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("orientation")]		public UIDeviceOrientation Orientation { get; private set; }				/// <summary>		/// A Boolean value that indicates whether the receiver generates orientation notifications (true) or not (false). (read-only)		/// </summary>		[iOSVersion(2)]		[Export("generatesDeviceOrientationNotifications")]		public bool GeneratesDeviceOrientationNotifications { get; private set; }				/// <summary>		/// Begins the generation of notifications of device orientation changes.		/// </summary>		[iOSVersion(2)]		[Export("beginGeneratingDeviceOrientationNotifications")]		public void BeginGeneratingDeviceOrientationNotifications() { }				/// <summary>		/// Ends the generation of notifications of device orientation changes.		/// </summary>		[iOSVersion(2)]		[Export("endGeneratingDeviceOrientationNotifications")]		public void EndGeneratingDeviceOrientationNotifications() { }				/// <summary>		/// The battery charge level for the device. (read-only)		/// </summary>		[iOSVersion(3)]		[Export("batteryLevel")]		public CFloat BatteryLevel { get; private set; }				/// <summary>		/// A Boolean value indicating whether battery monitoring is enabled (true) or not (false).		/// </summary>		[iOSVersion(3)]		[Export("batteryMonitoringEnabled")]		public bool BatteryMonitoringEnabled { get; set; }				/// <summary>		/// The battery state for the device. (read-only)		/// </summary>		[iOSVersion(3)]		[Export("batteryState")]		public UIDeviceBatteryState BatteryState { get; private set; }				/// <summary>		/// A Boolean value indicating whether proximity monitoring is enabled (true) or not (false).		/// </summary>		[iOSVersion(3)]		[Export("proximityMonitoringEnabled")]		public bool ProximityMonitoringEnabled { get; set; }				/// <summary>		/// A Boolean value indicating whether the proximity sensor is close to the user (true) or not (false). (read-only)		/// </summary>		[iOSVersion(3)]		[Export("proximityState")]		public bool ProximityState { get; private set; }				/// <summary>		/// Plays an input click in an enabled input view.		/// </summary>		[Export("playInputClick")]		public void PlayInputClick() { }						WHAT								WHAT								WHAT								WHAT	}			/// <summary>	/// The battery power state of the device.	/// </summary>	public enum UIDeviceBatteryState	{		/// <summary>		/// The battery state for the device cannot be determined.		/// </summary>		[iOSVersion(3)]		Unknown,					/// <summary>		/// The device is not plugged into power; the battery is discharging.		/// </summary>		[iOSVersion(3)]		Unplugged,					/// <summary>		/// The device is plugged into power and the battery is less than 100% charged.		/// </summary>		[iOSVersion(3)]		Charging,					/// <summary>		/// The device is plugged into power and the battery is 100% charged.		/// </summary>		[iOSVersion(3)]		Full,	}	/// <summary>	/// The physical orientation of the device.	/// </summary>	public enum UIDeviceOrientation	{		/// <summary>		/// The orientation of the device cannot be determined.		/// </summary>		[iOSVersion(2)]		Unknown,					/// <summary>		/// The device is in portrait mode, with the device held upright and the home button at the bottom.		/// </summary>		[iOSVersion(2)]		Portrait,					/// <summary>		/// The device is in portrait mode but upside down, with the device held upright and the home button at the top.		/// </summary>		[iOSVersion(2)]		PortraitUpsideDown,					/// <summary>		/// The device is in landscape mode, with the device held upright and the home button on the right side.		/// </summary>		[iOSVersion(2)]		LandscapeLeft,					/// <summary>		/// The device is in landscape mode, with the device held upright and the home button on the left side.		/// </summary>		[iOSVersion(2)]		LandscapeRight,					/// <summary>		/// The device is held parallel to the ground with the screen facing upwards.		/// </summary>		[iOSVersion(2)]		FaceUp,					/// <summary>		/// The device is held parallel to the ground with the screen facing downwards.		/// </summary>		[iOSVersion(2)]		FaceDown,	}	/// <summary>	/// The type of interface that should be used on the current device	/// </summary>	public enum UIUserinterfaceIdiom	{		/// <summary>		/// Used when an object has a trait collection, but it is not in an environment yet. For example, a view that is created, but not put into a view hierarchy.		/// </summary>		[iOSVersion(8)]		Unspecified,					/// <summary>		/// The user interface should be designed for iPhone and iPod touch.		/// </summary>		[iOSVersion(3.2)]		Phone,					/// <summary>		/// The user interface should be designed for iPad.		/// </summary>		[iOSVersion(3.2)]		Pad,	}}