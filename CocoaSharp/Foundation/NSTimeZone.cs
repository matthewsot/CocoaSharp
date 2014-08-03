using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// NSTimeZone is an abstract class that defines the behavior of time zone objects. Time zone objects represent geopolitical regions. Consequently, these objects have names for these regions. Time zone objects also represent a temporal offset, either plus or minus, from Greenwich Mean Time (GMT) and an abbreviation (such as PST for Pacific Standard Time).    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSTimeZone_Class/index.html#//apple_ref/occ/cl/NSTimeZone"/>    [iOSVersion(2)]    public class NSTimeZone : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding    {        /// <summary>        /// Returns the time zone object identified by a given abbreviation.        /// </summary>        /// <param name="abbreviation">An abbreviation for a time zone.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSTimeZone(string abbreviation) { }                /// <summary>        /// Returns a time zone object offset from Greenwich Mean Time by a given number of seconds.        /// </summary>        /// <param name="forSecondsFromGMT">The number of seconds by which the new time zone is offset from GMT.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSTimeZone(int forSecondsFromGMT) { }                /// <summary>        /// Returns a time zone initialized with a given ID.        /// </summary>        /// <param name="name">The ID for the time zone. Providing nil for this parameter raises an invalid argument exception.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [IgnoreParameter("NAME_YOUR_PARAMS")]        public NSTimeZone(string name, bool NAME_YOUR_PARAMS = false) { }                /// <summary>        /// Initializes a time zone with a given ID and time zone data.        /// </summary>        /// <param name="name">The ID for the time zone. Providing nil for this parameter raises an invalid argument exception.</param>        /// <param name="data">The data from the time-zone files located at /usr/share/zoneinfo.</param>        [iOSVersion(2)]        public NSTimeZone(string name, NSData data) { }                /// <summary>        /// Returns the time zone data version.        /// </summary>        [iOSVersion(4)]        [Export("timeZoneDataVersion")]        public static string TimeZoneDataVersion() { return default(string); }                /// <summary>        /// Returns an object that forwards all messages to the default time zone for the current application.        /// </summary>        [iOSVersion(2)]        [Export("localTimeZone")]        public static NSTimeZone LocalTimeZone() { return default(NSTimeZone); }                /// <summary>        /// Returns the default time zone for the current application.        /// </summary>        [iOSVersion(2)]        [Export("defaultTimeZone")]        public static NSTimeZone DefaultTimeZone() { return default(NSTimeZone); }                /// <summary>        /// Sets the default time zone for the current application to a given time zone.        /// </summary>        /// <param name="aTimeZone">The new default time zone for the current application.</param>        [iOSVersion(2)]        [Export("setDefaultTimeZone")]        public static void SetDefaultTimeZone(NSTimeZone aTimeZone) {  }                /// <summary>        /// Resets the system time zone object cached by the application, if any.        /// </summary>        [iOSVersion(2)]        [Export("resetSystemTimeZone")]        public static void ResetSystemTimeZone() {  }                /// <summary>        /// Returns the time zone currently used by the system.        /// </summary>        [iOSVersion(2)]        [Export("systemTimeZone")]        public static NSTimeZone SystemTimeZone() { return default(NSTimeZone); }                /// <summary>        /// Returns a dictionary holding the mappings of time zone abbreviations to time zone names.        /// </summary>        [iOSVersion(2)]        [Export("abbreviationDictionary")]        public static Dictionary<NSObject, AnyObject> AbbreviationDictionary() { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Returns an array of strings listing the IDs of all the time zones known to the system.        /// </summary>        [iOSVersion(2)]        [Export("knownTimeZoneNames")]        public static AnyObject[] KnownTimeZoneNames() { return default(AnyObject[]); }                /// <summary>        /// Sets the abbreviation dictionary to the specified dictionary.        /// </summary>        /// <param name="dict">A dictionary containing key-value pairs for looking up time zone names given their abbreviations. The keys should be NSString objects containing the abbreviations; the values should be NSString objects containing their corresponding geopolitical region names.</param>        [iOSVersion(4)]        [Export("setAbbreviationDictionary")]        public static void SetAbbreviationDictionary(Dictionary<NSObject, AnyObject> dict) {  }                /// <summary>        /// Returns the abbreviation for the receiver at a given date.        /// </summary>        /// <param name="aDate">The date for which to get the abbreviation for the receiver.</param>        [iOSVersion(2)]        [Export("abbreviationForDate")]        public string AbbreviationForDate(NSDate aDate) { return default(string); }                /// <summary>        /// Returns the difference in seconds between the receiver and Greenwich Mean Time at a given date.        /// </summary>        /// <param name="aDate">The date against which to test the receiver.</param>        [iOSVersion(2)]        [Export("secondsFromGMTForDate")]        public int SecondsFromGMTForDate(NSDate aDate) { return default(int); }                /// <summary>        /// Returns a Boolean value that indicates whether the receiver has the same name and data as the specified time zone.        /// </summary>        /// <param name="aTimeZone">The time zone to compare with the receiver.</param>        [iOSVersion(2)]        [Export("isEqualToTimeZone")]        public bool IsEqualToTimeZone(NSTimeZone aTimeZone) { return default(bool); }                /// <summary>        /// Returns the name of the receiver localized for a given locale.        /// </summary>        /// <param name="style">The format style for the returned string.</param>        /// <param name="locale">The locale for which to format the name.</param>        [iOSVersion(2)]        [Export("localizedName")]        public string LocalizedName(NSTimeZoneNameStyle style, NSLocale locale) { return default(string); }                /// <summary>        /// Returns a Boolean value that indicates whether the receiver uses daylight saving time at a given date.        /// </summary>        /// <param name="aDate">The date against which to test the receiver.</param>        [iOSVersion(2)]        [Export("isDaylightSavingTimeForDate")]        public bool IsDaylightSavingTimeForDate(NSDate aDate) { return default(bool); }                /// <summary>        /// Returns the daylight saving time offset for a given date.        /// </summary>        /// <param name="aDate">A date.</param>        [iOSVersion(2)]        [Export("daylightSavingTimeOffsetForDate")]        public NSTimeInterval DaylightSavingTimeOffsetForDate(NSDate aDate) { return default(NSTimeInterval); }                /// <summary>        /// Returns the next daylight saving time transition after a given date.        /// </summary>        /// <param name="aDate">A date.</param>        [iOSVersion(2)]        [Export("nextDaylightSavingTimeTransitionAfterDate")]        public NSDate NextDaylightSavingTimeTransitionAfterDate(NSDate aDate) { return default(NSDate); }                /// <summary>        /// The abbreviation for the receiver, such as “EDT” (Eastern Daylight Time). (read-only)        /// </summary>        [iOSVersion(2)]        [Export("abbreviation")]        public string Abbreviation { get; private set; }                /// <summary>        /// The geopolitical region ID that identifies the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("name")]        public string Name { get; private set; }                /// <summary>        /// The current difference in seconds between the receiver and Greenwich Mean Time. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("secondsFromGMT")]        public int SecondsFromGMT { get; private set; }                /// <summary>        /// The data that stores the information used by the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("data")]        public NSData Data { get; private set; }                /// <summary>        /// The description of the receiver, including the name, abbreviation, offset from GMT, and whether or not daylight saving time is currently in effect. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("description")]        public string Description { get; private set; }                /// <summary>        /// A Boolean value that indicates whether the receiver is currently using daylight saving time. (read-only)        /// </summary>        [iOSVersion(8)]        [Export("daylightSavingTime")]        public bool DaylightSavingTime { get; private set; }                /// <summary>        /// The current daylight saving time offset of the receiver. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("daylightSavingTimeOffset")]        public NSTimeInterval DaylightSavingTimeOffset { get; private set; }                /// <summary>        /// The date of the next daylight saving time transition for the receiver.        /// </summary>        [iOSVersion(2)]        [Export("nextDaylightSavingTimeTransition")]        public NSDate NextDaylightSavingTimeTransition { get; private set; }    }    /// <summary>    /// Specify styles for presenting time zone names.    /// </summary>    [iOSVersion(2)]    public enum NSTimeZoneNameStyle    {        /// <summary>        /// Specifies a standard name style. For example, “Central Standard Time” for Central Time.        /// </summary>        [iOSVersion(2)]        Standard,        /// <summary>        /// Specifies a short name style. For example, “CST” for Central Time.        /// </summary>        [iOSVersion(2)]        ShortStandard,        /// <summary>        /// Specifies a daylight saving name style. For example, “Central Daylight Time” for Central Time.        /// </summary>        [iOSVersion(2)]        DaylightSaving,        /// <summary>        /// Specifies a short daylight saving name style.  For example, “CDT” for Central Time.        /// </summary>        [iOSVersion(2)]        ShortDaylightSaving,        /// <summary>        /// Specifies a generic name style. For example, “Central Time” for Central Time.        /// </summary>        [iOSVersion(4)]        Generic,        /// <summary>        /// Specifies a generic time zone name. For example, “CT” for Central Time.        /// </summary>        [iOSVersion(4)]        ShortGeneric,    }    /// <summary>    ///     /// </summary>    [iOSVersion(2)]    public class NSSystemTimeZoneDidChangeNotification : NSNotification    {        public NSSystemTimeZoneDidChangeNotification() : base("", null) { }    }}