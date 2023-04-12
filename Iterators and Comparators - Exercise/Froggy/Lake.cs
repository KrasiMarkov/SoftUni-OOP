using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> MyList;

        public Lake(int[] numbers)
        {
            this.MyList = numbers.ToList();
        }

       

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.MyList.Count; i+=2)
            {
                yield return this.MyList[i];

            }

            int lastOddIndex = this.MyList.Count - 1;

            if (lastOddIndex % 2 == 0)
            {
                lastOddIndex--;
            }

            for (int i = lastOddIndex; i >= 0; i-=2)
            {
                yield return this.MyList[i];
            }

            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
