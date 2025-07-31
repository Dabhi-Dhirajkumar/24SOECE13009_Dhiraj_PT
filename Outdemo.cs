using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class Outdemo
    {
        
        static void Change(ref int a, ref int b)
        {
            /// <summary>
            /// this include important method  
            /// </summary>
            /// <param name="a">first variable </param>
            /// <param name="b">second variable </param>
            a = 100;
            b = 200;
        }
        static void Update(out int x, out int y) //return multiple value in same method
        {
            x = 100;
            y = 200;
        }

        static void Main()
        {
            int a = 10, b = 20;
            int x = 10, y = 20;
            Console.WriteLine("Before swap:a={0} and b={1}", a, b);
            Change(ref a, ref b);
            Console.WriteLine("After swap:a={0} and b={1}", a, b);

            Console.WriteLine("Before swap:a={0} and b={1}", x, y);
            Update(out x, out y);
            Console.WriteLine("After swap:a={0} and b={1}", x, y);
        }
    }
}
