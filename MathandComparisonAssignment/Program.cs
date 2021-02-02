using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int hourly1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week?");
            int worked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int hourly2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week?");
            int worked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:");
            int annual1 = hourly1 * worked1 * 52;
            Console.WriteLine(annual1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:");
            int annual2 = hourly2 * worked2 * 52;
            Console.WriteLine(annual2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();


            bool compare = annual1 > annual2;
            Console.Write(compare.ToString());
            Console.ReadLine();
        }
    }
}
