using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Stupid_Passwords_Generator
{
    class StupidPasswordsGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int i2 = 1; i2 < n; i2++)
                {
                    for (char i3 = 'a'; i3 < 'a' + l; i3++)
                    {
                        for (char i4 = 'a'; i4 < 'a' + l; i4++)
                        {
                            int k = Math.Max(i, i2);
                            for (int i5 = k + 1; i5 <= n; i5++)
                            {
                                Console.Write($"{i}{i2}{i3}{i4}{i5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

