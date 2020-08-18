using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using static System.Console;

namespace Library
{
    public class DataTimeFormat
    {
        static void Main(string[] args)
        {
            DataTime dt = new DataTime(2020, 08, 19, 07, 23, 07);
            
            WriteLine("{0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);
            CultureInfo ciKo = new CultureInfo("ko-KR);
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
        }
    }
}