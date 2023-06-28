using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public abstract class Shape
    {
        public abstract void CalculateArea();
    }

    public class Rectangle : Shape
    {
        private int l, b;
        private double area;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b;
        }
        public override string ToString()
        {
            return $"area of reactangle is {area}";

        }
    }
}

