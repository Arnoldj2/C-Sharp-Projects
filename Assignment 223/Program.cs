using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to perform some math operations");
            int number = Convert.ToInt32(Console.ReadLine());
            int ret, ret1, ret2;
            Class1 n = new Class1();


            ret = n.AddFive(number);
            ret1 = n.DivideFive(number);
            ret2 = n.MultiFive(number);


            Console.WriteLine("your number + 5 = " + ret);
            Console.WriteLine("your number / by 5 = " + ret1);
            Console.WriteLine("your number * 5 = " + ret2);
            Console.ReadLine();
        }
    }
}
