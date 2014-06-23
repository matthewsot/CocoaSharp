using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
	//https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSByteCountFormatter_Class/index.html#//apple_ref/occ/cl/NSByteCountFormatter
	/// <summary>
	/// The NSByteCountFormatter class converts a byte count value into a textual representation that is formatted with the appropriate byte modifier (KB, MB, GB and so on).
	/// </summary>
	[iOSVersion(6)]
	public class NSByteCountFormatter : NSFormatter
	{
		/// <summary>
		/// Converts a byte count into the specified string format without creating an NSNumber object.
		/// </summary>
		/// <param name="byteCount">The byte count.</param>
		/// <param name="countStyle">The formatter style. See NSByteCountFormatterCountStyle for possible values.</param>
		/// <returns>A string containing the formatted byteCount value.</returns>
		[iOSVersion(6)]
		[Export("stringFromByteCount")]
		public static string StringFromByteCount(CLongLong byteCount, NSByteCountFormatterCountStyle countStyle) { return ""; }
		
		/// <summary>
		/// Converts a byte count into a string without creating an NSNumber object.
		/// </summary>
		/// <param name="byteCount">The byte count.</param>
		/// <returns>A string containing the formatted byteCount value.</returns>
		[iOSVersion(6)]
		[Export("stringFromByteCount")]
		public string StringFromByteCount(CLongLong byteCount) { return ""; }
		
		/// <summary>
		/// Specify the the number of bytes to be used for kilobytes.
		/// </summary>
		[iOSVersion(6)]
		[Export("countStyle")]
		public NSByteCountFormatterCountStyle CountStyle { get; set; }
		
		/// <summary>
		/// Determines whether to allow more natural display of some values.
		/// </summary>
		[iOSVersion(6)]
		[Export("allowsNonnumericFormatting")]
		public bool AllowsNonnumericFormatting { get; set; }
		
		/// <summary>
		/// Determines whether to include the number of bytes after the formatted string.
		/// </summary>
		[iOSVersion(6)]
		[Export("includesActualByteCount")]
		public bool IncludesActualByteCount { get; set; }
		
		/// <summary>
		/// Determines the display style of the size representation.
		/// </summary>
		[iOSVersion(6)]
		[Export("adaptive")]
		public bool Adaptive { get; set; }
		
		/// <summary>
		/// Specify the units that can be used in the output.
		/// </summary>
		[iOSVersion(6)]
		[Export("allowedUnits")]
		public NSByteCountFormatterUnits AllowedUnits { get; set; }
		
		/// <summary>
		/// Determines whether to include the count in the resulting formatted string.
		/// </summary>
		[iOSVersion(6)]
		[Export("includesCount")]
		public bool IncludesCount { get; set; }
		
		/// <summary>
		/// Determines whether to include the units in the resulting formatted string.
		/// </summary>
		[iOSVersion(6)]
		[Export("includesUnit")]
		public bool IncludesUnit { get; set; }
		
		/// <summary>
		/// Determines whether to zero pad fraction digits so a consistent number of characters is displayed in a representation.
		/// </summary>
		[iOSVersion(6)]
		[Export("zeroPadsFractionDigits")]
		public bool ZeroPadsFractionDigits { get; set; }
		
		/// <summary>
		/// Specifies the units appropriate for the formatter to display. Specifying any units explicitly causes just those units to be used in showing the number.
		/// </summary>
		public enum NSByteCountFormatterUnits
		{
			/// <summary>
			/// This causes default units appropriate for the platform to be used. This is the default.
			/// </summary>
			[iOSVersion(6)]
			UseDefault,
			
			/// <summary>
			/// Displays bytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseBytes,
			
			/// <summary>
			/// Displays kilobytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseKB,
			
			/// <summary>
			/// Displays megabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseMB,
			
			/// <summary>
			/// Displays gigabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseGB,
			
			/// <summary>
			/// Displays terabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseTB,
			
			/// <summary>
			/// Displays petabyte in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UsePB,
			
			/// <summary>
			/// Displays exabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseEB,
			
			/// <summary>
			/// Displays zettabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseZB,
			
			/// <summary>
			/// Displays yottabytes in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseYBOrHigher,
			
			/// <summary>
			/// Can use any unit in the formatter content.
			/// </summary>
			[iOSVersion(6)]
			UseAll,
		}
		/// <summary>
		/// Specifies display of file or storage byte counts. The display style is platform specific.
		/// </summary>
		[iOSVersion(6)]
		public enum NSByteCountFormatterCountStyle
        {
            /// <summary>
            /// Specifies display of file byte counts. The actual behavior for this is platform-specific; on OS X 10.8, this uses the binary style, but that may change over time.
            /// </summary>
            [iOSVersion(6)]
            File,

            /// <summary>
            /// Specifies display of memory byte counts. The actual behavior for this is platform-specific; on OS X 10.8, this uses the binary style, but that may change over time.
            /// </summary>
            [iOSVersion(6)]
            Memory,

            /// <summary>
            /// Causes 1000 bytes to be shown as 1 KB. It is better to use NSByteCountFormatterCountStyleFile or NSByteCountFormatterCountStyleMemory in most cases.
            /// </summary>
            [iOSVersion(6)]
            Decimal,

            /// <summary>
            /// Causes 1024 bytes to be shown as 1 KB. It is better to use NSByteCountFormatterCountStyleFile or NSByteCountFormatterCountStyleMemory in most cases.
            /// </summary>
            [iOSVersion(6)]
            Binary
        }
	}
}