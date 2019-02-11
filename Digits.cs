using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int thirdDigit = n % 10;
            int secondDigid = n / 10 % 10;
            int firstDigit = n / 100;
            int row = firstDigit + secondDigid;
            int col = firstDigit + thirdDigit;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigid;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
