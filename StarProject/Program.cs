using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using ProwatchListener;

namespace HUSSDKDemo
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(method1));
            Thread t2 = new Thread(new ThreadStart(method2));
            t2.Start();
            t1.Start();
            
        }

        public static void method1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_SDKDemo());
        }
        public static void method2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
