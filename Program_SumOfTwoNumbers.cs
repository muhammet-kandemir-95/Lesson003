using System;

namespace Lesson003
{
    class Program_SumOfTwoNumbers
    {
        public static void Main_SumOfTwoNumbers(string[] args)
        {
            /*
                string: metin
                int: tam sayı negatif veya pozitif veya sıfır
                char: tek metin karakter
                bool: true/false
                float: ondalıklı sayı
            */
            Console.Write("Please enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("Result: " + result);
        }
    }
}