using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Number_Generator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            for (int m = M; m > 0; m--)
            {
                for (int n = N; n > 0; n--)
                {
                    for (int l = L; l > 0; l--)
                    {
                        int mnl = m * 100 + n * 10 + l;

                        if (mnl % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (l == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (mnl % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= controlNum)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNum}.");
                            return;                          
                        }
                    } 
                }              
            }
            Console.WriteLine($"No! {specialNum} is the last reached special number.");
        }
    }
}
