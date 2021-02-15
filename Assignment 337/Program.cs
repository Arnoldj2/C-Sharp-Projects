using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_337
{
    class Program
    {
        static void Main(string[] args)

        {
            // created a list of 10 employees , 
            List<Employee> empList1 = new List<Employee>();

            empList1.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Dirt" });
            empList1.Add(new Employee() { Id = 2, FirstName = "Joe", LastName = "Schmo" });
            empList1.Add(new Employee() { Id = 3, FirstName = "William", LastName = "DaFoe" });
            empList1.Add(new Employee() { Id = 4, FirstName = "William", LastName = "DaFriend" });
            empList1.Add(new Employee() { Id = 5, FirstName = "Christopher", LastName = "Walken" });
            empList1.Add(new Employee() { Id = 6, FirstName = "Christopher", LastName = "Running" });
            empList1.Add(new Employee() { Id = 7, FirstName = "Ron", LastName = "Swanson" });
            empList1.Add(new Employee() { Id = 8, FirstName = "Swan", LastName = "Ronson" });
            empList1.Add(new Employee() { Id = 9, FirstName = "Roger", LastName = "Rabbit" });
            empList1.Add(new Employee() { Id = 10, FirstName = "Jessica", LastName = "Rabbit" });

            //Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> empList2 = new List<Employee>();

            foreach (Employee employee in empList1)

                if (employee.FirstName == "Joe")
                {
                    empList2.Add(employee);
                    Console.WriteLine(employee.FirstName);
                }

            //Perform the same action again, but this time with a lambda expression.

            List<Employee> empList3 = empList1.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in empList3)
            {
                Console.WriteLine(employee.FirstName);
            }

            // Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> empList4 = empList1.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in empList4)
            {
                Console.WriteLine("Firstname: {0} Lastname: {1}", employee.FirstName, employee.LastName);
            }

            Console.ReadLine();
        }
    }
}
