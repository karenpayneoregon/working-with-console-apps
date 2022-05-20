using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace MenuSimpleApp
{
    class Init
    {
        [ModuleInitializer]
        public static void Setup()
        {
            Console.Title = "Code sample";
        }
    }
}





