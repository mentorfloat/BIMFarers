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
    }
}
