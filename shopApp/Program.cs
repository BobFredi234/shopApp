using System;
using System.Windows.Forms;

namespace shopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles(); // Set Style of a Form
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            
        }
    }
}
