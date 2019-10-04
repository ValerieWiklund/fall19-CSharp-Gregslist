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

        }

        public void GetCars()
        {
            Messages.Add("Available Cars");
            for (int i = 0; i < Cars.Count; i++)
            {
                Car c = Cars[i];
                Messages.Add($"{i + 1}: {c.Make} - {c.Model}");
            }

        }



        public CarService()
        {

        }
    }
}