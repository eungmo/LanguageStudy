using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program
{
    class SyncTest
    {
        public int count = 0;

        public void countPlus()
        {
            lock (this) // syncronize this area (critical section)
            {
                int temp = count;

                // print id and temp
                Console.WriteLine("Thread {0} ; {1}", Thread.CurrentThread.ManagedThreadId, temp);

                // add count
                temp = temp + 1;
                Thread.Sleep(1);
                count = temp;
            }
        }
    }

    class Thread4
    {
        static void Main(string[] args)
        {
            // create sync instance
            SyncTest sync = new SyncTest();

            // thread array
            Thread[] syncThread = new Thread[5];
            for (int i=0; i<5; i++)
            {
                // start thread
                syncThread[i] = new Thread(new ThreadStart(sync.countPlus));
                syncThread[i].Start();
            }

            // wait 0.1 second
            Thread.Sleep(100);

            // print result
            Console.WriteLine("Count: {0}", sync.count);

        }
    }
}
