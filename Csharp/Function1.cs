using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Function1
    {
        static void Print(int n1, int n2, int n3)
        {
            System.Console.WriteLine("{0} {1} {2}", n1, n2, n3);
        }

        static void Main()
        {
            char c = 'A';
            int n = 10;
            double d = 3.14;
            string s = "Hello!";

            Print(10, 20, 30);
            System.Console.WriteLine("{0} {1} {2} {3}", c, n, d, s);
            System.Console.WriteLine("{0}:{1}:{2}:{3}", c, n, d, s);
            System.Console.WriteLine("{0} {1} {2}", 10, 20, 30);
            System.Console.WriteLine("{0} {0} {0} {0}", c);
            System.Console.WriteLine("{0} {0} {1} {1}", c, n, n);

        }
    }
}
