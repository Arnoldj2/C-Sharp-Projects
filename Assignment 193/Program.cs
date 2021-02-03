using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_193
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "jeffrey";
            string mname = "albert";
            string lname = "arnold";

            string fullname = fname + " " + mname + " " + lname;
            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            StringBuilder sb = new StringBuilder("Hello");

            sb.Append(" How are you doing today?");
            sb.AppendLine(" Fine, I thank you.");
            sb.AppendLine(" Beautiful weather we are having.");
            sb.AppendLine(" Indeed.");


            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
