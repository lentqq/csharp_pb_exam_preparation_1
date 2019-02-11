using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Java
{
    class Java
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 6;
            int heigth = 3 * n + 1;
            int midlleChar = width - n - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}~ ~ ~{1}", new string(' ', n),
                    new string(' ', width - n - 5));
            }
            Console.WriteLine($"{new string('=', width - 1)}");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('|');
                if (i == n / 2)
                {
                    Console.Write($"{new string('~', n)}JAVA{new string('~', n)}");
                }
                else
                {
                    Console.Write($"{new string('~', 2 * n + 4)}");
                }
                Console.Write('|');
                Console.Write($"{new string(' ', n - 1)}");
                Console.WriteLine('|');

            }
            Console.WriteLine($"{new string('=', width - 1)}");
            for (int i = 0; i < n; i++)


            {
                Console.WriteLine("{0}\\{1}/{2}", new string(' ', i),
                new string('@', midlleChar), new string(' ', n - i));
                midlleChar -= 2;
            }
            Console.WriteLine($"{new string('=', width - n)}");
        }
    }
}
