using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double smallestRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double squareMeter = double.Parse(Console.ReadLine());

            double secondRoomArea = smallestRoomArea + smallestRoomArea * 0.10;
            double thirdRoomArea = secondRoomArea + secondRoomArea * 0.10;
            double badRoomArea = smallestRoomArea / 2.00;
            double area = smallestRoomArea + kitchenArea + secondRoomArea +
                thirdRoomArea + badRoomArea;
            double corridor = area * 0.05;
            double totalArea = area + corridor;
            double price = totalArea * squareMeter;
            Console.WriteLine($"{price:f2}");
        }
    }
}
