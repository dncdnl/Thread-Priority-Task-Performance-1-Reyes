﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Priority_Task_Performance_1_Reyes
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for(int x =0; x <= 2; x++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread:  " + thread.Name + " = " + x );
                Thread.Sleep(500);
            }
        }
        public static void  Thread2()
        {

        }
    }
}