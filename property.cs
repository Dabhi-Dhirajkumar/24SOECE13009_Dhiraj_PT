using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    class student
    { 
        private string firstname;
        private string lastname;
        //1st way
        public string getFirstName()
        {
            return firstname;
        }
        public void setFirstName(string fstname)
        {
            firstname = fstname;
        }
        public string FirstName
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }  
    class property
    {
        static void Main()
        {
            student obj = new student();

            //1st way
            obj.setFirstName("Dabhi");//with method
            Console.WriteLine("First Name: " + obj.getFirstName());

            //2nd way
            obj.FirstName = "Dhiraj"; //with property
            Console.WriteLine("First Name: " + obj.FirstName);

            //3rd way
            string str = obj.FirstName;
            Console.WriteLine("First Name: " + str);

        }

    }
}
