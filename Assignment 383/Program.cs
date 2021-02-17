using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_383
{
    class Program
    {
        static void Main(string[] args)
        {
            const string x = "x";  //Create a const variable. 

            var list = new List<int>(Enumerable.Range(1, 10));  //Create a variable using the keyword “var”

            foreach ( int i in list)  // Iterates over the list just to validate functionality using "var" and " const" variables
            {
                Console.WriteLine(i + x);
            }

            //Chain two constructors together.

            Employee A = new Employee();   // here i instantiate a class without parameters 
            Employee B = new Employee(123, "thisguy"); // here i instantiate a class with parameters

            Console.WriteLine(A.id + A.name); ;  //  console write employee A to confirm assigned values ( see employee class )
            Console.WriteLine(B.id + B.name); ; //  console write  employee B to confirm assigned values  ( see employee class )

            Console.ReadLine();


        }
    }
}
