using System;
using DiCar.Interfaces;

namespace DiCar
{
	public class Car
	{
		private IChassis Chassis { get; }

		public Car(IChassis chassis)
		{
			Chassis = chassis;
		}

		public string Run()
		{
			return "V" + Chassis.Run();
		}
	}
}
