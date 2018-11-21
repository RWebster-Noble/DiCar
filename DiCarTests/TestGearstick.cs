using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using TestBase;

namespace DiCarTests
{
    [TestFixture]
    public class TestGearstick : BaseSetup
    {
        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            Services.AddSingleton<IGearstick, Gearstick>();
        }

        [Test]
        public void Test_Gearstick()
        {
            var result = Gearstick.Run();

            Assert.AreEqual("!", result);
        }
    }
}