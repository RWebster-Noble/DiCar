using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DiCarTests
{
	[TestFixture]
	public class TestGearbox
	{
		private Gearbox _gearbox;

		[SetUp]
		public void SetUp()
		{
			var mockGearstick = new Mock<IGearstick>(MockBehavior.Strict);
			_gearbox = new Gearbox(mockGearstick.Object);
		}

		[Test]
		public void Test_Gearbox()
		{
			Assert.IsNotNull(_gearbox);
		}
	}
}
