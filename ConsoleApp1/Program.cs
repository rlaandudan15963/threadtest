using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void threadthing(object intthing)
        {
            Random random = new Random();
            Console.WriteLine((int)intthing * 2.5);
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(threadthing);
            Console.WriteLine("thread start");
            t.Start(12);
            Thread.Sleep(500);
            Console.WriteLine("thread pose 5s...");
            t.Suspend();
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
        }
    }
}
