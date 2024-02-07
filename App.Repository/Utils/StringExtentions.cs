namespace App.Repository.Utils
{
    public static class StringExtentions
    {
        public static string PhoneNumberMask(this string s)
        {
            if (string.IsNullOrWhiteSpace(s) && s.Length != 12) return "";
            return $"{s.Substring(0, 5)}•••{s.Substring(7, 4)}";
        }
    }
}
