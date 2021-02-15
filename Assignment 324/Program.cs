using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_324
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current date of the week. . .");   //  Prompts the user to enter the current day of the week

                string inputday = Console.ReadLine();  

                Days day = (Days)Enum.Parse(typeof(Days), inputday);  // assigns the value to variable of the enum data type 

                Console.WriteLine(day + " was found");  


            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");  //ex.message
            }
            finally
            {
                Console.ReadLine();
            }
        }

        public enum Days   //created an enum for the days of the week.
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

