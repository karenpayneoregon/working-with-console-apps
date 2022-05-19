using System;
using System.Runtime.CompilerServices;

namespace WorkingWithDataConsoleApp
{
    class Initialization
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }
    }
}
