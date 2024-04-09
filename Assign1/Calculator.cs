using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Calculator : ICalculator
    {
        double ICalculator.Add(double num1, double num2)
        {
            return num1 + num2;
        }

        double ICalculator.Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        double ICalculator.Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        double ICalculator.Divide(double num1, double num2)
        {
            if(num2 == 0)
            {
                Console.WriteLine("Cannot Divide by Zero !");
                return -1;
            }

            return num1 / num2;
        }
    }
}
