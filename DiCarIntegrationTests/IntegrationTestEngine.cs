﻿using System;
using System.Drawing;
using DiCar;
using NUnit.Framework;

namespace DiCarIntegrationTests
{
    [TestFixture]
    public class IntegrationTestEngine
    {
        private Engine _engine;

        [SetUp]
        public void SetUp()
        {
            var gearstick = new Gearstick();
            var gearbox = new Gearbox(gearstick);
            var bodyControlModule = new BodyControlModule();
            _engine = new Engine(gearbox, bodyControlModule);
        }

        [Test]
        public void Test()
        {
            Assert.Pass();
        }
    }
}