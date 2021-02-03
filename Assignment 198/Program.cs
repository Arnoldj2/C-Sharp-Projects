using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_198
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "your", "name", "is", "not", "sure" };

           
            Console.WriteLine("Please select an index number to call the string array value");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 4)
            {
                Console.WriteLine("Index does not exist");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(stringArray[number]);
                Console.ReadLine();
            }

            int[] numArray = new int[] { 5, 10, 15, 20, 25 };
          

            Console.WriteLine("Please select an index number to call the int array value");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 > 4)
            {
                Console.WriteLine("Index does not exist");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine(numArray[number2]);
                Console.ReadLine();
            }


            List<string> stringList = new List<string>();
            stringList.Add("you've entered the name not sure, is this correct?");
            stringList.Add("no thats not correct ");
            stringList.Add("thank you, not is correct");
            stringList.Add("is sure correct?");

            Console.WriteLine("Please select an index number to call the string list value ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 > 3)
            {
                Console.WriteLine("Index does not exist");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine(stringList[number3]);
                Console.ReadLine();
            }



        }
    }
}
