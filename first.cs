using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class first
    {
         static void Main(string[] args)
        {
        int a = 5;
        int b = 5;
        int res = a++ + b++; //12
        res = a + b;
        a = a + 1;
        b=b+1;

        Console.WriteLine(res); 
        }
    }
}
