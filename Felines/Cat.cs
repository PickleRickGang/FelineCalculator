using System;

namespace FelineCalculator.Felines
{
    class Cat : ICanScratch, ICanPurr
    {
        public void Purr()
        {
            Console.WriteLine("Cat is purring");
        }

        public void Scratch()
        {
            Console.WriteLine("Cat is scratching");
        }
    }
}
