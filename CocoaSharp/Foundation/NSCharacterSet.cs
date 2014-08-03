using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An NSCharacterSet object represents a set of Unicode-compliant characters. NSString and NSScanner objects use NSCharacterSet objects to group characters together for searching operations, so that they can find any of a particular set of characters during a search. The cluster’s two public classes, NSCharacterSet and NSMutableCharacterSet, declare the programmatic interface for static and dynamic character sets, respectively.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSCharacterSet_Class/index.html#//apple_ref/occ/cl/NSCharacterSet"/>	[iOSVersion(2)]	public class NSCharacterSet : NSObject//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol	{		/// <summary>		/// Returns a character set containing the characters in the categories Letters, Marks, and Numbers.		/// </summary>		[iOSVersion(2)]		[Export("alphanumericCharacterSet")]		public static NSCharacterSet AlphanumericCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Titlecase Letters.		/// </summary>		[iOSVersion(2)]		[Export("capitalizedLetterCharacterSet")]		public static NSCharacterSet CapitalizedLetterCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the categories of Control or Format Characters.		/// </summary>		[iOSVersion(2)]		[Export("controlCharacterSet")]		public static NSCharacterSet ControlCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Decimal Numbers.		/// </summary>		[iOSVersion(2)]		[Export("decimalDigitCharacterSet")]		public static NSCharacterSet DecimalDigitCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing all individual Unicode characters that can also be represented as composed character sequences.		/// </summary>		[iOSVersion(2)]		[Export("decomposableCharacterSet")]		public static NSCharacterSet DecomposableCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing values in the category of Non-Characters or that have not yet been defined in version 3.2 of the Unicode standard.		/// </summary>		[iOSVersion(2)]		[Export("illegalCharacterSet")]		public static NSCharacterSet IllegalCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the categories Letters and Marks.		/// </summary>		[iOSVersion(2)]		[Export("letterCharacterSet")]		public static NSCharacterSet LetterCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Lowercase Letters.		/// </summary>		[iOSVersion(2)]		[Export("lowercaseLetterCharacterSet")]		public static NSCharacterSet LowercaseLetterCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the newline characters.		/// </summary>		[iOSVersion(2)]		[Export("newlineCharacterSet")]		public static NSCharacterSet NewlineCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Marks.		/// </summary>		[iOSVersion(2)]		[Export("nonBaseCharacterSet")]		public static NSCharacterSet NonBaseCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Punctuation.		/// </summary>		[iOSVersion(2)]		[Export("punctuationCharacterSet")]		public static NSCharacterSet PunctuationCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the category of Symbols.		/// </summary>		[iOSVersion(2)]		[Export("symbolCharacterSet")]		public static NSCharacterSet SymbolCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in the categories of Uppercase Letters and Titlecase Letters.		/// </summary>		[iOSVersion(2)]		[Export("uppercaseLetterCharacterSet")]		public static NSCharacterSet UppercaseLetterCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing Unicode General Category Z*, U000A ~ U000D, and U0085.		/// </summary>		[iOSVersion(2)]		[Export("whitespaceAndNewlineCharacterSet")]		public static NSCharacterSet WhitespaceAndNewlineCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing only the in-line whitespace characters space (U+0020) and tab (U+0009).		/// </summary>		[iOSVersion(2)]		[Export("whitespaceCharacterSet")]		public static NSCharacterSet WhitespaceCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a fragment URL component.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLFragmentAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a host URL subcomponent.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLHostAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a password URL subcomponent.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLPasswordAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a path URL component.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLPathAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a query URL component.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLQueryAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns the character set for characters allowed in a user URL subcomponent.		/// </summary>		[iOSVersion(7)]		public static NSCharacterSet URLUserAllowedCharacterSet() { return default(NSCharacterSet); }				/// <summary>		/// Returns a character set containing the characters in a given string.		/// </summary>		/// <param name="charactersInString">A string containing characters for the new character set.</param>		[iOSVersion(2)]		public NSCharacterSet(string charactersInString) { }				/// <summary>		/// Returns a character set containing characters with Unicode values in a given range.		/// </summary>		/// <param name="range">A range of Unicode values.		///   aRange.location is the value of the first character to return; aRange.location + aRange.length– 1 is the value of the last.</param>		[iOSVersion(2)]		public NSCharacterSet(NSRange range) { }				/// <summary>		/// Returns a character set containing characters determined by a given bitmap representation.		/// </summary>		/// <param name="bitmapRepresentation">A bitmap representation of a character set.</param>		[iOSVersion(2)]		public NSCharacterSet(NSData bitmapRepresentation) { }				/// <summary>		/// Returns a character set read from the bitmap representation stored in the file a given path.		/// </summary>		/// <param name="contentsOfFile">A path to a file containing a bitmap representation of a character set. The path name must end with the extension .bitmap.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSCharacterSet(string contentsOfFile, bool NAME_YOUR_PARAMS = false) { }				/// <summary>		/// Returns a Boolean value that indicates whether a given character is in the receiver.		/// </summary>		/// <param name="aCharacter">The character to test for membership of the receiver.</param>		[iOSVersion(2)]		[Export("characterIsMember")]		public bool CharacterIsMember(unichar aCharacter) { return default(bool); }				/// <summary>		/// Returns a Boolean value that indicates whether the receiver has at least one member in a given character plane.		/// </summary>		/// <param name="thePlane">A character plane.</param>		[iOSVersion(2)]		[Export("hasMemberInPlane")]		public bool HasMemberInPlane(UInt8 thePlane) { return default(bool); }				/// <summary>		/// Returns a Boolean value that indicates whether the receiver is a superset of another given character set.		/// </summary>		/// <param name="theOtherSet">A character set.</param>		[iOSVersion(2)]		[Export("isSupersetOfSet")]		public bool IsSupersetOfSet(NSCharacterSet theOtherSet) { return default(bool); }				/// <summary>		/// Returns a Boolean value that indicates whether a given long character is a member of the receiver.		/// </summary>		/// <param name="theLongChar">A UTF32 character.</param>		[iOSVersion(2)]		[Export("longCharacterIsMember")]		public bool LongCharacterIsMember(UTF32Char theLongChar) { return default(bool); }				/// <summary>		/// Returns a character set containing only characters that don’t exist in the receiver.		/// </summary>		[iOSVersion(2)]		[Export("invertedSet")]		public NSCharacterSet InvertedSet { get; private set; }				/// <summary>		/// Returns an NSData object encoding the receiver in binary format.		/// </summary>		[iOSVersion(2)]		[Export("bitmapRepresentation")]		public NSData BitmapRepresentation { get; private set; }				/// <summary>		/// Specifies lower bound for a Unicode character range reserved for Apple’s corporate use.		/// </summary>		public int NSOpenStepUnicodeReservedBase { get; set; }	}}