using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.VehicleCatalogue
{
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();    

        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public  int HorsePower { get; set; }
    }
    internal class Program
    {

        static void Main()
        {
            Catalog CatalogObject = new Catalog();
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] splitParam = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = splitParam[0];
                string brand = splitParam[1];
                string model = splitParam[2];
                int finalParam = int.Parse(splitParam[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, finalParam);
                    CatalogObject.Cars.Add(newCar);
                }
                if (type == "Truck")
                {
                   Truck newTruck = new Truck(brand, model, finalParam);
                    CatalogObject.Trucks.Add(newTruck);
                }


                command = Console.ReadLine();
            }
            if (CatalogObject.Cars.Count > 0)
            {
                List<Car> orderedCar = CatalogObject.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCar)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if(CatalogObject.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = CatalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();
                

                foreach (Truck truck in orderedTrucks)
                {

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
