using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_369
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);  //  prints the current date time           
            Console.WriteLine("Please enter a number");  //asks the user for a number
            int userinput = Convert.ToInt32(Console.ReadLine()); // assigns user input to variable
            var futuretime = DateTime.Now.AddHours(userinput); //  adds hours input by the user to the current time and assigns the value to a variable
            Console.WriteLine("the exact time it will be in " + userinput + " hours will be " + futuretime); // console writes the new time
            Console.ReadLine(); //booyah!
        }
    }
}
