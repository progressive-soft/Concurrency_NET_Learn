using ConcurrencyTrainingWinForms.Recipes;
using System;
using System.Windows.Forms;

namespace ConcurrencyTrainingWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new DeadlockExample());
            //Application.Run(new CallingAsyncMethodsFromSyncCode());
            //Application.Run(new DownloadWithRetriesAsync());
            Application.Run(new DownloadWithTimeoutAsync());
            //Application.Run(new ProgressReporting());
            //Application.Run(new DownloadAllAsync());
            //Application.Run(new DownloadAllAsyncWithProgress());
        }
    }
}
