using System;
using DiCar;

namespace DiCarConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bodyControlModule = new BodyControlModule();
            var gearStick = new Gearstick();
            var gearbox = new Gearbox(gearStick);
            var engine = new Engine(gearbox, bodyControlModule);

            var car = new Car(engine);

            Console.WriteLine(car.Run());
        }
    }
}