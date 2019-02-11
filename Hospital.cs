using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= numDays; i++)
            {             
                int patiensOfDays = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    doctors++;
                }
                if (patiensOfDays > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patiensOfDays - doctors;
                }
                else
                {
                    treatedPatients += patiensOfDays;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}

