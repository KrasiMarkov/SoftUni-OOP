using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable
    {
        private T item;



        public Box(T item)
        {
            this.item = item;

        }

        public override string ToString()
        {


            return $"{this.item.GetType()}: {this.item}";

        }

        
        public bool IsLower(Box<T> otherBox)
        {
           int result = this.item.CompareTo(otherBox.item);

            return result < 0;
        }

    }
}
