using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wire
{
    class Wire
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double pricePerMeter = double.Parse(Console.ReadLine());
            double weigthPerSquareMeter = double.Parse(Console.ReadLine());

            int netLength = length * 2 + width * 2;
            double netPrice = netLength * pricePerMeter;
            double netWeigth = netLength * heigth * weigthPerSquareMeter;
            Console.WriteLine(netLength);
            Console.WriteLine("{0:f2}", netPrice);
            Console.WriteLine("{0:f3}", netWeigth);

        }
    }
}
