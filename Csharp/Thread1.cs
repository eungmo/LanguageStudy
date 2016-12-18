using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program
{
    class Thread1
    {
        static void ThreadSample()
        {
            Console.WriteLine("Thread Called");

            // print thread ID
            Console.WriteLine("Current Thread ID : {0}", Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            // excute method
            ThreadSample();

            // declare thread
            ThreadStart ts = new ThreadStart(ThreadSample);
            Thread spThread = new Thread(ts);

            // start thread
            spThread.Start();            
        }
    }
}
