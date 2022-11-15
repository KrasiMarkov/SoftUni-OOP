using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemos.App
{
    public class BancAccount
    {
        public BancAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; }

    }
}
