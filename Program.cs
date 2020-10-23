using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            char character;
            int integer;
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ").ToArray();

                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 3)
                {
                    if (char.TryParse(engineInfo[2], out character))
                    {
                        string engineEfficiency = engineInfo[2];
                        string engineDisplacement = "n/a";
                        Engine engine = new Engine
                        (engineModel, enginePower, engineDisplacement, engineEfficiency);
                        engines.Add(engine);
                    }
                    else if (int.TryParse(engineInfo[2], out integer))
                    {
                        string engineDisplacement = engineInfo[2];
                        string engineEfficiency = "n/a";
                        Engine engine = new Engine
                        (engineModel, enginePower, engineDisplacement, engineEfficiency);
                        engines.Add(engine);
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    string engineDisplacement = engineInfo[2];
                    string engineEfficiency = engineInfo[3];

                    Engine engine = new Engine
                        (engineModel, enginePower, engineDisplacement, engineEfficiency);
                    engines.Add(engine);
                }
                else
                {
                    string engineDisplacement = "n/a";
                    string engineEfficiency = "n/a";

                    Engine engine = new Engine
                        (engineModel, enginePower, engineDisplacement, engineEfficiency);
                    engines.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ").ToArray();

                string carModel = carInfo[0];
                string carEngine = carInfo[1];

                if (carInfo.Length == 3)
                {
                    if (!int.TryParse(carInfo[2], out integer))
                    {
                        string carColor = carInfo[2];
                        string carWeight = "n/a";
                        Car car = new Car
                        (carModel, carEngine, carWeight, carColor);
                        cars.Add(car);
                    }
                    else if (int.TryParse(carInfo[2], out integer))
                    {
                        string carWeight = carInfo[2];
                        string carColor = "n/a";
                        Car car = new Car
                        (carModel, carEngine, carWeight, carColor);
                        cars.Add(car);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    string carWeight = carInfo[2];
                    string carColor = carInfo[3];

                    Car car = new Car(carModel, carEngine, carWeight, carColor);
                    cars.Add(car);
                }
                else
                {
                    string carWeight = "n/a";
                    string carColor = "n/a";
                    Car car = new Car(carModel, carEngine, carWeight, carColor);
                    cars.Add(car);
                }
            }

            foreach (var car in cars)
            {
                if (engines.Any(x => x.Model == car.Engine))
                {

                    Console.Write($"{car.Model}:" +
                                  $"\n  {car.Engine}:");
                    foreach (var engine in engines.Where(x => x.Model == car.Engine))
                    {
                        Console.Write($"\n    Power: {engine.Power}" +
                                      $"\n    Displacement: {engine.Displacement}" +
                                      $"\n    Efficiency: {engine.Efficiency}");
                    }
                    Console.Write($"\n  Weight: {car.Weight}" +
                                  $"\n  Color: {car.Color}");
                }

                Console.WriteLine();
            }
         }
    }
}
