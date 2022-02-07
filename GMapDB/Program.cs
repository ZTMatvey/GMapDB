using System;
using System.Windows.Forms;

namespace GMapDB
{
    static class Program
    {
        public delegate void MarkerEvent(object sender, MarkerEventArgs e);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
