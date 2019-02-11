using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            char skipSimbol = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i1 = firstSymbol; i1 <= lastSymbol; i1++)
            {
                for (char i2 = firstSymbol; i2 <= lastSymbol; i2++)
                {
                    for (char i3 = firstSymbol; i3 <= lastSymbol; i3++)
                    {
                        if (i1 == skipSimbol || i2 == skipSimbol || i3 == skipSimbol)
                        {
                            continue;
                        }
                        Console.Write($"{i1}{i2}{i3} ");
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
