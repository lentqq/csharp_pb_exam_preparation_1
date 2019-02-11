using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombination = int.Parse(Console.ReadLine());
            int count = 0;
            string combination = string.Empty;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combination = $"<{i}-{j}>";
                    count++;
                    if (count <= maxCombination)
                    {
                        Console.Write(combination);
                    }
                }
            }
        }
    }
}
