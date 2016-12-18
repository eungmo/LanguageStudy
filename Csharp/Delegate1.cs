using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Program
{
    delegate void deleMath(int Value); // declare delegate
    class MathClass
    {
        public int Number;
        public void Plus (int Value)
        {
            Number += Value;
        }
        public void Minus (int Value)
        {
            Number -= Value;
        }
        public void Multiply (int Value)
        {
            Number *= Value;
        }
    }

    class Delegate1
    {
        static void Main(string[] args)
        {
            MathClass MathClass = new MathClass();

            // make delegate instance
            deleMath Math = new deleMath(MathClass.Plus);

            // add function
            Math += new deleMath(MathClass.Minus);
            Math += new deleMath(MathClass.Multiply);

            // result 1
            MathClass.Number = 10;
            Math(10);
            Console.WriteLine("Result:{0}", MathClass.Number);

            // remove minus fuction
            Math -= new deleMath(MathClass.Minus);

            // result 2
            MathClass.Number = 10;
            Math(10);
            Console.WriteLine("Result:{0}", MathClass.Number);

            // remove multiply fuction
            Math -= new deleMath(MathClass.Multiply);

            // result 3
            MathClass.Number = 10;
            Math(10);
            Console.WriteLine("Result:{0}", MathClass.Number);

        }
    }
}
