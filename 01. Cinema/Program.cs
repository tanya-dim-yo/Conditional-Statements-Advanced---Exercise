using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seats = rows * cols;
            double income = 0;
            if (projectionType == "Premiere")
            {
                income = seats * 12.0;
            }
            else if (projectionType == "Normal")
            {
                income = seats * 7.50;
            }
            else if (projectionType == "Discount")
            {
                income = seats * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}