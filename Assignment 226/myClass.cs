using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_226
{
    class myClass
    {
        public int multi(int x)
        {
            return x * 10;
        }

        public double multi(double x)
        {
            return x + 150;
        }

        public int multi(string x)
        {
            int num1 = Convert.ToInt32(x);
            return num1 + 150;
        }

    }
}
