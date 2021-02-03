using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_190
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            bool number1 = false;
            while (!number1)
            {
                Console.WriteLine(i);
                i++;
                
                if (i > 15)
                {
                    number1 = true;
                }
            }




            Console.WriteLine("Out of a total of 8. How many hours of study did you put in today?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool goal = number == 8;
            do
            {
                switch (number)
                {
                    case 2:
                        Console.WriteLine("You are 25% of the way. keep at it");
                        Console.WriteLine("Input hours studied");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You are 50% of the way. keep at it");
                        Console.WriteLine("Input hours studied");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("You are 75% of the way. keep at it");
                        Console.WriteLine("Input hours studied");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You reached your Goal, you are done for the day!");
                        goal = true;
                        break;
                    default:
                        Console.WriteLine("Take a break , Then study for one more hour");
                        Console.WriteLine("Input hours studied");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!goal);


            Console.Read();
        }
    }
}
