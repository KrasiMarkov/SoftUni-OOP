using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;


        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }

                else
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

            }

        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }

                else
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

            }

        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }

                else
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

            }

        }

        public double CalculateSurfaceArea()
        {

            double surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);

            return surfaceArea;

        }

        public double CalculateLateralSurfaceArea()
        {

            double lateralSurfaceArea = (2 * length * height) + (2 * width * height);

            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {

            double volume = length * width * height;

            return volume;
        }

    }
}
