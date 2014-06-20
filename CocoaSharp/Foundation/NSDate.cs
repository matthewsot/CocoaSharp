using ObjectiveC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    public class NSDate : NSObject
    {
        /// <summary>
        /// Returns an NSDate object initialized to the current date and time.
        /// </summary>
        /// <returns>An NSDate object initialized to the current date and time.</returns>
        public NSDate() { }

        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using
        /// Returns an NSDate object initialized relative to the given time
        /// </summary>
        /// <param name="timeIntervalSinceNow">The number of seconds from relative to the current date and time to which the receiver should be initialized. A negative value means the returned object will represent a date in the past.</param>
        /// <param name="timeIntervalSinceReferenceDate">The number of seconds to add to the reference date (the first instant of 1 January 2001, GMT). A negative value means the receiver will be earlier than the reference date.</param>
        /// <param name="timeIntervalSince1970">The number of seconds from the reference date, 1 January 1970, GMT, for the new date. Use a negative argument to specify a date before this date.</param>
        public NSDate(NSTimeInterval timeIntervalSinceNow = null, NSTimeInterval timeIntervalSinceReferenceDate = null, NSTimeInterval timeIntervalSince1970 = null) { }

        /// <summary>
        /// Returns an NSDate object initialized relative to another given date by a given number of seconds.
        /// </summary>
        /// <param name="timeInterval">The number of seconds to add to refDate. A negative value means the receiver will be earlier than refDate.</param>
        /// <param name="refDate">The reference date.</param>
        /// <returns>An NSDate object initialized relative to refDate by timeInterval seconds.</returns>
        public NSDate(NSTimeInterval timeInterval, NSDate sinceDate) { }

        /// <summary>
        /// Creates and returns an NSDate object representing a date in the distant future.
        /// </summary>
        /// <returns>An NSDate object representing a date in the distant future (in terms of centuries).</returns>
        [Export("distantFuture")]
        public static AnyObject DistantFuture() { return null; }

        /// <summary>
        /// Creates and returns an NSDate object representing a date in the distant past.
        /// </summary>
        /// <returns>An NSDate object representing a date in the distant past (in terms of centuries).</returns>
        [Export("distantPast")]
        public static AnyObject DistantPast() { return null; }

        /// <summary>
        /// Returns a Boolean value that indicates whether a given object is an NSDate object and exactly equal the receiver.
        /// </summary>
        /// <param name="anotherDate">The date to compare with the receiver.</param>
        /// <returns>true if the anotherDate is an NSDate object and is exactly equal to the receiver, otherwise false.</returns>
        [Export("isEqualToDate")]
        public bool IsEqualToDate(NSDate anotherDate) { return false; }

        /// <summary>
        /// Returns the earlier of the receiver and another given date.
        /// </summary>
        /// <param name="anotherDate">The date with which to compare the receiver.</param>
        /// <returns>The earlier of the receiver and anotherDate, determined using timeIntervalSinceDate:. If the receiver and anotherDate represent the same date, returns the receiver.</returns>
        [Export("earlierDate")]
        public NSDate EarlierDate(NSDate anotherDate) { return null; }

        /// <summary>
        /// Returns the later of the receiver and another given date.
        /// </summary>
        /// <param name="anotherDate">The date with which to compare the receiver.</param>
        /// <returns>The later of the receiver and anotherDate, determined using timeIntervalSinceDate:. If the receiver and anotherDate represent the same date, returns the receiver.</returns>
        [Export("laterDate")]
        public NSDate LaterDate(NSDate anotherDate) { return null; }

        /// <summary>
        /// Returns an NSComparisonResult value that indicates the temporal ordering of the receiver and another given date.
        /// </summary>
        /// <param name="anotherDate">The date with which to compare the receiver.   This value must not be nil. If the value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>If:</returns>
        [Export("compare")]
        public NSComparisonResult Compare(NSDate anotherDate) { return null; }

        /// <summary>
        /// Returns the interval between the receiver and another given date.
        /// </summary>
        /// <param name="anotherDate">The date with which to compare the receiver.</param>
        /// <returns>The interval between the receiver and anotherDate. If the receiver is earlier than anotherDate, the return value is negative.</returns>
        [Export("timeIntervalSinceDate")]
        public NSTimeInterval TimeIntervalSinceDate(NSDate anotherDate) { return null; }

        /// <summary>
        /// Returns the interval between the receiver and the current date and time.
        /// </summary>
        /// <returns>The interval between the receiver and the current date and time. If the receiver is earlier than the current date and time, the return value is negative.</returns>
        [Export("timeIntervalSinceNow")]
        public static NSTimeInterval TimeIntervalSinceNow { get; private set; }

        /// <summary>
        /// Returns the interval between the first instant of 1 January 2001, GMT and the current date and time.
        /// </summary>
        /// <returns>The interval between the system’s absolute reference date (the first instant of 1 January 2001, GMT) and the current date and time.</returns>
        [Export("timeIntervalSinceReferenceDate")]
        public static NSTimeInterval TimeIntervalSinceReferenceDateAndNow() { return null; }

        /// <summary>
        /// Returns the interval between the receiver and the first instant of 1 January 2001, GMT.
        /// </summary>
        /// <returns>The interval between the receiver and the system’s absolute reference date (the first instant of 1 January 2001, GMT). If the receiver is earlier than the reference date, the value is negative.</returns>
        [Export("timeIntervalSinceReferenceDate")]
        public NSTimeInterval TimeIntervalSinceReferenceDate { get; private set; }

        /// <summary>
        /// Returns the interval between the receiver and the first instant of 1 January 1970, GMT.
        /// </summary>
        /// <returns>The interval between the receiver and the reference date, 1 January 1970, GMT. If the receiver is earlier than the reference date, the value is negative.</returns>
        [Export("timeIntervalSince1970")]
        public static NSTimeInterval TimeIntervalSince1970 { get; private set; }

        /// <summary>
        /// Returns a new NSDate object that is set to a given number of seconds relative to the receiver.
        /// </summary>
        /// <param name="seconds">The number of seconds to add to the receiver. Use a negative value for seconds to have the returned object specify a date before the receiver.</param>
        /// <returns>A new NSDate object that is set to seconds seconds relative to the receiver. The date returned might have a representation different from the receiver’s.</returns>
        [Export("dateByAddingTimeInterval")]
        public NSDate DateByAddingTimeInterval(NSTimeInterval seconds) { return null; }

        /// <summary>
        /// Returns a new NSDate object that is set to a given number of seconds relative to the receiver.
        /// Deprecation Statement: This method has been replaced by dateByAddingTimeInterval:.
        /// </summary>
        /// <param name="seconds">The number of seconds to add to the receiver. Use a negative value for seconds to have the returned object specify a date before the receiver.</param>
        /// <returns>A new NSDate object that is set to seconds seconds relative to the receiver. The date returned might have a representation different from the receiver’s.</returns>
        [Obsolete]
        [Export("addTimeInterval")]
        public AnyObject AddTimeInterval(NSTimeInterval seconds) { return null; }

        /// <summary>
        /// Returns a string representation of the receiver.
        /// </summary>
        /// <returns>A string representation of the receiver.</returns>
        [Export("description")]
        public static string Description { get; private set; }

        /// <summary>
        /// Returns a string representation of the receiver using the given locale.
        /// </summary>
        /// <param name="locale">An NSLocale object.   If you pass nil, NSDate formats the date in the same way as the description method.   On OS X v10.4 and earlier, this parameter was an NSDictionary object. If you pass in an NSDictionary object on OS X v10.5, NSDate uses the default user locale—the same as if you passed in [NSLocale currentLocale].</param>
        /// <returns>A string representation of the receiver, using the given locale, or if the locale argument is nil, in the international format YYYY-MM-DD HH:MM:SS ±HHMM, where ±HHMM represents the time zone offset in hours and minutes from GMT (for example, “2001-03-24 10:45:32 +0600”)</returns>
        [Export("descriptionWithLocale")]
        public string DescriptionWithLocale(AnyObject locale) { return ""; }

        /// <summary>
        /// NSDate provides a constant that specifies the number of seconds from 1 January 1970 to the reference date, 1 January 2001.
        /// </summary>
        [Export("NSTimeIntervalSince1970")]
        public static CDouble NSTimeIntervalSince1970 { get; private set; }

        //TODO: Add NSSystemClockDidChangeNotification
    }
}
