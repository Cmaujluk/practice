using System;

namespace DifferentCarsVariants.Sound
{
    class NoSound : ISoundable
    {
        public void Sound()
        {
            Console.WriteLine("Silence...");
        }
    }
}
