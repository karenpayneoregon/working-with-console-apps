using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringBasicsConsoleApp.HelperClasses;

namespace StringBasicsConsoleApp.Classes
{
    public class StringJoin
    {
        public static void StandardJoining()
        {
            List<string> monthList = Mocked.EnglishMonthList;


            ConsoleColors.WriteLineCyan("Join with comma");
            var join1 = string.Join(",", monthList.ToArray());
            Console.WriteLine($"\t{join1}");

            ConsoleColors.WriteLineCyan("Join with dash");

            var join2 = string.Join("-", monthList.ToArray());
            Console.WriteLine($"\t{join2}");

            ConsoleColors.WriteLineCyan("Bend C# to our will");
            Console.WriteLine(monthList.JoinWith());

        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        /// </summary>
        public static void interpolationJoining()
        {
            string[] monthArray = Mocked.EnglishMonthList.Take(3).ToArray();

            var joinedMonthNames = $"{monthArray[0]},{monthArray[1]},{monthArray[2]}";

            ConsoleColors.WriteLineYellow("interpolation Joining");
            Console.WriteLine(joinedMonthNames);
        }
        /// <summary>
        /// Using <see cref="StringExtensions.JoinWithLastSeparator"/> by Karen
        /// </summary>
        public static void ExtensionsJoining()
        {
            string[] monthArray = Mocked.EnglishMonthList.ToArray();

            var joinedMonthNames = monthArray.JoinWithLastSeparator();

            ConsoleColors.WriteLineGreen("Using extension method on array");
            Console.WriteLine(joinedMonthNames);

            ConsoleColors.WriteLineGreen("Using extension method on list");
            List<string> monthList = Mocked.EnglishMonthList;
            Console.WriteLine(monthList.JoinWithLastSeparator());
        }

        public static void JoinInList()
        {
            List<MonthData> list = Mocked.EnglishMonthList.Select((monthName, index) =>
                new MonthData { Month = monthName, Index = index + 1 }).OrderBy(x => x.Index).ToList();

            var joinedNames = list.Select(x => x.Month).ToList().JoinWith();

            ConsoleColors.WriteLineGreen("Join on property");
            Console.WriteLine(joinedNames);

            JoinInListAnonymousExample();
            
        }
        
        public static List<NotAnonymous> JoinInListAnonymousExample()
        {
             return Mocked.EnglishMonthList
                .Select((monthName, index) => new NotAnonymous {Month = monthName, Index = index + 1})
                .OrderBy(x => x.Index).ToList();


        }
    }
}
