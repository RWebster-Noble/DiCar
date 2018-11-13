using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestEngine
	{
		private Engine _engine;

		[SetUp]
		public void SetUp()
		{
			var mockGearbox = new Mock<IGearbox>(MockBehavior.Strict);
			_engine = new Engine(mockGearbox.Object);
		}

		[Test]
		public void Test_Engine()
		{
			Assert.IsNotNull(_engine);
		}
	}
}
