using System;
using System.Collections.Generic;

namespace StringBasicsConsoleApp.HelperClasses
{
    public static class GenericExtensions
    {
        public static List<T> GetRange<T>(this List<T> list, Range range)
        {
            /*
             * Named value Tuple
             */
            (int start, int length) = range.GetOffsetAndLength(list.Count);
            return list.GetRange(start, length);
        }

    }
}
