using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string destination = "";
            string type = "";
            double cost = 0.0;
            if (budget >0 && budget <= 100.0)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    cost = budget * 0.3;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    cost = budget * 0.7;
                }
            }
            else if (budget > 100.0 && budget <= 1000.0)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    cost = budget * 0.4;
                }
                else if (season == "winter")
                {
                    type = "Hotel";
                    cost = budget * 0.8;
                }
            }
            else if (budget > 1000.0)
            {
                destination = "Europe";
                type = "Hotel";
                cost = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {cost:f2}");
        }
    }
}