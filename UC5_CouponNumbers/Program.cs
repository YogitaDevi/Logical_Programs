using System;

namespace UC5_CouponNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("The Random number is : ");
            Console.WriteLine(rnd.Next(10));
            Console.WriteLine("The Distinct Coupon Number is : ");
            string[] names = { "568738", "986454", "855386", "976368", "864576", "864532" };
            int index = rnd.Next(names.Length);
            Console.WriteLine(names[index]);

           

        }
    }
}
