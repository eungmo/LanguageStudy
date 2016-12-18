using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program
{
    class Thread2
    {
        public void ThreadSample()
        {
            // wait 1 second
            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            // declare thread
            Thread2 tsObject = new Thread2();
            Thread spThread = new Thread(new ThreadStart(tsObject.ThreadSample));
            Console.WriteLine("Current Thread Status: {0}", spThread.ThreadState);

            // start thread
            spThread.Start();
            Console.WriteLine("Current Thread Status: {0}", spThread.ThreadState);
            Console.WriteLine("Current Thread isAlive? {0}", spThread.IsAlive);

            // stop thread
            spThread.Abort();
            Console.WriteLine("Current Thread Status: {0}", spThread.ThreadState);
        }
    }
}
