using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            int c = a + b;

            return c;
        }

        public double Add(double a, double b, double c)
        {
            double d = a + b + c;

            return d;
        }

        public decimal Add(decimal a, decimal b, decimal c)
        {
            decimal d = a + b + c;

            return d;
        }

    }
}
