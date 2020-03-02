using System;

namespace FelineCalculator.Felines
{
    public class Feline
    {
        public virtual void Talk()
        {
            Console.WriteLine("Feline is talking");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Feline is sleeping");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Feline is eating");
        }

        public virtual void Hunt()
        {
            Console.WriteLine("Feline is hunting");
        }

        public virtual void Jump()
        {
            Console.WriteLine("Feline is jumping");
        }

        public virtual void Run()
        {
            Console.WriteLine("Feline is running");
        }
    }
}
