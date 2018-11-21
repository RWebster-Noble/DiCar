using DiCar;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using TestBase;

namespace DiCarTests
{
    [TestFixture]
    public class TestEngine : BaseSetup
    {
        [SetUp]
        protected override void SetUp()
        {
            base.SetUp();
            Services.AddSingleton<IEngine, Engine>();
        }

        [Test]
        public void Test_Engine()
        {
            var result = Engine.Run();

            Assert.AreEqual("oo", result);
            MockGearbox.Verify(x => x.Run(), Times.Once);
        }
    }
}