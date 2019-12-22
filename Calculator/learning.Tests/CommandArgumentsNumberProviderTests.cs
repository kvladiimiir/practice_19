using System;
using System.Collections.Generic;
using Xunit;

namespace learning.Tests
{
    public class CommandArgumentsNumberProviderTests
    {
        [Theory]
        [InlineData("12", "12", "10")]
        [InlineData("12", "12", "10", "134", "1203")]
        public void InStringArray_ParseArguments_And_CheckFirstArgument(params string[] arguments)
        {
            //arrange
            int expected = Int32.Parse(arguments[0]);
            var tmp = new List<string>(arguments);
            tmp.RemoveAt(0);
            var args = tmp.ToArray();
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(args);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.A);
        }

        [Theory]
        [InlineData("10", "12", "10")]
        [InlineData("10", "12", "10", "134", "1203")]
        public void InStringArray_ParseArguments_And_CheckSecondArgument(params string[] arguments)
        {
            //arrange
            int expected = Int32.Parse(arguments[0]);
            var tmp = new List<string>(arguments);
            tmp.RemoveAt(0);
            var args = tmp.ToArray();
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(args);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.B);
        }

        [Theory]
        [InlineData("12", "12", "10", "134as", "Hello")]
        public void ArrayWithOtherArgumentsMayContainSymbols_ParseFirstAndSecondArguments(params string[] arguments)
        {
            //arrange
            int expected = Int32.Parse(arguments[0]);
            var tmp = new List<string>(arguments);
            tmp.RemoveAt(0);
            var args = tmp.ToArray();
            //act
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(args);
            //assert
            Assert.Equal(expected, commandArgumentsNumberProvider.A);
        }

        [Theory]
        [InlineData("12")]
        [InlineData("")]
        public void OneAndZeroLengthInputArray_ParseParams_ExpectedThrow(params string[] arguments)
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
        public void InInputArrayWithSymbols_ParseArguments_ExpectedThrow(params string[] arguments)
        {
            //arrange

            //act
            Action act = () => CommandArgumentsNumberProvider.Parse(arguments);
            //assert
            Assert.Throws<Exception>(act);
        }

        [Fact]
        public void InputAArg_IncrementInA_ExpectedIncAArg()
        {
            //arrange
            int expected = 2;
            CommandArgumentsNumberProvider NP = new CommandArgumentsNumberProvider(1, 3);
            //act
            NP.IncrementA();
            //assert
            Assert.Equal(expected, NP.A);
        }

        [Theory]
        [InlineData("12", "9")]
        [InlineData("1", "-2")]
        public void InputArrayArguments_AddInBArg_ExpectedCorrectResult(params string[] argsInTest)
        {
            //arrange
            int count = Convert.ToInt32(argsInTest[1]);
            int expected = Convert.ToInt32(argsInTest[0]);
            CommandArgumentsNumberProvider NP = new CommandArgumentsNumberProvider(1, 3);
            //act
            NP.AddNumberInBArg(count);
            //assert
            Assert.Equal(expected, NP.B);
        }
    }
}
