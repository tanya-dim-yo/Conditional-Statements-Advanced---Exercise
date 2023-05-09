using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double cost = 0.0;
            if (roomType == "room for one person")
            {
                cost = nights * 18.0;
            }
            else if (roomType == "apartment")
            {
                cost = nights * 25.0;
                if (nights > 0 && nights < 10)
                {
                    cost -= cost * 0.3;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    cost -= cost * 0.35;
                }
                else if (nights > 15)
                {
                    cost -= cost * 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                cost = nights * 35.0;
                if (nights > 0 && nights < 10)
                {
                    cost -= cost * 0.1;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    cost -= cost * 0.15;
                }
                else if (nights > 15)
                {
                    cost -= cost * 0.2;
                }
            }
            if (rating == "positive")
            {
                cost += cost * 0.25;
            }
            else if (rating == "negative")
            {
                cost -= cost * 0.1;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}