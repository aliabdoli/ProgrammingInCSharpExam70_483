using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public class Section9
    {
        public static void Do()
        {
            var client = new ThreadClient();
            client.Main();
        }
    }
    public class ThreadClient
    {
        public void Main()
        {
            //Normal threads
            //var thread = new Thread(WriteO);
            //thread.Start();
            //WriteX();

            //Thread Pool
            //var thread1 = new Thread(WriteFG);
            //thread1.Start();
            //var result = Task.Run(() => WriteBG());

            //Async Await
            var demo = new AsyncWaitDemo();
            demo.DoStuff();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Still work on main thread .....");
            }

        }

        #region NormalThreads
        public void WriteO()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }
        }

        public void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }
        }


        #endregion

        #region MyRegion
        public void WriteFG()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.Write("FG ");
            }
        }

        public void WriteBG()
        {
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("T ");
            }
        }
        #endregion

        

    }

    public class AsyncWaitDemo
    {
        public async void DoStuff()
        {
            await Task.Run(() =>
            { 
                Count();
            });
            Console.WriteLine("Counting Done -----------");
        }

        private async Task<string> Count()
        {
            int i;
            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("BG Count: " + i);
            }
            return "Counter: " + i;
        }
    }

}
