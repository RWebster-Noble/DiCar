using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestCar
	{
	    private Mock<IEngine> _mockEngine;

	    private Car _car;

	    [SetUp]
		public void SetUp()
		{
			_mockEngine = new Mock<IEngine>(MockBehavior.Strict);
			_mockEngine.Setup(x => x.Run()).Returns("");
			_car = new Car(_mockEngine.Object);
		}

		[Test]
		public void Test_Car()
		{


			var result = _car.Run();


			Assert.AreEqual("Vr", result);
			_mockEngine.Verify(x => x.Run(), Times.Once);
		}
	}
}
