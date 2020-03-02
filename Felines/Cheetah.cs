using System;

namespace FelineCalculator.Felines
{
    class Cheetah : ICanClimb, ICanSwim
    {
        public void Climb()
        {
            Console.WriteLine("Cheetah is climbing");
        }

        public void Swim()
        {
            Console.WriteLine("Cheetah is swim");
        }
    }
}
