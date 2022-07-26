using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("hello", false)]

        // For example [InlineData(“racecar”, true)]
        public void Test1(string str, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
