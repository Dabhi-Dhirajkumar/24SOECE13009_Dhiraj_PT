using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class third
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int res = ++a + b++ + b++ + a++ + ++a + ++b + a++; //++a = increase 1, a++ first tej value rakhvi ane pachi 1 increase karvu
            Console.WriteLine(res);//47
        }
    }
}
