using System;

namespace DifferentCarsVariants.Drive
{
    class WithoutDriver : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Nobody's here");
        }
    }
}
