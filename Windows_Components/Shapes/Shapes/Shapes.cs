using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle
    {
        double Radius;

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double givenRadius)
        {
            Radius = givenRadius;
        }

        public double Area()
        { 
            return System.Math.PI * (Radius * Radius);
        }
    }

    public class Triangle
    {
        double Base, Height;

        public Triangle()
        {
            Base = 0;
            Height = 0;
        }

        public Triangle(double givenBase, double givenHeight)
        {
            Base = givenBase;
            Height = givenHeight;
        }

        public double Area()
        {
            return 0.5F * Base * Height;
        }
    }
}
