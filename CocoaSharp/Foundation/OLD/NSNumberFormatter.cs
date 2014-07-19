using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNumberFormatter_Class/index.html#//apple_ref/occ/cl/NSNumberFormatter
    /// <summary>
    /// Instances of NSNumberFormatter format the textual representation of cells that contain NSNumber objects and convert textual representations of numeric values into NSNumber objects. The representation encompasses integers, floats, and doubles; floats and doubles can be formatted to a specified decimal position. NSNumberFormatter objects can also impose ranges on the numeric values cells can accept.
    /// </summary>
    [iOSVersion(2)]
    public class NSNumberFormatter : NSFormatter
    {
        /// <summary>
        /// Sets the formatter behavior of the receiver.
        /// </summary>
        /// <param name="behavior">An NSNumberFormatterBehavior constant that indicates the revision of the NSNumberFormatter class providing the current behavior.</param>
        [iOSVersion(2)]
        [Export("formatterBehavior")]
        public NSNumberFormatterBehavior FormatterBehavior { get; set; }

        /// <summary>
        /// Sets the default formatter behavior for new instances of NSNumberFormatter .
        /// </summary>
        /// <param name="behavior">An NSNumberFormatterBehavior constant that indicates the revision of the class providing the default behavior.</param>
        [iOSVersion(2)]
        [Export("setDefaultFormatterBehavior")]
        public static void SetDefaultFormatterBehavior(NSNumberFormatterBehavior behavior) { }

        /// <summary>
        /// Returns an NSNumberFormatterBehavior constant that indicates default formatter behavior for new instances of NSNumberFormatter.
        /// </summary>
        /// <returns>An NSNumberFormatterBehavior constant that indicates default formatter behavior for new instances of NSNumberFormatter.</returns>
        [iOSVersion(2)]
        [Export("defaultFormatterBehavior")]
        public static NSNumberFormatterBehavior DefaultFormatterBehavior() { return NSNumberFormatterBehavior.BehaviorDefault; }

        /// <summary>
        /// Sets the number style used by the receiver.
        /// </summary>
        /// <param name="style">An NSNumberFormatterStyle constant that specifies a formatter style.</param>
        [iOSVersion(2)]
        [Export("numberStyle")]
        public NSNumberFormatterStyle NumberStyle { get; set; }

        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver creates instances of NSDecimalNumber when it converts strings to number objects.
        /// </summary>
        /// <returns>true if the receiver creates instances of NSDecimalNumber when it converts strings to number objects, false if it creates instance of NSNumber.</returns>
        [iOSVersion(2)]
        [Export("generatesDecimalNumbers")]
        public bool GeneratesDecimalNumbers { get; set; }

        /// <summary>
        /// Returns by reference a cell-content object after creating it from a range of characters in a given string.
        /// </summary>
        /// <param name="anObject">On return, contains an instance of NSDecimalNumber or NSNumber based on the current value of generatesDecimalNumbers. The default is to return NSDecimalNumber instances</param>
        /// <param name="forString">A string object with the range of characters specified in rangep that is used to create anObject.</param>
        /// <param name="range">A range of characters in aString. On return, contains the actual range of characters used to create the object.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that explains why the conversion failed. If you pass in nil for error you are indicating that you are not interested in error information.</param>
        /// <returns>true if the conversion from string to cell-content object was successful, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("getObjectValue")]
        public bool GetObjectValue(AutoreleasingUnsafePointer<AnyObject> anObject, string forString, CMutablePointer<NSRange> range, NSErrorPointer error) { return false; }

        /// <summary>
        /// Returns an NSNumber object created by parsing a given string.
        /// </summary>
        /// <param name="string">An NSString object that is parsed to generate the returned number object.</param>
        /// <returns>An NSNumber object created by parsing string using the receiver’s format.</returns>
        [iOSVersion(2)]
        [Export("numberFromString")]
        public NSNumber NumberFromString(string @string) { return null; }

        /// <summary>
        /// Returns a string containing the formatted value of the provided number object.
        /// </summary>
        /// <param name="number">An NSNumber object that is parsed to create the returned string object.</param>
        /// <returns>A string containing the formatted value of number using the receiver’s current settings.</returns>
        [iOSVersion(2)]
        [Export("stringFromNumber")]
        public string StringFromNumber(NSNumber number) { return ""; }

        /// <summary>
        /// Returns a localized number string with the specified style.
        /// </summary>
        /// <param name="num">The number to localize</param>
        /// <param name="numberStyle">The localization style to use. See NSNumberFormatterStyle for the supported values.</param>
        /// <returns>An appropriately formatted NSString.</returns>
        [iOSVersion(4)]
        [Export("localizedStringFromNumber")]
        public static string LocalizedStringFromNumber(NSNumber num, NSNumberFormatterStyle numberStyle) { return ""; }

        /// <summary>
        /// Sets the locale of the receiver.
        /// </summary>
        /// <param name="theLocale">An NSLocale object representing the new locale of the receiver.</param>
        [iOSVersion(2)]
        [Export("locale")]
        public NSLocale Locale { get; set; }

        /// <summary>
        /// Returns the rounding increment used by the receiver.
        /// </summary>
        /// <returns>The rounding increment used by the receiver.</returns>
        [iOSVersion(2)]
        [Export("roundingIncrement")]
        public NSNumber RoundingIncrement { get; set; }

        /// <summary>
        /// Sets the rounding mode used by the receiver.
        /// </summary>
        /// <param name="mode">An NSNumberFormatterRoundingMode constant that indicates a rounding mode.</param>
        [iOSVersion(2)]
        [Export("roundingMode")]
        public NSNumberFormatterRoundingMode RoundingMode { get; set; }

        /// <summary>
        /// Returns the format width of the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("formatWidth")]
        public int FormatWidth { get; set; }

        /// <summary>
        /// Sets the format the receiver uses to display negative values.
        /// </summary>
        /// <param name="aFormat">A string that specifies the format for negative values.</param>
        [iOSVersion(2)]
        [Export("negativeFormat")]
        public string NegativeFormat { get; set; }

        /// <summary>
        /// Returns the format used by the receiver to display positive numbers.
        /// </summary>
        [iOSVersion(2)]
        [Export("positiveFormat")]
        public string PositiveFormat { get; set; }

        /// <summary>
        /// Sets the multiplier of the receiver.
        /// </summary>
        /// <param name="number">A number object that represents a multiplier.</param>
        [iOSVersion(2)]
        [Export("multiplier")]
        public NSNumber Multiplier { get; set; }

        /// <summary>
        /// Returns the string that the receiver uses to represent the percent symbol.
        /// </summary>
        [iOSVersion(2)]
        [Export("percentSymbol")]
        public string PercentSymbol { get; set; }

        /// <summary>
        /// Sets the string used by the receiver to represent the per-mill (per-thousand) symbol.
        /// </summary>
        /// <param name="string">A string that represents a per-mill symbol.</param>
        [iOSVersion(2)]
        [Export("perMillSymbol")]
        public string PerMillSymbol { get; set; }

        /// <summary>
        /// Returns the string the receiver uses to represent the minus sign.
        /// </summary>
        /// <returns>The string that represents the receiver’s minus sign.</returns>
        [iOSVersion(2)]
        [Export("minusSign")]
        public string MinusSign { get; set; }

        /// <summary>
        /// Sets the string used by the receiver to represent the plus sign.
        /// </summary>
        /// <param name="string">A string that represents a plus sign.</param>
        [iOSVersion(2)]
        [Export("plusSign")]
        public string PlusSign { get; set; }

        /// <summary>
        /// Returns the string the receiver uses as an exponent symbol.
        /// </summary>
        /// <returns>The string the receiver uses as an exponent symbol.</returns>
        [iOSVersion(2)]
        [Export("exponentSymbol")]
        public string ExponentSymbol { get; set; }

        /// <summary>
        /// Sets the string the receiver uses as the symbol to show the value zero.
        /// </summary>
        /// <param name="string">The string the receiver uses as the symbol to show the value zero.</param>
        [iOSVersion(2)]
        [Export("zeroSymbol")]
        public string ZeroSymbol { get; set; }

        /// <summary>
        /// Returns the string the receiver uses to represent a nil value.
        /// </summary>
        /// <returns>The string the receiver uses to represent a nil value.</returns>
        [iOSVersion(2)]
        [Export("nilSymbol")]
        public string NilSymbol { get; set; }

        /// <summary>
        /// Sets the string the receiver uses to represent NaN (“not a number”).
        /// </summary>
        /// <param name="string">A string that represents a NaN symbol.</param>
        [iOSVersion(2)]
        [Export("notANumberSymbol")]
        public string NotANumberSymbol { get; set; }

        /// <summary>
        /// Returns the symbol the receiver uses to represent negative infinity.
        /// </summary>
        /// <returns>The symbol the receiver uses to represent negative infinity.</returns>
        [iOSVersion(2)]
        [Export("negativeInfinitySymbol")]
        public string NegativeInfinitySymbol { get; set; }

        /// <summary>
        /// Sets the string used by the receiver for the positive infinity symbol.
        /// </summary>
        /// <param name="string">A string that represents a positive infinity symbol.</param>
        [iOSVersion(2)]
        [Export("positiveInfinitySymbol")]
        public string PositiveInfinitySymbol { get; set; }

        /// <summary>
        /// Returns the receiver’s local currency symbol.
        /// </summary>
        [iOSVersion(2)]
        [Export("currencySymbol")]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Sets the receiver’s currency code.
        /// </summary>
        /// <param name="string">A string specifying the receiver's new currency code.</param>
        [iOSVersion(2)]
        [Export("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the international currency symbol used by the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("internationalCurrencySymbol")]
        public string internationalCurrencySymbol { get; set; }

        /// <summary>
        /// Sets the currency grouping separator for the receiver.
        /// </summary>
        /// <param name="string">The currency grouping separator for the receiver.</param>
        [iOSVersion(2)]
        [Export("currencyGroupingSeparator")]
        public string CurrencyGroupingSeparator { get; set; }

        /// <summary>
        /// Returns the string the receiver uses as the prefix for positive values.
        /// </summary>
        /// <returns>The string the receiver uses as the prefix for positive values.</returns>
        [iOSVersion(2)]
        [Export("positivePrefix")]
        public string PositivePrefix { get; set; }

        /// <summary>
        /// Sets the string the receiver uses as the suffix for positive values.
        /// </summary>
        /// <param name="string">A string to use as the suffix for positive values.</param>
        [iOSVersion(2)]
        [Export("positiveSuffix")]
        public string PositiveSuffix { get; set; }

        /// <summary>
        /// Returns the string the receiver inserts as a prefix to negative values.
        /// </summary>
        /// <returns>The string the receiver inserts as a prefix to negative values.</returns>
        [iOSVersion(2)]
        [Export("negativePrefix")]
        public string NegativePrefix { get; set; }

        /// <summary>
        /// Sets the string the receiver uses as a suffix for negative values.
        /// </summary>
        /// <param name="string">A string to use as the suffix for negative values.</param>
        [iOSVersion(2)]
        [Export("negativeSuffix")]
        public string NegativeSuffix { get; set; }

        /// <summary>
        /// Returns a dictionary containing the text attributes that have been set for negative values.
        /// </summary>
        /// <returns>A dictionary containing the text attributes that have been set for negative values.</returns>
        [iOSVersion(2)]
        [Export("textAttributesForNegativeValues")]
        public NSDictionary TextAttributesForNegativeValues { get; set; }

        /// <summary>
        /// Sets the text attributes to be used in displaying positive values.
        /// </summary>
        /// <param name="newAttributes">A dictionary containing text attributes for the display of positive values.</param>
        [iOSVersion(2)]
        [Export("textAttributesForPositiveValues")]
        public NSDictionary TextAttributesForPositiveValues { get; set; }

        /// <summary>
        /// Sets the text attributes used to display a zero value.
        /// </summary>
        /// <param name="newAttributes">A dictionary containing text attributes for the display of zero values.</param>
        [iOSVersion(2)]
        [Export("textAttributesForZero")]
        public NSDictionary TextAttributesForZero { get; set; }

        /// <summary>
        /// Returns a dictionary containing the text attributes used to display the nil symbol.
        /// </summary>
        /// <returns>A dictionary containing the text attributes used to display the nil symbol.</returns>
        [iOSVersion(2)]
        [Export("textAttributesForNil")]
        public NSDictionary TextAttributesForNil { get; set; }

        /// <summary>
        /// Sets the text attributes used to display the NaN (&quot;not a number&quot;) string.
        /// </summary>
        /// <param name="newAttributes">A dictionary containing text attributes for the display of the NaN symbol.</param>
        [iOSVersion(2)]
        [Export("textAttributesForNotANumber")]
        public NSDictionary TextAttributesForNotANumber { get; set; }

        /// <summary>
        /// Returns a dictionary containing the text attributes used to display the positive infinity symbol.
        /// </summary>
        /// <returns>A dictionary containing the text attributes used to display the positive infinity symbol.</returns>
        [iOSVersion(2)]
        [Export("textAttributesForPositiveInfinity")]
        public NSDictionary TextAttributesForPositiveInfinity { get; set; }

        /// <summary>
        /// Sets the text attributes used to display the negative infinity symbol.
        /// </summary>
        /// <param name="newAttributes">A dictionary containing text attributes for the display of the negative infinity symbol.</param>
        [iOSVersion(2)]
        [Export("textAttributesForNegativeInfinity")]
        public NSDictionary TextAttributesForNegativeInfinity { get; set; }

        /// <summary>
        /// Returns a string containing the receiver’s grouping separator.
        /// </summary>
        /// <returns>A string containing the receiver’s grouping separator.</returns>
        [iOSVersion(2)]
        [Export("groupingSeparator")]
        public string GroupingSeparator { get; set; }

        /// <summary>
        /// Controls whether the receiver displays the grouping separator.
        /// </summary>
        /// <param name="flag">true if the receiver should display the grouping separator, false otherwise.</param>
        [iOSVersion(2)]
        [Export("usesGroupingSeparator")]
        public bool UsesGroupingSeparator { get; set; }

        /// <summary>
        /// Returns a string containing the character the receiver uses to represent decimal separators.
        /// </summary>
        /// <returns>A string containing the character the receiver uses to represent decimal separators.</returns>
        [iOSVersion(2)]
        [Export("decimalSeparator")]
        public string DecimalSeparator { get; set; }

        /// <summary>
        /// Controls whether the receiver always shows the decimal separator, even for integer numbers.
        /// </summary>
        /// <param name="flag">true if the receiver should always show the decimal separator, false otherwise.</param>
        [iOSVersion(2)]
        [Export("alwaysShowsDecimalSeparator")]
        public bool AlwaysShowsDecimalSeparator { get; set; }

        /// <summary>
        /// Returns the receiver’s currency decimal separator as a string.
        /// </summary>
        /// <returns>The receiver’s currency decimal separator as a string.</returns>
        [iOSVersion(2)]
        [Export("currencyDecimalSeparator")]
        public string CurrencyDecimalSeparator { get; set; }

        /// <summary>
        /// Sets the grouping size of the receiver.
        /// </summary>
        /// <param name="numDigits">An integer that specifies the grouping size.</param>
        [iOSVersion(2)]
        [Export("groupingSize")]
        public int GroupingSize { get; set; }

        /// <summary>
        /// Returns the size of secondary groupings for the receiver.
        /// </summary>
        /// <returns>The size of secondary groupings for the receiver.</returns>
        [iOSVersion(2)]
        [Export("secondaryGroupingSize")]
        public int SecondaryGroupingSize { get; set; }

        /// <summary>
        /// Sets the string that the receiver uses to pad numbers in the formatted string representation.
        /// </summary>
        /// <param name="string">A string containing a padding character (or characters).</param>
        [iOSVersion(2)]
        [Export("paddingCharacter")]
        public string PaddingCharacter { get; set; }

        /// <summary>
        /// Returns the padding position of the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("paddingPosition")]
        public NSNumberFormatterPadPosition PaddingPosition { get; set; }

        /// <summary>
        /// Sets whether the receiver allows as input floating-point values (that is, values that include the period character [.]).
        /// </summary>
        /// <param name="flag">true if the receiver allows floating-point values, false otherwise.</param>
        [iOSVersion(2)]
        [Export("allowsFloats")]
        public bool AllowsFloats { get; set; }

        /// <summary>
        /// Returns the lowest number allowed as input by the receiver.
        /// </summary>
        /// <returns>The lowest number allowed as input by the receiver or nil, meaning no limit.</returns>
        [iOSVersion(2)]
        [Export("minimum")]
        public NSNumber Minimum { get; set; }

        /// <summary>
        /// Sets the highest number the receiver allows as input.
        /// </summary>
        /// <param name="aMaximum">A number object that specifies a maximum input value.</param>
        [iOSVersion(2)]
        [Export("maximum")]
        public NSNumber Maximum { get; set; }

        /// <summary>
        /// Returns the minimum number of integer digits allowed as input and output by the receiver.
        /// </summary>
        /// <returns>The minimum number of integer digits allowed as input and output.</returns>
        [iOSVersion(2)]
        [Export("minimumintegerDigits")]
        public int MinimumintegerDigits { get; set; }

        /// <summary>
        /// Sets the minimum number of digits after the decimal separator allowed as input and output by the receiver.
        /// </summary>
        /// <param name="number">The minimum number of digits after the decimal separator allowed as input and output.</param>
        [iOSVersion(2)]
        [Export("minimumFractionDigits")]
        public int MinimumFractionDigits { get; set; }

        /// <summary>
        /// Returns the maximum number of integer digits allowed as input and output by the receiver.
        /// </summary>
        /// <returns>The maximum number of integer digits allowed as input and output.</returns>
        [iOSVersion(2)]
        [Export("maximumintegerDigits")]
        public int MaximumintegerDigits { get; set; }

        /// <summary>
        /// Sets the maximum number of digits after the decimal separator allowed as input and output by the receiver.
        /// </summary>
        /// <param name="number">The maximum number of digits after the decimal separator allowed as input and output.</param>
        [iOSVersion(2)]
        [Export("maximumFractionDigits")]
        public int MaximumFractionDigits { get; set; }

        /// <summary>
        /// Sets whether the receiver uses significant digits.
        /// </summary>
        /// <param name="b">true if the receiver uses significant digits, otherwise false.</param>
        [iOSVersion(2)]
        [Export("usesSignificantDigits")]
        public bool UsesSignificantDigits { get; set; }

        /// <summary>
        /// Returns the minimum number of significant digits for the receiver.
        /// </summary>
        /// <returns>The minimum number of significant digits for the receiver.</returns>
        [iOSVersion(2)]
        [Export("minimumSignificantDigits")]
        public int MinimumSignificantDigits { get; set; }

        /// <summary>
        /// Sets the maximum number of significant digits for the receiver.
        /// </summary>
        /// <param name="number">The maximum number of significant digits for the receiver.</param>
        [iOSVersion(2)]
        [Export("maximumSignificantDigits")]
        public int MaximumSignificantDigits { get; set; }

        /// <summary>
        /// Sets whether the receiver will use heuristics to guess at the number which is intended by a string.
        /// </summary>
        /// <param name="b">true if the receiver will use heuristics to guess at the number which is intended by the string; otherwise false.</param>
        [iOSVersion(2)]
        [Export("lenient")]
        public bool Lenient { get; set; }

        /// <summary>
        /// Sets whether partial string validation is enabled for the receiver.
        /// </summary>
        /// <param name="enabled">true if partial string validation is enabled, otherwise false.</param>
        [iOSVersion(2)]
        [Export("partialStringValidationEnabled")]
        public bool PartialStringValidationEnabled { get; set; }
    }

    /// <summary>
    /// These constants specify predefined number format styles. These constants are used by the numberStyle and setNumberStyle: methods.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNumberFormatterStyle
    {
        /// <summary>
        /// Specifies no style.
        /// </summary>
        [iOSVersion(2)]
        NoStyle,

        /// <summary>
        /// Specifies a decimal style format.
        /// </summary>
        [iOSVersion(2)]
        DecimalStyle,

        /// <summary>
        /// Specifies a currency style format.
        /// </summary>
        [iOSVersion(2)]
        CurrencyStyle,

        /// <summary>
        /// Specifies a percent style format.
        /// </summary>
        [iOSVersion(2)]
        PercentStyle,

        /// <summary>
        /// Specifies a scientific style format.
        /// </summary>
        [iOSVersion(2)]
        ScientificStyle,

        /// <summary>
        /// Specifies a spell-out format; for example, “23” becomes “twenty-three”.
        /// </summary>
        [iOSVersion(2)]
        SpellOutStyle,
    }

    /// <summary>
    /// These constants specify the behavior of a number formatter. These constants are returned by the defaultFormatterBehavior class method and the formatterBehavior instance methods; you set them with the setDefaultFormatterBehavior: class method and the setFormatterBehavior: instance method.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNumberFormatterBehavior
    {
        /// <summary>
        /// The number-formatter behavior set as the default for new instances. You can set the default formatter behavior with the class method setDefaultFormatterBehavior:.
        /// </summary>
        [iOSVersion(2)]
        BehaviorDefault,

        /// <summary>
        /// The number-formatter behavior since OS X v10.4.
        /// </summary>
        [iOSVersion(2)]
        Behavior10_4,
    }

    /// <summary>
    /// These constants are used to specify how numbers should be padded. These constants are used by the paddingPosition and setPaddingPosition: methods.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNumberFormatterPadPosition
    {
        /// <summary>
        /// Specifies that the padding should occur before the prefix.
        /// </summary>
        [iOSVersion(2)]
        BeforePrefix,

        /// <summary>
        /// Specifies that the padding should occur after the prefix.
        /// </summary>
        [iOSVersion(2)]
        AfterPrefix,

        /// <summary>
        /// Specifies that the padding should occur before the suffix.
        /// </summary>
        [iOSVersion(2)]
        BeforeSuffix,

        /// <summary>
        /// Specifies that the padding should occur after the suffix.
        /// </summary>
        [iOSVersion(2)]
        AfterSuffix,
    }
    /// <summary>
    /// These constants are used to specify how numbers should be rounded. These constants are used by the roundingModeand setRoundingMode: methods.
    /// </summary>
    public enum NSNumberFormatterRoundingMode
    {
        /// <summary>
        /// Round towards positive infinity.
        /// </summary>
        [iOSVersion(2)]
        RoundCeiling,

        /// <summary>
        /// Round towards negative infinity.
        /// </summary>
        [iOSVersion(2)]
        RoundFloor,

        /// <summary>
        /// Round towards zero.
        /// </summary>
        [iOSVersion(2)]
        RoundDown,

        /// <summary>
        /// Round away from zero.
        /// </summary>
        [iOSVersion(2)]
        RoundUp,

        /// <summary>
        /// Round towards the nearest integer, or towards an even number if equidistant.
        /// </summary>
        [iOSVersion(2)]
        RoundHalfEven,

        /// <summary>
        /// Round towards the nearest integer, or towards zero if equidistant.
        /// </summary>
        [iOSVersion(2)]
        RoundHalfDown,

        /// <summary>
        /// Round towards the nearest integer, or away from zero if equidistant.
        /// </summary>
        [iOSVersion(2)]
        RoundHalfUp,
    }
}