using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IBuyer
    {
        void BuyFood();

        int Food { get; set; }

        string Name { get; set; }

    }
}
