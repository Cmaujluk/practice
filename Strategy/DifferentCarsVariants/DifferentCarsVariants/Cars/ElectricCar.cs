using DifferentCarsVariants.Drive;
using DifferentCarsVariants.Movement;
using DifferentCarsVariants.Sound;

namespace DifferentCarsVariants.Cars
{
    class ElectricCar : CarBase
    {
        public ElectricCar(string name)
        {
            Name = name;
            Movement = new Rider();
            Driving = new AIDriving();
            Sounds = new SimulationSound();
        }
    }
}
