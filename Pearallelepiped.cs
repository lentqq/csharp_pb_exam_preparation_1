using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parallelepiped
{
    class Pearallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int heigth = 4 * n + 4;
            int width = 3 * n + 1;
            int wave = n - 2;
            string waves = new string('~', wave);

            // first row
            Console.WriteLine($"+{waves}+{new string('.', width - n)}");

            // middle up
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', i),
                    waves, new string('.', (2 * n) - i));
            }
            //middle down

            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i),
                    new string('.', (2 * n) - i), waves);
            }
            // last row
            Console.WriteLine($"{new string('.', width - n)}+{waves}+");
        }
    }
} 
			

			
