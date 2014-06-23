using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDateComponents_Class/index.html#//apple_ref/occ/cl/NSDateComponents	/// <summary>	/// NSDateComponents encapsulates the components of a date in an extendable, object-oriented manner. It is used to specify a date by providing the temporal components that make up a date and time: hour, minutes, seconds, day, month, year, and so on. It can also be used to specify a duration of time, for example, 5 hours and 16 minutes. An NSDateComponents object is not required to define all the component fields. When a new instance of NSDateComponents is created the date components are set to NSUndefinedDateComponent.	/// </summary>	[iOSVersion(2)]	public class NSDateComponents : NSObject	{		/// <summary>		/// Returns or sets the number of era units for the receiver.		/// </summary>
        /// <returns>The number of era units for the receiver.</returns>
        /// <param name="v">The number of era units for the receiver.</param>		[iOSVersion(2)]		[Export("era")]		public int Era { get; set; }				/// <summary>		/// Returns or sets the number of year units for the receiver.		/// </summary>
        /// <returns>The number of year units for the receiver.</returns>
        /// <param name="v">The number of year units for the receiver.</param>		[iOSVersion(2)]		[Export("year")]		public int Year { get; set; }				/// <summary>		/// Returns or sets the number of month units for the receiver.		/// </summary>
        /// <returns>The number of month units for the receiver.</returns>
        /// <param name="v">The number of month units for the receiver.</param>		[iOSVersion(2)]		[Export("month")]		public int Month { get; set; }				/// <summary>		/// Returns the date of the receiver.		/// </summary>		/// <returns>The date.</returns>		[iOSVersion(4)]		[Export("date")]		public NSDate Date { get; private set; }				/// <summary>		/// Returns or sets the number of day units for the receiver.		/// </summary>
        /// <returns>The number of day units for the receiver.</returns>
        /// <param name="v">The number of day units for the receiver.</param>		[iOSVersion(2)]		[Export("day")]		public int Day { get; set; }				/// <summary>		/// Returns or sets the number of hour units for the receiver.		/// </summary>
        /// <returns>The number of hour units for the receiver.</returns>
        /// <param name="v">The number of hour units for the receiver.</param>		[iOSVersion(2)]		[Export("hour")]		public int Hour { get; set; }				/// <summary>		/// Returns or sets the number of minute units for the receiver.		/// </summary>
        /// <returns>The number of minute units for the receiver.</returns>
        /// <param name="v">The number of minute units for the receiver.</param>		[iOSVersion(2)]		[Export("minute")]		public int Minute { get; set; }				/// <summary>		/// Returns or sets the number of second units for the receiver.
        /// </summary>
        /// <param name="v">The number of second units for the receiver.</param>
        /// <returns>The number of second units for the receiver.</returns>		[iOSVersion(2)]		[Export("second")]		public int Second { get; set; }				/// <summary>		/// Returns or sets the number of week units for the receiver.
        /// </summary>
        /// <param name="v">The number of weekday units for the receiver.</param>		/// <returns>The number of week units for the receiver.</returns>		[iOSVersion(2)]		[Export("week")]		public int Week() { return 0; }				/// <summary>		/// Returns or sets the number of weekday units for the receiver.
        /// </summary>
        /// <param name="v">The number of weekday units for the receiver.</param>		/// <returns>The number of weekday units for the receiver.</returns>		[iOSVersion(2)]		[Export("weekday")]		public int Weekday { get; set; }				/// <summary>		/// Returns the ordinal number of weekday units for the receiver.
        /// </summary>
        /// <param name="v">The ordinal number of weekday units for the receiver.</param>		/// <returns>The ordinal number of weekday units for the receiver.</returns>		[iOSVersion(2)]		[Export("weekdayOrdinal")]		public int WeekdayOrdinal { get; set; }				/// <summary>		/// Returns or sets the number of quarters in the calendar.
        /// </summary>
        /// <param name="v">The number of quarters units for the receiver.</param>		/// <returns>The number of quarters units for the receiver.</returns>		[iOSVersion(4)]		[Export("quarter")]		public int Quarter { get; set; }				/// <summary>		/// Returns or sets the calendar of the receiver.
        /// </summary>
        /// <param name="cal">The calendar.</param>		/// <returns>The calendar.</returns>		[iOSVersion(4)]		[Export("calendar")]		public NSCalendar Calendar { get; set; }				/// <summary>		/// Returns or sets the receiver’s time zone.
        /// </summary>
        /// <param name="tz">The time zone.</param>		/// <returns>The time zone.</returns>		[iOSVersion(4)]		[Export("timeZone")]		public NSTimeZone TimeZone { get; set; }				/// <summary>		/// Returns or sets the week of the month.
        /// </summary>
        /// <param name="week">The week number of the month.</param>		/// <returns>The week number of the month.</returns>		[iOSVersion(5)]		[Export("weekOfMonth")]		public int WeekOfMonth { get; set; }				/// <summary>
        /// Returns or sets the week of the year.
        /// </summary>
        /// <param name="week">The week number of the year.</param>		/// <returns>The week number of the year.</returns>		[iOSVersion(5)]		[Export("weekOfYear")]		public int WeekOfYear { get; set; }				/// <summary>
        /// Returns or sets the year for the week of the year.
        /// </summary>
        /// <param name="year">The year when the calendar is being interpreted as a week-based calendar.</param>		/// <returns>The year number for the week of the year.</returns>		[iOSVersion(5)]		[Export("yearForWeekOfYear")]		public int YearForWeekOfYear { get; set; }				/// <summary>		/// Sets the number of week units for the receiver.		/// </summary>		/// <param name="v">The number of week units for the receiver.</param>		[iOSVersion(2)]		[Export("setWeek")]		public void SetWeek(int v) { }				/// <summary>		/// Sets the month as a leap month.		/// </summary>		/// <param name="lm">true if the month is a leap month, false otherwise.</param>		[iOSVersion(6)]		[Export("leapMonth")]		public bool LeapMonth { get; set; }				/// <summary>		/// This constant specifies that an NSDateComponents component is undefined.		/// </summary>		[Export("NSUndefinedDateComponent")]		public int NSUndefinedDateComponent { get; private set; }	}}