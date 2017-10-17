using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace FlaUIRecorder
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var assemblyTitle = Assembly.GetEntryAssembly().GetCustomAttribute(typeof(AssemblyTitleAttribute)) as AssemblyTitleAttribute;
            Thread.CurrentThread.Name = assemblyTitle.Title;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainUnhandledException;
            Application.ThreadException += ApplicationThreadException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new MainForm());
        }

        private static void ExitApplication()
        {
            Application.ThreadException -= ApplicationThreadException;
            AppDomain.CurrentDomain.UnhandledException -= CurrentDomainUnhandledException;

            Application.Exit();
        }

        private static void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowExceptionDialog(e.Exception);
        }

        private static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ShowExceptionDialog(e.ExceptionObject as Exception);
        }
        private static void ShowExceptionDialog(Exception ex)
        {
            using (var exceptionForm = new ExceptionForm(ex))
            {
                exceptionForm.ShowDialog();
            }
        }
    }
}
