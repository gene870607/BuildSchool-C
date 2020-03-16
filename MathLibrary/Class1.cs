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

        public static decimal GetQuotient(this decimal a, decimal b)
        {
            if (a == 0) throw new ArgumentException(); 
            return a / b;
        }

        public static decimal GetPercentage(this decimal a)
        {
            return a / 100;
        }

        public static decimal GetPI()
        {
            return (decimal)Math.PI;
        }

        public static decimal GetE()
        {
            return (decimal)Math.E;
        }

        public static decimal GetTenExp(this decimal a, decimal b)
        {
            return a * (decimal)Math.Pow(10, decimal.ToDouble(b));
        }

        public static decimal Pow(this decimal a, decimal b)
        {
            double _a = decimal.ToDouble(a);
            double _b = decimal.ToDouble(b);
            return (decimal)Math.Pow(_a, _b);
        }

        public static decimal GetFactorial(this decimal a)
        {
            if (a < 0) throw new ArgumentException();
            if (a == 0) return 1;
            decimal _a = decimal.ToInt32(a);
            decimal ans = 1;
            while(_a > 1)
            {
                ans *= _a;
                _a--;
            }
            return ans;
        }

        public static decimal GetSin(this decimal a)
        {
            return (decimal)Math.Sin(decimal.ToDouble(a));
        }

        public static decimal GetCos(this decimal a)
        {
            return (decimal)Math.Cos(decimal.ToDouble(a));
        }

        public static decimal GetTan(this decimal a)
        {
            return (decimal)Math.Tan(decimal.ToDouble(a));
        }

        public static decimal GetLog(this decimal a)
        {
            return (decimal)Math.Log10(decimal.ToDouble(a));
        }

        public static decimal GetLn(this decimal a)
        {
            return (decimal)Math.Log(decimal.ToDouble(a));
        }

        public static decimal GetRoot(this decimal a)
        {
            return (decimal)Math.Sqrt(decimal.ToDouble(a));
        }
    }
}
