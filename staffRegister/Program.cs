using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staffRegister
{
    class Program
    {
        static void Main(string[] args)

        {

            int n = 3;

            for (int i = 0; i < n; i++)

            { 
                // using the classes
            employee cStaff = new employee();
            Console.Write("Enter first name :");
            cStaff.firstName = Console.ReadLine();

            Console.Write("Enter Last name :");
            cStaff.lastName = Console.ReadLine();

            salary cSalary = new salary();
            Console.Write("Enter salary ");
            cSalary.amount = Console.Read();

                
             Console.WriteLine("{0}, {1}, {2}", cStaff.firstName, cStaff.lastName, cSalary.amount);

       


            }
            Console.ReadLine();
        }

    }
        // Creating classes employee with two attributes: first name and last name
            class employee
        {
            public string firstName { get; set;}
            public string lastName { get; set;}
           
        }
    // Creating class salary with one attribute amount
    class salary
        {
        public int amount { get; set; }
        }





}
