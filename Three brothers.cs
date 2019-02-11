using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double generalCleanTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime +
                1 / thirdBrotherTime);

            double timeWithRest = generalCleanTime + generalCleanTime * 0.15;

            double timeLeft = (fishingTime - timeWithRest);

            Console.WriteLine($"Cleaning time: {(timeWithRest):f2}");
            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");

            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(timeLeft))} hours.");
            }
        }
    }
}
