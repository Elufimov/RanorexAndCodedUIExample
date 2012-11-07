using System;
using Example1.Repositories;

namespace Example1.Helpers.Loader
{
    public static class MapLoader
    {
        private static Calculator _calculator;

        public static Calculator Calculator
        {
            get
            {
                if (_calculator == null)
                    _calculator = new Calculator();
                return _calculator;
            }
        }
    }
}