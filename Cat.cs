using System;
using System.Collections.Generic;
using System.Text;

namespace FelineCalculator
{
    class Cat : ICanScratch, ICanPurr
    {
        public void Purr()
        {
            throw new NotImplementedException();
        }

        public void Scratch()
        {
            throw new NotImplementedException();
        }
    }
}
