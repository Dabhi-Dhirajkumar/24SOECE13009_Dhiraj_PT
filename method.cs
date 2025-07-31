using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class method
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a - b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }

        static void Main()
        {
            int a = 5, b = 10;
            int ra;
            ra= Add(a, b);
            Console.WriteLine("Addition :"+ra);
            ra= Sub(a, b);
            Console.WriteLine("subtraction :" + ra);
            ra = Mul(a, b);
            Console.WriteLine("Multiplication :" + ra);
            ra= Div(a, b);
            Console.WriteLine("Divison:" + ra);



        }

    }
}
