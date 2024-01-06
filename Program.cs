using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace Lesson003
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                > Please enter a length: <length:INPUT>
                # length = 4
                > **** = 4. Row -> 0 space, 4 star, 4 operation
                >  *** = 3. Row -> 1 space, 3 star, 4 operation
                >   ** = 2. Row -> 2 space, 2 star, 4 operation
                >    * = 1. Row -> 3 space, 1 star, 4 operation
                #      = x. Row -> (length - x) space
                > Oki doki
            */

            Console.Write("Please enter a length:");
            int length = Convert.ToInt32(Console.ReadLine());
            int i = length;
            int r = 0;
            C3:
            int b = length - i;
           C2:
            if (b > 0)
            {
                Console.Write(" ");
                b = b-1;
                goto C2;
            }
            else
            {
            C1:
                if (r < i)
                {
                    Console.Write("*");

                    r = r + 1;
                    goto C1;
                }
                else
                {
                    Console.WriteLine();
                    r = 0;
                    i = i - 1;
                    if (i > 0)
                    {
                        goto C3;

                    }
                    else
                    {
                        Console.Write("Oki doki");
                    }

                }

            }

        }

    }
}

