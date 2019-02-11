using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = 2 * n - 1;
            Console.Write(new string('.', dots));
            Console.Write(@"/|\");
            Console.WriteLine(new string('.', dots));

            Console.Write(new string('.', dots));
            Console.Write(@"\|/");
            Console.WriteLine(new string('.', dots));

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new string('.', dots - i) + "*" +
                    new string('-', i) + "*" + new string('-', i) +
                    "*" + new string('.', dots - i));
            }

            Console.WriteLine(new string('*', 4 * n + 1));
            Console.Write("*");
            for (int i = 0; i < 2 * n; i++)
            {

                Console.Write(".*");
            }
            Console.WriteLine();

            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
