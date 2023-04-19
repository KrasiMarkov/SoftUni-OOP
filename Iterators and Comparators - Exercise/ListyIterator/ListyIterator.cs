using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index ;

        private List<T> myList;
        public ListyIterator(List<T> data)
        {
            this.index = 0;
            this.myList = data;
        }

        public int Count => this.myList.Count;
        public bool Move()
        {
            

            if (this.index < this.Count - 1)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index < this.Count - 1)
            {
                return true;
            }

            return false;

        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.myList[this.index]);
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.myList)
            {
                yield return item;
            }
                 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
