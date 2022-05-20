using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace DateTimeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeString = "13:30";
            string format = "Valid format is HH:mm";
            if (!string.IsNullOrWhiteSpace(timeString))
            {
                var result = DateTime.TryParseExact(timeString, "HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var time) ?
                    time.ToShortTimeString() :
                    format;

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(format);
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
