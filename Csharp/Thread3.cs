using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Program
{
    class Horse
    {
        private int Number;

        public Horse (int Number)
        {
            this.Number = Number;
        }

        public void Go()
        {
            int Meter = 0;

            while(true)
            {
                Random rd = new Random(Number);

                // make 50~150 random number
                Meter += rd.Next(50, 150);

                // if the horse already pass the goal, break
                if (Meter >= 500) break;

                // print current status
                Console.WriteLine("{0} horse is passing {1} meters", Number, Meter);

                // sleep thread 0.3sec
                Thread.Sleep(300);
            }
            Console.WriteLine("{0} horse goal in!!", Number);
        }
    }


    class Thread3
    {
        static void Main(string[] args)
        {
            const int NUMOFH = 3;

            // create 3 horses
            Horse[] horses = new Horse[NUMOFH];
            for (int i = 0; i < NUMOFH; i++)
            {
                horses[i] = new Horse(i);
            }

            // create 3 threads
            Thread[] threads = new Thread[NUMOFH];
            for (int i=0; i< NUMOFH; i++)
            {
                threads[i] = new Thread(new ThreadStart(horses[i].Go));
            }

            // thread start
            for (int i = 0; i < NUMOFH; i++)
            {
                threads[i].Start();
            }

        }
    }
}
