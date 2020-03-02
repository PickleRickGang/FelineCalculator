using System;
using System.Collections.Generic;
using System.Text;

namespace FelineCalculator
{
    class Lynx : ICanClimb, ICanSwim
    {
        void ICanClimb.Climb()
        {
            throw new NotImplementedException();
        }

        void ICanSwim.Swim()
        {
            throw new NotImplementedException();
        }
    }
}
