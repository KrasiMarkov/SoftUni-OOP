using GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class ElementStore<T> where T : IComparable
    {
        private List<Box<T>> boxes;

        public ElementStore()
        {
            this.boxes = new List<Box<T>>();

        }

        public void AddToBoxes(Box<T> box)
        {
            boxes.Add(box);
        }

        public int CompareElements(T element)
        {
            Box<T> currentBox = new Box<T>(element);

            int counter = 0;

            foreach (Box<T> box in this.boxes)
            {
                if (currentBox.IsLower(box))
                {
                    counter++;
                }


            }

            return counter;
        }
    }
}
