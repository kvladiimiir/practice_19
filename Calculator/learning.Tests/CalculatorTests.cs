using System;
using Xunit;

namespace learning.Tests
{
    public class StubCalculator : INumberProvider
    {
        public int A { get; }
        public int B { get; }

        public StubCalculator(int a, int b)
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
        public void PositiveAndPositive_Sum_ExpectedPositive(int value1, int value2, int expected)
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
        public void PositiveAndNegative_Sum_ExpectedPositive(int value1, int value2, int expected)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act
            var result = calculator.Sum();
            //assert
            Assert.True(expected == result, "Test_Sum_+and-_(38)");
        }

        [Theory]
        [InlineData(-7, 5, -2)]
        [InlineData(-100049, 6, -100043)]
        [InlineData(-1, 1, 0)]
        public void PositiveAndNegative_Sum_ExpectedNegative(int value1, int value2, int expected)
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
        public void NegativeAndNegative_Sum_ExpectedPositive(int value1, int value2, int expected)
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
        public void PositiveAndPositive_Product_ExpectedPositive(int value1, int value2, int expected)
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
        public void PositiveAndNegative_Product_ExpectedNegative(int value1, int value2, int expected)
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
        public void NegativeAndNegative_Product_ExpectedPositive(int value1, int value2, int expected)
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
        public void OnZeroArg_Product_ExpectedZero(int value1, int value2, int expected)
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
        public void PositiveAndPositive_Subtract_ExpectedPositive(int value1, int value2, int expected)
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
        public void PositiveAndNegative_Subtract_ExpectedPositive(int value1, int value2, int expected)
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
        public void NegativeAndPositive_Subtract_ExpectedNegative(int value1, int value2, int expected)
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
        public void NegativeAndNegative_Subtract_ExpectedPositive(int value1, int value2, int expected)
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
        public void NegativeAndZero_Subtract_ExpectedNegative(int value1, int value2, int expected)
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
        public void ZeroAndNegative_Subtract_ExpectedPositive(int value1, int value2, int expected)
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
        public void ZeroAndPositive_Subtract_ExpectedNegative(int value1, int value2, int expected)
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
        public void PositiveAndPositive_Division_ExpectedPositive(int value1, int value2, int expected)
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
        public void PositiveAndNegative_Division_ExpectedNegative(int value1, int value2, int expected)
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
        public void NegativeAndPositive_Division_ExpectedNegative(int value1, int value2, int expected)
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
        public void NegativeAndNegative_Division_ExpectedPositive(int value1, int value2, int expected)
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
        public void ZeroAndNumber_Division_ExpectedZero(int value1, int value2, int expected)
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
        public void NumberAndZero_Division_ExpectedThrow(int value1, int value2)
        {
            //arrange
            var stubCalculator = new StubCalculator(value1, value2);
            var calculator = new Calculator(stubCalculator);
            //act & assert
            Assert.Throws<Exception>(() => calculator.Division());
        }
    }
}
