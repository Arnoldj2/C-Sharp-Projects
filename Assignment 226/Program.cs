using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_226
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int ret;
            double ret2;
            int ret3;

            myClass x = new myClass();


            ret = x.multi(10);
            ret2 = x.multi(.5);
            ret3 = x.multi("500");


            Console.WriteLine("10 * 10 = " + ret);
            Console.WriteLine("150 + .5 = " + ret2);
            Console.WriteLine("String value of \"500\"coverted to an into an int + 150 = " + ret3);

            Console.ReadLine();

        }
    }
}
