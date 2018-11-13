using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestEngine
	{
		private Mock<IGearbox> _mockGearbox;

		private Engine _engine;

		[SetUp]
		public void SetUp()
		{
			_mockGearbox = new Mock<IGearbox>(MockBehavior.Strict);
			_mockGearbox.Setup(x => x.Run()).Returns("");

			_engine = new Engine(_mockGearbox.Object);
		}

		[Test]
		public void Test_Engine()
		{


			var result = _engine.Run();


			Assert.AreEqual("o", result);
			_mockGearbox.Verify(x => x.Run(), Times.Once);
		}
	}
}
