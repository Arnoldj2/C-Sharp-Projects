using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_306
{
    public abstract class Person  // made an abstract class ,  all properties must be inherited.
    {
        public string FirstName { get; set; }   // created first name property
        public string LastName { get; set; } // created last name property

        public virtual void SayName()  // Made an abstract method, any class inheriting this class MUST inherit this method but by making it virtual it has the ability to be overridden 
        {

        }
    }
}
