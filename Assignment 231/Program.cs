using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 n = new Class1();

            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());

            n.myfunc(input);
            Console.Write("\n");

            n.myfunc2(out input);
            Console.Write("\n");

            Class1.add(10, 10);
            
            Class1.add("hey", "guy");
            
            Class1.add(5.5, 6.6);

            Console.ReadLine();
        }
    }
}
