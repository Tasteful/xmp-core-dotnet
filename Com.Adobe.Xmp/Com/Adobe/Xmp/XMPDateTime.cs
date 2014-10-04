// =================================================================================================
// ADOBE SYSTEMS INCORPORATED
// Copyright 2006 Adobe Systems Incorporated
// All Rights Reserved
//
// NOTICE:  Adobe permits you to use, modify, and distribute this file in accordance with the terms
// of the Adobe license agreement accompanying it.
// =================================================================================================
using System;
using Com.Adobe.Xmp;
using Sharpen;

namespace Com.Adobe.Xmp
{
	/// <summary>
	/// The <code>XMPDateTime</code>-class represents a point in time up to a resolution of nano
	/// seconds.
	/// </summary>
	/// <remarks>
	/// The <code>XMPDateTime</code>-class represents a point in time up to a resolution of nano
	/// seconds. Dates and time in the serialized XMP are ISO 8601 strings. There are utility functions
	/// to convert to the ISO format, a <code>Calendar</code> or get the Timezone. The fields of
	/// <code>XMPDateTime</code> are:
	/// <ul>
	/// <li> month - The month in the range 1..12.
	/// <li> day - The day of the month in the range 1..31.
	/// <li> minute - The minute in the range 0..59.
	/// <li> hour - The time zone hour in the range 0..23.
	/// <li> minute - The time zone minute in the range 0..59.
	/// <li> nanoSecond - The nano seconds within a second. <em>Note:</em> if the XMPDateTime is
	/// converted into a calendar, the resolution is reduced to milli seconds.
	/// <li> timeZone - a <code>TimeZone</code>-object.
	/// </ul>
	/// DateTime values are occasionally used in cases with only a date or only a time component. A date
	/// without a time has zeros for all the time fields. A time without a date has zeros for all date
	/// fields (year, month, and day).
	/// </remarks>
	public interface XMPDateTime : IComparable
	{
		/// <returns>Returns the year, can be negative.</returns>
		int GetYear();

		/// <param name="year">Sets the year</param>
		void SetYear(int year);

		/// <returns>Returns The month in the range 1..12.</returns>
		int GetMonth();

		/// <param name="month">Sets the month 1..12</param>
		void SetMonth(int month);

		/// <returns>Returns the day of the month in the range 1..31.</returns>
		int GetDay();

		/// <param name="day">Sets the day 1..31</param>
		void SetDay(int day);

		/// <returns>Returns hour - The hour in the range 0..23.</returns>
		int GetHour();

		/// <param name="hour">Sets the hour in the range 0..23.</param>
		void SetHour(int hour);

		/// <returns>Returns the minute in the range 0..59.</returns>
		int GetMinute();

		/// <param name="minute">Sets the minute in the range 0..59.</param>
		void SetMinute(int minute);

		/// <returns>Returns the second in the range 0..59.</returns>
		int GetSecond();

		/// <param name="second">Sets the second in the range 0..59.</param>
		void SetSecond(int second);

		/// <returns>
		/// Returns milli-, micro- and nano seconds.
		/// Nanoseconds within a second, often left as zero?
		/// </returns>
		int GetNanoSecond();

		/// <param name="nanoSecond">
		/// Sets the milli-, micro- and nano seconds.
		/// Granularity goes down to milli seconds.
		/// </param>
		void SetNanoSecond(int nanoSecond);

		/// <returns>Returns the time zone.</returns>
		TimeZoneInfo GetTimeZone();

		/// <param name="tz">a time zone to set</param>
		void SetTimeZone(TimeZoneInfo tz);

		/// <summary>This flag is set either by parsing or by setting year, month or day.</summary>
		/// <returns>Returns true if the XMPDateTime object has a date portion.</returns>
		bool HasDate();

		/// <summary>This flag is set either by parsing or by setting hours, minutes, seconds or milliseconds.</summary>
		/// <returns>Returns true if the XMPDateTime object has a time portion.</returns>
		bool HasTime();

		/// <summary>This flag is set either by parsing or by setting hours, minutes, seconds or milliseconds.</summary>
		/// <returns>Returns true if the XMPDateTime object has a defined timezone.</returns>
		bool HasTimeZone();

		/// <returns>
		/// Returns a <code>Calendar</code> (only with milli second precision). <br />
		/// <em>Note:</em> the dates before Oct 15th 1585 (which normally fall into validity of
		/// the Julian calendar) are also rendered internally as Gregorian dates.
		/// </returns>
		Sharpen.Calendar GetCalendar();

		/// <returns>Returns the ISO 8601 string representation of the date and time.</returns>
		string GetISO8601String();
	}
}
