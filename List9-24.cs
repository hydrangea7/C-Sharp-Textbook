using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(2020, 9, 3);
            var date2 = date1.AddDays(-7);
            Console.WriteLine($"{date2.Year}年{date2.Month}月{date2.Day}");
        }
    }
}
