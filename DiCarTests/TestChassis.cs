using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestChassis
	{
		private Mock<IEngine> _mockEngine;
		private Mock<IBodywork> _mockBodywork;

		private Chassis _chassis;

		[SetUp]
		public void SetUp()
		{
			_mockEngine = new Mock<IEngine>(MockBehavior.Strict);
			_mockEngine.Setup(x => x.Run()).Returns("");

			_mockBodywork = new Mock<IBodywork>(MockBehavior.Strict);
			_mockBodywork.Setup(x => x.Run()).Returns("");

			_chassis = new Chassis(_mockEngine.Object, _mockBodywork.Object);
		}

		[Test]
		public void Test_Bodywork()
		{


			var result = _chassis.Run();


			Assert.AreEqual("r", result);
			_mockEngine.Verify(x => x.Run(), Times.Once);
			_mockBodywork.Verify(x => x.Run(), Times.Once);
		}
	}
}
