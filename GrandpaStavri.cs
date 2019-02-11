using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class GrandpaStavri
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double sumLiters = 0.00;
            double sumDegrees = 0.00;

            for (int i = 1; i <= days; i++)
            {
                double litersBrandy = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                sumLiters += litersBrandy;
                sumDegrees = sumDegrees + litersBrandy * degrees;
            }
            double averageDegrees = sumDegrees / sumLiters;
            Console.WriteLine($"Liter: {sumLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");
            if (averageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegrees > 38 && averageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
