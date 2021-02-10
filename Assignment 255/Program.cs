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
            Employee<string> employee1 = new Employee<string>
            {
                Things = new List<string>()
            };

            employee1.Things.Add("CarKeys");
            employee1.Things.Add("Badge");
            employee1.Things.Add("Wrench");
            employee1.Things.Add("MysteriousTrinket");


            foreach (string item in employee1.Things)
            {
                Console.Write(item);
            }

            Console.ReadLine();

            Employee<int> employee2 = new Employee<int>
            {
                Things = new List<int>()
            };

            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);
            employee2.Things.Add(5);
            employee2.Things.Add(7);


            foreach (int item in employee2.Things)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
