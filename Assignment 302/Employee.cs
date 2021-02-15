using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_302
{
    public class Employee : Person    // this employee class inherits from person
    {
        public override void SayName()   // override is used so that we can define this method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        
    }
}
