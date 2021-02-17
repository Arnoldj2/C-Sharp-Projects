using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_383
{
    public class Employee
    {
        public int id { get; set; }    
        public string name { get; set; }

        public Employee(int id, string name)   // created a constructor 
        {
            this.id = id;
            this.name = name;
        }

        public Employee() : this(100 , "no name")  // chained constructor ( inherits from previous constructor ) 
        {
        }

        public Employee(int id) : this(id, "")
        {
        }

        public Employee(string name) : this(0, name)
        {
        }
    }
}
