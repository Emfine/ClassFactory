using Iguana.Tools.ORMClass.Model;
using Iguana.Tools.ORMClass.UserForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iguana.Tools.ORMClass
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
            Application.Run(new MainForm());
        }

        static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex == null) return;

            UFMessage.Show(EnumDialogStyleType.Info, ex.Message);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            UFMessage.Show(EnumDialogStyleType.Info, e.Exception.Message);
        }
    }
}