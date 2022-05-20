using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringBasicsConsoleApp.HelperClasses;

namespace StringBasicsConsoleApp.Classes
{
    public class StringConcatenation
    {
        /// <summary>
        /// Strings are reallocated with each concatenation which for small operations
        /// this is okay while working with many strings will eat up memory
        /// </summary>
        public static void NoviceConcatenation()
        {
            List<string> monthList = Mocked.EnglishMonthList;
            var monthNames = "";

            foreach (var name in monthList)
            {
                monthNames += name + " ";
            }

            Console.WriteLine(monthNames);

        }
        public static void RecommendedConcatenation()
        {
            
            List<string> monthList = Mocked.EnglishMonthList;

            StringBuilder builder = new ();

            foreach (var name in monthList)
            {
                builder.Append($"{name} ");
            }

            Console.WriteLine(builder.ToString());

            
        }
    }
}
