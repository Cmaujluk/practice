using System;

namespace DifferentCarsVariants.Movement
{
    class Rider : IMovable
    {
        public void Move()
        {
            Console.WriteLine("We're Riding!");
        }
    }
}
