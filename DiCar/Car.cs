using System;
using DiCar.Interfaces;

namespace DiCar
{
	public class Car
	{
		public IChassis Chassis { get; }

		public Car(IChassis chassis)
		{
			Chassis = chassis;
		}

		public string Run()
		{
			return "Vroom!";
		}
	}
}
