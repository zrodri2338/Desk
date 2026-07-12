using System;

/*
Name: Zulisa Cruz
Date Completed: July 2026
Program: Desks
Description: Calculates the price of a desk based on wood type and number of drawers.
Resources Used: Course materials and Microsoft C# documentation.
*/

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            int drawers;
            char woodType;
            double cost;

            drawers = GetDrawers();
            woodType = GetWoodType();

            cost = CalculateCost(drawers, woodType);

            DisplayResults(drawers, woodType, cost);

            Console.ReadKey();
        }

        static int GetDrawers()
        {
            Console.Write("Enter the number of drawers: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static char GetWoodType()
        {
            Console.Write("Enter wood type (m = Mahogany, o = Oak, p = Pine): ");
            return char.ToLower(Console.ReadLine()[0]);
        }

        static double CalculateCost(int drawers, char woodType)
        {
            double basePrice;

            if (woodType == 'p')
                basePrice = 100;
            else if (woodType == 'o')
                basePrice = 140;
            else
                basePrice = 180;

            return basePrice + (drawers * 30);
        }

        static void DisplayResults(int drawers, char woodType, double cost)
        {
            string woodName;

            if (woodType == 'p')
                woodName = "Pine";
            else if (woodType == 'o')
                woodName = "Oak";
            else
                woodName = "Mahogany";

            Console.WriteLine("\nDesk Order Summary");
            Console.WriteLine("Wood Type: " + woodName);
            Console.WriteLine("Number of Drawers: " + drawers);
            Console.WriteLine("Total Cost: $" + cost);
        }
    }
}