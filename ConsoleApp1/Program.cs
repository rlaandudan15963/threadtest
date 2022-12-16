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
            t.Start();
        }
    }
}
