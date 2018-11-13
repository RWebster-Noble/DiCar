using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DiCarTests
{
	[TestFixture]
	public class TestBodywork
	{
		private Mock<IPaint> _mockPaint;

		private Bodywork _bodywork;

		[SetUp]
		public void SetUp()
		{
			_mockPaint = new Mock<IPaint>(MockBehavior.Strict);
			_mockPaint.Setup(x => x.Run()).Returns("");

			_bodywork = new Bodywork(_mockPaint.Object);
		}

		[Test]
		public void Test_Bodywork()
		{


			var result = _bodywork.Run();


			Assert.AreEqual("m", result);
			_mockPaint.Verify(x=>x.Run(), Times.Once);
		}
	}
}
