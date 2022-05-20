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
