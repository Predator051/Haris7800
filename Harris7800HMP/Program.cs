using System;
using System.Windows.Forms;

namespace Harris7800HMP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());
                Application.Run(new LessonsMenu());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            }
        }
    }
}
