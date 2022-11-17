using System;
using TestDemos.App;
using Xunit;

namespace TestDemos.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void SumShouldReturnCorrectResultWithTwoNumbers()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Sum(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithManyNumbers()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Sum(1, 2, 3, 4, 5, 6);

            Assert.Equal(21, result);
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithNoNumbers()
        {
            Calculator calculator = new Calculator();

            int result = calculator.Sum();

            Assert.Equal(0, result);
        }
    }
}
