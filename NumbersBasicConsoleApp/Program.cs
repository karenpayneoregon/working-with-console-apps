using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using NumbersBasicConsoleApp.Extensions;


namespace NumbersBasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines1 = new[] {"2","4", "4" };
            string[] lines2 = new[] {"2","w", null };


            if (!lines2.AllInt())
            {
                var noneInts = lines2.ToList().GetNonIntegerIndexes();

                foreach (var item in noneInts)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();
            var whoCares = lines2.ToList().ToIntegerPreserveArray();

            foreach (var care in whoCares)
            {
                Console.WriteLine(care);
            }


            Console.ReadLine();
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

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }
    }
}
