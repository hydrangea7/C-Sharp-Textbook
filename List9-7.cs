using System;
using System.Text;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "オブジェクト指向";
            var sub1 = str.Substring(0, 6);
            var sub2 = str.Substring(6, 2);
            Console.WriteLine(str);
            Console.WriteLine(sub1);
            Console.WriteLine(sub2);
        }
    }   
}
