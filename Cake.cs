using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int withCake = int.Parse(Console.ReadLine());
            int lenghtCake = int.Parse(Console.ReadLine());
            int allPieces = withCake * lenghtCake;
            int takePieces = 0;
            string command = Console.ReadLine();

            while (command != "STOP" && takePieces<=allPieces) //(command != "STOP")
            {
                int cutPieces = int.Parse(command);
                takePieces += cutPieces;

                //if (takePieces > allPieces)
                //{
                //    break;
                //}
                command = Console.ReadLine();

            }
            if (takePieces > allPieces)
            {
                Console.WriteLine($"No more cake left! You need {takePieces - allPieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{allPieces - takePieces} pieces are left.");
            }
        }
    }
}
