using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class MethodOverloading
    {
        static void Main()
        {
            // Method Overloading
            employee emp1 = new employee(101, "Dhiraj");
            employee emp2 = new employee(102, "Dhiraj", "Delhi");
            employee emp3 = new employee(); // Default constructor
        }

        class employee
        {
            int empid;
            string empname;
            string city;

            public employee()
            {
            }
            public employee(int empid, string empname)
            {
                this.empid = empid;
                this.empname = empname;
                Console.WriteLine("Employee ID: {0}, Name: {1}", empid, empname);
            }
            public employee(int empid, string empname, string city) : this(empid, empname) // Constructor chaining
            {

                this.city = city;
                Console.WriteLine("Employee ID: {0}, Name: {1}, City: {2}", empid, empname, city);
            }
        } 
    }
}
