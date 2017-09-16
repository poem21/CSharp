using System;
using System.IO;
using System.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_Thread
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread thd = new Thread(ProcTimer);
            //Thread thd1 = new Thread(Proc1to10);
            //Thread thd2 = new Thread(ProcGood);

            //thd.IsBackground = true ;
            //thd1.IsBackground = false;
            //thd2.IsBackground = true;


            //thd.Start();
            //thd1.Start();
            //thd2.Start();





            //while (true)
            //{
            //    Console.WriteLine("thd status : {0}", thd.IsAlive.ToString());
            //    Console.WriteLine("thd1 status : {0}", thd1.IsAlive.ToString());
            //    Console.WriteLine("thd2 status : {0}", thd2.IsAlive.ToString());
            //    Thread.Sleep(500);

            //    if (thd1.IsAlive == false)
            //    {
            //        Console.WriteLine("thd status : {0}", thd.IsAlive.ToString());
            //        Console.WriteLine("thd1 status : {0}", thd1.IsAlive.ToString());
            //        Console.WriteLine("thd2 status : {0}", thd2.IsAlive.ToString());

            //        thd.Abort();
            //        thd2.Abort();
            //        Thread.Sleep(0);

            //        Console.WriteLine("thd status : {0}", thd.IsAlive.ToString());
            //        Console.WriteLine("thd1 status : {0}", thd1.IsAlive.ToString());
            //        Console.WriteLine("thd2 status : {0}", thd2.IsAlive.ToString());
            //        break;
            //    }
            //}

            //ThreadPool.QueueUserWorkItem(Proc1to10);

            while (true)
            {
                Thread.Sleep(1000);
            }

            //Thread.Sleep(2000);
            //Console.WriteLine("프로세스 종료");

        }

        

        /// <summary>
        /// 1부터 10가지 카운트
        /// </summary>
        /// <param name="ino">데이터 수</param>
        static void ProcTimer(int ino)
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
            
        }

        static void Proc1to10(object status)
        {
            for (int i=1; i<=10;i++)
            {
                //i++;
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            }
        }

        static void ProcGood()
        {
            while (true)
            {
                Console.WriteLine("Goooooood");
                Thread.Sleep(3000);
            }
        }
    }
}
