using System;
using System.Collections.Generic;

namespace Exams2
{
    class Book : Product
    {
        public override double computeTax(){
            return price * 5 / 100;
        }
    }
}