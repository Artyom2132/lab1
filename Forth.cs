using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Forth
    {
        public bool isDivisor(int a, int b)
        {
            if ((a % b == 0) || (b % a == 0))
            {
                return true;
            }
            return false;
        }
    }
}
