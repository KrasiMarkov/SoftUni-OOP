using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDemos.App
{
    public class Calculator
    {
        public int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
