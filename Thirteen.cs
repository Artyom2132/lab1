using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Thirteen
    {
        public bool equalNum(int x)
        {
            int firstDigit = x % 10;
            x = x / 10;

            while (x > 0)
            {
                int currentDigit = x % 10;
                if (currentDigit != firstDigit)
                    return false;
                x = x / 10;
            }

            return true;
        }
        
    }
}
