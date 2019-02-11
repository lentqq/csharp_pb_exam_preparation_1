using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;

            for (int i = 1; i <= n && sum < controlNumber; i++)
            {
                for (int j = m; j >= 1 && sum < controlNumber; j--)
                {
                    sum = sum + (i * 2 + j * 3);
                    count++;

                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                    }
                }
            }
            if (sum < controlNumber)
            {
                Console.WriteLine($"{count} moves");
            }
        }
    }
}
