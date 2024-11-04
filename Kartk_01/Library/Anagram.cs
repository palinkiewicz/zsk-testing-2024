using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Library
{
    public class Anagram
    {
        public static bool IsAnagram(string anagramFirst, string anagramSecond)
        {
            var normalizedFirst = Regex.Replace(anagramFirst.Trim().ToLower(), @"\s+", string.Empty);
            var normalizedSecond = Regex.Replace(anagramSecond.Trim().ToLower(), @"\s+", string.Empty);

            var sortedFirst = String.Concat(normalizedFirst.OrderBy(c => c));
            var sortedSecond = String.Concat(normalizedSecond.OrderBy(c => c));

            return sortedFirst.Equals(sortedSecond);
        }
    }
}
