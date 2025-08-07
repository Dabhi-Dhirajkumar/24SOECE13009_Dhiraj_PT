using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    class Student
    {
        private string enrollmentNo;
        private string name;

        public string Enrollment
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class Tutorial_2_7
    {
        static void Main()
        {
            Student studentObj = new Student();

            // Using property to get values
            studentObj.Enrollment = "24SOECE13009";
            Console.WriteLine("Enrollment No: " + studentObj.Enrollment);

            studentObj.Name = "Dhiraj Dabhi";
            Console.WriteLine("Name: " + studentObj.Name);
        }
    }
}

