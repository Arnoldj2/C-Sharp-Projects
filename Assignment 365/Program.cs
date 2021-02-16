using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_365
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Jeffrey\Logs\log2.txt", text);
            Console.WriteLine(text);
            string text2 = System.IO.File.ReadAllText(@"C:\Users\Jeffrey\Logs\log2.txt");
            Console.WriteLine(text2);
            Console.ReadLine();
        }
    }
}
