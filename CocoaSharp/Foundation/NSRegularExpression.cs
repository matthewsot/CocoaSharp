using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// The NSRegularExpression class is used to represent and apply regular expressions to Unicode strings.  An instance of this class is an immutable representation of a compiled regular expression pattern and various option flags. The pattern syntax currently supported is that specified by ICU. The ICU regular expressions are described at http://userguide.icu-project.org/strings/regexp.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Foundation/Reference/NSRegularExpression_Class/index.html#//apple_ref/occ/cl/NSRegularExpression"/>	[iOSVersion(4)]	public class NSRegularExpression : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol	{		/// <summary>		/// Creates an NSRegularExpression instance with the specified regular expression pattern and options.		/// </summary>		/// <param name="pattern">The regular expression pattern to compile.</param>		/// <param name="options">The matching options. See NSRegularExpressionOptions for possible values. The values can be combined using the C-bitwise OR operator.</param>		/// <param name="error">An out value that returns any error encountered during initialization. Returns an NSError object if the regular expression pattern is invalid; otherwise returns nil.</param>		[iOSVersion(4)]		[Export("regularExpressionWithPattern")]		public static NSRegularExpression RegularExpressionWithPattern(string pattern, NSRegularExpressionOptions options, NSErrorPointer error) { return default(NSRegularExpression); }				/// <summary>		/// Returns an initialized NSRegularExpression instance with the specified regular expression pattern and options.		/// </summary>		/// <param name="pattern">The regular expression pattern to compile.</param>		/// <param name="options">The regular expression options that are applied to the expression during matching. See NSRegularExpressionOptions for possible values.</param>		/// <param name="error">An out value that returns any error encountered during initialization. Returns an NSError object if the regular expression pattern is invalid; otherwise returns nil.firstMatchInString:options:range</param>		[iOSVersion(4)]		public NSRegularExpression(string pattern, NSRegularExpressionOptions options, NSErrorPointer error) { }				/// <summary>		/// Returns the number of matches of the regular expression within the specified range of the string.		/// </summary>		/// <param name="@string">The string to search.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		[iOSVersion(4)]		[Export("numberOfMatchesInString")]		public int NumberOfMatchesInString(string @string, NSMatchingOptions options, NSRange range) { return default(int); }				/// <summary>		/// Enumerates the string allowing the Block to handle each regular expression match.		/// </summary>		/// <param name="@string">The string.</param>		/// <param name="options">The matching options to report. See NSMatchingOptions for the supported values.</param>		/// <param name="range">The range of the string to test.</param>		/// <param name="usingBlock">The Block enumerates the matches of the regular expression in the string..		///   The block takes three arguments:		///       result		///   An NSTextCheckingResult specifying the match. This result gives the overall matched range via its range property, and the range of each individual capture group via its rangeAtIndex: method. The range {NSNotFound, 0} is returned if one of the capture groups did not participate in this particular match.		///       flags		///   The current state of the matching progress. See NSMatchingFlags for the possible values.		///       stop		///   A reference to a Boolean value. The Block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.		///   The Block returns void.</param>		[iOSVersion(4)]		[Export("enumerateMatchesInString")]		public void EnumerateMatchesInString(string @string, NSMatchingOptions options, NSRange range, Action<NSTextCheckingResult, NSMatchingFlags, UnsafePointer<ObjCBool>> usingBlock) {  }				/// <summary>		/// Returns an array containing all the matches of the regular expression in the string.		/// </summary>		/// <param name="@string">The string to search.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		[iOSVersion(4)]		[Export("matchesInString")]		public AnyObject[] MatchesInString(string @string, NSMatchingOptions options, NSRange range) { return default(AnyObject[]); }				/// <summary>		/// Returns the first match of the regular expression within the specified range of the string.		/// </summary>		/// <param name="@string">The string to search.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		[iOSVersion(4)]		[Export("firstMatchInString")]		public NSTextCheckingResult FirstMatchInString(string @string, NSMatchingOptions options, NSRange range) { return default(NSTextCheckingResult); }				/// <summary>		/// Returns the range of the first match of the regular expression within the specified range of the string.		/// </summary>		/// <param name="@string">The string to search.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		[iOSVersion(4)]		[Export("rangeOfFirstMatchInString")]		public NSRange RangeOfFirstMatchInString(string @string, NSMatchingOptions options, NSRange range) { return default(NSRange); }				/// <summary>		/// Replaces regular expression matches within the mutable string using the template string.		/// </summary>		/// <param name="@string">The mutable string to search and replace values within.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		/// <param name="withTemplate">The substitution template used when replacing matching instances.</param>		[iOSVersion(4)]		[Export("replaceMatchesInString")]		public int ReplaceMatchesInString(NSMutableString @string, NSMatchingOptions options, NSRange range, string withTemplate) { return default(int); }				/// <summary>		/// Returns a new string containing matching regular expressions replaced with the template string.		/// </summary>		/// <param name="@string">The string to search for values within.</param>		/// <param name="options">The matching options to use. See NSMatchingOptions for possible values.</param>		/// <param name="range">The range of the string to search.</param>		/// <param name="withTemplate">The substitution template used when replacing matching instances.</param>		[iOSVersion(4)]		[Export("stringByReplacingMatchesInString")]		public string StringByReplacingMatchesInString(string @string, NSMatchingOptions options, NSRange range, string withTemplate) { return default(string); }				/// <summary>		/// Returns a template string by adding backslash escapes as necessary to protect any characters that would match as pattern metacharacters		/// </summary>		/// <param name="@string">The template string</param>		[iOSVersion(4)]		[Export("escapedTemplateForString")]		public static string EscapedTemplateForString(string @string) { return default(string); }				/// <summary>		/// Returns a string by adding backslash escapes as necessary to protect any characters that would match as pattern metacharacters.		/// </summary>		/// <param name="@string">The string.</param>		[iOSVersion(4)]		[Export("escapedPatternForString")]		public static string EscapedPatternForString(string @string) { return default(string); }				/// <summary>		/// Used to perform template substitution for a single result for clients implementing their own replace functionality.		/// </summary>		/// <param name="result">The result of the single match.</param>		/// <param name="inString">The string from which the result was matched.</param>		/// <param name="offset">The offset to be added to the location of the result in the string.</param>		/// <param name="template">See Flag Options for the format of template.</param>		[iOSVersion(4)]		[Export("replacementStringForResult")]		public string ReplacementStringForResult(NSTextCheckingResult result, string inString, int offset, string template) { return default(string); }				/// <summary>		/// Returns the regular expression pattern. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("pattern")]		public string Pattern { get; private set; }				/// <summary>		/// Returns the options used when the regular expression option was created. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("options")]		public NSRegularExpressionOptions Options { get; private set; }				/// <summary>		/// Returns the number of capture groups in the regular expression. (read-only)		/// </summary>		[iOSVersion(4)]		[Export("numberOfCaptureGroups")]		public int NumberOfCaptureGroups { get; private set; }	}	/// <summary>	/// These constants define the regular expression options. These constants are used by the property options, regularExpressionWithPattern:options:error:, and initWithPattern:options:error:.	/// </summary>	[iOSVersion(4)]	public enum NSRegularExpressionOptions	{		/// <summary>		/// Match letters in the pattern independent of case.		/// </summary>		[iOSVersion(4)]		CaseInsensitive,		/// <summary>		/// Ignore whitespace and #-prefixed comments in the pattern.		/// </summary>		[iOSVersion(4)]		AllowCommentsAndWhitespace,		/// <summary>		/// Treat the entire pattern as a literal string.		/// </summary>		[iOSVersion(4)]		IgnoreMetacharacters,		/// <summary>		/// Allow . to match any character, including line separators.		/// </summary>		[iOSVersion(4)]		DotMatchesLineSeparators,		/// <summary>		/// Allow ^ and $ to match the start and end of lines.		/// </summary>		[iOSVersion(4)]		AnchorsMatchLines,		/// <summary>		/// Treat only \n as a line separator (otherwise, all standard line separators are used).		/// </summary>		[iOSVersion(4)]		UseUnixLineSeparators,		/// <summary>		/// Use Unicode TR#29 to specify word boundaries (otherwise, traditional regular expression word boundaries are used).		/// </summary>		[iOSVersion(4)]		UseUnicodeWordBoundaries,	}	/// <summary>	/// Set by the Block as the matching progresses, completes, or fails. Used by the method enumerateMatchesInString:options:range:usingBlock:.	/// </summary>	[iOSVersion(4)]	public enum NSMatchingFlags	{		/// <summary>		/// Set when the Block is called to report progress during a long-running match operation.		/// </summary>		[iOSVersion(4)]		Progress,		/// <summary>		/// Set when the Block is called after matching has completed.		/// </summary>		[iOSVersion(4)]		Completed,		/// <summary>		/// Set when the current match operation reached the end of the search range.		/// </summary>		[iOSVersion(4)]		HitEnd,		/// <summary>		/// Set when the current match depended on the location of the end of the search range.		/// </summary>		[iOSVersion(4)]		RequiredEnd,		/// <summary>		/// Set when matching failed due to an internal error.		/// </summary>		[iOSVersion(4)]		InternalError,	}	/// <summary>	/// The matching options constants specify the reporting, completion and matching rules to the expression matching methods. These constants are used by all methods that search for, or replace values, using a regular expression.	/// </summary>	[iOSVersion(4)]	public enum NSMatchingOptions	{		/// <summary>		/// Call the Block periodically during long-running match operations. This option has no effect for methods other than enumerateMatchesInString:options:range:usingBlock:. See enumerateMatchesInString:options:range:usingBlock: for a description of the constant in context.		/// </summary>		[iOSVersion(4)]		ReportProgress,		/// <summary>		/// Call the Block once after the completion of any matching. This option has no effect for methods other than enumerateMatchesInString:options:range:usingBlock:. See enumerateMatchesInString:options:range:usingBlock: for a description of the constant in context.		/// </summary>		[iOSVersion(4)]		ReportCompletion,		/// <summary>		/// Specifies that matches are limited to those at the start of the search range. See enumerateMatchesInString:options:range:usingBlock: for a description of the constant in context.		/// </summary>		[iOSVersion(4)]		Anchored,		/// <summary>		/// Specifies that matching may examine parts of the string beyond the bounds of the search range, for purposes such as word boundary detection, lookahead, etc. This constant has no effect if the search range contains the entire string. See enumerateMatchesInString:options:range:usingBlock: for a description of the constant in context.		/// </summary>		[iOSVersion(4)]		WithTransparentBounds,		/// <summary>		/// Specifies that ^ and $ will not automatically match the beginning and end of the search range, but will still match the beginning and end of the entire string. This constant has no effect if the search range contains the entire string. See enumerateMatchesInString:options:range:usingBlock: for a description of the constant in context.		/// </summary>		[iOSVersion(4)]		WithoutAnchoringBounds,	}}