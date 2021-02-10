using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_261
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
            Console.WriteLine("Enter the current date of the week. . .");

            string inputday = Console.ReadLine();

            Days day = (Days)Enum.Parse(typeof(Days), inputday);
              
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

        public enum Days
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
