﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_267
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number();
            number.Amount = 4.5;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
            

        }

        public struct Number
        {
            public double Amount { get; set; }
            
        }


    }
}
