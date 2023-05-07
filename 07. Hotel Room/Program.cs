using System;
using System.Data;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double costStudio = 0.0;
            double costApartment = 0.0;
            if (month == "May" || month == "October")
            {
                costStudio = nights * 50.0;
                costApartment = nights * 65.0;
                if (nights > 7 && nights <= 14)
                {
                    costStudio -= costStudio * 0.05;
                }
                else if (nights > 14)
                {
                    costStudio -= costStudio * 0.3;
                    costApartment -= costApartment * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                costStudio = nights * 75.20;
                costApartment = nights * 68.70;
                if (nights > 14)
                {
                    costStudio -= costStudio * 0.2;
                    costApartment -= costApartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                costStudio = nights * 76.0;
                costApartment = nights * 77.0;
                if (nights > 14)
                {
                    costApartment -= costApartment * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {costApartment:f2} lv.");
            Console.WriteLine($"Studio: {costStudio:f2} lv.");
        }
    }
}