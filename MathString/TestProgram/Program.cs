using System;
using MathLibrary;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Enter expression: ");
                string expression = Console.ReadLine();

                try
                {
                    int result = Calculator.Calculate(expression);
                    Console.WriteLine($"The expression result is: {result}");
                }
                catch (CalculateExceptionDivideByZero)
                {
                    Console.WriteLine("Division by zero is prohibited!");
                }
                catch (CalculateExceptionStringIsEmpty)
                {
                    Console.WriteLine("Missing expression input!");
                }
                catch (CalculateExceptionInvalidExpression)
                {
                    Console.WriteLine("Invalid expression!");
                }

                Console.ReadKey();
            }
        }
    }
}