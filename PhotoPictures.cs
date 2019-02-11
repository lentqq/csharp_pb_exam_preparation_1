using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhotoPictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            int numPictures = int.Parse(Console.ReadLine());
            string sizePictures = Console.ReadLine();
            string typeOrder = Console.ReadLine();
            double orderPrice = 0;


            switch (sizePictures)
            {
                case "9X13":
                    orderPrice = numPictures * 0.16;
                    if (numPictures >= 50)
                        orderPrice = orderPrice - orderPrice * 0.05;
                    break;
                case "10X15":
                    orderPrice = numPictures * 0.16;
                    if (numPictures >= 80)
                        orderPrice = orderPrice - orderPrice * 0.03;
                    break;
                case "13X18":
                    orderPrice = numPictures * 0.38;
                    if (numPictures >= 50 && numPictures <= 100)
                    {
                        orderPrice = orderPrice - orderPrice * 0.03;
                    }
                    if (numPictures > 100)
                    {
                        orderPrice = orderPrice - orderPrice * 0.05;
                    }
                    break;
                case "20X30":
                    orderPrice = numPictures * 2.90;
                    if (numPictures > 10 && numPictures <= 50)
                    {
                        orderPrice = orderPrice - orderPrice * 0.07;
                    }
                    if (numPictures > 50)
                    {
                        orderPrice = orderPrice - orderPrice * 0.09;
                    }
                    break;
            }
            if (typeOrder == "online")
            {
                Console.WriteLine($"{(orderPrice - orderPrice * 0.02):f2}BGN");
            }

            if (typeOrder == "office")
            {
                Console.WriteLine($"{(orderPrice):f2}BGN");
            }
        }
    }
}
