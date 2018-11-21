using DiCar;
using System;
using System.Drawing;

namespace DiCarConsole
{
	class Program
	{
		static void Main(string[] args)
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
