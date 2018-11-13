using DiCar.Interfaces;

namespace DiCar
{
	public class Bodywork : IBodywork
	{
		public IPaint Paint { get; }

		public Bodywork(IPaint paint)
		{
			Paint = paint;
		}
	}
}