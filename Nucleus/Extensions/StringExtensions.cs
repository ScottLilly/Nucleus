using System;

namespace Nucleus.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotNullEmptyOrWhiteSpace(this string text)
        {
            if(text == null)
            {
                return false;
            }

            return !string.IsNullOrWhiteSpace(text);
        }

        public static string StartingCharacters(this string text, int length)
        {
            return text?.Substring(0, Math.Min(text.Length, length));
        }
    }
}