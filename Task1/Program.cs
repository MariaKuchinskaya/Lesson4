using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 30)
            {
                Console.WriteLine($"{number} is from 0 to 30");
            }
            else
            {
                if (number >= 31 && number <= 60)
                {
                    Console.WriteLine($"{number} is from 31 to 60");
                }
                else
                {
                    if (number >= 61 && number <= 100)
                    {
                        Console.WriteLine($"{number} is from 61 to 100");
                    }
                    else
                    {
                        Console.WriteLine("I don't know such number");
                    }
                }
            }
        }
    }
}
