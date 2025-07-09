using System;

class Program
{
    static void Main()
    {
        int rows = 5; // Total number of rows

        for (int i = rows; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to next line after each row
        }
    }
}