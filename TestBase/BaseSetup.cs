using System;
using DiCar.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace TestBase
{
    public class BaseSetup
    {
        public Mock<IBodyControlModule> MockBodyControlModule => Provider.GetRequiredService<Mock<IBodyControlModule>>();
        public IBodyControlModule BodyControlModule => Provider.GetRequiredService<IBodyControlModule>();

        public Mock<IEngine> MockEngine => Provider.GetRequiredService<Mock<IEngine>>();
        public IEngine Engine => Provider.GetRequiredService<IEngine>();

        public Mock<IGearbox> MockGearbox => Provider.GetRequiredService<Mock<IGearbox>>();
        public IGearbox Gearbox => Provider.GetRequiredService<IGearbox>();

        public Mock<IGearstick> MockGearstick => Provider.GetRequiredService<Mock<IGearstick>>();
        public IGearstick Gearstick => Provider.GetRequiredService<IGearstick>();


        private ServiceProvider _provider;
        private ServiceCollection _services;


        protected ServiceProvider Provider => _provider ?? (_provider = _services.BuildServiceProvider());

        protected ServiceCollection Services
        {
            get
            {
                _provider = null; // Any existing service provider wont pick up changes to the ServiceCollection, so kill it.
                return _services;
            }
        }

        protected virtual void SetUp()
        {
            _services = new ServiceCollection();
            _provider = null;

            SetupDi();
        }

        private void SetupDi()
        {
            Mock<IBodyControlModule> mockBodyControlModule = null;
            _services.AddSingleton((p) =>
            {
                if (mockBodyControlModule != null)
                    return mockBodyControlModule;
                mockBodyControlModule = new Mock<IBodyControlModule>(MockBehavior.Strict);
                return mockBodyControlModule;
            });
            _services.AddSingleton((p) => p.GetService<Mock<IBodyControlModule>>().Object);

            Mock<IEngine> mockEngine = null;
            _services.AddSingleton((p) =>
            {
                if (mockEngine != null)
                    return mockEngine;
                mockEngine = new Mock<IEngine>(MockBehavior.Strict);
                mockEngine.Setup(x => x.Run()).Returns("");
                return mockEngine;
            });
            _services.AddSingleton((p) => p.GetService<Mock<IEngine>>().Object);

            Mock<IGearbox> mockGearbox = null;
            _services.AddSingleton((p) =>
            {
                if (mockGearbox != null)
                    return mockGearbox;
                mockGearbox = new Mock<IGearbox>(MockBehavior.Strict);
                mockGearbox.Setup(x => x.Run()).Returns("");
                return mockGearbox;
            });
            _services.AddSingleton((p) => p.GetService<Mock<IGearbox>>().Object);

            Mock<IGearstick> mockGearstick = null;
            _services.AddSingleton((p) =>
            {
                if (mockGearstick != null)
                    return mockGearstick;
                mockGearstick = new Mock<IGearstick>(MockBehavior.Strict);
                mockGearstick.Setup(x => x.Run()).Returns("");
                return mockGearstick;
            });
            _services.AddSingleton((p) => p.GetService<Mock<IGearstick>>().Object);
        }
    }
}
