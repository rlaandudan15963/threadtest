using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Threadtest
    {
        public void threadthing()
        {
            Random random = new Random();
            int thing = random.Next();
            Console.Write(thing);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Threadtest obj = new Threadtest();
            ThreadStart ts = new ThreadStart(obj.threadthing);
            Thread t = new Thread(ts);
            Console.WriteLine("thread start");
            for(int i = 1; i < 10; i++)
            {
            t.Start(i);
            Console.WriteLine("thread pose 5s...");
            Thread.Sleep(100);
            Console.WriteLine("1");
            Thread.Sleep(100);
            Console.WriteLine("2");
            Thread.Sleep(100);
            Console.WriteLine("3");
            Thread.Sleep(100);
            Console.WriteLine("4");
            Thread.Sleep(100);
            Console.WriteLine("5");
            Console.WriteLine("thread continue");
            Console.WriteLine("thread done");
            t.Abort();
            }

        }
    }
}
