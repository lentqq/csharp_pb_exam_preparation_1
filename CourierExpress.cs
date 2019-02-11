using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CourierExpress
{
    class CourierExpress
    {
        static void Main(string[] args)
        {
            double weightOfShipmentKg = double.Parse(Console.ReadLine());
            string typeService = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double priceOfShipment = 0;
            double priceOfKm = 0;
            double totalPrice = 0;
            if (typeService == "standard")
            {
                if (weightOfShipmentKg < 1)
                {
                    priceOfKm = 0.03;
                    totalPrice = distance * priceOfKm;
                }
                else if (weightOfShipmentKg >= 1 && weightOfShipmentKg <= 10)
                {
                    priceOfKm = 0.05;
                    totalPrice = distance * priceOfKm;
                }
                else if (weightOfShipmentKg >= 11 && weightOfShipmentKg <= 40)
                {
                    priceOfKm = 0.10;
                    totalPrice = distance * priceOfKm;
                }
                else if (weightOfShipmentKg >= 41 && weightOfShipmentKg <= 90)
                {
                    priceOfKm = 0.15;
                    totalPrice = distance * priceOfKm;
                }
                else if (weightOfShipmentKg >= 91 && weightOfShipmentKg <= 150)
                {
                    priceOfKm = 0.20;
                    totalPrice = distance * priceOfKm;
                }
            }
            else if (typeService == "express")
            {
                double overCharge = 0;

                if (weightOfShipmentKg < 1)
                {
                    overCharge = 0.80 * 0.03 * weightOfShipmentKg;
                    priceOfShipment = overCharge * distance;
                    totalPrice = priceOfShipment + (distance * 0.03);
                }
                else if (weightOfShipmentKg >= 1 && weightOfShipmentKg <= 10)
                {
                    overCharge = 0.40 * 0.05 * weightOfShipmentKg;
                    priceOfShipment = overCharge * distance;
                    totalPrice = priceOfShipment + (distance * 0.05);
                }
                else if (weightOfShipmentKg >= 11 && weightOfShipmentKg <= 40)
                {
                    overCharge = 0.05 * 0.10 * weightOfShipmentKg;
                    priceOfShipment = overCharge * distance;
                    totalPrice = priceOfShipment + (distance * 0.10);
                }
                else if (weightOfShipmentKg >= 41 && weightOfShipmentKg <= 90)
                {
                    overCharge = 0.02 * 0.15 * weightOfShipmentKg;
                    priceOfShipment = overCharge * distance;
                    totalPrice = priceOfShipment + (distance * 0.15);
                }
                else if (weightOfShipmentKg >= 91 && weightOfShipmentKg <= 150)
                {
                    overCharge = 0.01 * 0.20 * weightOfShipmentKg;
                    priceOfShipment = overCharge * distance;
                    totalPrice = priceOfShipment + (distance * 0.20);
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {weightOfShipmentKg:f3} kg. would cost {totalPrice:f2} lv.");
        }
    }
}

