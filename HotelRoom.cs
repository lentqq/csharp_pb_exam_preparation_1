using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numOverNights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = numOverNights * 50.00;
                    if (numOverNights > 7 && numOverNights <= 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.05;
                    }
                    if (numOverNights > 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.30;
                    }
                    apartmentPrice = numOverNights * 65.00;
                    if (numOverNights > 14)
                    {
                        apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = numOverNights * 75.20;
                    if (numOverNights > 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.20;
                    }
                    apartmentPrice = numOverNights * 68.70;
                    if (numOverNights > 14)
                    {
                        apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = numOverNights * 76.00;
                    apartmentPrice = numOverNights * 77.00;
                    if (numOverNights > 14)
                    {
                        apartmentPrice = apartmentPrice - apartmentPrice * 0.10;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {(apartmentPrice):f2} lv.");
            Console.WriteLine($"Studio: {(studioPrice):f2} lv.");
        }
    }
}
