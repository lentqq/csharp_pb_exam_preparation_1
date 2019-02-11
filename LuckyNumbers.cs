using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LuckyNumbers
{
    class LuckyNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            string num = ($"{i}{i2}{i3}{i4}");
                            if (i + i2 == i3 + i4 && n % (i + i2) == 0)
                            {
                                Console.Write($"{num} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
