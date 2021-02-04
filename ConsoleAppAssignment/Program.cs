using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine("Input some text");
            string modify = Console.ReadLine();

            for (int i = 0; i < weekDays.Length; i++)
            {
                weekDays[i] = weekDays[i] + modify;
                Console.WriteLine(weekDays[i]);

            }

            while (true)  //this was the infinite loop, it was fixed by adding "break;"
            {
                Console.WriteLine("these are the days of the week with your input concated");
                break;
            }

            Console.ReadLine();

            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("count:" + x);
                x++;
            }
            Console.ReadLine();


            int y = 0;
            while (y <= 5)
            {
                Console.WriteLine("count:" + y);
                y++;
            }
            Console.ReadLine();


            List<string> list = new List<string>() { "Steve", "Bill", "Jeff", "Brian", "Zoe", "Rick", "Mike" };
            bool result = false;
            while (!result)
            {
                Console.WriteLine("Input text to search for in the list");
                string search = Console.ReadLine();




                for (int b = 0; b < list.Count; b++)
                {Z

                    if (list[b].Contains(search))
                    {

                        Console.WriteLine("Your search result " + list[b] + " was found in index " + b);
                        result = true;

                        if (result = true)
                        {
                            break;
                        }

                    }

                }

                if (!result)

                {
                    Console.WriteLine("Search result is not on the list");
                }
            }
            Console.ReadLine();


           
            List<string> list2 = new List<string>() { "Steve", "Bill", "Steve", "Brian", "Zoe", "Rick", "Mike" };
            bool result3 = false;

            while (!result3)
            {

                Console.WriteLine("Input text to search for in the list");
                string search2 = Console.ReadLine();

                for (int c = 0; c < list2.Count; c++)
                {

                    if (list2[c].Contains(search2))
                    {

                        Console.WriteLine("Your search result " + list2[c] + " was found in index " + c);
                        result3 = true;


                    }

                }
                if (!result3)

                {
                    Console.WriteLine("Search result is not on the list");
                }
            }
            Console.ReadLine();



            List<string> firstlist = new List<string>() { "Amanda", "Zoe", "Steve", "Brian", "Zoe", "Rick", "Mike" , "Mike"};    
            List<string> newlist = new List<string>();


            foreach (string z in firstlist)
            {
                if (!newlist.Contains(z))
                {
                    newlist.Add(z);
                    Console.WriteLine(z);
                }
                else if (newlist.Contains(z))
                {
                    Console.WriteLine(z + " has appeared before");
                }

            }
            
            Console.ReadLine();



        }
    }
}
