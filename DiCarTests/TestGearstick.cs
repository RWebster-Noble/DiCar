using DiCar;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestGearstick
	{
		private Gearstick _gearstick;

		[SetUp]
		public void SetUp()
		{
			_gearstick = new Gearstick();
		}

		[Test]
		public void Test_Gearstick()
		{
			Assert.IsNotNull(_gearstick);
		}
	}
}
