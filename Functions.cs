using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCalculator
{
    class Functions : IInterface
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int min(int x, int y)
        {
            return x - y;
        }

        public int times(int x, int y)
        {
            return x * y;
        }

        public int div(int x, int y)
        {
            return x / y;
        }
    }
}
