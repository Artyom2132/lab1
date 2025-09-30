using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Six
    {
        public double safeDiv(int a , int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / (double)b;
        }
    }
}
