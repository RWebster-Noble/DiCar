using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestCar
	{
		private Mock<IChassis> _mockChassis;

		private Car _car;

		[SetUp]
		public void SetUp()
		{
			_mockChassis = new Mock<IChassis>(MockBehavior.Strict);
			_mockChassis.Setup(x => x.Run()).Returns("");
			_car = new Car(_mockChassis.Object);
		}

		[Test]
		public void Test_Car()
		{


			var result = _car.Run();


			Assert.AreEqual("V", result);
			_mockChassis.Verify(x => x.Run(), Times.Once);
		}
	}
}
