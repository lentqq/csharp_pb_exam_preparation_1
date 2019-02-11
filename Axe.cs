using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int with = 5 * n;
            // int b = with - ((2 * n) - 2) -((n / 2) + 1);
            //Console.WriteLine(b);
            for (int i = 0

                ; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n),
                    new string('-', i), new string('-', with - 2 - 3 * n - i));
            }
            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}{1}*{1}", new string('*', (3 * n) + 1),
                        new string('-', n - 1));
                }
            }
            else if (n % 2 != 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}{1}*{1}", new string('*', (3 * n) + 1),
                      new string('-', n - 1));
                }
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n - i), new string('-', with - (3 * n - i) - 2 - (n - 1 - i)),
                    new string('-', n - 1 - i));
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', with - (2 * n - 1) - n / 2),
                    new string('*', 2 * n - 1), new string('-', n / 2));
            }
            else if (n % 2 != 0)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', with - ((2 * n) - 2) - ((n / 2) + 1)),
                   new string('*', (2 * n) - 2), new string('-', n / 2 + 1));
            }
        }
    }
}
