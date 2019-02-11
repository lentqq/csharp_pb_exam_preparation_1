using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Salary
{
    class Salary
    {
        static void Main(string[] args)
        {
            double basicSalary = double.Parse(Console.ReadLine());
            int workingExperience = int.Parse(Console.ReadLine());
            string sindicateMember = Console.ReadLine().ToLower();
            int leftYears = 0;
            for (int i = 1; i <= workingExperience; i++)
            {
                basicSalary = basicSalary + basicSalary * 0.06;

                if (i % 10 == 5)
                {
                    basicSalary += 100;
                }
                else if (i % 10 == 0)
                {
                    basicSalary += 200;
                }
                else if (sindicateMember == "yes" && i % 10 != 5 && i % 10 != 0)
                {
                    basicSalary = (basicSalary + basicSalary * 0.06) - basicSalary * 0.01;
                }
                if (basicSalary >= 5000)
                {
                    basicSalary = 5000;
                    Console.WriteLine($"Current salary:{basicSalary:f2}");
                    Console.WriteLine($"0 more years to max salary.");
                    return;
                }
            }
            Console.WriteLine($"Current salary:{basicSalary:f2}");
            for (int i = workingExperience ; i <= 45; i++)
            {
                basicSalary = basicSalary + basicSalary * 0.06;

                if (i % 10 == 5)
                {
                    basicSalary += 100;
                }
                else if (i % 10 == 0)
                {
                    basicSalary += 200;
                }
                else if (sindicateMember == "yes" && i % 10 != 5 && i % 10 != 0)
                {
                    basicSalary = (basicSalary + basicSalary * 0.06) - basicSalary * 0.01;
                }
                leftYears++;
                if (basicSalary >= 5000)
                {
                    break;
                }
            }
            Console.WriteLine($"{ leftYears - 1} more years to max salary.");
        }
    }
}
