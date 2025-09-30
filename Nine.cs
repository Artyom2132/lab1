using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Nine
    {
        public String age(int x)
        {
            if ((x % 10 == 1) && (x != 11))
            {
                return $"{x} год";
            }
            else if ((2 <= x % 10 && x % 10 <= 4) && (x != 11) && (x != 12) && (x != 13) && (x != 14))
            {
                return $"{x} года";
            }
            else
            {
                return $"{x} лет";
            }
        }
    }
}
