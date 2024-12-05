using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.zadania
{
    public abstract class Shape
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract double CalculateArea();

    }

   internal class Square : Shape
    {
       public Square(int x): base(x, x) { }
        public override double CalculateArea()
       {
           return X*X;
       }
    }

    internal class Circle : Shape
    { 
        public Circle(int y): base(y, y) { }

        public override double CalculateArea()
        {
            return Y * Y * 3.14;
        }
    }
}