using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int dots = (width - 2) / 2;
            int space = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',dots--),
                    new string(' ',space));
                space += 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n / 2),
                new string('*',2 * n));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.',n / 2),
                    new string('\\',width - 2 - n));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",new string('.',n/2 - i),
                    new string('*',width - ((n/2 - i)*2)-2));
            }
        }
    }
}
