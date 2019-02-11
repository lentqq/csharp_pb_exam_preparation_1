using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Mobileoperator
    {
        static void Main(string[] args)
        {
            string duration = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int numMonth = int.Parse(Console.ReadLine());

            double monthlyFee = 0.00;

            if (duration == "one")
            {
                switch (typeContract)
                {
                    case "Small": monthlyFee = 9.98; break;
                    case "Middle": monthlyFee = 18.99; break;
                    case "Large": monthlyFee = 25.98; break;
                    case "ExtraLarge": monthlyFee = 35.99; break;
                }
            }
            else if (duration == "two")
            {
                switch (typeContract)
                {
                    case "Small": monthlyFee = 8.58; break;
                    case "Middle": monthlyFee = 17.09; break;
                    case "Large": monthlyFee = 23.59; break;
                    case "ExtraLarge": monthlyFee = 31.79; break;
                }
            }
            if (internet == "yes")
            {
                if (monthlyFee <= 10.00)
                {
                    monthlyFee += 5.50;
                }
                else if (monthlyFee <= 30.00)
                {
                    monthlyFee += 4.35;
                }
                else if (monthlyFee > 30.00)
                {
                    monthlyFee += 3.85;
                }
            }
            double sumMonthlyFee = numMonth * monthlyFee;

            if (duration == "two")
            {
                sumMonthlyFee = sumMonthlyFee - sumMonthlyFee * 3.75 / 100;
            }
            Console.WriteLine($"{sumMonthlyFee:f2} lv.");
            // Console.WriteLine($"{sumMonthlyFee:0.00} lv.");
        }
    }
}
