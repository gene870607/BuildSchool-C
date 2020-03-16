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

        public static decimal getQuotient(this decimal a, decimal b)
        {
            if (a == 0) throw new ArgumentException(); 
            return a / b;
        }

        public static decimal getReminder(this decimal a, decimal b)
        {
            if (a == 0) throw new ArgumentException();
            bool negative = false;
            if (a > 0 ^ b > 0) negative = true;
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;
            decimal ans = 0;

            while(a - b > 0)
            {
                a -= b;
                ans++;
            }
            return (negative)? ans * -1  : ans;
        }


    }
}
