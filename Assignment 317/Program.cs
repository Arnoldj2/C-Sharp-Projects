using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_317
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>  //Instantiate an Employee object with type “string”  as its generic parameter.
            {
                Things = new List<string>()
            };

            employee1.Things.Add("CarKeys");
            employee1.Things.Add("Badge");
            employee1.Things.Add("Wrench");
            employee1.Things.Add("MysteriousTrinket");


            foreach (string item in employee1.Things)  // Created a loop that prints all of the Things to the Console.
            {
                Console.Write(item);
            }

            Console.ReadLine();

            Employee<int> employee2 = new Employee<int>  // Instantiate an Employee object with type “int” as its generic parameter.
            {
                Things = new List<int>()
            };

            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);
            employee2.Things.Add(5);
            employee2.Things.Add(7);


            foreach (int item in employee2.Things)  // Created a loop that prints all of the Things to the Console.
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
