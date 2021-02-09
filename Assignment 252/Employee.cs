using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_252
{
    public class Employee : Person
    {
        public int Id { get; set; }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;

        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        //public override bool Equals(object obj)
        //{
        //    var emp = obj as Employee;
        //    if (emp == null)
        //        return false;

        //    return this.Id.Equals(emp.Id);
        //}
    }
}
