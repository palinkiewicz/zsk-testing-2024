using System.Text.RegularExpressions;

namespace Kartkowka
{
    internal static class Palindrome
    {
        private static bool IsPalindrome(string palindromeCandidate)
        {
            var normalized = Regex.Replace(palindromeCandidate.Trim().ToLower(), @"\s+", string.Empty);

            return normalized.Equals(normalized.Reverse());
        }
    }
}
