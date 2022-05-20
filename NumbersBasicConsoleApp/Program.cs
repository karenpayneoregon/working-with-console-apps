using System;


namespace NumbersBasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterValidInt();
        }

        private static void EnterValidInt()
        {
            Console.WriteLine("Enter a number");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var value))
            {
                Console.WriteLine($"You entered {value}");
            }
            else
            {
                Console.WriteLine($"{userInput} is not valid");
            }

            Console.ReadLine();
        }
    }
}
