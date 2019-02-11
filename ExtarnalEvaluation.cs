using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExternalEvaluation
{
    class ExtarnalEvaluation
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            double numPoorMarks = 0;
            double numStatisfactoryMarks = 0;
            double numGoodMarks = 0;
            double numVeryGoodMsrks = 0;
            double numExcellentMarks = 0;
            for (int i = 1; i <= numStudents; i++)
            {
                double numPointsOfStudents = double.Parse(Console.ReadLine());

                if (numPointsOfStudents > 0 && numPointsOfStudents < 22.5)
                {
                    numPoorMarks++;
                    // percentPoorMarks = numPoorMarks / (numStudents / 100);
                }

                else if (numPointsOfStudents >= 22.5 && numPointsOfStudents < 40.5)
                {
                    numStatisfactoryMarks++;
                    // percentStatisfactoryMarks = numStatisfactoryMarks / (numStudents / 100);
                }
                else if (numPointsOfStudents >= 40.5 && numPointsOfStudents < 58.5)
                {
                    numGoodMarks++;
                    //  percentGoodMarks = numGoodMarks / (numStudents / 100);
                }
                else if (numPointsOfStudents >= 58.5 && numPointsOfStudents < 76.5)
                {
                    numVeryGoodMsrks++;
                    // percentVerygoogMarks = numVeryGoodMsrks / (numStudents / 100);
                }
                else if (numPointsOfStudents >= 76.5 && numPointsOfStudents <= 100)
                {
                    numExcellentMarks++;
                    // percentExcellentMraks = numExcellentMarks / (numStudents / 100);
                }
            }
            double percentPoorMarks = numPoorMarks / (numStudents / 100.00);
            double percentStatisfactoryMarks = numStatisfactoryMarks / (numStudents / 100.00);
            double percentGoodMarks = numGoodMarks / (numStudents / 100.00);
            double percentVerygoogMarks = numVeryGoodMsrks / (numStudents / 100.00);
            double percentExcellentMraks = numExcellentMarks / (numStudents / 100.00);

            Console.WriteLine($"{percentPoorMarks:f2}% poor marks");
            Console.WriteLine($"{percentStatisfactoryMarks:f2}% satisfactory marks");
            Console.WriteLine($"{percentGoodMarks:f2}% good marks");
            Console.WriteLine($"{percentVerygoogMarks:f2}% very good marks");
            Console.WriteLine($"{percentExcellentMraks:f2}% excellent marks");

        }
    }
}
