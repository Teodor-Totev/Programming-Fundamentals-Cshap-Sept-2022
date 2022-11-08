namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            int carCount = 0;
            int truckCount = 0;
            double truckHp = 0;
            double carHp = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(" ");

                string type = cmdArg[0];
                string model = cmdArg[1];
                string color = cmdArg[2];
                int horsePower = int.Parse(cmdArg[3]);

                Vehicle currVehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(currVehicle);

                if (type == "car")
                {
                    carHp += horsePower;
                    carCount++;
                }
                else
                {
                    truckHp += horsePower;
                    truckCount++;
                }
            }
            double avrCarHp = carHp / carCount;
            double avrTruckHp = truckHp / truckCount;
            if (carCount == 0)
            {
                avrCarHp = 0;
            }
            if (truckCount == 0)
            {
                avrTruckHp = 0;
            }

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == command)
                    {
                        if (vehicle.Type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        }

                    }
                }
            }
            
            Console.WriteLine($"Cars have average horsepower of: {avrCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrTruckHp:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; private set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
