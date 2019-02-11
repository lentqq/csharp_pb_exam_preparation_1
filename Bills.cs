using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int numMonth = int.Parse(Console.ReadLine());
            double totalElectricityBill = 0.00;
            double water = 20.00;
            double internet = 15.00;
            double otherBill = 0.00;
            double otherBills = 0.00;
            for (int i = 1; i <= numMonth; i++)
            {

                double electricityBill = double.Parse(Console.ReadLine());
                totalElectricityBill += electricityBill;
                double discount = (electricityBill + water + internet) * 0.20;
                otherBill = (electricityBill + water + internet) + discount;
                otherBills += otherBill;
            }
            double waterBill = numMonth * water;
            double internetBill = numMonth * internet;
            double averageBills = (totalElectricityBill + waterBill + internetBill + otherBills) / numMonth;
            Console.WriteLine($"Electricity: {totalElectricityBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {otherBills:f2} lv");
            Console.WriteLine($"Average: {averageBills:f2} lv");
        }
    }
}
