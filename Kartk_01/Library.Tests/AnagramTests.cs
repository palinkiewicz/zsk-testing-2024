using Library;

namespace Library.Tests
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("evil", "vile")]
        [InlineData("restful", "fluster")]
        [InlineData("tom marvolo riddle", "i am lord voldemort")]
        [InlineData("", "")]
        public void Anagram_ChecksActualAnagram_ReturnsTrue(string a, string b)
        {
            // Act
            bool result = Anagram.IsAnagram(a, b);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("evil", "vileeee")]
        [InlineData("restful", "restless")]
        [InlineData("tom marvolo riddle", "i am not lord voldemort")]
        [InlineData("a", "")]
        public void Anagram_ChecksWrongAnagram_ReturnsFalse(string a, string b)
        {
            // Act
            bool result = Anagram.IsAnagram(a, b);

            // Assert
            Assert.False(result);
        }
    }
}