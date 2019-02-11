using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double cinauans = double.Parse(Console.ReadLine());
            double percentComision = double.Parse(Console.ReadLine());

            double bitcoin = 1168.00;
            double cinauan = 0.15;
            double USD = 1.76;
            double euro = 1.95;

            double changeBitcoin = bitcoins * bitcoin;
            double changeUan = cinauans * cinauan;
            double changeUSD = changeUan * USD;
            double changeEuro = (changeBitcoin + changeUSD) / euro;
            double comision = (percentComision / 100.00) * changeEuro;
            double totalSum = changeEuro - comision;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
