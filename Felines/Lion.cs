using System;

namespace FelineCalculator.Felines
{
    class Lion : ICanCamo, ICanSocialise, ICanSwim
    {
        public void Camoflaging()
        {
            Console.WriteLine("Lion is camoflaging");
        }

        public void Socialise()
        {
            Console.WriteLine("Lion is socialising");
        }

        public void Swim()
        {
            Console.WriteLine("Lion is swimming");
        }
    }
}
