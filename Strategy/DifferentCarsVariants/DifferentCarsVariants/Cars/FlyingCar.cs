using DifferentCarsVariants.Drive;
using DifferentCarsVariants.Movement;
using DifferentCarsVariants.Sound;

namespace DifferentCarsVariants.Cars
{
    class FlyingCar : CarBase
    {
        public FlyingCar(string name)
        {
            Name = name;
            Movement = new Fly();
            Driving = new DriverDriving();
            Sounds = new ReactiveEngineSound();
        }
    }
}
