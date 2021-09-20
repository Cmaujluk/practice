using System;

namespace DifferentCarsVariants.Movement
{
    class Fly : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Yoohoo we're flying");
        }
    }
}
