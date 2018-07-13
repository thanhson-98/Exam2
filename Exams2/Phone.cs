using System;
using System.Collections.Generic;

namespace Exams2
{
    class Phone : Product
    {
        public override double computeTax()
        {
            return price * 10 / 100;
        }
    }

}