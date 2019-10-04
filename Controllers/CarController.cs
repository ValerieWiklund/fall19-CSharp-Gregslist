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
            Console.Clear();
            switch (choice)
            {
                case "q":
                    Environment.Exit(1);
                    break;
                default:
                    if (int.TryParse(choice, out int index))
                    {
                        //print car details
                        _carService.GetCars(index - 1);
                        Print();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid Command!");
                        Console.Beep();
                    }
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
            System.Console.WriteLine();

        }
    }
}