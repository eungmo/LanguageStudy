using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
            : this(0, 0)
        {
        }
        public void Print()
        {
            System.Console.WriteLine("{0} {1}", x, y);
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return x; }
            set { y = value; }
        }
    }

    class Class1
    {
        static void Main()
        {
            Point pt = new Point();
            pt.Print();

            pt.X++;
            pt.Y++;
            System.Console.WriteLine("{0} {1}", pt.X, pt.Y);

        }
    }
}
