using System;
using System.Runtime.CompilerServices;
using StringBasicsConsoleApp.Classes;
using static StringBasicsConsoleApp.Classes.StringConcatenation;

namespace StringBasicsConsoleApp
{
    class Program
    {
        [ModuleInitializer]
        public static void Init1()
        {
            Console.Title = "Working with strings";
        }
        static void Main(string[] args)
        {
            StringManipulation.TrimmingWhitespace();
            Console.ReadLine();
        }

        private static void JoinStrings()
        {
            StringJoin.StandardJoining();
            Console.WriteLine();
            StringJoin.interpolationJoining();
            Console.WriteLine();
            StringJoin.ExtensionsJoining();
            Console.WriteLine();
            StringJoin.JoinInList();
        }

        /// <summary>
        /// Basic Concatenation of strings
        /// </summary>
        private static void ConcatenationStrings()
        {

            RecommendedConcatenation();

            Console.WriteLine();
            
        }
    }
}
