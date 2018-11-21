using DiCar;
using DiCar.Interfaces;
using Moq;
using NUnit.Framework;

namespace DiCarTests
{
    [TestFixture]
    public class TestEngine
    {
        private Mock<IGearbox> _mockGearbox;
        private Mock<IBodyControlModule> _mockBcm;

        private Engine _engine;

        [SetUp]
        public void SetUp()
        {
            _mockGearbox = new Mock<IGearbox>(MockBehavior.Strict);
            _mockGearbox.Setup(x => x.Run()).Returns("");

            _mockBcm = new Mock<IBodyControlModule>(MockBehavior.Strict);
            _engine = new Engine(_mockGearbox.Object, _mockBcm.Object);
        }

        [Test]
        public void Test_Engine()
        {
            var result = _engine.Run();


            Assert.AreEqual("oo", result);
            _mockGearbox.Verify(x => x.Run(), Times.Once);
        }
    }
}