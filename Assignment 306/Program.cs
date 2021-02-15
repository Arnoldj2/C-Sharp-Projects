using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_306
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();  // created an object type from IQuittable

            ((Employee)employee).FirstName = "Sample";
            ((Employee)employee).LastName = "Student";

            employee.Quit(); //calling quit method 


            Console.ReadLine();

        }
    }
}
