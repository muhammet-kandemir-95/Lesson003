using System;

namespace Lesson003
{
    class Program_Rectangle
    {
        public static void Main_Rectangle(string[] args)
        {
            Console.Write("Please enter a length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int i = length + 2;
            int r = 0;

            checkpoint1:
            if (r < i)
            {
                int c = 0;
                checkpoint2:
                if (c < i)
                {
                    if (r == 0 && c == 0)
                    {
                        Console.Write("╔");
                    }
                    else if (r == 0 && c == i - 1)
                    {
                        Console.Write("╗");
                    }
                    else if (r == i - 1 && c == 0)
                    {
                        Console.Write("╚");
                    }
                    else if (r == i - 1 && c == i - 1)
                    {
                        Console.Write("╝");
                    }
                    else if (r != 0 && r != i - 1 && c != 0 && c != i - 1)
                    {
                        Console.Write(" ");
                    }
                    else if (r == 0 || r == i - 1)
                    {
                        Console.Write("═");
                    }
                    else
                    {
                        Console.Write("║");
                    }
                    c = c + 1;
                    goto checkpoint2;
                }
                else 
                {
                    Console.WriteLine();
                    r = r + 1;
                    goto checkpoint1;
                }
            }
        }
    }
}