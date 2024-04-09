using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class CalculatorRunner
    {
        private readonly ICalculator _calculator;

        public CalculatorRunner(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Run()
        {
            double num1, num2;

            // Taking input from the user
            Console.WriteLine("Enter the first number : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Addition
            Console.WriteLine($"Addition: {num1} + {num2} = {_calculator.Add(num1, num2)}");

            // Subtraction
            Console.WriteLine($"Subtraction: {num1} - {num2} = {_calculator.Subtract(num1, num2)}");

            // Multiplication
            Console.WriteLine($"Multiplication: {num1} * {num2} = {_calculator.Multiply(num1, num2)}");

            // Division
            Console.WriteLine($"Division: {num1} / {num2} = {_calculator.Divide(num1, num2)}");
        }
    }
}
