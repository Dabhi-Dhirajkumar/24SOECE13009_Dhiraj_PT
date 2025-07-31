using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    /// <summary>
    /// the class include is important method
    /// </summary>
    internal class Swapmethod
    {
        /// <summary>
        /// used to share % value
        /// </summary>\
        int a;

        /// <summary>
        /// this mwthod is  used to swap values of two variable
        /// </summary>
        /// <param name="a">first vaible </param>
        /// <param name="b">second variable </param>
     
        static void Swap(ref int a,ref int b)
        {
            
            a = a + b;
            b = a - b;
            a = a - b;
            //int Temp = a;
            //a = b;
            //b = Temp;
        }
        static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swap:a={0} and b={1}", a, b);
            //Swap(a, b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap:a={0} and b={1}", a, b);
        }
    }
}
