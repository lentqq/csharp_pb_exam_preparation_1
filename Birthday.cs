using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = (lenght * width * heigth) * 0.001;
            double remainVolume = volume - (volume * percent / 100);

           // Console.WriteLine($"{(remainVolume).ToString("0.000")}");
            Console.WriteLine($"{(remainVolume):f3}");
        }
    }
}
