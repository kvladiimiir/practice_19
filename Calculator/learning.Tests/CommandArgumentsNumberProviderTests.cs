using System;
using Xunit;

namespace learning.Tests
{
    public class MethodCommandArgumentsNumberProvider : INumberProvider
    {
        public int A { get; }
        public int B { get; }
    }
    public class CommandArgumentsNumberProviderTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            string[] testArgs = {"12", "10"};
            var expected = 12;
            //act
            MethodCommandArgumentsNumberProvider methodCommand = MethodCommandArgumentsNumberProvider.Parse(testArgs);
            //assert
            Assert.Equal(expected, methodCommand.A);
        }
    }
}
