using DiCar.Interfaces;

namespace DiCar
{
	public class Gearbox : IGearbox
	{
		public IGearstick Gearstick { get; }

		public Gearbox(IGearstick gearstick)
		{
			Gearstick = gearstick;
		}
	}
}