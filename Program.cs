using System;
using gregslist.Controllers;

namespace gregslist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            CarController cc = new CarController();
            while (true)
            {
                cc.UserInput();
            }
        }
    }
}
