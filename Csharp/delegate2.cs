using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Program
{
    delegate void eventDelegate();
    class EventTest
    {
        public event eventDelegate ckEvent;

        // Let's think if user click something, this fuctions is operated.
        public void btnClick()
        {
            ckEvent();
        }
    }
    class delegate2
    {
        static void Click()
        {
            Console.WriteLine("clicked.");
        }
        static void Main(string[] args)
        {
            EventTest eTest = new EventTest();
            eTest.ckEvent += new eventDelegate(delegate2.Click);

            // button click
            eTest.btnClick();
        }
    }
}
