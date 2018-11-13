using DiCar.Interfaces;

namespace DiCar
{
	public class Engine : IEngine
	{
		private IGearbox Gearbox { get; }

		public Engine(IGearbox gearbox)
		{
			Gearbox = gearbox;
		}

		public string Run()
		{
			return "o" + Gearbox.Run();
		}
	}
}