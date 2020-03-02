using System;

namespace FelineCalculator.Felines
{
    class Lynx : ICanClimb, ICanSwim
    {
        void Climb()
        {
            Console.WriteLine("Lynx is climbing");
        }

        void Swim()
        {
            Console.WriteLine("Lynx is swimming");
        }
    }
}
