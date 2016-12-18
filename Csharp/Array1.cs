using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Program
{
    class Point
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }

    class Array1
    {
        static void Main(string[] args)
        {
            string[] arrS = new string[3] { "abc", "ABC", "12345" };

            for (int i=0; i< arrS.Length; i++)
            {
                Console.WriteLine("{0} ", arrS[i]);
            }

            Point[] arrP = new Point[3] { new Program.Point(1, 1), new Program.Point(2, 2), new Point(3, 3) };

            foreach (Point pt in arrP)
            {
                pt.Print();
            }
        }
    }
}
