using DiCar.Interfaces;

namespace DiCar
{
    public class Gearbox : IGearbox
    {
        private IGearstick Gearstick { get; }

        public Gearbox(IGearstick gearstick)
        {
            Gearstick = gearstick;
        }

        public string Run()
        {
            return "m" + Gearstick.Run();
        }
    }
}