using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FriendlyTrip
{
    class FriendlyTrip
    {
        static void Main(string[] args)
        {
            int distanceKm = int.Parse(Console.ReadLine());
            int costsCar100Km = int.Parse(Console.ReadLine());
            double priceFuelPerLiter = double.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double costsCar = distanceKm * (costsCar100Km / 100.0);
            double tottalCosts = costsCar * priceFuelPerLiter;

            if (budget >= tottalCosts)
            {
                Console.WriteLine($"You can take a trip. {budget - tottalCosts:f2} money left.");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {budget / 5.0:f2} money.");
            }

        }
    }
}
