using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
	[TestFixture]
	public class TestChassis
	{
		private Chassis _chassis;

		[SetUp]
		public void SetUp()
		{
			var mockEngine = new Mock<IEngine>(MockBehavior.Strict);
			var mockBodywork = new Mock<IBodywork>(MockBehavior.Strict);

			_chassis = new Chassis(mockEngine.Object, mockBodywork.Object);
		}

		[Test]
		public void Test_Bodywork()
		{
			Assert.IsNotNull(_chassis);
		}
	}
}
