using System;

namespace UC1_FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Enter the number of elements to Print : ");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci series are : ");
            if (numberOfElements < 2)
            {
                Console.Write("Please Enter a number greater than two");
               
            }
            else
            {
                Console.Write(firstNumber + " " + SecondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
           
             Console.ReadKey();
        }
    }
}
