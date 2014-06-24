using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Protocols/NSDecimalNumberBehaviors_Protocol/index.html#//apple_ref/occ/intf/NSDecimalNumberBehaviors
    /// <summary>
    /// The NSDecimalBehaviors protocol declares three methods that control the discretionary aspects of working with NSDecimalNumber objects.
    /// </summary>
    [iOSVersion(2)]
    public interface NSDecimalNumberBehaviors
    {
        /// <summary>
        /// Returns the way that NSDecimalNumber's decimalNumberBy... methods round their return values. (required)
        /// </summary>
        /// <returns>Returns the current rounding mode. See NSRoundingMode for possible values.</returns>
        [iOSVersion(2)]
        [Export("roundingMode")]
        NSRoundingMode RoundingMode();
        
        /// <summary>
        /// Returns the number of digits allowed after the decimal separator. (required)
        /// </summary>
        /// <returns>The number of digits allowed after the decimal separator.</returns>
        [iOSVersion(2)]
        [Export("scale")]
        CShort Scale();
        
        /// <summary>
        /// Specifies what an NSDecimalNumber object will do when it encounters an error. (required)
        /// </summary>
        /// <param name="method">The method that was being executed when the error occurred.</param>
        /// <param name="error">The type of error that was generated.</param>
        /// <param name="leftOperand">The left operand.</param>
        /// <param name="rightOperand">The right operand.</param>
        [iOSVersion(2)]
        [Export("exceptionDuringOperation")]
        NSDecimalNumber ExceptionDuringOperation(Selector method, NSCalculationError error, NSDecimalNumber leftOperand, NSDecimalNumber rightOperand);
    }


    /// <summary>
    /// These constants specify rounding behaviors.
    /// </summary>
    public enum NSRoundingMode
    {
        /// <summary>
        /// Round to the closest possible return value; when caught halfway between two positive numbers, round up; when caught between two negative numbers, round down.
        /// </summary>
        [iOSVersion(2)]
        RoundPlain,

        /// <summary>
        /// Round return values down.
        /// </summary>
        [iOSVersion(2)]
        RoundDown,

        /// <summary>
        /// Round return values up.
        /// </summary>
        [iOSVersion(2)]
        RoundUp,

        /// <summary>
        /// Round to the closest possible return value; when halfway between two possibilities, return the possibility whose last digit is even.
        /// </summary>
        [iOSVersion(2)]
        RoundBankers,
    }
    /// <summary>
    /// Calculation error constants used to describe an error in exceptionDuringOperation:error:leftOperand:rightOperand:.
    /// </summary>
    public enum NSCalculationError
    {
        /// <summary>
        /// No error occurred.
        /// </summary>
        [iOSVersion(2)]
        NoError,

        /// <summary>
        /// The number can’t be represented in 38 significant digits.
        /// </summary>
        [iOSVersion(2)]
        LossOfPrecision,

        /// <summary>
        /// The number is too small to represent.
        /// </summary>
        [iOSVersion(2)]
        Underflow,

        /// <summary>
        /// The number is too large to represent.
        /// </summary>
        [iOSVersion(2)]
        Overflow,

        /// <summary>
        /// The caller tried to divide by 0.
        /// </summary>
        [iOSVersion(2)]
        DivideByZero,
    }
}