using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    class Class1
    {
        public void myfunc( int num01)
        {
            
            int newnum = num01 / 2;
            Console.Write("Your number divided by 2 is: " + newnum);
               
        }

        public void myfunc2(out int num02)
        {
            num02 = 0;
            num02 = num02 + 10;
            Console.Write("out is one way, it sends data back from the callee to the caller and any data from the caller is discarded" + num02 );
        }

        public static void add(int x , int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }

        public static void add(string x , string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }

        public static void add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
