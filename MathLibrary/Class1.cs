using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class MathLibrary
    {   
        public static decimal Add(this decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Minus(this decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Multiple(this decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Divide(this decimal a, decimal b)
        {
            return a / b;
        }
    }
}
