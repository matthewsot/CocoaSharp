using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSDecimalBehaviors protocol declares three methods that control the discretionary aspects of working with NSDecimalNumber objects.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSDecimalNumberBehaviors_Protocol/index.html#//apple_ref/occ/intf/NSDecimalNumberBehaviors"/>	[iOSVersion(2)]	public interface NSDecimalNumberBehaviors//:	{		/// <summary>		/// Returns the way that NSDecimalNumber's decimalNumberBy... methods round their return values. (required)		/// </summary>		[iOSVersion(2)]		[Export("roundingMode")]		NSRoundingMode RoundingMode();				/// <summary>		/// Returns the number of digits allowed after the decimal separator. (required)		/// </summary>		[iOSVersion(2)]		[Export("scale")]		Int16 Scale();				/// <summary>		/// Specifies what an NSDecimalNumber object will do when it encounters an error. (required)		/// </summary>		/// <param name="method">The method that was being executed when the error occurred.</param>		/// <param name="error">The type of error that was generated.</param>		/// <param name="leftOperand">The left operand.</param>		/// <param name="rightOperand">The right operand.</param>		[iOSVersion(2)]		[Export("exceptionDuringOperation")]		NSDecimalNumber ExceptionDuringOperation(Selector method, NSCalculationError error, NSDecimalNumber leftOperand, NSDecimalNumber rightOperand);	}}