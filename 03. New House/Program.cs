using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost = 0.0;
            if (flowerType == "Roses")
            {
                cost = quantity * 5.0;
                if (quantity > 80)
                {
                    cost -= cost * 0.1;
                }
            }
            else if (flowerType == "Dahlias")
            {
                cost = quantity * 3.80;
                if (quantity > 90)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                cost = quantity * 2.80;
                if (quantity > 80)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                cost = quantity * 3.0;
                if (quantity < 120)
                {
                    cost += cost * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                cost = quantity * 2.50;
                if (quantity < 80)
                {
                    cost += cost * 0.2;
                }
            }
            if (budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");
            }
        }
    }
}