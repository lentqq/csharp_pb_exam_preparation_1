using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ПлодовиКоктейли
{
    class ПлодовиКоктейли
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string cocktailSize = Console.ReadLine().ToLower();
            int numDrinks = int.Parse(Console.ReadLine());
            double price = 1.00;
            
            if (cocktailSize == "small")
            {
                switch (fruit)
                {
                    case "watermelon": price = 2.00 * 56.00; break;
                    case "mango": price = 2.00 * 36.66; break;
                    case "pineapple": price = 2.00* 42.10; break;
                    case "raspberry": price = 2.00 * 20.00; break;
                }
            }
            else if (cocktailSize == "big")
            {
                switch (fruit)
                {
                    case "watermelon": price = 5.00 * 28.70; break;
                    case "mango": price = 5 * 19.60; break;
                    case "pineapple": price = 5.00 * 24.80; break;
                    case "raspberry": price = 5.00 * 15.20; break;
                }             
            }
            double  totalPrice =price * numDrinks;

            if (totalPrice > 1000)
            {
                totalPrice -= totalPrice * 0.50;
            }
            else if ( totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice -= totalPrice * 0.15;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
