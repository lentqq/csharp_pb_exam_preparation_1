using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ПаричнаНаграда
{
    class ПаричнаНаграда
    {
        static void Main(string[] args)
        {
            int projectParts = int.Parse(Console.ReadLine());
            double cashPrizeForPoint = double.Parse(Console.ReadLine());
            int sumPoints = 0;
            for (int i = 1; i <= projectParts; i++)
            {
                int points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    points *= 2;
                }
                sumPoints += points;
            }
            double prize = cashPrizeForPoint * sumPoints;
            Console.WriteLine($"The project prize was {prize:f2} lv.");
        }
    }
}
