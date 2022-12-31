using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class MyTupleTwo<TItem1, TItem2, TItem3>
    {

        private TItem1 Item1;

        private TItem2 Item2;

        private TItem3 Item3;

        public MyTupleTwo(TItem1 Item1, TItem2 Item2, TItem3 Item3)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
            this.Item3 = Item3;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
