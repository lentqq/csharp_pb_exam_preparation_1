using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cange_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double widhtFloor = double.Parse(Console.ReadLine());
            double lenghtFloor = double.Parse(Console.ReadLine());
            double sideTile = double.Parse(Console.ReadLine());
            double heightTile = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double masterSalary = double.Parse(Console.ReadLine());

            double floorArea = widhtFloor * lenghtFloor;
            double tileArea = sideTile * heightTile / 2;
            double numTile = Math.Ceiling(floorArea / tileArea) + 5;
            double sumNeeded = numTile * priceTile + masterSalary;

            if (sumNeeded <= budget)
            {
                Console.WriteLine($"{(budget - sumNeeded).ToString("0.00")} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(sumNeeded - budget).ToString("0.00")} lv more.");
            }
        }
    }
}
