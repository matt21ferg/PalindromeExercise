using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak",true)]
        [InlineData("tenet", true)]
        [InlineData("Racecar", true)]
        [InlineData("Kayak", true)]
        [InlineData("poop",true)]
        [InlineData("Poop", true)]
        [InlineData("hello",false)]
        [InlineData("matt",false)]
        [InlineData("pizza",false)]
        public void PalindromeTest(string word ,bool expected)
        {
            var wordsmith = new WordSmith();
            var actual = wordsmith.IsAPalindrome(word);
               Assert.Equal(expected, actual);
        }
    }
}
