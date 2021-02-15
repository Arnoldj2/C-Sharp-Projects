using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_317
{
    class Employee<T>  //Created class with generic type operator  
    {
        public List<T> Things { get; set; }  // Added a property called “things” which has its data type as a generic list that matches the generic type of the class.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
