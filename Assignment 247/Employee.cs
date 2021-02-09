using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_247
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I Quit, 2 seconds has proven to be too much!");
        }
    }
    
}
