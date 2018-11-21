using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestBase;

namespace DiCarTests
{
	[TestFixture]
	public class TestGearbox : BaseSetup
	{
		[SetUp]
		protected override void SetUp()
		{
            base.SetUp();
		    Services.AddSingleton<IGearbox, Gearbox>();
		}

		[Test]
		public void Test_Gearbox()
		{
			var result = Gearbox.Run();

			Assert.AreEqual("m", result);
		}
	}
}
