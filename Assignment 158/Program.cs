using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long number = Convert.ToInt64(Console.ReadLine());
            long number1 = number * 50;
            Console.WriteLine("Your number multiplied by 50 = " + number1);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            long number2 = Convert.ToInt64(Console.ReadLine());
            long number3 = number2 + 25;
            Console.WriteLine("Your number plus 25 = " + number3);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            long number4 = Convert.ToInt64(Console.ReadLine());
            double number5 = number4 / 12.5f;
            Console.WriteLine("Your number divided by 12.5 = " + number5);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            long number6 = Convert.ToInt64(Console.ReadLine());
            bool number7 = number6 > 50;
            Console.WriteLine("Your number is greater than 50: " + number7.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            long number8 = Convert.ToInt64(Console.ReadLine());
            long number9 = number8 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + number9);
            Console.ReadLine();

         
        }

    }
}
