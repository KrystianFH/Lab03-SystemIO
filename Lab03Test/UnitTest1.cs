using System;
using Xunit;
using SystemIO;

namespace SystemIOTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(24, new int[] { 2, 3, 4 })]
        [InlineData(0, new int[] { 2, 3 })]
        [InlineData(-24, new int[] { -2, 3, 4, 5 })]
        public void MultiplyTest(int expected, int[] testArray)
        {
            int results = Program.Multiply(testArray);
            Assert.Equal(expected, results);
        }

        [Theory]
        [InlineData("10", true)]
        [InlineData("10.5", true)]
        [InlineData("NaN", false)]
        [InlineData("-10", false)]

        public void NumberValidationTest(string testInput, bool expected)
        {
            //  bool results = Program.ValidateChallenge2(testInput);
            //  Assert.Equal(expected, results);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]

        public void Challenge2AverageTest(int[] testArray, int expected)
        {
            // int results = Program.FindAverageChallenge2(testArray);
            //  Assert.Equal(expected, results);


        }

        // Challenge 5 - Krystian and Matthew
        [Theory]
        [InlineData(new int[] { 1, 2, 1, 4 }, 4)]
        [InlineData(new int[] { -1, 2, 2, 1, 4 }, 4)]
        [InlineData(new int[] { 2, 2, 2, 2 }, 2)]

        public void Challenge5Test(int[] testArray, int expected)
        {
            int results = Program.FindMax(testArray);
            Assert.Equal(expected, results);
        }

        // Challenge 6 - Krystian and Alan

    }
}

