using System;

namespace FelineCalculator.Felines
{
    class Tiger : ICanClimb, ICanSwim, ICanCamo
    {
        public void Camoflaging()
        {
            Console.WriteLine("Tiger is camoflaging");
        }

        public void Climb()
        {
            Console.WriteLine("Tiger is climbing");
        }

        public void Swim()
        {
            Console.WriteLine("Tiger is swimming");
        }
    }
}
