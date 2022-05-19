using System;
using System.Runtime.CompilerServices;
using static CommonLibrary.Classes.Howdy;

namespace LoginConsoleApp.Classes
{
    class Initialization
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"Spectre.Console/protobuf-net login {TimeOfDay()} ";
        }
    }
}
