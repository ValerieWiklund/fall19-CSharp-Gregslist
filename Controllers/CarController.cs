using System;
using gregslist.Services;

namespace gregslist.Controllers
{
    public class CarController
    {
        private CarService _carService { get; set; } = new CarService();
        public void UserInput()
        {
            System.Console.WriteLine("Type a number to see details or Q to quit");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "q":
                    Environment.Exit(1);
                    break;

            }
        }
    }
}