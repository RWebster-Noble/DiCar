using DiCar.Interfaces;

namespace DiCar
{
	public class Chassis : IChassis
	{
		public IEngine Engine { get; }
		public IBodywork Bodywork { get; }

		public Chassis(IEngine engine, IBodywork bodywork)
		{
			Engine = engine;
			Bodywork = bodywork;
		}
	}
}