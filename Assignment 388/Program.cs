using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_388
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

            
            bool validator = false;
            int answer = 0;
            
            while(!validator)
            {
                Console.WriteLine("please enter your age");
                validator = int.TryParse(Console.ReadLine(), out answer);
                if (!validator) Console.WriteLine("Please enter digits only");           
            }
            if( answer == 0 || answer < 0 )
                {
                    throw new ArgumentException();
                }
           

            int yearborn = 2021 - answer;
            Console.WriteLine("You were born in " + yearborn);
            
            }
            catch(ArgumentException)
            {
                Console.WriteLine("the year can not be less than or equal to zero.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
