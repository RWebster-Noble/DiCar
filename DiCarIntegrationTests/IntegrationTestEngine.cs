using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using TestBase;

namespace DiCarIntegrationTests
{
    [TestFixture]
    public class IntegrationTestEngine : BaseSetup
    {
        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            Services.AddSingleton<IGearstick, Gearstick>();
            Services.AddSingleton<IGearbox, Gearbox>();
            Services.AddSingleton<IBodyControlModule, BodyControlModule>();
            Services.AddSingleton<IEngine, Engine>();
        }

        [Test]
        public void Test()
        {
            var result = Engine.Run();

            Assert.AreEqual("oom!", result);
        }
    }
}