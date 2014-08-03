using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// Locales encapsulate information about linguistic, cultural, and technological conventions and standards. Examples of information encapsulated by a locale include the symbol used for the decimal separator in numbers and the way dates are formatted.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSLocale_Class/index.html#//apple_ref/occ/cl/NSLocale"/>	[iOSVersion(2)]	public class NSLocale : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Initializes the receiver using a given locale identifier.		/// </summary>		/// <param name="localeIdentifier">The identifier for the new locale.</param>		[iOSVersion(2)]		public NSLocale(string localeIdentifier) { }				/// <summary>		/// Returns the current logical locale for the current user.		/// </summary>		[iOSVersion(2)]		[Export("autoupdatingCurrentLocale")]		public static NSLocale AutoupdatingCurrentLocale() { return default(NSLocale); }				/// <summary>		/// Returns the logical locale for the current user.		/// </summary>		[iOSVersion(2)]		[Export("currentLocale")]		public static NSLocale CurrentLocale() { return default(NSLocale); }				/// <summary>		/// Returns the generic locale that contains fixed “backstop” settings that provide values for otherwise undefined keys.		/// </summary>		[iOSVersion(2)]		[Export("systemLocale")]		public static NSLocale SystemLocale() { return default(NSLocale); }				/// <summary>		/// Returns the display name for the given value.		/// </summary>		/// <param name="key">Specifies which of the locale property keys value is (see Constants),</param>		/// <param name="value">A value for key.</param>		[iOSVersion(2)]		[Export("displayNameForKey")]		public string DisplayNameForKey(AnyObject key, AnyObject value) { return default(string); }				/// <summary>		/// Returns the object corresponding to the specified key.		/// </summary>		/// <param name="key">The key for which to return the corresponding value. For valid values of key, see Constants.</param>		[iOSVersion(2)]		[Export("objectForKey")]		public AnyObject ObjectForKey(AnyObject key) { return default(AnyObject); }				/// <summary>		/// Returns an array of NSString objects, each of which identifies a locale available on the system.		/// </summary>		[iOSVersion(2)]		[Export("availableLocaleIdentifiers")]		public static AnyObject[] AvailableLocaleIdentifiers() { return default(AnyObject[]); }				/// <summary>		/// Returns an array of NSString objects that represents all known legal country codes.		/// </summary>		[iOSVersion(2)]		public static AnyObject[] ISOCountryCodes() { return default(AnyObject[]); }				/// <summary>		/// Returns an array of NSString objects that represents all known legal ISO currency codes.		/// </summary>		[iOSVersion(2)]		public static AnyObject[] ISOCurrencyCodes() { return default(AnyObject[]); }				/// <summary>		/// Returns an array of NSString objects that represents all known legal ISO language codes.		/// </summary>		[iOSVersion(2)]		public static AnyObject[] ISOLanguageCodes() { return default(AnyObject[]); }				/// <summary>		/// Returns an array of common ISO currency codes		/// </summary>		[iOSVersion(2)]		[Export("commonISOCurrencyCodes")]		public static AnyObject[] CommonISOCurrencyCodes() { return default(AnyObject[]); }				/// <summary>		/// Returns the canonical identifier for a given locale identification string.		/// </summary>		/// <param name="@string">A locale identification string.</param>		[iOSVersion(2)]		[Export("canonicalLocaleIdentifierFromString")]		public static string CanonicalLocaleIdentifierFromString(string @string) { return default(string); }				/// <summary>		/// Returns a dictionary that is the result of parsing a locale ID.		/// </summary>		/// <param name="@string">A locale ID, consisting of language, script, country, variant, and keyword/value pairs, for example, &quot;en_US@calendar=japanese&quot;.</param>		[iOSVersion(2)]		[Export("componentsFromLocaleIdentifier")]		public static Dictionary<NSObject, AnyObject> ComponentsFromLocaleIdentifier(string @string) { return default(Dictionary<NSObject, AnyObject>); }				/// <summary>		/// Returns a locale identifier from the components specified in a given dictionary.		/// </summary>		/// <param name="dict">A dictionary containing components that specify a locale. For valid dictionary keys, see Constants.</param>		[iOSVersion(2)]		[Export("localeIdentifierFromComponents")]		public static string LocaleIdentifierFromComponents(Dictionary<NSObject, AnyObject> dict) { return default(string); }				/// <summary>		/// Returns a canonical language identifier by mapping an arbitrary locale identification string to the canonical identifier.		/// </summary>		/// <param name="@string">A string representation of an arbitrary locale identifier.</param>		[iOSVersion(4)]		[Export("canonicalLanguageIdentifierFromString")]		public static string CanonicalLanguageIdentifierFromString(string @string) { return default(string); }				/// <summary>		/// Returns a locale identifier from a Windows locale code.		/// </summary>		/// <param name="lcid">The Windows locale code.</param>		[iOSVersion(4)]		[Export("localeIdentifierFromWindowsLocaleCode")]		public static string LocaleIdentifierFromWindowsLocaleCode(uint lcid) { return default(string); }				/// <summary>		/// Returns a Window locale code from the locale identifier.		/// </summary>		/// <param name="localeIdentifier">The locale identifier.</param>		[iOSVersion(4)]		[Export("windowsLocaleCodeFromLocaleIdentifier")]		public static uint WindowsLocaleCodeFromLocaleIdentifier(string localeIdentifier) { return default(uint); }				/// <summary>		/// Returns the user's language preference order as an array of strings.		/// </summary>		[iOSVersion(2)]		[Export("preferredLanguages")]		public static AnyObject[] PreferredLanguages() { return default(AnyObject[]); }				/// <summary>		/// Returns the character direction for the specified ISO language code.		/// </summary>		/// <param name="isoLangCode">The ISO language code.</param>		[iOSVersion(4)]		[Export("characterDirectionForLanguage")]		public static NSLocaleLanguageDirection CharacterDirectionForLanguage(string isoLangCode) { return default(NSLocaleLanguageDirection); }				/// <summary>		/// Returns the line direction for the specified ISO language code.		/// </summary>		/// <param name="isoLangCode">The ISO language code.</param>		[iOSVersion(4)]		[Export("lineDirectionForLanguage")]		public static NSLocaleLanguageDirection LineDirectionForLanguage(string isoLangCode) { return default(NSLocaleLanguageDirection); }				/// <summary>		/// The identifier for the receiver. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("localeIdentifier")]		public string LocaleIdentifier { get; private set; }	}}