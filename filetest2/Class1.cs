using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using filetest3;

namespace file_test2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int x = 10, y = 1;
            Console.WriteLine(10.0 / y);
            Console.WriteLine(x / y);

            SS s = new SS();
            int s1 = s.ss(1);

            Console.WriteLine(s1);
        }
    }
}
