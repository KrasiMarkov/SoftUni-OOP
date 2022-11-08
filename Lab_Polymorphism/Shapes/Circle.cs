using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                this.radius = value;
            }

        }

        public override double CalculateArea()
        {
            double area = Math.PI * radius * radius;

            return area;
        }

        public override double CalculatePerimeter()
        {
            double Perimeter = 2 * Math.PI * radius;

            return Perimeter;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }

    }
}
