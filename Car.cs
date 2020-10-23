using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public List<Car> cars { get; set; }

        public Car(string model, string engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public string Model { get; set; }

        public string Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }
    }
}
