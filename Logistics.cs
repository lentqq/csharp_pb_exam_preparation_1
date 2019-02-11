using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numCargo = int.Parse(Console.ReadLine());
            double busPriceTransportForTon = 200.00;
            double truckPriceTransportForTon = 175.00;
            double trainPriceTransportForTon = 120.00;
            double busPriceTransoprt = 0.00;
            double truckPriceTransport = 0.00;
            double trainPriceTransport = 0.00;
            double sumAllCargos = 0.00;
            double busSumCargo = 0.00;
            double truckSumCargo = 0.00;
            double trainSumCargo = 0.00;

            for (int i = 1; i <= numCargo; i++)
            {
                double weightCargo = double.Parse(Console.ReadLine());
                sumAllCargos += weightCargo;
                if (weightCargo <= 3)
                {
                    busSumCargo += weightCargo;
                    busPriceTransoprt = busSumCargo * busPriceTransportForTon;
                }
                else if (weightCargo >= 4 && weightCargo <= 11)
                {
                    truckSumCargo += weightCargo;
                    truckPriceTransport = truckSumCargo * truckPriceTransportForTon;
                }
                else if (weightCargo >= 12)
                {
                    trainSumCargo += weightCargo;
                    trainPriceTransport = trainSumCargo * trainPriceTransportForTon;
                }
            }
            double averagePriceTon = (busPriceTransoprt + truckPriceTransport + trainPriceTransport) / sumAllCargos;
            double busPercentWeigth = busSumCargo / sumAllCargos * 100;
            double truckPercentWeigth = truckSumCargo / sumAllCargos * 100;
            double trainPercentWeigth = trainSumCargo / sumAllCargos * 100;
            Console.WriteLine($"{averagePriceTon:f2}");
            Console.WriteLine($"{busPercentWeigth:0.00}%");
            Console.WriteLine($"{truckPercentWeigth:0.00}%");
            Console.WriteLine($"{trainPercentWeigth:0.00}%");
            //Console.WriteLine("{0:P}", busPercentWeigth);
            //Console.WriteLine("{0:P}", truckPercentWeigth);
            //Console.WriteLine("{0:P}", trainPercentWeigth);
        }
    }
}
