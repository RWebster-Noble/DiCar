using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using TestBase;

namespace DiCarTests
{
	[TestFixture]
	public class TestCar : BaseSetup
	{
	    private Car _car;

	    [SetUp]
	    protected override void SetUp()
		{
            base.SetUp();
		    _car = ActivatorUtilities.CreateInstance<Car>(Provider);
		}

		[Test]
		public void Test_Car()
		{


			var result = _car.Run();


			Assert.AreEqual("Vr", result);
			MockEngine.Verify(x => x.Run(), Times.Once);
		}
	}
}
