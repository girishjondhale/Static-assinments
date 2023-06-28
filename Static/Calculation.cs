using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Substraction(double a, double b)
        {
            return a - b;
        }
        public double Substraction(double a, double b, double c)
        {
            return a - b - c;
        }
        public double Multiplication(double c, double d)
        {
            return c * d;
        }
        public double Multiplication(double c, double d, double e)
        {
            return c * d * e;
        }
    }
}
