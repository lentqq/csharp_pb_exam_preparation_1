using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int numHriz = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string checkHolyday = Console.ReadLine();
            bool isHolyday = false;
            if (checkHolyday == "Y")
            {
                isHolyday = true;
            }
            double buketSum = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    buketSum = numHriz * 2.00 + numRoses * 4.10 + numTulips * 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    buketSum = numHriz * 3.75 + numRoses * 4.50 + numTulips * 4.15;
                    break;
                default:
                    break;
            }
            if (isHolyday)
            {
                buketSum *= 1.15;
            }
            if (numTulips > 7 && season == "Spring")
            {
                buketSum *= 0.95;
            }
            if (numRoses >= 10 && season == "Winter")
            {
                buketSum *= 0.90;
            }
            if (numHriz + numRoses + numTulips > 20)
            {
                buketSum *= 0.80;
            }
            Console.WriteLine((buketSum + 2).ToString("0.00"));
        }
    }
}
