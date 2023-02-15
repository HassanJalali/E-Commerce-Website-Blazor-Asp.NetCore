using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Front.Extensions
{
    public static class Extensions
    {
        public static string DayName;
        public static string ToPersianDate(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            return pc.GetYear(dateTime).ToString() + "/" +
                pc.GetMonth(dateTime).ToString("00") + "/" +
                pc.GetDayOfMonth(dateTime).ToString("00");
        }
        public static string ToPersianFullDateInfo(this DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Friday)
                DayName = "جمعه";
            if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                DayName = "شنبه";
            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                DayName = "یکشنبه";
            if (dateTime.DayOfWeek == DayOfWeek.Monday)
                DayName = "دوشنبه";
            if (dateTime.DayOfWeek == DayOfWeek.Tuesday)
                DayName = "سه شنبه";
            if (dateTime.DayOfWeek == DayOfWeek.Wednesday)
                DayName = "چهار شنبه";
            if (dateTime.DayOfWeek == DayOfWeek.Thursday)
                DayName = "پنج شنبه";

            var pc = new PersianCalendar();
            return DayName + " " +
                pc.GetYear(dateTime).ToString() + "/" +
                pc.GetMonth(dateTime).ToString("00") + "/" +
                pc.GetDayOfMonth(dateTime).ToString("00");
        }

        public static DateTime? ToDateTime(this string persianDate)
        {
            var pc = new PersianCalendar();
            if (string.IsNullOrEmpty(persianDate))
                return null;
            try
            {
                var year = Convert.ToInt32(persianDate.Substring(0, 4));
                var month = Convert.ToInt32(persianDate.Substring(5, 2));
                var day = Convert.ToInt32(persianDate.Substring(8, 2));

                return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
