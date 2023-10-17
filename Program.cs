using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_closest_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(check(78, 95));
            Console.WriteLine(check(95,95));
            Console.WriteLine(check(99,70));
            Console.ReadKey();
        }
        public static int check(int x, int y)
        {
            const int n = 100;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            return val1 == val2?0 : (val1<val2 ? x:y);

        }
    }
}
