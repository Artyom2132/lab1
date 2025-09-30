using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Twelve
    {
        public int pow(int x,int y)
        {
            int c = x * 1;
            for (int i = 1; i != y; i++)
            {
                c *= x;
            }
            return c;
        }
    }
}
