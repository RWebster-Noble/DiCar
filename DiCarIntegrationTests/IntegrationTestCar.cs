using System;
using System.Drawing;
using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using TestBase;

namespace DiCarIntegrationTests
{
    [TestFixture]
    public class IntegrationTestCar : BaseSetup
    {
        private Car _car;

        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            Services.AddSingleton<IGearstick, Gearstick>();
            Services.AddSingleton<IGearbox, Gearbox>();
            Services.AddSingleton<IBodyControlModule, BodyControlModule>();
            Services.AddSingleton<IEngine, Engine>();

            _car = ActivatorUtilities.CreateInstance<Car>(Provider);
        }

        [Test]
        public void Test()
        {
            var result = _car.Run();
            Assert.AreEqual("Vroom!", result);
        }
    }
}
