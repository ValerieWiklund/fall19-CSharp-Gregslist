using System;
using gregslist.Services;

namespace gregslist.Controllers
{
    public class CarController
    {
        private CarService _carService { get; set; } = new CarService();
        public void UserInput()
        {
            _carService.GetCars();
            Print();
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "q":
                    Environment.Exit(1);
                    break;

            }
        }

        private void Print()
        {
            foreach (string message in _carService.Messages)
            {
                System.Console.WriteLine(message);
            }
            _carService.Messages.Clear();
            System.Console.WriteLine("Type a number to see details or Q to quit");

        }
    }
}