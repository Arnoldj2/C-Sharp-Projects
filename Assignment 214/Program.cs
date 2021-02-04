using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_214
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listint = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };

            try
            {

                Console.WriteLine("pick a number");
                int number = Convert.ToInt32(Console.ReadLine());

                foreach (int i in listint)
                {
                    Console.WriteLine(i / number);
                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                Console.ReadLine();
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
                Console.ReadLine();
                
            }
         

            Console.WriteLine("the program has emerged from try/catch block and continued with the program execution");

            Console.ReadLine();
         }
    }
}
