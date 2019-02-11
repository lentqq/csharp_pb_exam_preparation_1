using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.СборИлиПроизведение
{
    class СборИлиПроизведение
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool valid = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c && a + b + c == n)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            valid = true;
                        }
                        else if (a > b && b > c && a * b * c == n)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            valid = true;
                        }

                    }
                }
            }
            if (valid != true)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
