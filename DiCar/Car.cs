using DiCar.Interfaces;

namespace DiCar
{
    public class Car
    {
        public IEngine Engine { get; }

        public Car(IEngine engine)
        {
            Engine = engine;
        }

        public string Run()
        {
            return "Vr" + Engine.Run();
        }
    }
}