﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;

        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set 
            {
                this.height = value;
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
                this.width = value;
            }

        }

        public override double CalculateArea()
        {
            double area = this.height * this.width;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.height + this.width);

            return perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;

        }

    }
}
