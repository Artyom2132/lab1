using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Seven
    {
        public String makeDecision(int a, int b)
        {
            if (a > b)
            {
                return "a > b";
            }
            else if (a < b)
            {
                return "a < b";
            }
            else
            {
                return "a == b";
            }
        }
    }
}
