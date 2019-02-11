using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class TheSongOfTheWheels
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int counter = 0;
            string password = string.Empty;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    if (a < b)
                    {
                        {
                            for (int c = 1; c <= 9; c++)
                            {
                                for (int d = 1; d <= 9; d++)
                                {
                                    if (c > d)
                                    {

                                        if ((a * b + c * d) == M)
                                        {
                                            Console.Write($"{a}{b}{c}{d} ");
                                            counter++;
                                            if (counter == 4)
                                            {
                                                password = $"{a}{b}{c}{d}";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (password != "")
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
    
