using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIDatePicker_Class/index.html#//apple_ref/occ/cl/UIDatePicker    /// <summary>    /// The UIDatePicker class implements an object that uses multiple rotating wheels to allow users to select dates and times. iPhone examples of a date picker are the Timer and Alarm (Set Alarm) panes of the Clock application. You may also use a date picker as a countdown timer.    /// </summary>    [iOSVersion(2)]    public class UIDatePicker : UIControl    {        /// <summary>        /// The calendar to use for the date picker.        /// </summary>        [iOSVersion(2)]        [Export("calendar")]        public NSCalendar Calendar { get; set; }                /// <summary>        /// The date displayed by the date picker.        /// </summary>        [iOSVersion(2)]        [Export("date")]        public NSDate Date { get; set; }                /// <summary>        /// The locale used by the date picker.        /// </summary>        [iOSVersion(2)]        [Export("locale")]        public NSLocale Locale { get; set; }                /// <summary>        /// Sets the date to display in the date picker, with an option to animate the setting.        /// </summary>        /// <param name="date">An NSDate object representing the new date to display in the date picker.</param>        /// <param name="animated">true to animate the setting of the new date, otherwise false. The animation rotates the wheels until the new date and time is shown under the highlight rectangle.</param>        [iOSVersion(2)]        [Export("setDate")]        public void SetDate(NSDate date, bool animated) { }                /// <summary>        /// The time zone reflected in the date displayed by the date picker.        /// </summary>        [iOSVersion(2)]        [Export("timeZone")]        public NSTimeZone TimeZone { get; set; }                /// <summary>        /// The mode of the date picker.        /// </summary>        [iOSVersion(2)]        [Export("datePickerMode")]        public UIDatePickerMode DatePickerMode { get; set; }                /// <summary>        /// The maximum date that a date picker can show.        /// </summary>        [iOSVersion(2)]        [Export("maximumDate")]        public NSDate MaximumDate { get; set; }                /// <summary>        /// The minimum date that a date picker can show.        /// </summary>        [iOSVersion(2)]        [Export("minimumDate")]        public NSDate MinimumDate { get; set; }                /// <summary>        /// The interval at which the date picker should display minutes.        /// </summary>        [iOSVersion(2)]        [Export("minuteinterval")]        public int Minuteinterval { get; set; }                /// <summary>        /// The seconds from which the countdown timer counts down.        /// </summary>        [iOSVersion(2)]        [Export("countDownDuration")]        public NSTimeinterval CountDownDuration { get; set; }    }

    /// <summary>
    /// The mode of the date picker.
    /// </summary>
    public enum UIDatePickerMode
    {
        /// <summary>
        /// The date picker displays hours, minutes, and (optionally) an AM/PM designation. The exact items shown and their order depend upon the locale set. An example of this mode is [ 6 | 53 | PM ].
        /// </summary>
        [iOSVersion(2)]
        Time,

        /// <summary>
        /// The date picker displays months, days of the month, and years. The exact order of these items depends on the locale setting. An example of this mode is [ November | 15 | 2007 ].
        /// </summary>
        [iOSVersion(2)]
        Date,

        /// <summary>
        /// The date picker displays dates (as unified day of the week, month, and day of the month values) plus hours, minutes, and (optionally) an AM/PM designation. The exact order and format of these items depends on the locale set. An example of this mode is [ Wed Nov 15 | 6 | 53 | PM ].
        /// </summary>
        [iOSVersion(2)]
        DateAndTime,

        /// <summary>
        /// The date picker displays hour and minute values, for example [ 1 | 53 ]. The application must set a timer to fire at the proper interval and set the date picker as the seconds tick down.
        /// </summary>
        [iOSVersion(2)]
        CountDownTimer,
    }}