using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_247
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();
            ((Employee)employee).FirstName = "Sample";
            ((Employee)employee).LastName = "Student";

            employee.Quit();
           
          

            Console.ReadLine();
        }
    }
}
