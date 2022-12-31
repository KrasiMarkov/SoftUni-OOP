using GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class BoxStore<T>
    {
        List<Box<T>> totalBoxes;

        public BoxStore()
        {
            this.totalBoxes = new List<Box<T>>();
        }

        public void AddToTotalBoxes(Box<T> box)
        {
            totalBoxes.Add(box);
        }

        public void SwapBoxes(int firstIndex, int secondIndex)
        {
            var current = totalBoxes[firstIndex];

            var secondCurrent = totalBoxes[secondIndex];

            totalBoxes[firstIndex] = secondCurrent;

            totalBoxes[secondIndex] = current;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Box<T> box in totalBoxes)
            {
                sb.AppendLine(box.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}
