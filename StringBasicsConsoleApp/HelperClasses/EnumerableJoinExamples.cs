using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasicsConsoleApp.HelperClasses
{
    public class EnumerableJoinExamples
    {
        /// <summary>
        /// Return new collection that includes matching strings in both the collection.
        /// </summary>
        public static void EnumerableJoin()
        {
            IList<string> list1 = new List<string>() {
                "One",
                "Two",
                "Three",
                "Four"
            };

            IList<string> list2 = new List<string>() {
                "One",
                "Two",
                "Five",
                "Six"
            };

            var innerJoin = list1.Join(list2,
                str1 => str1,
                str2 => str2,
                (str1, str2) => str1);

            ConsoleColors.WriteLineCyan("Joining Operator: Join");
            foreach (var item in innerJoin)
            {
                Console.WriteLine(item);
            }

        }
    }
}
