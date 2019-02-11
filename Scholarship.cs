using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double incomesBGN = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialScolarship = 0;
            double scolarshipForExcellentResult = 0;

            if (incomesBGN < minSalary && averageGrade > 4.5)
            {
                socialScolarship = 0.35 * minSalary;
            }
            if (averageGrade >= 5.5)
            {
                scolarshipForExcellentResult = averageGrade * 25;
            }
            if (socialScolarship == 0 && scolarshipForExcellentResult == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScolarship > scolarshipForExcellentResult)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScolarship)} BGN");
            }
            else
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scolarshipForExcellentResult)} BGN");
            }
        }
    }
}
