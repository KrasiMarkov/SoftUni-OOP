using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> data;

        public Box()
        {
            this.data = new Stack<T>();

        }

        public int Count
        {
           get
           { 
               return this.data.Count;

           }

        }
        public void Add(T item)
        {
            data.Push(item);
        }

        public T Remove()
        {
             return data.Pop();
        }

    }
}
