using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_331
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number();
            number.Amount = 4.5m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();


        }

        public struct Number
        {
            public decimal Amount { get; set; }

        }

    }
}
