namespace _03._Need_for_Speed_III
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split('|');
                string name = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                cars[name] = new Car(name, mileage, fuel);
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split(" : ");
                string cmdType = cmdArg[0];
                string name = cmdArg[1];

                if (cmdType == "Drive")
                {
                    int distance = int.Parse(cmdArg[2]);
                    int fuel = int.Parse(cmdArg[3]);
                    CommandDrive(cars, name, distance, fuel);

                }
                else if (cmdType == "Refuel")
                {
                    int fuel = int.Parse(cmdArg[2]);
                    CommandRefuel(cars, name, fuel);
                }
                else if (cmdType == "Revert")
                {
                    int kilometers = int.Parse(cmdArg[2]);

                    cars[name].Mileage -= kilometers;

                    if (cars[name].Mileage < 10000)
                    {
                        cars[name].Mileage = 10000;
                        continue;
                    }
                    
                    Console.WriteLine($"{name} mileage decreased by {kilometers} kilometers");
                }

            }

            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."
            foreach (KeyValuePair<string, Car> car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }

        private static void CommandRefuel(Dictionary<string, Car> cars, string name, int fuel)
        {
            if (cars[name].Fuel + fuel <= 75)
            {
                cars[name].Fuel += fuel;
                Console.WriteLine($"{name} refueled with {fuel} liters");
            }
            else
            {
                int requiredFuel = 75 - cars[name].Fuel;
                cars[name].Fuel += requiredFuel;
                Console.WriteLine($"{name} refueled with {requiredFuel} liters");
            }
        }

        private static void CommandDrive(Dictionary<string, Car> cars, string name, int distance, int fuel)
        {
            if (cars[name].Fuel >= fuel)
            {
                cars[name].Mileage += distance;
                cars[name].Fuel -= fuel;

                Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                if (cars[name].Mileage >= 100000)
                {
                    cars.Remove(name);
                    Console.WriteLine($"Time to sell the {name}!");
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }
        private static void RevertKilometrage (Dictionary<string, Car> cars, string name, int kilometers)
        {

        }
    }
    public class Car
    {
        public Car(string name, int mileage, int fuel)
        {
            this.Name = name;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Name { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
}
