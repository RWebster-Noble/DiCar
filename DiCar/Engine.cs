using DiCar.Interfaces;

namespace DiCar
{
    public class Engine : IEngine
    {
        private IGearbox Gearbox { get; }

        public Engine(IGearbox gearbox, IBodyControlModule bodyControlModule)
        {
            Gearbox = gearbox;
        }

        public string Run()
        {
            return "oo" + Gearbox.Run();
        }
    }
}