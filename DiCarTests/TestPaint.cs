using System.Drawing;
using DiCar;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestPaint
	{
		private Paint _paint;

		[SetUp]
		public void SetUp()
		{
			_paint = new Paint(Color.Blue);
		}

		[Test]
		public void Test_Paint()
		{
			Assert.IsNotNull(_paint);
			Assert.AreEqual(Color.Blue, _paint.Colour);
		}
	}
}
