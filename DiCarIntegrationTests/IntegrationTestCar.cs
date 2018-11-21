using DiCar;
using NUnit.Framework;

namespace DiCarIntegrationTests
{
    [TestFixture]
    public class IntegrationTestCar
    {
        private Car _car;

        [SetUp]
        public void SetUp()
        {
            var gearstick = new Gearstick();
            var gearbox = new Gearbox(gearstick);
            var bodyControlModule = new BodyControlModule();
            var engine = new Engine(gearbox, bodyControlModule);

            _car = new Car(engine);
        }

        [Test]
        public void Test()
        {
            var result = _car.Run();
            Assert.AreEqual("Vroom!", result);
        }
    }
}