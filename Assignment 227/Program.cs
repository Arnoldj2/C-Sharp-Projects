using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_227
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 n = new Class1();
            int ret;

            Console.WriteLine("Enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a second number, this can be left blank if you so choose");
            
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))  // What im doing here is trying to parse the string as an integer because if i used something like "int number2 = Convert.ToInt32(Console.ReadLine()); "
                                                // and if user leaves that blank instead of putting in a number  i get the error “Cannot convert null to ‘int’ because it is a non-nullable value type.”  

            {
                ret = n.calc(number1, value);
            }

            else
            {
                ret = n.calc(number1);
            }


         


            Console.WriteLine("Area is:" + ret);
            Console.ReadLine();


        }
    }
}
