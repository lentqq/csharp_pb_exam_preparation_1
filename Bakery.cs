
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Bakery
{
    class Bakery
    {
        static void Main(string[] args)
        {
            int doughWeightGr = int.Parse(Console.ReadLine());
            int bakeryWeightGr = int.Parse(Console.ReadLine());
            double bakeryPrice = double.Parse(Console.ReadLine());
            int soldBakery = int.Parse(Console.ReadLine());
            int soldSweets = int.Parse(Console.ReadLine());

            double doughKgPrice = 4.00;
            double dailyIncomes = soldBakery * bakeryPrice;
            double needBakeryDough = soldBakery * bakeryWeightGr;
            double leftDough = doughWeightGr - needBakeryDough;
            double newDough = doughWeightGr - leftDough;
            double sweetsPrice = bakeryPrice + (bakeryPrice * 0.25);
            double sweetsWeightGr = bakeryWeightGr - (bakeryWeightGr * 0.20);
            double needSweetsDough = soldSweets * sweetsWeightGr;
            double nightIncomes = soldSweets * sweetsPrice;
            double totalDoghCosts = ((doughWeightGr/1000.0) + (newDough/1000.0)) * doughKgPrice;
            double pureIncome = (dailyIncomes + nightIncomes) - totalDoghCosts;
            double doughUsed = needBakeryDough + needSweetsDough;
            Console.WriteLine($"Pure income: {pureIncome:f2} lv.");
            Console.WriteLine($"Dough used: {Math.Round(doughUsed, 0)} g.");
        }
    }
}
