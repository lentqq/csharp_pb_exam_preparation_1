using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Cup
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int with = 5 * n;
            int lenght = 2 * n + 4;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string('.', n + i)}{new string('#', (with - (n + i) * 2))}{new string('.', n + i)}");
            }
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', ((with - 2 * n) / 2) + i), new string('.', with - (((with - 2 * n) / 2) + i) * 2 - 2));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n), new string('#', n));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (with - (n + 4)) / 2), new string('#', n + 4));
            }
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (with -10) / 2));
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (with - (n + 4)) / 2), new string('#', n + 4));
            }
        }
    }
}
