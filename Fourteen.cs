using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Fourteen
    {
        public void leftTriangl(int x)
        {
            for ( int i= 1; i <= x; i++)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }
        }
    }
}
