using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// NSDecimalNumber, an immutable subclass of NSNumber, provides an object-oriented wrapper for doing base-10 arithmetic. An instance can represent any number that can be expressed as mantissa x 10^exponent where mantissa is a decimal integer up to 38 digits long, and exponent is an integer from –128 through 127.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDecimalNumber_Class/index.html#//apple_ref/occ/cl/NSDecimalNumber"/>	[iOSVersion(2)]	public class NSDecimalNumber : NSNumber//, AnyObject, BooleanLiteralConvertible, FloatLiteralConvertible, IntegerLiteralConvertible, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Creates and returns an NSDecimalNumber object equivalent to the number specified by the arguments.		/// </summary>		/// <param name="mantissa">The mantissa for the new decimal number object.</param>		/// <param name="exponent">The exponent for the new decimal number object.</param>		/// <param name="isNegative">A Boolean value that specifies whether the sign of the number is negative.</param>		[iOSVersion(2)]		[Export("decimalNumberWithMantissa")]		public static NSDecimalNumber DecimalNumberWithMantissa(UInt64 mantissa, Int16 exponent, bool isNegative) { return default(NSDecimalNumber); }				/// <summary>		/// Creates and returns an NSDecimalNumber object whose value is equivalent to that in a given numeric string.		/// </summary>		/// <param name="numericString">A numeric string.		///   Besides digits, numericString can include an initial “+” or “–”; a single “E” or “e”, to indicate the exponent of a number in scientific notation; and a single NSLocaleDecimalSeparator to divide the fractional from the integral part of the number.</param>		[iOSVersion(2)]		[Export("decimalNumberWithString")]		public static NSDecimalNumber DecimalNumberWithString(string numericString) { return default(NSDecimalNumber); }				/// <summary>		/// Creates and returns an NSDecimalNumber object whose value is equivalent to that in a given numeric string, interpreted using a given locale.		/// </summary>		/// <param name="numericString">A numeric string.		///   Besides digits, numericString can include an initial “+” or “–”; a single “E” or “e”, to indicate the exponent of a number in scientific notation; and a single NSLocaleDecimalSeparator to divide the fractional from the integral part of the number.</param>		/// <param name="locale">A dictionary that defines the locale (specifically the NSLocaleDecimalSeparator) to use to interpret the number in numericString.</param>		[iOSVersion(2)]		[Export("decimalNumberWithString")]		public static NSDecimalNumber DecimalNumberWithString(string numericString, AnyObject locale) { return default(NSDecimalNumber); }				/// <summary>		/// Returns an NSDecimalNumber object equivalent to the number 1.0.		/// </summary>		[iOSVersion(2)]		[Export("one")]		public static NSDecimalNumber One() { return default(NSDecimalNumber); }				/// <summary>		/// Returns an NSDecimalNumber object equivalent to the number 0.0.		/// </summary>		[iOSVersion(2)]		[Export("zero")]		public static NSDecimalNumber Zero() { return default(NSDecimalNumber); }				/// <summary>		/// Returns an NSDecimalNumber object that specifies no number.		/// </summary>		[iOSVersion(2)]		[Export("notANumber")]		public static NSDecimalNumber NotANumber() { return default(NSDecimalNumber); }				/// <summary>		/// Returns an NSDecimalNumber object initialized using the given mantissa, exponent, and sign.		/// </summary>		/// <param name="mantissa">The mantissa for the new decimal number object.</param>		/// <param name="exponent">The exponent for the new decimal number object.</param>		/// <param name="isNegative">A Boolean value that specifies whether the sign of the number is negative.</param>		[iOSVersion(2)]		[Export("convenience init")]		public NSDecimalNumber(UInt64 mantissa, Int16 exponent, bool isNegative) { }				/// <summary>		/// Returns an NSDecimalNumber object initialized so that its value is equivalent to that in a given numeric string.		/// </summary>		/// <param name="@string">A numeric string.		///   Besides digits, numericString can include an initial “+” or “–”; a single “E” or “e”, to indicate the exponent of a number in scientific notation; and a single NSLocaleDecimalSeparator to divide the fractional from the integral part of the number. For a listing of acceptable and unacceptable strings, see the class method decimalNumberWithString:locale:.</param>		[iOSVersion(2)]		[Export("convenience init")]		public NSDecimalNumber(string @string) { }				/// <summary>		/// Returns an NSDecimalNumber object initialized so that its value is equivalent to that in a given numeric string, interpreted using a given locale.		/// </summary>		/// <param name="@string">A numeric string.		///   Besides digits, numericString can include an initial “+” or “–”; a single “E” or “e”, to indicate the exponent of a number in scientific notation; and a single NSLocaleDecimalSeparator to divide the fractional from the integral part of the number.</param>		/// <param name="locale">A dictionary that defines the locale (specifically the NSLocaleDecimalSeparator) to use to interpret the number in numericString.</param>		[iOSVersion(2)]		[Export("convenience init")]		public NSDecimalNumber(string @string, AnyObject locale) { }				/// <summary>		/// Returns a new NSDecimalNumber object whose value is the sum of the receiver and another given NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber">The number to add to the receiver.</param>		[iOSVersion(2)]		[Export("decimalNumberByAdding")]		public NSDecimalNumber DecimalNumberByAdding(NSDecimalNumber decimalNumber) { return default(NSDecimalNumber); }				/// <summary>		/// Returns a new NSDecimalNumber object whose value is that of another given NSDecimalNumber object subtracted from the value of the receiver.		/// </summary>		/// <param name="decimalNumber">The number to subtract from the receiver.</param>		[iOSVersion(2)]		[Export("decimalNumberBySubtracting")]		public NSDecimalNumber DecimalNumberBySubtracting(NSDecimalNumber decimalNumber) { return default(NSDecimalNumber); }				/// <summary>		/// Returns a new NSDecimalNumber object whose value is the value of the receiver multiplied by that of another given NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber">The number by which to multiply the receiver.</param>		[iOSVersion(2)]		[Export("decimalNumberByMultiplyingBy")]		public NSDecimalNumber DecimalNumberByMultiplyingBy(NSDecimalNumber decimalNumber) { return default(NSDecimalNumber); }				/// <summary>		/// Returns a new NSDecimalNumber object whose value is the value of the receiver divided by that of another given NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber">The number by which to divide the receiver.</param>		[iOSVersion(2)]		[Export("decimalNumberByDividingBy")]		public NSDecimalNumber DecimalNumberByDividingBy(NSDecimalNumber decimalNumber) { return default(NSDecimalNumber); }				/// <summary>		/// Returns a new NSDecimalNumber object whose value is the value of the receiver raised to a given power.		/// </summary>		/// <param name="power">The power to which to raise the receiver.</param>		[iOSVersion(2)]		[Export("decimalNumberByRaisingToPower")]		public NSDecimalNumber DecimalNumberByRaisingToPower(int power) { return default(NSDecimalNumber); }				/// <summary>		/// Multiplies the receiver by 10^power and returns the product, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="power"></param>		[iOSVersion(2)]		[Export("decimalNumberByMultiplyingByPowerOf10")]		public NSDecimalNumber DecimalNumberByMultiplyingByPowerOf10(Int16 power) { return default(NSDecimalNumber); }				/// <summary>		/// Adds decimalNumber to the receiver and returns the sum, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByAdding")]		public NSDecimalNumber DecimalNumberByAdding(NSDecimalNumber decimalNumber, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Subtracts decimalNumber from the receiver and returns the difference, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberBySubtracting")]		public NSDecimalNumber DecimalNumberBySubtracting(NSDecimalNumber decimalNumber, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Multiplies the receiver by decimalNumber and returns the product, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByMultiplyingBy")]		public NSDecimalNumber DecimalNumberByMultiplyingBy(NSDecimalNumber decimalNumber, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Divides the receiver by decimalNumber and returns the quotient, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByDividingBy")]		public NSDecimalNumber DecimalNumberByDividingBy(NSDecimalNumber decimalNumber, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Raises the receiver to power and returns the result, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="power"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByRaisingToPower")]		public NSDecimalNumber DecimalNumberByRaisingToPower(int power, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Multiplies the receiver by 10^power and returns the product, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="power"></param>		/// <param name="withBehavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByMultiplyingByPowerOf10")]		public NSDecimalNumber DecimalNumberByMultiplyingByPowerOf10(Int16 power, NSDecimalNumberBehaviors withBehavior) { return default(NSDecimalNumber); }				/// <summary>		/// Rounds the receiver off in the way specified by behavior and returns the result, a newly created NSDecimalNumber object.		/// </summary>		/// <param name="behavior"></param>		[iOSVersion(2)]		[Export("decimalNumberByRoundingAccordingToBehavior")]		public NSDecimalNumber DecimalNumberByRoundingAccordingToBehavior(NSDecimalNumberBehaviors behavior) { return default(NSDecimalNumber); }				/// <summary>		/// Returns a string, specified according to a given locale, that represents the contents of the receiver.		/// </summary>		/// <param name="locale">A dictionary that defines the locale (specifically the NSLocaleDecimalSeparator) to use to generate the returned string.</param>		[iOSVersion(2)]		[Export("descriptionWithLocale")]		public string DescriptionWithLocale(AnyObject locale) { return default(string); }				/// <summary>		/// Returns the way arithmetic methods, like decimalNumberByAdding:, round off and handle error conditions.		/// </summary>		[iOSVersion(2)]		[Export("defaultBehavior")]		public static NSDecimalNumberBehaviors DefaultBehavior() { return default(NSDecimalNumberBehaviors); }				/// <summary>		/// Specifies the way that arithmetic methods, like decimalNumberByAdding:, round off and handle error conditions.		/// </summary>		/// <param name="behavior"></param>		[iOSVersion(2)]		[Export("setDefaultBehavior")]		public static void SetDefaultBehavior(NSDecimalNumberBehaviors behavior) {  }				/// <summary>		/// Returns an NSComparisonResult value that indicates the numerical ordering of the receiver and another given NSDecimalNumber object.		/// </summary>		/// <param name="decimalNumber">The number with which to compare the receiver.		///   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>		[iOSVersion(2)]		[Export("compare")]		public NSComparisonResult Compare(NSNumber decimalNumber) { return default(NSComparisonResult); }				/// <summary>		/// Returns the largest possible value of an NSDecimalNumber object.		/// </summary>		[iOSVersion(2)]		[Export("maximumDecimalNumber")]		public static NSDecimalNumber MaximumDecimalNumber() { return default(NSDecimalNumber); }				/// <summary>		/// Returns the smallest possible value of an NSDecimalNumber object.		/// </summary>		[iOSVersion(2)]		[Export("minimumDecimalNumber")]		public static NSDecimalNumber MinimumDecimalNumber() { return default(NSDecimalNumber); }				/// <summary>		/// The decimal number’s closest approximate double value. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("doubleValue")]		public Double DoubleValue { get; private set; }				/// <summary>		/// A C string containing the Objective-C type for the data contained in the decimal number object. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("objCType")]		public ConstUnsafePointer<Int8> ObjCType { get; private set; }	}}