using System;

namespace Lesson003
{
    class Program_Triangle
    {
        public static void Main_Triangle(string[] args)
        {
            Console.Write("Please enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int i = length;

            checkpoint2:
            if (i > 0)
            {
                int j = 0;
                checkpoint1:
                if (j < i)
                {
                    Console.Write("*");
                    j = j + 1;
                    goto checkpoint1;
                }
                else
                {
                    Console.WriteLine();
                    i = i - 1;
                    goto checkpoint2;
                }
            }
        }
    }
}