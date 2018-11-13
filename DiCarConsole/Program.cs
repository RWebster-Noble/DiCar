using DiCar;
using System;
using System.Drawing;

namespace DiCarConsole
{
	class Program
	{
		static void Main()
		{
			var carColour = Color.Black;

			var paint = new Paint(carColour);
			var gearStick = new Gearstick();
			var gearbox = new Gearbox(gearStick);
			var engine = new Engine(gearbox);
			var bodyWork = new Bodywork(paint);
			var chassis = new Chassis(engine, bodyWork);

			var car = new Car(chassis);

			Console.WriteLine(car.Chassis.Engine.Gearbox.Gearstick);
		}
	}
}
