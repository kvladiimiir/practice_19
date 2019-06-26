using System;

namespace learning
{
    public class CommandArgumentsNumberProvider : INumberProvider
    {
        public int A { get; }
        public int B { get; }
        public CommandArgumentsNumberProvider(int a, int b)
        {
            A = a;
            B = b;
        }

        public static CommandArgumentsNumberProvider Parse(string[] args)
        {
            if (args.Length < 2)
            {
                throw new Exception("Error arguments number!");
            }

            if (!ValidationArgument(args[0]) || !ValidationArgument(args[1]))
            {
                throw new Exception("Error, because the argument contains a symbol!");
            }

            int first = int.Parse(args[0]);
            int second = int.Parse(args[1]);

            return new CommandArgumentsNumberProvider(first, second);
        }
        
        private static bool ValidationArgument(string argument)
        {
            int result;
            return Int32.TryParse(argument, out result);
        }
    }
}