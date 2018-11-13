using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestCar
	{
		private Car _car;

		[SetUp]
		public void SetUp()
		{
			var mockChassis = new Mock<IChassis>(MockBehavior.Strict);
			_car = new Car(mockChassis.Object);
		}

		[Test]
		public void Test_Car()
		{
			Assert.IsNotNull(_car);
		}
	}
}
