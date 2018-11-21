using System;
using DiCar;

namespace DiCarConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var gearStick = new Gearstick();
            var gearbox = new Gearbox(gearStick);
            var bodyControlModule = new BodyControlModule();
            var engine = new Engine(gearbox, bodyControlModule);

            var car = new Car(engine);

            Console.WriteLine(car.Run());
        }
    }
}