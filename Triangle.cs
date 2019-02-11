using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b + c || b > a + c || c > a + b)
            {
                Console.WriteLine($"There is no triangle with sides {a}, {b} and {c}.");
            }
            else if (a < b + c && b < a + c && c < a + b && a == b && b == c && c == a)
            {
                Console.WriteLine($"Triangle with sides {a}, {b} and {c} is equilateral.");
            }
            else if (a < b + c && b < a + c && c < a + b && a == b || a == c || b == c)
            {
                Console.WriteLine($"Triangle with sides {a}, {b} and {c} is isosceles.");
            }
            else if (a < b + c && b < a + c && c < a + b && a != b && b != c && c != a)
            {
                Console.WriteLine($"Triangle with sides {a}, {b} and {c} is scalene.");
            }         
        }
    }
}
