using DiCar.Interfaces;

namespace DiCar
{
	public class Chassis : IChassis
	{
		private IEngine Engine { get; }
		private IBodywork Bodywork { get; }

		public Chassis(IEngine engine, IBodywork bodywork)
		{
			Engine = engine;
			Bodywork = bodywork;
		}

		public string Run()
		{
			return "r" + Engine.Run() + Bodywork.Run();
		}
	}
}