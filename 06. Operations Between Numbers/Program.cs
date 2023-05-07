using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double result = 0.0;
            double resultDivide = 0.0;
            string evenOdd = "";
            if (action == "+")
            {
                result = number1 + number2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "-")
            {
                result = number1 - number2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "*")
            {
                result = number1 * number2;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
            }
            else if (action == "/")
            {
                resultDivide = number1 / number2;
            }
            else if (action == "%")
            {
                result = number1 % number2;
            }
            if (action == "+")
            {
                Console.WriteLine($"{number1} + {number2} = {result} - {evenOdd}");
            }
            else if (action == "-")
            {
                Console.WriteLine($"{number1} - {number2} = {result} - {evenOdd}");
            }
            else if (action == "*")
            {
                Console.WriteLine($"{number1} * {number2} = {result} - {evenOdd}");
            }
            else if (action == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} / {number2} = {resultDivide:f2}");
                }
            }
            else if (action == "%")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }
                else
                {
                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }
        }
    }
}