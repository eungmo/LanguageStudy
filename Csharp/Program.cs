using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello!";
            int n = 10; // 4byte
            double d = 1.1; // 8byte
            char c = 'A';   //2byte
            bool b = true;

            System.Console.WriteLine(s); // String
            System.Console.WriteLine(n); // integer
            System.Console.WriteLine(d); // double
            System.Console.WriteLine(c); // character
            System.Console.WriteLine(b); // bool
        }
    }
}
