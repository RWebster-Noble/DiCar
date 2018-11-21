using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
    [TestFixture]
    public class TestGearbox
    {
        private Mock<IGearstick> _mockGearstick;

        private Gearbox _gearbox;

        [SetUp]
        public void SetUp()
        {
            _mockGearstick = new Mock<IGearstick>(MockBehavior.Strict);
            _mockGearstick.Setup(x => x.Run()).Returns("");

            _gearbox = new Gearbox(_mockGearstick.Object);
        }

        [Test]
        public void Test_Gearbox()
        {
            var result = _gearbox.Run();

            Assert.AreEqual("m", result);
        }
    }
}