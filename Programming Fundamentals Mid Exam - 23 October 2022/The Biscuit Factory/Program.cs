using System;
using System.Numerics;

namespace The_Biscuit_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte biscuitsPerWorker = byte.Parse(Console.ReadLine());
            short workerCount = short.Parse(Console.ReadLine());
            ulong competingFactoryBiscouits = ulong.Parse(Console.ReadLine());

            int biscuitsPerDay = biscuitsPerWorker * workerCount;
            float everyThirdDay =  (float)Math.Floor(biscuitsPerDay * 0.75);
            float fullBuiscuitsCount = (biscuitsPerDay * 20) + (everyThirdDay * 10);


            Console.WriteLine($"You have produced {fullBuiscuitsCount} biscuits for the past month.");

            if (fullBuiscuitsCount > competingFactoryBiscouits)
            {
                float percentage = ((fullBuiscuitsCount - competingFactoryBiscouits) / competingFactoryBiscouits) * 100;

                Console.WriteLine($"You produce {percentage:F2} percent more biscuits.");
            }
            else
            {
                float percentage = (float)Math.Abs((fullBuiscuitsCount - competingFactoryBiscouits) / competingFactoryBiscouits) * 100;
                Console.WriteLine($"You produce {percentage: F2} percent less biscuits.");
            }

        }
    }
}
