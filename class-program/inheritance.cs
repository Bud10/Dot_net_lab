using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_class
{
     interface Iaddition
    {
        double Add(double a, double b);
    }
    interface Isubstraction
    {
        double Subtract(double a, double b);
    }
    interface Imultiplication
    {
        double Multiply(double a, double b);
    }
    interface Idivision
    {
        double Divide(double a, double b);
    }
    
    class Interface : Iaddition, Isubstraction, Imultiplication, Idivision
    {
         public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }
    }
}
