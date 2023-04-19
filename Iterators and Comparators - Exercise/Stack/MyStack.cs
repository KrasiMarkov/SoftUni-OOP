using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private Stack<T> MyCustomStack;

        public MyStack()
        {
            this.MyCustomStack = new Stack<T>();


        }
        public void Push(T current)
        {
            MyCustomStack.Push(current);
        }

        public void Pop()
        {
            if (MyCustomStack.Count > 0)
            {
                MyCustomStack.Pop();
            }
            else
            {
                Console.WriteLine("No elements");
            }
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in MyCustomStack)
            {
                yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
