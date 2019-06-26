using System;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandArgumentsNumberProvider commandArgumentsNumberProvider = CommandArgumentsNumberProvider.Parse(args);
            Calculator calculator = new Calculator(commandArgumentsNumberProvider);

            Console.WriteLine(calculator.Product());
        }
    }
}
