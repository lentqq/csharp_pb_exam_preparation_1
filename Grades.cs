using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            double sumGrade = 0;
            int excelent = 0;
            int veryGood = 0;
            int good = 0;
            int fail = 0;

            for (int i = 1; i <= numStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrade += grade;

                if (grade < 3)
                {
                    fail++;
                }
                else if (grade < 4)
                {
                    good++;
                }
                else if (grade < 5)
                {
                    veryGood++;
                }
                else
                {
                    excelent++;
                }
            }
            Console.WriteLine($"Top students: {(excelent / (double)numStudents).ToString("0.00%")}");
            Console.WriteLine($"Between 4.00 and 4.99: {(veryGood / (double)numStudents).ToString("0.00%")}");
            Console.WriteLine($"Between 3.00 and 3.99: {(good / (double)numStudents).ToString("0.00%")}");
            Console.WriteLine($"Fail: {(fail / (double)numStudents).ToString("0.00%")}");

            Console.WriteLine($"Average: {(sumGrade / numStudents).ToString("0.00")}");
        }
    }
}
