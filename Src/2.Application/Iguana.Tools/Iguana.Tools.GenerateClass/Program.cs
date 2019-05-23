using Iguana.Winform.UserForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iguana.Tools.GenerateClass
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += Application_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IOCConfig.Register();
            Application.Run(new MainForm());
        }

        static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex == null) return;

            MessageHelper.Show(EnumDialogStyleType.Info, ex.Message);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageHelper.Show(EnumDialogStyleType.Info, e.Exception.Message);
        }
    }
}