using System;

namespace UC2_PerfectNumber
{
    internal class Program
    {
        static bool isPerfect(int n)
        {
            if (n == 1)
            return false;
            int sum = 1;

            for (int i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
                return true;
                return false;
        }

       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the no : ");
            int n = int.Parse(Console.ReadLine());

            if (isPerfect(n))
                Console.WriteLine(n + " is a perfect number");
            else
                Console.WriteLine(n + " is not a perfect number");
        }
    }
}
