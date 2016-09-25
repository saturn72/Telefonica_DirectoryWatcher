using System;
using System.Security.Permissions;
using System.Windows.Forms;
using Common;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Bootstrapper().Load();
            Application.Run(new Form1());
        }
    }
}