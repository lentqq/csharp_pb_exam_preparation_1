using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Lutenisa
{
    class Lutenitsa
    {
        static void Main(string[] args)
        {
            double quantity = double.Parse(Console.ReadLine());
            int boxes = int.Parse(Console.ReadLine());
            int jarsInBox = int.Parse(Console.ReadLine());
            double quantityLutenica = quantity / 5;
            Console.WriteLine("Total lutenica: {0} kilograms.", (int)quantityLutenica);
            double totalQuantity = (boxes * jarsInBox * 0.535);
            double neededQuantityJars = quantityLutenica / 0.535;
            double neededQuantityBoxes = neededQuantityJars / jarsInBox;

            if (quantityLutenica >= totalQuantity)
            {
                Console.WriteLine("{0} boxes left. ", (Math.Floor(neededQuantityBoxes - boxes)));
                Console.WriteLine("{0} jars left.", Math.Floor(neededQuantityJars - (boxes * jarsInBox)));
            }
            else
            {
                Console.WriteLine("{0} more boxes needed.", (Math.Abs(Math.Truncate(neededQuantityBoxes - boxes))));
                Console.WriteLine("{0} more jars needed.", Math.Abs(Math.Truncate(neededQuantityJars - (boxes * jarsInBox))));
            }
        }
    }
}
