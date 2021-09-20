using DifferentCarsVariants.Drive;
using DifferentCarsVariants.Movement;
using DifferentCarsVariants.Sound;

namespace DifferentCarsVariants.Cars
{
    class CarBase
    {
        protected string name;
        protected IMovable Movement;
        protected ISoundable Sounds;
        protected IDrivable Driving;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public CarBase()
        {
            Movement = new Rider();
            Sounds = new EngineSound();
            Driving = new DriverDriving();
        }

        public void SetMovement(IMovable movement)
        {
            Movement = movement;
        }

        public void SetSound(ISoundable sounds)
        {
            Sounds = sounds;
        }

        public void SetDriving(IDrivable driving)
        {
            Driving = driving;
        }

        public CarBase(IMovable movement, ISoundable sounds, IDrivable driving)
        {
            Movement = movement;
            Sounds = sounds;
            Driving = driving;
        }

        public void Simulate()
        {
            Movement.Move();
            Sounds.Sound();
            Driving.Drive();
        }
    }
}
