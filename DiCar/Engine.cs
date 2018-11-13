using DiCar.Interfaces;

namespace DiCar
{
	public class Engine : IEngine
	{
		public IGearbox Gearbox { get; }

		public Engine(IGearbox gearbox)
		{
			Gearbox = gearbox;
		}
	}
}