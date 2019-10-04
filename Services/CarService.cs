using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Services
{
    public class CarService
    {
        public List<Car> Cars { get; private set; }
        public List<string> Messages { get; set; }

        public void Setup()
        {
            Car ford = new Car("Ford", "F350", 2019, "leather seats and all the bells and whistles", 50000.89);
            Car honda = new Car("Honda", "Civic", 1989, "how dare you", 1000);
            Car toyota = new Car("Toyota", "Tacoma", 2011, "full of trash", 12000);
            Car tracker = new Car("Darryl", "Frankenstein", 1989, "mostly a tracker", 1000000);
            Cars.AddRange(new Car[] { ford, honda, toyota, tracker });
        }

        internal void GetCars(int index)
        {
            if (index < Cars.Count && index > -1)
            {

                Messages.Add($@"
                Make: {}
                ");
            }
            else
            {
                Messages.Add("Invalid Choice... Dummy!");

            }
        }

        public void GetCars()
        {
            Messages.Add("Available Cars");
            for (int i = 0; i < Cars.Count; i++)
            {
                Car c = Cars[i];
                Messages.Add($"{i + 1}: {c.Make} - {c.Model}");
            }
            Messages.Add("Type a number to see details or Q to quit");
        }

        public CarService()
        {
            Messages = new List<string>();
            Cars = new List<Car>();
            Setup();
        }
    }
}