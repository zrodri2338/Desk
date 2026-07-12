using System;

/*
Name: Zulisa Cruz
Date Completed: July 2026
Description: This program calculates the price of a desk based
on the type of wood and the number of drawers.
Resources Used: Course materials and class notes.
*/

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            int drawers = GetDrawers();
            char woodType = GetWoodType();
            double cost = CalculateCost(drawers, woodType);

            DisplayDetails(drawers, woodType, cost);
        }

        static int GetDrawers()
        {
            Console.Write("Enter the number of drawers: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static char GetWoodType()
        {
            Console.Write("Enter wood type (m = Mahogany, o = Oak, p = Pine): ");

            string input = Console.ReadLine() ?? "";
            return char.ToLower(input[0]);
        }

        static double CalculateCost(int drawers, char woodType)
        {
            double basePrice;

            if (woodType == 'p')
            {
                basePrice = 100;
            }
            else if (woodType == 'o')
            {
                basePrice = 140;
            }
            else
            {
                basePrice = 180;
            }

            return basePrice + (drawers * 30);
        }

        static void DisplayDetails(int drawers, char woodType, double cost)
        {
            string woodName;

            if (woodType == 'p')
            {
                woodName = "Pine";
            }
            else if (woodType == 'o')
            {
                woodName = "Oak";
            }
            else
            {
                woodName = "Mahogany";
            }

            Console.WriteLine("\nDesk Order Details");
            Console.WriteLine($"Wood type: {woodName}");
            Console.WriteLine($"Number of drawers: {drawers}");
            Console.WriteLine($"Final price: {cost:C}");
        }
    }
}