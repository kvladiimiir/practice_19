using System;
using Xunit;

namespace learning.Tests
{
    public class StubCalculator : INumberProvider
    {
        public int A { get; }
        public int B { get; }

        public StubCalculator (int a, int b)
        {
            A = a;
            B = b;
        }
    }
    public class CalculatorTests
    {
        [Theory]
        [InlineData(7, 5, 12)]
        [InlineData(100049, 6, 100055)]
        [InlineData(0, 0, 0)]
        public void SumPositiveAndPositiveExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Sum();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, -5, 2)]
        [InlineData(100049, -6, 100043)]
        [InlineData(-1, 1, 0)]
        public void SumPositiveAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Sum();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 5, -2)]
        [InlineData(-100049, 6, -100043)]
        [InlineData(-1, 1, 0)]
        public void SumPositiveAndNegativeExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Sum();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, -5, -12)]
        [InlineData(-100049, -6, -100055)]
        [InlineData(-1, -1, -2)]
        public void SumNegativeAndNegativeExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Sum();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, 5, 35)]
        [InlineData(100049, 6, 600294)]
        public void ProductPositiveAndPositiveExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Product();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, -5, -35)]
        [InlineData(100049, -6, -600294)]
        [InlineData(-1, 1, -1)]
        public void ProductPositiveAndNegativeExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Product();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, -5, 35)]
        [InlineData(-100049, -6, 600294)]
        [InlineData(-1, -1, 1)]
        public void ProductNegativeAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Product();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 0, 0)]
        [InlineData(100049, 0, 0)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 0, 0)]
        public void ProductOnZeroExpectedZero(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Product();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, 5, 2)]
        [InlineData(100049, 6, 100043)]
        [InlineData(0, 0, 0)]
        public void SubtractPositiveAndPositiveExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, -5, 12)]
        [InlineData(100049, -6, 100055)]
        [InlineData(1, -1, 2)]
        public void SubtractPositiveAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 12, -19)]
        [InlineData(-100049, 100055, -200104)]
        [InlineData(-1, 2, -3)]
        public void SubtractNegativeAndPositiveExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, -12, 5)]
        [InlineData(-100049, -100055, 6)]
        [InlineData(-1, -2, 1)]
        public void SubtractNegativeAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 0, -7)]
        [InlineData(100049, 0, 100049)]
        [InlineData(-2, 0, -2)]
        public void SubtractNegativeAndZeroExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, -7, 7)]
        [InlineData(0, -100049, 100049)]
        public void SubtractZeroAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 7, -7)]
        [InlineData(0, 100049, -100049)]
        public void SubtractZeroAndPositiveExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Subtract();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, 2, 3)]
        [InlineData(100050, 100049, 1)]
        [InlineData(1, 1, 1)]
        public void DivisionPositiveAndPositiveExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Division();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(7, -2, -3)]
        [InlineData(100050, -100049, -1)]
        [InlineData(1, -1, -1)]
        public void DivisionPositiveAndNegativeExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Division();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, 2, -3)]
        [InlineData(-100050, 100049, -1)]
        [InlineData(-1, 1, -1)]
        public void DivisionNegativeAndPositiveExpectedNegative(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Division();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-7, -2, 3)]
        [InlineData(-100050, -100049, 1)]
        [InlineData(-1, -1, 1)]
        public void DivisionNegativeAndNegativeExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Division();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, -2, 0)]
        [InlineData(0, 100049, 0)]
        [InlineData(0, -1, 0)]
        public void DivisionZeroAndNumberExpectedZero(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Division();
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(100049, 0)]
        [InlineData(1, 0)]
        public void DivisionNumberAndZeroExpectedThrow(int value1, int value2)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act & assert
            Assert.Throws<Exception>(() => calculator.Division());
        }
    }
}
