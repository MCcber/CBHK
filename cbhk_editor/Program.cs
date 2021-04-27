using System;
using System.IO;
using System.Windows.Forms;

namespace CB_Edition
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                if (!Directory.Exists(Application.StartupPath + "\\BugInfo"))
                    Directory.CreateDirectory(Application.StartupPath + "\\BugInfo");
                File.AppendAllText(Application.StartupPath + "\\BugInfo\\bugs.ini", eventArgs.Exception.Message + "\n" + eventArgs.Exception.StackTrace + "\r\n");
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new cbhk_editor.MainForm.Cbhk_form());
        }
    }
}
