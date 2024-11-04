using System.Text.RegularExpressions;

namespace Kartkowka
{
    internal class Anagram
    {
        private static bool IsAnagram(string anagramFirst, string anagramSecond)
        {
            var normalizedFirst = Regex.Replace(anagramFirst.Trim().ToLower(), @"\s+", string.Empty);
            var normalizedSecond = Regex.Replace(anagramSecond.Trim().ToLower(), @"\s+", string.Empty);

            var sortedFirst = String.Concat(normalizedSecond.OrderBy(c => c));
            var sortedSecond = String.Concat(normalizedSecond.OrderBy(c => c));

            return normalizedFirst.Equals(normalizedSecond.Reverse());
        }
    }
}
