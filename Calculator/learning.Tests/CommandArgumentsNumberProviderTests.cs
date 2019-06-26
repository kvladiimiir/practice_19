using System;
using Xunit;

namespace learning.Tests
{
    public class CommandArgumentsNumberProviderTests
    {
        [Theory]
        [InlineData("12", "10")]
        [InlineData("12", "10", "134", "1203")]
        public void ParseArgumentsInStringArrayAndCheckFirstArgument(params string[] arguments)
        {
            //arrange
            var expected = 12;
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.A);
        }

        [Theory]
        [InlineData("12", "10")]
        [InlineData("12", "10", "134", "1203")]
        public void ParseArgumentsInStringArrayAndCheckSecondArgument(params string[] arguments)
        {
            //arrange
            var expected = 10;
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.B);
        }

        [Theory]
        [InlineData("12", "10", "134as", "Hello")]
        public void ParseFirstAndSecondArgumentsButOtherArgumentsMayContainSymbols(params string[] arguments)
        {
            //arrange
            var expected = 12;
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.A);
        }

        [Theory]
        [InlineData("12")]
        [InlineData()]
        public void ParseOneAndZeroLengthInputArrayParamsExpectedThrow(params string[] arguments)
        {
            //arrange

            //act
            Action act = () => CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Throws<Exception>(act);
        }

        [Theory]
        [InlineData("12", "1a0")]
        [InlineData("12a", "10", "134as", "Hello")]
        public void ParseArgumentsWithSymbolExpectedThrow(params string[] arguments)
        {
            //arrange

            //act
            Action act = () => CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Throws<Exception>(act);
        }
    }
}
