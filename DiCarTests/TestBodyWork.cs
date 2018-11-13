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
		private Bodywork _bodywork;

		[SetUp]
		public void SetUp()
		{
			var mockPaint = new Mock<IPaint>(MockBehavior.Strict);
			_bodywork = new Bodywork(mockPaint.Object);
		}

		[Test]
		public void Test_Bodywork()
		{
			Assert.IsNotNull(_bodywork);
		}
	}
}
