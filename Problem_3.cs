using System;

namespace NumbersInBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers In Between!");

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Ask the user for the second number
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Ask the user for the increment value
            Console.Write("Enter the increment value: ");
            int increment = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers in between:");
            if (firstNumber <= secondNumber)
            {
                for (int i = firstNumber + increment; i < secondNumber; i += increment)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = firstNumber - increment; i > secondNumber; i -= increment)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
