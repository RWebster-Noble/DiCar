using System.Drawing;
using DiCar.Interfaces;

namespace DiCar
{
	public class Paint : IPaint
	{
		public Color Colour { get; }

		public Paint(Color colour)
		{
			Colour = colour;
		}
	}
}