using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int with = 2 * n + 3;
            int height = 2 * n + 1;

            Console.WriteLine("*{0}*{0}*", new string('.', n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n - i));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            Console.WriteLine($"{new string('*', with)}");
            Console.WriteLine("{0}{1}{0}", new string('.', n - 1), new string('*', 5));
            for (int i = n - 2; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', n - i));
            }
            Console.WriteLine("*{0}*{0}*", new string('.', n));
        }
    }
}
