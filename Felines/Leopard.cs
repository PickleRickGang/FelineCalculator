using System;

namespace FelineCalculator.Felines
{
    class Leopard : ICanClimb, ICanSwim, ICanCamo
    {
        public void Camoflaging()
        {
            Console.WriteLine("Leopard is camoflaging");
        }

        public void Climb()
        {
            Console.WriteLine("Leopard is climbing");
        }

        public void Swim()
        {
            Console.WriteLine("Leopard is swimming");
        }
    }
}
