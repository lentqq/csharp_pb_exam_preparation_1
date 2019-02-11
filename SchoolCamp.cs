using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string kindGroup = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numOverNigth = int.Parse(Console.ReadLine());

            double tottalPrice = 1.00;
            string sport = string.Empty;
            double price = 1.00;

            if (kindGroup == "girls")
            {
                switch (season)
                {
                    case "winter":
                        price = 9.60;
                        sport = "Gymnastics";
                        break;
                    case "spring":
                        price = 7.20;
                        sport = "Athletics";
                        break;
                    case "summer":
                        price = 15.00;
                        sport = "Volleyball";
                        break;
                }
            }
            else if (kindGroup == "boys")
            {
                switch (season)
                {
                    case "winter":
                        price = 9.60;
                        sport = "Judo";
                        break;
                    case "spring":
                        price = 7.20;
                        sport = "Tennis";
                        break;
                    case "summer":
                        price = 15.00;
                        sport = "Football";
                        break;
                }
            }
            else if (kindGroup == "mixed")
            {
                switch (season)
                {
                    case "winter":
                        price = 10.00;
                        sport = "Ski";
                        break;
                    case "spring":
                        price = 9.50;
                        sport = "Cycling";
                        break;
                    case "summer":
                        price = 20.00;
                        sport = "Swimming";
                        break;
                }
            }
            tottalPrice = numStudents * price * numOverNigth;

            if (numStudents >= 50)
            {
                tottalPrice -= tottalPrice * 0.50;
            }
            else if (numStudents >= 20 && numStudents < 50)
            {
                tottalPrice -= tottalPrice * 0.15;
            }
            else if (numStudents >= 10 && numStudents < 20)
            {
                tottalPrice -= tottalPrice * 0.05;
            }
            //else
            //{
            //    tottalPrice = tottalPrice;
            //}
            Console.WriteLine($"{sport} {tottalPrice:f2} lv.");
        }
    }
}
