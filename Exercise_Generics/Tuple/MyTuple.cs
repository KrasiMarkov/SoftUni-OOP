using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTuple<TItem1, TItem2>
    {
        private TItem1 Item1;

        private TItem2 Item2;

        public MyTuple(TItem1 Item1, TItem2 Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
