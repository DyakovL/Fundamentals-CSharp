using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatlouge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Catalog catalog = new Catalog();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = command.Split('/');

                string vehicleType = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);

                if (vehicleType == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }
            }

            foreach (var car in catalog.Cars
                .OrderBy(x => x.brea))
            {

            }

            foreach (var truck in catalog.Trucks)
            {

            }

        }
    }

    public class Catalog
    {
        
        public List<Car> Cars { get; set;}

        public List<Truck> Trucks { get; set;}
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        string Brand {get;set;}
        string Model {get;set;}
        int HorsePower {get;set;}

    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        string Brand {get;set;}
        string Model {get;set;}
        int Weight {get;set;}

    }
}
