using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSNumber is a subclass of NSValue that offers a value as any C scalar (numeric) type. It defines a set of methods specifically for setting and accessing the value as a signed or unsigned char, short int, int, long int, long long int, float, or double or as a BOOL. (Note that number objects do not necessarily preserve the type they are created with.) It also defines a compare: method to determine the ordering of two NSNumber objects.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNumber_Class/index.html#//apple_ref/occ/cl/NSNumber"/>	[iOSVersion(2)]	public class NSNumber : NSValue//, AnyObject, BooleanLiteralConvertible, FloatLiteralConvertible, IntegerLiteralConvertible, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a BOOL.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithBool")]		public static NSNumber NumberWithBool(bool value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a signed char.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithChar")]		public static NSNumber NumberWithChar(Int8 value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a double.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithDouble")]		public static NSNumber NumberWithDouble(Double value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a float.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithFloat")]		public static NSNumber NumberWithFloat(Float value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a signed int.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithInt")]		public static NSNumber NumberWithInt(int value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an NSInteger.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithInteger")]		public static NSNumber NumberWithInteger(int value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a signed long.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithLong")]		public static NSNumber NumberWithLong(int value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as a signed long long.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithLongLong")]		public static NSNumber NumberWithLongLong(Int64 value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing value, treating it as a signed short.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithShort")]		public static NSNumber NumberWithShort(Int16 value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an unsigned char.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedChar")]		public static NSNumber NumberWithUnsignedChar(UInt8 value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an unsigned int.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedInt")]		public static NSNumber NumberWithUnsignedInt(uint value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an NSUInteger.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedInteger")]		public static NSNumber NumberWithUnsignedInteger(int value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an unsigned long.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedLong")]		public static NSNumber NumberWithUnsignedLong(uint value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an unsigned long long.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedLongLong")]		public static NSNumber NumberWithUnsignedLongLong(UInt64 value) { return default(NSNumber); }				/// <summary>		/// Creates and returns an NSNumber object containing a given value, treating it as an unsigned short.		/// </summary>		/// <param name="value">The value for the new number.</param>		[iOSVersion(2)]		[Export("numberWithUnsignedShort")]		public static NSNumber NumberWithUnsignedShort(UInt16 value) { return default(NSNumber); }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a BOOL.		/// </summary>		/// <param name="bool">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(bool bool) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a signed char.		/// </summary>		/// <param name="char">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(Int8 char) { }				/// <summary>		/// Returns an NSNumber object initialized to contain value, treated as a double.		/// </summary>		/// <param name="double">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(Double double) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a float.		/// </summary>		/// <param name="float">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(Float float) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a signed int.		/// </summary>		/// <param name="int">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(int int) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an NSInteger.		/// </summary>		/// <param name="integer">The value for the new number.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSNumber(int integer, bool NAME_YOUR_PARAMS = false) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a signed long.		/// </summary>		/// <param name="long">The value for the new number.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSNumber(int long, int NAME_YOUR_PARAMS = 0) { }				/// <summary>		/// Returns an NSNumber object initialized to contain value, treated as a signed long long.		/// </summary>		/// <param name="longLong">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(Int64 longLong) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as a signed short.		/// </summary>		/// <param name="short">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(Int16 short) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an unsigned char.		/// </summary>		/// <param name="unsignedChar">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(UInt8 unsignedChar) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an unsigned int.		/// </summary>		/// <param name="unsignedInt">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(uint unsignedInt) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an NSUInteger.		/// </summary>		/// <param name="unsignedInteger">The value for the new number.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSNumber(int unsignedInteger, string NAME_YOUR_PARAMS = "") { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an unsigned long.		/// </summary>		/// <param name="unsignedLong">The value for the new number.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSNumber(uint unsignedLong, bool NAME_YOUR_PARAMS = false) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an unsigned long long.		/// </summary>		/// <param name="unsignedLongLong">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(UInt64 unsignedLongLong) { }				/// <summary>		/// Returns an NSNumber object initialized to contain a given value, treated as an unsigned short.		/// </summary>		/// <param name="unsignedShort">The value for the new number.</param>		[iOSVersion(2)]		public NSNumber(UInt16 unsignedShort) { }				/// <summary>		/// Returns a string that represents the contents of the number object for a given locale.		/// </summary>		/// <param name="aLocale">An object containing locale information with which to format the description. Use nil if you don’t want the description formatted.</param>		[iOSVersion(2)]		[Export("descriptionWithLocale")]		public string DescriptionWithLocale(AnyObject aLocale) { return default(string); }				/// <summary>		/// Returns an NSComparisonResult value that indicates whether the number object’s value is greater than, equal to, or less than a given number.		/// </summary>		/// <param name="aNumber">The number to compare to the number object’s value.		///   This value must not be nil. If the value is nil, the behavior is undefined and may change in future versions of OS X.</param>		[iOSVersion(2)]		[Export("compare")]		public NSComparisonResult Compare(NSNumber aNumber) { return default(NSComparisonResult); }				/// <summary>		/// Returns a Boolean value that indicates whether the number object’s value and a given number are equal.		/// </summary>		/// <param name="aNumber">The number to compare to the number object’s value.</param>		[iOSVersion(2)]		[Export("isEqualToNumber")]		public bool IsEqualToNumber(NSNumber aNumber) { return default(bool); }				/// <summary>		/// The number object's value expressed as a Boolean value. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("boolValue")]		public bool BoolValue { get; private set; }				/// <summary>		/// The number object's value expressed as a char. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("charValue")]		public Int8 CharValue { get; private set; }				/// <summary>		/// The number object's value expressed as a double, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("doubleValue")]		public Double DoubleValue { get; private set; }				/// <summary>		/// The number object's value expressed as a float, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("floatValue")]		public Float FloatValue { get; private set; }				/// <summary>		/// The number object's value expressed as an int, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("intValue")]		public int IntValue { get; private set; }				/// <summary>		/// The number object's value expressed as an NSInteger object, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("integerValue")]		public int IntegerValue { get; private set; }				/// <summary>		/// The number object's value expressed as a long long, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("longLongValue")]		public Int64 LongLongValue { get; private set; }				/// <summary>		/// The number object's value expressed as a long, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("longValue")]		public int LongValue { get; private set; }				/// <summary>		/// The number object's value expressed as a short, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("shortValue")]		public Int16 ShortValue { get; private set; }				/// <summary>		/// The number object's value expressed as an unsigned char, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedCharValue")]		public UInt8 UnsignedCharValue { get; private set; }				/// <summary>		/// The number object's value expressed as an NSUInteger object, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedIntegerValue")]		public int UnsignedIntegerValue { get; private set; }				/// <summary>		/// The number object's value expressed as an unsigned int, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedIntValue")]		public uint UnsignedIntValue { get; private set; }				/// <summary>		/// The number object's value expressed as an unsigned long long, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedLongLongValue")]		public UInt64 UnsignedLongLongValue { get; private set; }				/// <summary>		/// The number object's value expressed as an unsigned long, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedLongValue")]		public uint UnsignedLongValue { get; private set; }				/// <summary>		/// The number object's value expressed as an unsigned short, converted as necessary. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("unsignedShortValue")]		public UInt16 UnsignedShortValue { get; private set; }				/// <summary>		/// The number object's value expressed as a human-readable string. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("stringValue")]		public string StringValue { get; private set; }	}}