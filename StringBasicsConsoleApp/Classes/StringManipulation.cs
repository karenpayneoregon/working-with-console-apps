using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StringBasicsConsoleApp.HelperClasses;

namespace StringBasicsConsoleApp.Classes
{
    public class StringManipulation
    {
        public static void ReplaceStringWithString()
        {
            ConsoleColors.WriteLineGreen(nameof(ReplaceStringWithString));

            string value = "First Class Mail";

            // C# is case sensitive so this fails
            Console.WriteLine(value.Replace("first", "Second"));

            // Bring in RegEx
            Console.WriteLine(Regex.Replace(value, "first", "Second", RegexOptions.IgnoreCase));

            // make it reusable via a extension method
            Console.WriteLine(value.ReplaceInsensitive("first", "Second"));

        }

        public static void FindStringInString()
        {
            

            ConsoleColors.WriteLineGreen(nameof(FindStringInString));

            string value = "First Class Mail";

            // fail to find
            Console.WriteLine(value.Contains("class"));

            // got it
            Console.WriteLine(value.Contains("class", StringComparison.OrdinalIgnoreCase));

            // fail with -1
            var location = value.IndexOf("m");
            Console.WriteLine(location);

            // finds it at position 12
            location = value.IndexOf("m", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(location);

        }

        public static void TrimmingWhitespace()
        {
            ConsoleColors.WriteLineGreen(nameof(TrimmingWhitespace));

            string value = " First Class Mail ";

            Console.WriteLine($"[{value.Trim()}]");
        }

        public static void ExtractPartOfString()
        {
            ConsoleColors.WriteLineGreen(nameof(ExtractPartOfString));

            string value = "First Class Mail";
            Console.WriteLine(value);



            Console.WriteLine();

            Console.WriteLine(value.SubstringByIndexes(6, 11));

            Console.WriteLine(value[6..]);


            /*
             * New to C#8
             * https://github.com/karenpayneoregon/csharp-features/tree/master/Ranges-examples
             */
            Console.WriteLine($"        Last char '{value[^1]}'");
            Console.WriteLine($"Next to last char '{value[^2]}'");

            Index index = new Index(value.IndexOf("Class", StringComparison.Ordinal) - 1, true);
            Console.Write($"Start of string to one char less than end char ");
            ConsoleColors.WriteGreen($"{value[..^1]}\n");

            Console.Write($"Start of string to Class ");
            ConsoleColors.WriteGreen($"{value[..index]}\n");

            Console.WriteLine();

            // hard coded
            Console.WriteLine("Range");
            Range phrase1 = 6..11; // Get 'Class`
            Console.WriteLine($"\t{value[phrase1]}");

            //  dynamic
            int position = value.IndexOf("Class", StringComparison.Ordinal);
            Range phrase2 = new Range(position, position + "Class".Length);
            Console.WriteLine($"\t{value[phrase2]}");

            Console.WriteLine();

            /*
             * New to C# 8
             * https://github.com/karenpayneoregon/indexes-ranges-csharp
             */
            var sentence = "Just want to say, Hello World there!";
            Index indexStart = sentence.IndexOf("world", StringComparison.InvariantCultureIgnoreCase) - 1;
            Console.WriteLine($"{sentence[..indexStart]} to you!!!");

            Ranger();

        }

        /// <summary>
        /// Advance code to work with obtaining parts of a string array (in this case).
        /// This is simply a peek for what is coming down the road.
        /// 
        /// Index Operator ^ (hat operator)
        /// Range Operator ..
        /// </summary>
        private static void Ranger()
        {
            Console.WriteLine();

            ConsoleColors.WriteLineGreen(nameof(Ranger));

            var list = Mocked.EnglishMonthList;

            Console.WriteLine($" {list.JoinWith()}");
            Console.WriteLine();

            /*
             * Get first two elements as ^1 skips the last element
             * Which can also be expressed as
             *    list.GetRange(0..2)
             */

            Range range = new Range(0, ^1);
            List<string> subList1 = list.GetRange(range);

            /*
             * Get first element where 0 is first and ..1 get one
             */
            List<string> subList = list.GetRange(0..1);


            Console.WriteLine($"        Range(0, ^1)\t{string.Join(",", subList1.ToArray())}");
            Console.WriteLine($" list.GetRange(0..1)\t{string.Join(",", subList.ToArray())}");

            Console.WriteLine();

        }
    }


    


}


