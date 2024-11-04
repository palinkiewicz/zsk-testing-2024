using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Library.Tests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("ujuju")]
        public void Palindrome_ChecksActualPalindrome_ReturnsTrue(string a)
        {
            // Act
            bool result = Palindrome.IsPalindrome(a);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("juwadu")]
        public void Palindrome_ChecksWrongPalindrome_ReturnsFalse(string a)
        {
            // Act
            bool result = Palindrome.IsPalindrome(a);

            // Assert
            Assert.False(result);
        }
    }
}
