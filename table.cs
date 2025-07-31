using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_Dhiraj_PT
{
    internal class table
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 to 10 table\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Table of {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
