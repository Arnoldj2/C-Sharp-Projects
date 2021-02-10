using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_255
{
    class Program
    {
        static void Main(string[] args)
        {

            // Make the Employee class take a generic type parameter.
            // Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
            //  Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
            // Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
            // Create a loop that prints all of the Things to the Console


            Employee<int> employee = new Employee<int>();
            employee.Things = new List<int>() {1, 3, 5, 7, 11 };
            
            

            foreach (int item in Things)
            {
                Console.Write(item);
            }
        }
    }
}
