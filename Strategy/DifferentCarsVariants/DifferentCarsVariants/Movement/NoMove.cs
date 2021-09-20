using System;

namespace DifferentCarsVariants.Movement
{
    class NoMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("I'm just standing");
        }
    }
}
