using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using ProwatchListener;
using FireAlarm;
using SerialportSample;

namespace HUSSDKDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(method1));
            Thread t2 = new Thread(new ThreadStart(method2));
            t1.Start();
            t2.Start();
        }


        public static void method1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FireAlarmForm());
        }

        public static void method2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SerialportSampleForm());
        }
    }
}
