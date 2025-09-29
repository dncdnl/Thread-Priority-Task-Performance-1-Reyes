using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Priority_Task_Performance_1_Reyes
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // creating a thread object and passing the method to be executed by the thread
            lblThread.Text = "-Thread Start-";
            Console.WriteLine("-Thread Start-");

            // creating 4 threads name
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            //Creating Priority to the threads
            threadA.Priority  = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            // Starting Threads
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            //Joining Threads
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
        }
    }
}
