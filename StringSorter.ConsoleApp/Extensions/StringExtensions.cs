using System.Text.RegularExpressions;

namespace StringSorter.ConsoleApp.Extensions
{
    public static class StringExtensions
    {
        public static char[] SortString(this string input)
        {
            char temp;
            char[] chars = input.ToCharArray();
            for (int i = 1; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }

            return chars;
        }

        public static string CleanInputString(this string input)
        {
            return Regex.Replace(input, @"[^\w]", "").ToLower();
        }
    }
}
