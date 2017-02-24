using System;
using Xunit;

namespace CSharpDrill.Advanced
{
    public class IsPowerOfTwoEvaluatorTests
    {
        // Task: Implement IsPowerOfTwoEvaluator.Evaluate() 
        // without usage of division and multiplication operations.

        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(8, true)]
        [InlineData(16, true)]
        [InlineData(32, true)]
        [InlineData(64, true)]
        [InlineData(128, true)]
        [InlineData(256, true)]
        public void Evaluate_ForGivenNumber_ShouldReturnExpected(int number, bool expected)
        {
            var result = IsPowerOfTwoEvaluator.Evaluate(number);
            Assert.Equal(expected, result);
        }
    }

    public class IsPowerOfTwoEvaluator
    {
        public static bool Evaluate(int number)
        {
            throw new NotImplementedException();
        }
    }
}