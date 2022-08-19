﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBasicsConsoleApp.HelperClasses
{
    public class Mocked
    {
        public static List<string> EnglishMonthList => Enumerable.Range(1, 12)
            .Select((index) => 
                DateTimeFormatInfo.CurrentInfo.GetMonthName(index)).ToList();

        public static List<string> RussianMonthNames() =>
            Enumerable.Range(1, 12).Select((index) => 
                new CultureInfo("ru-RU").DateTimeFormat.GetMonthName(index)).ToList();

        public static List<string> VietnameseMonthNames() =>
            Enumerable.Range(1, 12).Select((index) => 
                new CultureInfo("vie").DateTimeFormat.GetMonthName(index)).ToList();

        public static List<string> SpanishMonthNames() =>
            Enumerable.Range(1, 12).Select((index) => 
                new CultureInfo("es").DateTimeFormat.GetMonthName(index)).ToList();
    }
}
