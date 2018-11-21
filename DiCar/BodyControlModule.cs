using System;
using System.Collections.Generic;
using System.Text;
using DiCar.Interfaces;

namespace DiCar
{
    public class BodyControlModule : IBodyControlModule
    {
        public bool InteriorTrimLightsOn { get; set; }
    }
}
