using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Ladybird
{
    class Ladybird
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            Console.WriteLine($"{new string(' ', (width - 5) / 2)}@   @{new string(' ', (width - 5) / 2)}");
            Console.WriteLine($"{new string(' ', (width - 3) / 2)}\\_/{new string(' ', (width - 3) / 2)}");
            Console.WriteLine($"{new string(' ', (width - 3) / 2)}/ \\{new string(' ', (width - 3) / 2)}");
            Console.WriteLine($"{new string(' ', (width - 3) / 2)}|_|{new string(' ', (width - 3) / 2)}");

            int outsideSpace = (width - 3) / 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string(' ', outsideSpace)}/{new string(' ', i)}|" +
                    $"{new string(' ', i)}\\" +
                    $"{new string(' ', outsideSpace)}");
                outsideSpace -= 1;
            }
            int insideSpace = (width - 5) / 2;
            int insideSpace1 = (insideSpace) / 2;
            int insideSpace2 = insideSpace1 + 1;
            for (int i = 0; i < n / 2; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"|{new string(' ', insideSpace1)}@" +
                        $"{new string(' ', insideSpace1)}|" +
                        $"{new string(' ', insideSpace1)}@" +
                        $"{new string(' ', insideSpace1)}|");
                }
                if (n % 2 != 0)
                {
                    Console.WriteLine($"|{new string(' ', insideSpace1)}@" +
                      $"{new string(' ', insideSpace2)}|" +
                      $"{new string(' ', insideSpace2)}@" +
                      $"{new string(' ', insideSpace1)}|");
                }
            }
            int insideSp = (width - 3) / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string(' ', i)}\\{new string(' ', insideSp)}|{new string(' ', insideSp)}/{new string(' ', i)}");
                insideSp -= 1;
            }
            Console.WriteLine($"{new string(' ', (width - 1 - (n / 2) * 2) / 2)}{new string('^', n / 2)}|{new string('^', n / 2)}{new string(' ', (width - 1 - (n / 2) * 2) / 2)}");
        }
    }
}
