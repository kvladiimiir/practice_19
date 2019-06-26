using System;

namespace learning
{
    public class Calculator
    {
        private readonly INumberProvider _numberProvider;

        public Calculator(INumberProvider numberProvider)
        {
            _numberProvider = numberProvider;
        }

        public int Sum()
        {
            return _numberProvider.A + _numberProvider.B;
        }

        public int Product()
        {
            return _numberProvider.A * _numberProvider.B;
        }

        public int Subtract()
        {
            return _numberProvider.A - _numberProvider.B;
        }

        public int Division()
        {
            if (_numberProvider.B == 0)
            {
                throw new Exception("Division by 0!");
            }

            return _numberProvider.A / _numberProvider.B;
        }
    }
}