using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringBasicsConsoleApp.HelperClasses
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string sender) 
            => string.IsNullOrWhiteSpace(sender);

        /// <summary>
        /// Join string array with " and " as the last delimiter.
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender) 
            => string.Join(", ", sender.Take(sender.Length - 1)) + (((sender.Length <= 1) ? "" : " and ") + 
                    sender.LastOrDefault());

        public static string JoinWithLastSeparator(this List<string> sender) 
            => sender.ToArray().JoinWithLastSeparator();

        /// <summary>
        /// Wraps string.Join for a list.
        /// We could name it Join but that would override <see cref="Enumerable.Join"/>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join?view=net-5.0
        ///
        /// <see cref="EnumerableJoinExamples.EnumerableJoin"/> for an example of <see cref="Enumerable.Join"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinWith(this List<string> sender, string separator = ",") 
            => string.Join(separator, sender.ToArray());

        public static string ReplaceInsensitive(this string sender, string from, string to) 
            => Regex.Replace(sender, @from, to, RegexOptions.IgnoreCase);

        public static string SubstringByIndexes(this string value, int startIndex, int endIndex) 
            => value[startIndex..(endIndex + 1)];
    }
}
