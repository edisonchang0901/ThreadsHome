namespace ThreadsHome.Domain.Common
{
    public static class TimeUtil
    {
        public static DateTime TaipeiStandardTimeNow()
        {
            TimeZoneInfo taipeiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, taipeiTimeZone);
        }
    }
}
