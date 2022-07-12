namespace BIMFarersApp
{
    public static class Extensions
    {
        public static DateTime RoundDownToNearest30(this DateTime datetime)
        {
            double minutes = datetime.TimeOfDay.TotalMinutes % 30;
            return datetime.AddMinutes(-minutes);
        }

        public static DateTime RoundUpToNearest30(this DateTime datetime)
        {
            double atMinuteInBlock = datetime.TimeOfDay.TotalMinutes % 30;
            double minutesToAdd = 30 - atMinuteInBlock;
            return datetime.AddMinutes(minutesToAdd);
        }

        public static DateTime FirstDayOfWeek(this DateTime datetime)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var diff = datetime.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return datetime.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime datetime)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var diff = datetime.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            DateTime start = datetime.AddDays(-diff).Date;
            return start.AddDays(6).Date;
        }
    }
}
