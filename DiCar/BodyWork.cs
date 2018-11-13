using DiCar.Interfaces;

namespace DiCar
{
	public class Bodywork : IBodywork
	{
		private IPaint Paint { get; }

		public Bodywork(IPaint paint)
		{
			Paint = paint;
		}

		public string Run()
		{
			return "m" + Paint.Run();
		}
	}
}