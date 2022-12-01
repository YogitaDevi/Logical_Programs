using System;

namespace UC4_ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int number = int.Parse(Console.ReadLine());

            int reverseNumber = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + number);

            for (remainder = 0; number > 0; number = number / 10)
            {
                remainder = number % 10;

                reverseNumber = reverseNumber * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = " + reverseNumber);
        }
    }
}
