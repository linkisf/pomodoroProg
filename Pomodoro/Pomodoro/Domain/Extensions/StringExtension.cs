namespace System
{
    public static class StringExtension
    {
        public static string FormatTimeTwoDigits(this string value)
        {
            if (int.Parse(value) < 10)
                return "0" + value;

            return value;
        }
    }
}
