using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal interface ICalculator
    {
        public double Add(double num1, double num2);
        public double Subtract(double num1, double num2);
        public double Multiply(double num1, double num2);
        public double Divide(double num1, double num2);
    }
}
