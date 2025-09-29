using System;
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
            // Create a thread for 2 times of looping
            for (int x =0; x <= 2; x++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread:  " + thread.Name + " = " + x );
                Thread.Sleep(500);
            }
        }
        public static void  Thread2()
        {
            // creating a thread for 6 times of looping
            for (int i = 0; i <= 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread:  " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}