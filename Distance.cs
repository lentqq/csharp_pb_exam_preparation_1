using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstDistance = firstSpeed * firstTime / 60.0;
            double secondDistance = firstSpeed * 1.1 * secondTime / 60.0;
            double thirdDistance = ((firstSpeed * 1.1) - (firstSpeed * 1.1 * 0.05)) * thirdTime / 60.0;

            double totalDistance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:0.00}",totalDistance);
        }
    }
}
