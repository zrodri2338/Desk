using System;

/*
Name: Zulisa Rodriguez
Date July 11, 2026
Program: Desk
Description: Calculates the price of a desk based on wood type and number of drawers.
*/

namespace Desk
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
            return Convert.ToChar(Console.ReadLine().ToLower());
        }

        static double CalculateCost(int drawers, char woodType)
        
        }
    }
}