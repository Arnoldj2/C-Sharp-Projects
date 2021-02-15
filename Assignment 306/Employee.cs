using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_306
{
    public class Employee : Person, IQuittable   // this employee class inherits from class "person" and interface "Iquittable"
    {
        public override void SayName()   // override is used so that we can define this method
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit() // implemented quit() method 
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " has quit.");  
        }

    }
}
